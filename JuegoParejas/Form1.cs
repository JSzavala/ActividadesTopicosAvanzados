namespace JuegoMemoria
{
    public partial class Form1 : Form
    {
        Label firstClicked = null, secondClicked = null;

        Random random = new Random();
        List<String> icons = new List<string>()
        {
            "!","!","a","a","b","b","c","c",
            "d","d","e","e","f","f",",",",",
        };
        public void AssignIcons()
        {
            foreach (Control control in tblCuadricula.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel == null) continue;
                int randomNumber = random.Next(icons.Count);
                iconLabel.Text = icons[randomNumber];
                iconLabel.ForeColor = iconLabel.BackColor;
                icons.RemoveAt(randomNumber);

            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIcons();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null || clickedLabel.ForeColor == Color.Black) return;
            if (firstClicked == null)
            {
                clickedLabel.ForeColor = Color.Black;
                firstClicked = clickedLabel;
            }
            else
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                if (secondClicked.Text == firstClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    CheckWinner();
                    return;
                }
                else timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked=null;
            secondClicked=null;
        }
        private void CheckWinner()
        {
            foreach(Control control in tblCuadricula.Controls)
            {
                Label icon = control as Label;
                if (icon != null && icon.ForeColor == icon.BackColor) return;
            }
            MessageBox.Show("¡Ganaste el juego!", "¡Felicidades!");
            Close();
        }
    }

}
