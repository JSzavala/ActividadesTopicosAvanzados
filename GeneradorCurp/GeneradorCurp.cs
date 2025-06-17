using System.Security.Cryptography;

namespace GeneradorCurp
{

    public partial class GeneradorCurp : UserControl
    {
        private string Curp;
        private string Nombre;
        private string ApellidoPaterno;
        private string ApellidoMaterno;
        private int Estado;
        private DateTime FechaNacimiento;
        private char Genero = 'M';
        public string CurpPreview
        {
            get
            {
                return Curp;
            }
            set
            {
                Curp = value;
                txtCurp.Text = Curp;
            }
        }
        public string NombrePreview
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
                txtNombre.Text = Nombre;
            }
        }
        public string ApellidoPatPreview
        {
            get
            {
                return ApellidoPaterno;
            }
            set
            {
                ApellidoPaterno = value;
                txtApellidoPaterno.Text = ApellidoPaterno;
            }
        }
        public string ApellidoMatPreview
        {
            get
            {
                return ApellidoMaterno;
            }
            set
            {
                ApellidoMaterno = value;
                txtApellidoMaterno.Text = ApellidoMaterno;
            }
        }
        public int EstadoPreview
        {
            get
            {
                return Estado;
            }
            set
            {
                Estado = value % 32;
                cbEstado.SelectedIndex += value;
            }
        }
        public DateTime FechaNacimientoPreview
        {
            get
            {
                return FechaNacimiento;
            }
            set
            {
                FechaNacimiento = value;
                dtpNacimiento.Value = FechaNacimiento;
            }
        }
        public char GeneroPreview
        {
            get
            {
                return Genero;
            }
            set
            {
                bool aux;
                Genero = value;
                aux = (Genero == 'M' ? true : false);
                rbtGenMasculino.Checked = aux;
                rbtGenFemenino.Checked = !aux;
            }
        }
        public GeneradorCurp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtGenMasculino_CheckedChanged(object sender, EventArgs e)
        {
            rbtGenFemenino.Checked = false;
            rbtGenMasculino.Checked = true;
            Genero = 'H';
            txtCurp.Text = GenerarCurp();
        }

        private void rbtGenFemenino_CheckedChanged(object sender, EventArgs e)
        {
            rbtGenMasculino.Checked = false;
            rbtGenFemenino.Checked = true;
            Genero = 'M';
            txtCurp.Text = GenerarCurp();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            txtCurp.Text = GenerarCurp();
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            ApellidoPaterno = txtApellidoPaterno.Text;
            txtCurp.Text = GenerarCurp();
        }
        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            ApellidoMaterno = txtApellidoMaterno.Text;
            txtCurp.Text = GenerarCurp();
        }
        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estado = cbEstado.SelectedIndex+1;
            txtCurp.Text = GenerarCurp();
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            FechaNacimiento = dtpNacimiento.Value;
            txtCurp.Text = GenerarCurp();
        }
        private string GenerarCurp()
        {
            string curp = "";
            if (!string.IsNullOrEmpty(ApellidoPaterno))
                curp += ApellidoPaterno[0].ToString().ToUpper();
            else
                curp += "X";
            curp += PrimeraVocalInterna(ApellidoPaterno);
            if (!string.IsNullOrEmpty(ApellidoMaterno))
                curp += ApellidoMaterno[0].ToString().ToUpper();
            else
                curp += "X";
            curp += PrimeraLetraNombre(Nombre);
            if (FechaNacimiento != DateTime.MinValue)
                curp += FechaNacimiento.ToString("yyMMdd");
            else
                curp += "000000";
            curp += Genero.ToString().ToUpper();
            curp += CodigoEstado(Estado);
            curp += PrimeraConsonanteInterna(ApellidoPaterno);
            curp += PrimeraConsonanteInterna(ApellidoMaterno);
            string[] partesNombre = Nombre?.Split(' ') ?? new string[0];
            string primerNombre = partesNombre.Length > 0 ? partesNombre[0] : "";
            curp += !string.IsNullOrEmpty(primerNombre) ? primerNombre[0].ToString().ToUpper() : "X";
            if (FechaNacimiento != null && FechaNacimiento.Year >= 2000)
                curp += "A";
            else
                curp += "0";
            if (EsPalabraInconveniente(curp.Substring(0, 4)))
            {
                curp = curp.Remove(1, 1).Insert(1, "X");
            }
            curp += CalcularDigitoVerificador(curp);
            return curp;
        }

        private string PrimeraVocalInterna(string texto)
        {
            if (string.IsNullOrEmpty(texto) || texto.Length < 2)
                return "X";
            for (int i = 1; i < texto.Length; i++)
            {
                char c = char.ToUpper(texto[i]);
                if ("AEIOU".Contains(c))
                    return c.ToString();
            }
            return "X";
        }

        private string PrimeraLetraNombre(string nombres)
        {
            if (string.IsNullOrEmpty(nombres))
                return "X";

            string[] nombresIgnorar = { "MARIA", "MA.", "MA ", "JOSE", "J.", "J " };
            string[] partesNombre = nombres.ToUpper().Split(' ');

            foreach (string nombre in partesNombre)
            {
                if (!nombresIgnorar.Contains(nombre))
                    return nombre[0].ToString();
            }
            return partesNombre[0][0].ToString();
        }

        private string PrimeraConsonanteInterna(string texto)
        {
            if (string.IsNullOrEmpty(texto) || texto.Length < 2)
                return "X";

            for (int i = 1; i < texto.Length; i++)
            {
                char c = char.ToUpper(texto[i]);
                if (!"AEIOU".Contains(c) && char.IsLetter(c))
                    return c.ToString();
            }
            return "X";
        }

        private bool EsPalabraInconveniente(string palabra)
        {
            string[] palabrasInconvenientes = {
        "BACA", "BAKA", "BUEI", "BUEY", "CACA", "CACO", "CAGA", "CAGO", "CAKA", "CAKO",
        "COGE", "COGI", "COJA", "COJE", "COJI", "COJO", "COLA", "CULO", "FALO", "FETO",
        "GETA", "GUEI", "GUEY", "JETA", "JOTO", "KACA", "KACO", "KAGA", "KAGO", "KAKA",
        "KAKO", "KOGE", "KOGI", "KOJA", "KOJE", "KOJI", "KOJO", "KOLA", "KULO", "LILO",
        "LOCA", "LOCO", "LOKA", "LOKO", "MAME", "MAMO", "MEAR", "MEAS", "MEON", "MIAR",
        "MION", "MOCO", "MOKO", "MULA", "MULO", "NACA", "NACO", "PEDA", "PEDO", "PENE",
        "PIPI", "PITO", "POPO", "PUTA", "PUTO", "QULO", "RATA", "ROBA", "ROBE", "ROBO",
        "RUIN", "SENO", "TETA", "VACA", "VAGA", "VAGO", "VAKA", "VUEI", "VUEY", "WUEI", "WUEY"
    };

            return palabrasInconvenientes.Contains(palabra);
        }

        private string CalcularDigitoVerificador(string curp17)
        {
            string diccionario = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            int[] factores = { 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int suma = 0;
            for (int i = 0; i < 17; i++)
            {
                char c = curp17[i];
                int valor = diccionario.IndexOf(c);
                suma += valor * factores[i];
            }

            int residuo = suma % 10;
            int digito = (10 - residuo) % 10;

            return digito.ToString();
        }

        private string CodigoEstado(int estado)
        {
            return estado switch
            {
                1 => "AS",   // Aguascalientes
                2 => "BC",   // Baja California
                3 => "BS",   // Baja California Sur
                4 => "CC",   // Campeche
                5 => "CL",   // Coahuila
                6 => "CM",   // Colima
                7 => "CS",   // Chiapas
                8 => "CH",   // Chihuahua
                9 => "DF",   // Ciudad de México
                10 => "DG",  // Durango
                11 => "GT",  // Guanajuato
                12 => "GR",  // Guerrero
                13 => "HG",  // Hidalgo
                14 => "JC",  // Jalisco
                15 => "MC",  // Estado de México
                16 => "MN",  // Michoacán
                17 => "MS",  // Morelos
                18 => "NT",  // Nayarit
                19 => "NL",  // Nuevo León
                20 => "OC",  // Oaxaca
                21 => "PL",  // Puebla
                22 => "QT",  // Querétaro
                23 => "QR",  // Quintana Roo
                24 => "SP",  // San Luis Potosí
                25 => "SL",  // Sinaloa
                26 => "SR",  // Sonora
                27 => "TC",  // Tabasco
                28 => "TS",  // Tamaulipas
                29 => "TL",  // Tlaxcala
                30 => "VZ",  // Veracruz
                31 => "YN",  // Yucatán
                32 => "ZS",  // Zacatecas
                _ => "NE"    // Extranjero
            };
        }

        
    }
}
