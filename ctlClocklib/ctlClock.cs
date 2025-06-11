namespace ctlClocklib
{
    public partial class ctlClock : UserControl
    {
        private Color colBColor, colFColor;
        public Color clockBackColor
        {
            get
            {
                return colBColor;
            }
            set
            {
                colBColor = value;
                lblDisplay.BackColor = colBColor;
            }
        }
        public Color clockForeColor
        {
            get
            {
                return colFColor;
            }
            set
            {
                colFColor = value;
                lblDisplay.ForeColor = colFColor;
            }
        }
        public ctlClock()
        {
            InitializeComponent();
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
