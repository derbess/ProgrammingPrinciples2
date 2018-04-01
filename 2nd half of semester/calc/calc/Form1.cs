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
        public string num1 = "";
        public string num2 = "";
        public string num3 = "";
        public double n1, n2,ans1,n3,ans3;
        public int nn;
        public string num = "";
        public string sign = "";
        
        public bool check = false;

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
            num1 = num;
            n1 = int.Parse(num);
            textBox1.Text = "0";
            num = "";
            sign = signchar.Text;
            check = true;
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
            n3 = int.Parse(num3);
            nn = int.Parse(num3);
            sign = unique.Text;
            if(sign == "±")
            {
                ans3 = n3 * (-1);
                textBox1.Text = Convert.ToString(ans3);
                num3 = Convert.ToString(ans3);
                n3 = ans3;
            }
           /* else if (sign == ".")
            {
                num3 = num3 + ".";
                textBox1.Text = num3;
                num3 = Convert.ToString(ans3);
                n3 = ans3;
            }
            */
            else if (sign == "C")
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
                textBox1.Text = "0";
                

            }
            else if (sign == "←")
            {
                ans3 = (nn / 10);
                textBox1.Text = Convert.ToString(ans3);
                num3 = Convert.ToString(ans3);
                n3 = ans3;
            }
            ans1 = ans3;
            num = num3;
            if (check == true)
            {
                n2 = n3;

            }
            else n1 = n3;
        }
        private void equal_Click(object sender, EventArgs e)
        {
            
            if(num1 != null)
            {
                n2 = int.Parse(num);
                if(sign == "+")
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
                    ans1 = Math.Pow(n1,n2);
                    textBox1.Text = Convert.ToString(ans1);
                    n1 = ans1;
                }
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
