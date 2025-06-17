using GeneradorCurp;

namespace TestControladorCurp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GeneradorCurp.GeneradorCurp curp = new GeneradorCurp.GeneradorCurp();
            this.Controls.Add(curp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
