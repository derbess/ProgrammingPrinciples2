using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public string num1 = "";//firstnumber string for fun2
        public string num2 = "";
        public string num3 = "";//for check unique
        public double n1, n2, ans1, n3, ans3;
        public string ms = "";
        public double nn;
        public string num = "";
        public string sign = "";
        public string ssign = "";

        public bool chzero = false;
        public bool check = false;
        public bool chdot = false;
        public bool fnst = false;
        public bool chres = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void fun1_Click(object sender, EventArgs e)
        {
            Button signchar = sender as Button;
            if (check)
            {
                //equal_Click( sender, e);
                sign = signchar.Text;
            }
            else
            {
                num1 = num;
                if (fnst == false)
                {
                    n1 = double.Parse(num);
                }
                else
                {
                }
                textBox1.Text = "0";
                num = "";
                sign = signchar.Text;
                check = true;
            }  
        }

        private void clearnumber_Click(object sender, EventArgs e)
        {
            num = "";
            textBox1.Text = "0";
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            n = n * (-1);
            num = Convert.ToString(n);
            textBox1.Text = num;
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            double n = Math.PI;
            num = Convert.ToString(n);
            textBox1.Text = num;
        }

        private void memoryread_Click(object sender, EventArgs e)
        {
                num = ms;
                textBox1.Text = num;            
        }

        private void memorysave_Click(object sender, EventArgs e)
        {
            ms = textBox1.Text;
        }

        private void memoryclear_Click(object sender, EventArgs e)
        {
            ms = "";
        }

        private void memoryplus_Click(object sender, EventArgs e)
        {
            int ms2 = int.Parse(textBox1.Text);
            int mss = int.Parse(ms);
            ms = Convert.ToString(mss + ms2);
        }

        private void memoryminus_Click(object sender, EventArgs e)
        {
            int ms2 = int.Parse(textBox1.Text);
            int mss = int.Parse(ms);
            ms = Convert.ToString(mss - ms2);
        }

        private void dote_Click(object sender, EventArgs e)
        {
            if (num.Contains(","))
            {
                chdot = true;
            }
            if(chdot==true)
            {
            }
            else
            {
                num += ",";
                textBox1.Text = num;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (num != "0")
            {
                num += "0";
                textBox1.Text = num;
            }
            else
            {
            }
        }

        private void fun2_Click(object sender, EventArgs e)
        {
            Button fx = sender as Button;
            num1 = num;
            n1 = double.Parse(num);
            num = "";
           // MessageBox.Show("rrr");
            sign = fx.Text; 
            if (num1 != null)
            {
                if(sign == "X^2")
                {
                    ans1 = n1 * n1;
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "n!")
                {
                    ans1 = 1;
                    for(int i = 1; i <= n1; i++)
                    {
                        ans1 = ans1 * i;
                    }
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "1/X")
                {
                    ans1 = 1 / n1;
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "10^X")
                {
                    ans1 = Math.Pow(10, n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "log")
                {
                    ans1 = Math.Log10(n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "e^X")
                {
                    ans1 = Math.Exp(n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "sin")
                {
                    ans1 = Math.Sin(n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "cos")
                {
                    ans1 = Math.Cos(n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "tan")
                {
                    ans1 = Math.Tan(n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "√")
                {
                    ans1 = Math.Sqrt(n1);
                    textBox1.Text = Convert.ToString(ans1);
                }
                ans1 = 0;
            }
        }
        private void unique_Click(object sender, EventArgs e)
        {
            Button unique = sender as Button;
            num3 = num;
            sign = unique.Text;    
            if (sign == "C")
            {
                n1 = 0;
                n2 = 0;
                n3 = 0;
                ans1 = 0;
                ans3 = 0;
                sign = "";
                check = false;
                num = "";
                num1 = "";
                num2 = "";
                num3 = "";
                chzero = false;
                chdot = false;
                fnst = false;
                chres = false;
                textBox1.Text = "0";
            }
            else if (sign == "←")
            {
                if (num3 != "")
                {
                    num3 = num3.Remove(num3.Length - 1, 1);
                    textBox1.Text = num3;
                }
                else textBox1.Text = "0";
            }
            ans1 = ans3;
            num = num3;
            if (check == true)
            {
                n2 = n3;
            }
            else n1 = n3;
        }

        void equal_Click(object sender, EventArgs e)
        {
            if(num != null)
            {
                if (chres == false)
                {
                    n2 = double.Parse(num);
                    nn = n2;
                    chres = true;
                }
                else
                {
                    n2 = nn;
                }
                if (sign == "+")
                {
                    ans1 = n1 + n2;
                    textBox1.Text = Convert.ToString(ans1);
                    n1 = ans1;
                }
                else if (sign == "-")
                {
                    ans1 = n1 - n2;
                    textBox1.Text = Convert.ToString(ans1);
                    n1 = ans1;
                }
                else if (sign == "×")
                {
                    ans1 = n1 * n2;
                    textBox1.Text = Convert.ToString(ans1);
                    n1 = ans1;
                }
                else if (sign == "÷")
                {
                    if (n2 == 0) textBox1.Text = "You can not divide by 0";
                    else
                    {
                        ans1 = n1 / n2;
                        textBox1.Text = Convert.ToString(ans1);
                        n1 = ans1;
                    }
                }
                else if (sign == "X^Y")
                {
                    ans1 = Math.Pow(n1, n2);
                    textBox1.Text = Convert.ToString(ans1);
                    n1 = ans1;
                }
                else if (sign == "X^1/Y")
                {
                    ans1 = Math.Pow(n1, 1 / n2);
                    textBox1.Text = Convert.ToString(ans1);
                    n1 = ans1;
                }
                else if (sign == "mod")
                {
                    ans1 = n1 % n2;
                    textBox1.Text = Convert.ToString(ans1);
                }
                else if (sign == "%")
                {
                    ans1 = n1 * n2 / 100;
                    textBox1.Text = Convert.ToString(ans1);
                }
                num = "";
                ssign = sign;
               // sign = "";
                check = false;
                fnst = true;
            }
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
                num += btn.Text;
                textBox1.Text = num;
        }
    }
}
