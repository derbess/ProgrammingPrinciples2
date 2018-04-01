using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath gp = new GraphicsPath();
        Pen P = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(P, gp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            gp.AddLine(10, 10, 100, 100);
            gp.AddEllipse(20, 20, 80, 80);

        }
    }
}
