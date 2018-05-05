using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle
{
    public partial class Form1 : Form
    {
        //Graphics g =;
        Pen p = new Pen(Color.Blue, 2);
        public Form1()
        {
            InitializeComponent();
           // Bitmap bm = new Bitmap(pictureBox1.Width,)
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(p, 40, 40, 80, 40);
            e.Graphics.DrawLine(p, 40, 40, 60, 80);
            e.Graphics.DrawLine(p, 80, 40, 60, 80);

            e.Graphics.DrawLine(p, 60, 20, 40, 60);
            e.Graphics.DrawLine(p, 40, 60, 80, 60);
            e.Graphics.DrawLine(p, 80, 60, 60, 20);
            
            e.Graphics.FillPolygon(new SolidBrush(Color.Red),one );
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), two);
        }
        Point[] one = {
            new Point(40,40),
            new Point(80,40),
            new Point(60,80),
        };
        Point[] two = {
            new Point(60,20),
            new Point(40,60),
            new Point(80,60),
        };
   
    }
}
