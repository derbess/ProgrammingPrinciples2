using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirlce
{
    public partial class Form1 : Form
    {
        Point cur;
        Color color;
        Graphics g;
        int radius = 4;
        Pen pen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int hs = r.Next(1, 4);
            if (hs == 1) color = Color.Green;
            else if (hs == 2) color = Color.Pink;
            else if (hs == 3) color = Color.Blue;
            else if (hs == 4) color = Color.Black;
            pen.Color = color;
            g.DrawEllipse(pen, cur.X-radius/2, cur.Y-radius/2, radius, radius);
            radius += 10;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
          //  g = e.Graphics;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            cur = new Point(e.Location.X,e.Location.Y);
            timer1.Enabled = true;
            radius = 10;
        }
    }
}
