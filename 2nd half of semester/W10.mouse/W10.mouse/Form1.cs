using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W10.mouse
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int cnt = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if(s.Length>8)
            {
                for (int i = 0; i < 1; i++)
                {


                    if (s[s.Length - 8] == '@')
                        cnt++;
                }
                if (cnt == 1)
                    label1.Text = "ok";

                else label1.Text = "no";
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                string ss = textBox2.Text;
            if ( ss.Length >  8)
                label2.Text = "ok";
            else label2.Text = "no";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Ok" && label2.Text == "Ok") ;
            MessageBox.Show("OK");
        }
    }
}
