using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form   
    {
        double x, y;
        string işlem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="0")
            {
                TextBox1.Text = "1";

            }
            else
            {
                TextBox1.Text += "1";
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "2";

            }
            else
            {
                TextBox1.Text += "2";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "3";

            }
            else
            {
                TextBox1.Text += "3";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "4";

            }
            else
            {
                TextBox1.Text += "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "5";

            }
            else
            {
                TextBox1.Text += "5";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "6";

            }
            else
            {
                TextBox1.Text += "6";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "7";

            }
            else
            {
                TextBox1.Text += "7";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "8";

            }
            else
            {
                TextBox1.Text += "8";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "9";

            }
            else
            {
                TextBox1.Text += "9";
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "0";

            }
            else
            {
                TextBox1.Text += "0";
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(TextBox1.Text)>0)
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
                if(TextBox1.Text.Length==0)
                {
                    TextBox1.Text = "0";
                }
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox1.Text);
            işlem = "+";
            Label1.Text = TextBox1.Text + "+";
            TextBox1.Text = "0";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(TextBox1.Text);
            if(işlem =="+")
            {
                TextBox1.Text = Convert.ToString(x + y);
            }

            y = Convert.ToDouble(TextBox1.Text);
            if (işlem == "-")
            {
                TextBox1.Text = Convert.ToString(x - y);
            }

            y = Convert.ToDouble(TextBox1.Text);
            if (işlem == "*")
            {
                TextBox1.Text = Convert.ToString(x * y);
            }

            y = Convert.ToDouble(TextBox1.Text);
            if (işlem == "/")
            {
                TextBox1.Text = Convert.ToString(x / y);

            }

            if (işlem == "mod")
                {
                TextBox1.Text = Convert.ToString(x % y);
                Label1.Text = "";

            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox1.Text);
            işlem = "-";
            Label1.Text = TextBox1.Text + "-";
            TextBox1.Text = "0";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox1.Text);
            işlem = "*";
            Label1.Text = TextBox1.Text + "*";
            TextBox1.Text = "0";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox1.Text);
            işlem = "/";
            Label1.Text = TextBox1.Text + "/";
            TextBox1.Text = "0";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(TextBox1.Text);
            kare = Math.Pow(kare, 2);
            TextBox1.Text = Convert.ToString(kare);

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            double karekök = Convert.ToDouble(TextBox1.Text);
            karekök = Math.Sqrt(karekök);
            TextBox1.Text = Convert.ToString(karekök);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            double bölümx = Convert.ToDouble(TextBox1.Text);
            bölümx = 1 / bölümx;
            TextBox1.Text = Convert.ToString(bölümx);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TextBox1.Text);
            işlem = "mod";
            Label1.Text = TextBox1.Text + "(mod)";
            TextBox1.Text = "0";

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "00";

            }
            else
            {
                TextBox1.Text += "00";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            Label1.Text = "";


        }
    }
    }
    
   
