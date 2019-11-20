using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cal
{
    
    class frmMain: Form
    {
        Button btn;
        TextBox tb;
        string sign;
        double val1;
        double val2;
        int a = -80;
        int b = 100;
        int i, j;
        public frmMain()
        {
            Init_Button();
            Init_Label();
            //this.tb.Select();
            this.Focus();
            KeyPreview = true;
            this.KeyDown += frmMain_KeyDown;
            
        }
        private void createButton()
        {
            this.Size = new Size(80, 40);
            btn = new Button();
            btn.Size = new Size(80, 40);
            btn.Location = new Point(a, b);
            if (i == 0 && j == 0)
            {
                btn.Text = "%";
                btn.Click += button1_Click;
            }
            if (i == 0 && j == 1)
            {
                btn.Text = "sqrt(x)";
                btn.Click += button2_Click;
            }
            if (i == 0 && j == 2)
            {
                btn.Text = "x^2";
                btn.Click += button3_Click;
            }
            if (i == 0 && j == 3)
            {
                btn.Text = "1/x";
                btn.Click += button4_Click;
            }
            if (i == 1 && j == 0)
            {
                btn.Text = "CE";
                btn.Click += button5_Click;
            }
            if (i == 1 && j == 1)
            {
                btn.Text = "C";
                btn.Click += button6_Click;
            }
            if (i == 1 && j == 2)
            {
                btn.Text = "Del";
                btn.Click += button7_Click;
            }
            if (i == 1 && j == 3)
            {
                btn.Text = "/";
                btn.Click += button8_Click;
            }
            if (i == 2 && j == 0)
            {
                btn.Text = "7";
                btn.Click += button9_Click;
            }
            if (i == 2 && j ==1 )
            {
                btn.Text = "8";
                btn.Click += button10_Click;
            }
            if (i == 2 && j == 2)
            {
                btn.Text = "9";
                btn.Click += button11_Click;
            }
            if (i == 2 && j == 3)
            {
                btn.Text = "*";
                btn.Click += button12_Click;
            }
            if (i == 3 && j == 0)
            {
                btn.Text = "4";
                btn.Click += button13_Click;
            }
            if (i == 3 && j == 1)
            {
                btn.Text = "5";
                btn.Click += button14_Click;
            }
            if (i == 3 && j == 2)
            {
                btn.Text = "6";
                btn.Click += button15_Click;
            }
            if (i == 3 && j == 3)
            {
                btn.Text = "-";
                btn.Click += button16_Click;
            }
            if (i == 4 && j == 0)
            {
                btn.Text = "1";
                btn.Click += button17_Click;
            }
            if (i == 4 && j == 1)
            {
                btn.Text = "2";
                btn.Click += button18_Click;
            }
            if (i == 4 && j == 2)
            {
                btn.Text = "3";
                btn.Click += button19_Click;
            }
            if (i == 4 && j == 3)
            {
                btn.Text = "+";
                btn.Click += button20_Click;
            }
            if (i == 5 && j == 0)
            {
                btn.Text = "+/-";
                btn.Click += button21_Click;
            }
            if (i == 5 && j == 1)
            {
                btn.Text = "0";
                btn.Click += button22_Click;
            }
            if (i == 5 && j == 2)
            {
                btn.Text = ".";
                btn.Click += button23_Click;
            }
            if (i == 5 && j == 3)
            {
                btn.Text = "=";
                btn.Click += button24_Click;
                this.Select();
            }
            this.Controls.Add(btn);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double result;
            val2 = Convert.ToDouble(tb.Text);
            if (sign == "+")
            {
                result = val1 + val2;
                tb.Text = Convert.ToString(result);
                val1 = result;
            }
            if (sign == "-")
            {
                result = val1 - val2;
                tb.Text = Convert.ToString(result);
                val1 = result;
            }
            if (sign == "*")
            {
                result = val1 * val2;
                tb.Text = Convert.ToString(result);
                val1 = result;
            }
            if (sign == "/")
            {
                result = val1 / val2;
                tb.Text = Convert.ToString(result);
                val1 = result;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            string str1 = ".";
            string str2;
            str2 = tb.Text;
            if(str2.Contains(str1))
            {
                str2 = tb.Text;
            }
            else tb.Text += ".";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tb.Text += "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double q;
            q = Convert.ToDouble(tb.Text);
            if (q > 0)
            {
                tb.Text = "-" + tb.Text;
            }
            else if (q < 0)
            {
                q = q * (0 - 1);
                tb.Text = Convert.ToString(q);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(tb.Text);
            tb.Text = " ";
            sign = "+";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "3";
            }
            else
                tb.Text += "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "2";
            }
            else
                tb.Text += "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "1";
            }
            else
                tb.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(tb.Text);
            tb.Text = " ";
            sign = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "6";
            }
            else
                tb.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "5";
            }
            else
                tb.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "4";
            }
            else
                tb.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(tb.Text);
            tb.Text = " ";
            sign = "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "9";
            }
            else
                tb.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "8";
            }
            else
                tb.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0" && tb.Text != null)
            {
                tb.Text = "7";
            }
            else
                tb.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(tb.Text);
            tb.Text = " ";
            sign = "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string temp;
            if (tb.Text.Length >= 1)
            {
                temp = tb.Text.Substring(0, tb.Text.Length - 1);
                tb.Text = temp;
            }
            if (tb.Text.Length == 0)
            {
                tb.Text = "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            val1 = 0;
            val2 = 0;
            tb.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToDouble(tb.Text);
            temp = 1 / temp;
            tb.Text = Convert.ToString(temp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToDouble(tb.Text);
            temp *= temp;
            tb.Text = Convert.ToString(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToDouble(tb.Text);
            temp = Math.Sqrt(temp);
            tb.Text = Convert.ToString(temp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToDouble(tb.Text);
            temp /= 100;
            tb.Text = Convert.ToString(temp);
        }

        void Init_Button()
        {
           Button btn;
           
           int[,] arr1 = new int[6, 4];
           for (i = 0; i < 6; i++)
           {
                for (j = 0; j < 4; j++)
                {
                    a += 90;
                    createButton();
                    btn = new Button();
                }
                a = -80;
                b += 50;
           }
        }
        private void form_focus(object sender, EventArgs e)
        {
            this.tb.Focus();
        }
        void Init_Label()
        {
            this.Size = new Size(390, 450);
            tb = new TextBox();
            tb.Size = new Size(350, 100);
            tb.Location = new Point(10, 0);
            tb.Text = "0";
            tb.Font = new Font("Arial", 40, FontStyle.Regular);
            tb.TextAlign = HorizontalAlignment.Right;
            tb.ReadOnly = true;
            this.Controls.Add(tb);
        }

        private void frmMain_KeyDown(Object sender,KeyEventArgs kea)
        {
            if( kea.KeyCode == Keys.D1)
            {
                button17_Click(btn, null);
            }
            if(kea.KeyCode == Keys.D0)
            {
                button22_Click(btn, null);
            }
            if(kea.KeyCode == Keys.D2)
            {
                button18_Click(btn, null);
            }
            if(kea.KeyCode == Keys.D3)
            {
                button19_Click(btn, null);

            }
            if(kea.KeyCode == Keys.D4)
            {
                button13_Click(btn, null);
            }
            if(kea.KeyCode == Keys.D5)
            {
                button14_Click(btn, null);
            }
            if (kea.KeyCode == Keys.D6)
            {
                button15_Click(btn, null);
            }
            if(kea.KeyCode == Keys.D7)
            {
                button9_Click(btn, null);
            }
            if (kea.KeyCode == Keys.D8) button10_Click(btn, null);
            if (kea.KeyCode == Keys.D9) button11_Click(btn, null);
            if (kea.KeyCode == Keys.OemPeriod) button23_Click(btn, null);
            //if (kea.Shift && kea.KeyCode == Keys.D8) button12_Click(btn, null);
            if (kea.KeyCode == Keys.Back) button7_Click(btn, null);
            if (kea.KeyCode == Keys.Subtract) button16_Click(btn, null);
            if (kea.KeyCode == Keys.Oemplus) button20_Click(btn, null);
            if (kea.KeyCode == Keys.Enter) button24_Click(btn, null);
        }
    }
}
