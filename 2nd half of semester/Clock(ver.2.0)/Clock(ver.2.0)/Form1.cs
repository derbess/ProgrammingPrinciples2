using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_ver._2._0_
{
    public partial class Form1 : Form
    {
        int radius = 400;
        Point origin;
        
        public Form1()
        {
            origin = new Point(Width / 2 - radius / 4, Height / 2 - radius / 2);
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2), origin.X, origin.Y, radius, radius);
        }
    }
}
