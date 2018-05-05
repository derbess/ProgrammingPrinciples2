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

namespace endka
{
    public partial class Form1 : Form
    {
        Point origin;
        int i = 0;
        Graphics g ;
       // GraphicsPath gg = new GraphicsPath();
        int radius = 60;
        Color color = Color.Red;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            origin = new Point(e.Location.X,e.Location.Y);
            // label1.Text = i.ToString();
            radius = 0;
            timer1.Enabled = true;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            Random r = new Random();
            int d = r.Next(1, 5);
            if(d == 1)
            {
                color = Color.Blue;
            }
            else if(d==2)
            {
                color = Color.Red;
            }
            else if(d==3)
            {
                color = Color.Yellow;
            }
            else if(d==4)
            {
                color = Color.Green;
            }
            else if(d==5)
            {
                color = Color.Gray;
            }

            g.DrawEllipse(new Pen(color, 2), origin.X - radius/2, origin.Y-radius/2, radius,radius);
            radius += 15;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

 
}
