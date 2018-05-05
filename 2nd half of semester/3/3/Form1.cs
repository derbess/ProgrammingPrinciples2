using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int circle = 100;
        Point cur;
        Graphics g;
        Point prev;
        Bitmap bm;

        bool chg = false;
        Pen pen = new Pen(Color.Red, 3);
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            //textBox1.Visible = false;
            pictureBox1.Image = bm;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = new Point(Height/2,Width/2);
            cur = new Point(prev.X + circle, prev.Y);
            

            g.DrawEllipse(pen, prev.X - circle / 2, prev.Y - circle / 2 , circle,circle );
           g.DrawEllipse(pen, cur.X - circle / 2, cur.Y - circle / 2, circle,circle);


            pictureBox1.Refresh();
        }
    }
}
