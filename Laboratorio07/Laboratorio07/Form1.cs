using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio07
{
    public partial class Form1 : Form
    {
        double antes, despues;
        string operaciones;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "0";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "0";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "1";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "2";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "3";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "4";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "5";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "6";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "7";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "8";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "9";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + "9";
            }
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            antes = 0;
            despues = 0;
            Visualizacion.Clear();
            Visualizacion.Focus();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                antes = Convert.ToDouble(Visualizacion.Text);
                operaciones = "/";
                Visualizacion.Clear();
                Visualizacion.Focus();
            }
            catch(FormatException)
            {
                Visualizacion.Text = "Syntax ERROR";
            }
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            try
            {
                antes = Convert.ToDouble(Visualizacion.Text);
                operaciones = "x";
                Visualizacion.Clear();
                Visualizacion.Focus();
            }
            catch (FormatException)
            {
                Visualizacion.Text = "Syntax ERROR";
            }
        }

        private void ButtonMas_Click(object sender, EventArgs e)
        {
            try
            {
                antes = Convert.ToDouble(Visualizacion.Text);
                operaciones = "+";
                Visualizacion.Clear();
                Visualizacion.Focus();
            }
            catch (FormatException)
            {
                Visualizacion.Text = "Syntax ERROR";
            }
        }

        private void ButtonMenos_Click(object sender, EventArgs e)
        {
            try
            {
                antes = Convert.ToDouble(Visualizacion.Text);
                operaciones = "-";
                Visualizacion.Clear();
                Visualizacion.Focus();
            }
            catch (FormatException)
            {
                Visualizacion.Text = "Syntax ERROR";
            }
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                despues = Convert.ToDouble(Visualizacion.Text);

                switch (operaciones)
                {
                    case "/":
                        if (despues == 0.0)
                        {
                            Visualizacion.Text = "Math ERROR";
                            break;
                        }
                        else
                        {
                            Visualizacion.Text = Convert.ToString(antes / despues);
                            break;
                        }
                    case "x":
                        Visualizacion.Text = Convert.ToString(antes * despues);
                        break;
                    case "+":
                        Visualizacion.Text = Convert.ToString(antes + despues);
                        break;
                    case "-":
                        Visualizacion.Text = Convert.ToString(antes - despues);
                        break;
                }
            }
            catch (FormatException)
            {
                Visualizacion.Text = "Syntax ERROR";
            }
        }

        private void ButtonPunto_Click(object sender, EventArgs e)
        {
            if (Visualizacion.Text == "")
            {
                Visualizacion.Text = "0,";
            }
            else
            {
                Visualizacion.Text = Visualizacion.Text + ",";
            }
        }
    }
}
