using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork
{

    public partial class Form1 : Form
    {
        int check = 0;
        public Form1()
        {
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (button1.Text == "pen") check = 0;
            else check = 1;
        }
    }
}
