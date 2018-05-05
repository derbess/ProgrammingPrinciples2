using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        
        int circle = 20;
        Point cur;
        Graphics g;
        Point prev;
        Bitmap bm;
        
        bool chg = false;
        Pen pen = new Pen(Color.Red, 2);
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
            prev = e.Location;
            for (int i = e.Location.Y; i < Height; i++)
            {

                g.DrawEllipse(pen, prev.X - circle / 2 , prev.Y - circle / 2+i, circle, circle);
              //  g.Clear(Color.White);
                pictureBox1.Refresh();
         
            }
          //  pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
           // for

        }
    }
}
