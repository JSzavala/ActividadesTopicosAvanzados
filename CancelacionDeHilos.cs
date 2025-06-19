using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CancellationDemos
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Demo: Cancelación básica ===");
            DemoBasicCancellation();
            await Task.Delay(1000);

            Console.WriteLine("\n=== Demo: Cancelación de objetos ===");
            DemoObjectCancellation();
            await Task.Delay(1000);

            Console.WriteLine("\n=== Demo: Escucha por polling ===");
            DemoPolling();
            await Task.Delay(2000);

            Console.WriteLine("\n=== Demo: Callback de cancelación ===");
            await DemoRegisterCallback();
            await Task.Delay(1000);

            Console.WriteLine("\n=== Demo: Escucha con WaitHandle ===");
            DemoWaitHandle();
            await Task.Delay(2000);

            Console.WriteLine("\n=== Demo: Tokens enlazados ===");
            DemoLinkedTokens();

            
        }

        // Cancelacion de operacion
        static void DemoBasicCancellation()
        {
            var cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(DoSomeWork, cts.Token);

            //Thread.Sleep(2500);
            cts.Cancel();
            Console.WriteLine("Solicitud de cancelación enviada.");
            Thread.Sleep(2500);

            cts.Dispose();
        }

        static void DoSomeWork(object state)
        {
            if (state is CancellationToken token)
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine($"  - Iteración {i + 1}: cancelación detectada.");
                        break;
                    }
                    Thread.SpinWait(500000);
                }
            }
        }

        // Cancelacion de objeto
        class CancelableObject
        {
            public string Id { get; }
            public CancelableObject(string id) => Id = id;
            public void Cancel() => Console.WriteLine($"  > Objeto {Id}: callback Cancel()");
        }

        static void DemoObjectCancellation()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;

            var o1 = new CancelableObject("1");
            var o2 = new CancelableObject("2");
            var o3 = new CancelableObject("3");

            token.Register(() => o1.Cancel());
            token.Register(() => o2.Cancel());
            token.Register(() => o3.Cancel());

            cts.Cancel();
            cts.Dispose();
        }

        // Polling 
        struct Rectangle { public int Columns, Rows; public Rectangle(int c, int r) { Columns = c; Rows = r; } }

        static void DemoPolling()
        {
            var rect = new Rectangle(3, 3);
            var cts = new CancellationTokenSource();
            Task.Run(async () => { await Task.Delay(1000); cts.Cancel(); });

            NestedLoops(rect, cts.Token);
        }

        static void NestedLoops(Rectangle rect, CancellationToken token)
        {
            for (int col = 0; col < rect.Columns && !token.IsCancellationRequested; col++)
            {
                for (int row = 0; row < rect.Rows; row++)
                {
                    Thread.SpinWait(50000);
                    Console.Write($"{col},{row} ");
                }
            }
            if (token.IsCancellationRequested)
                Console.WriteLine("\n  >> Operación cancelada.");
        }

        // Callback 
        static async Task DemoRegisterCallback()
        {
            var cts = new CancellationTokenSource();
            var client = new HttpClient();

            cts.Token.Register(() =>
            {
                client.CancelPendingRequests();
                Console.WriteLine("  >> Petición HTTP cancelada via callback.");
            });

            Console.WriteLine("Iniciando petición HTTP…");
            var request = client.GetStringAsync("http://www.contoso.com");

            cts.CancelAfter(100);

            try
            {
                string response = await request;
                Console.WriteLine($"  - Longitud de respuesta: {response.Length}");
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("  >> TaskCanceledException capturada.");
            }
        }

        // WaitHandle
        static void DemoWaitHandle()
        {
            var mre = new ManualResetEventSlim(false);
            var cts = new CancellationTokenSource(1000);

            Console.WriteLine("Esperando evento o cancelación…");
            int idx = WaitHandle.WaitAny(
                new WaitHandle[] { mre.WaitHandle, cts.Token.WaitHandle },
                TimeSpan.FromSeconds(2)
            );

            switch (idx)
            {
                case 0: Console.WriteLine("  - ManualResetEvent señalizado."); break;
                case 1: Console.WriteLine("  - Token cancelado."); break;
                default: Console.WriteLine("  - Tiempo de espera agotado."); break;
            }
        }

        // Multiples tokens
        static void DemoLinkedTokens()
        {
            var internalCts = new CancellationTokenSource(500);
            var externalCts = new CancellationTokenSource(1000);
            var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(
                                      internalCts.Token, externalCts.Token);

            try
            {
                DoWorkInternal(linkedCts.Token);
            }
            catch (OperationCanceledException)
            {
                if (internalCts.IsCancellationRequested)
                    Console.WriteLine("  >> Operación finalizada por timeout interno.");
                else if (externalCts.IsCancellationRequested)
                    Console.WriteLine("  >> Cancelación solicitada externamente.");
            }
        }

        static void DoWorkInternal(CancellationToken token)
        {
            for (int i = 0; i < 5; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine("  - Trabajando…");
                Thread.Sleep(300);
            }
            Console.WriteLine("  >> Trabajo completado sin cancelación.");
        }
    }
}
