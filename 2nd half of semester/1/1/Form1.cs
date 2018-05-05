using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        int cur = 20;
        public Form1()
        {
            InitializeComponent();
        }
        bool isprime(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(textBox1.Text);
            for(int j = 1;j<=a;j++)
            {
                if(isprime(j)==true)
                {
                    cur += 20;
                    Label pr = new Label();
                   // Label pr = sender as Label;
                    pr.Location = new Point(cur, 50);
                    pr.Size = new Size(20, 20);
                    pr.Text = j.ToString();
                    Controls.Add(pr);
                }
            }
            
        }
    }
}
