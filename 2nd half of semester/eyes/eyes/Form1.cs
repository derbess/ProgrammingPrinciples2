using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyes
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point p1, p2;
        int x1, x2, y1, y2;
        int radius = 150;
        Point p0;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            p0 = new Point(Width / 2 , Height / 2);
            p2 = new Point(Width / 2 -radius/2, Height / 2-radius);
            p1 = new Point(Width / 2 - 2*radius, Height / 2-radius);
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics t = e.Graphics;
            t.DrawEllipse(new Pen(Color.Black, 2), p1.X, p1.Y, radius, radius);
            t.DrawEllipse(new Pen(Color.Black, 2), p2.X, p2.Y, radius, radius);
            t.DrawEllipse(new Pen(Color.Black, 2), p0.X-radius, p0.Y-radius, radius*2, radius*2);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x1 = e.X - (p1.X + 10);
            x2 = e.X - (p2.X + 10);
            y1 = e.Y - (p1.Y + 10);
            y2 = e.Y - (p2.Y + 10);
            x1 = Math.Max(x1, x2) / 10;
            y1 = Math.Max(y1, y2) / 4;
            Refresh();
            g.FillEllipse(new SolidBrush(Color.Magenta), new Rectangle(p1.X + x1, p1.Y + y1, 20, 20));
            g.FillEllipse(new SolidBrush(Color.Magenta), new Rectangle(p2.X + x1, p2.Y + y1, 20, 20));
        }
    }
}
