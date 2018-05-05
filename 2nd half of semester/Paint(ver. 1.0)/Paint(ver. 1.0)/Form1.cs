using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_ver._1._0_
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        Color color = Color.Black;
        Pen pen = new Pen(Color.Black, 2);
        bool clicked = false;
        Queue<Point> q = new Queue<Point>();
        
       // bool firstcolorcheck = false;
        bool secondcolorcheck = false;
        Point prev, cur;
        enum Tool
        {
            PEN,
            RECTANGLE,
            TRIANGLE,
            ERASER,
            CIRCLE,
            LINE,
            FILL,
        };
        Tool swt = Tool.PEN;
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            //textBox1.Visible = false;
            pictureBox1.Image = bm;
        }

        
 		public void Fill(int x, int y, Color color, Color selfcolor)
        {
            if (bm.GetPixel(x, y) == selfcolor)
            {
                bm.SetPixel(x, y, color);
                Fill(x + 1, y, color, selfcolor);
                Fill(x - 1, y, color, selfcolor);
                Fill(x, y + 1, color, selfcolor);
                Fill(x, y - 1, color, selfcolor);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            clicked = true;
            if (swt == Tool.FILL)
            {
                Color color = bm.GetPixel(e.X, e.Y);
                q.Enqueue(e.Location);
                Point p;
                int r, l, u, d;
                while (q.Count != 0)
                {
                    p = q.Dequeue();
                    bm.SetPixel(p.X, p.Y, pen.Color);
                    r = p.X + 1;
                    l = p.X - 1;
                    d = p.Y + 1;
                    u = p.Y - 1;
                    if (bm.GetPixel(r, p.Y) == color && !q.Contains(new Point(r, p.Y)) && r != pictureBox1.Width - 1) q.Enqueue(new Point(r, p.Y));
                    if (bm.GetPixel(l, p.Y) == color && !q.Contains(new Point(l, p.Y)) && l != 0) q.Enqueue(new Point(l, p.Y));
                    if (bm.GetPixel(p.X, d) == color && !q.Contains(new Point(p.X, d)) && d != pictureBox1.Height - 1) q.Enqueue(new Point(p.X, d));
                    if (bm.GetPixel(p.X, u) == color && !q.Contains(new Point(p.X, u)) && u != 0) q.Enqueue(new Point(p.X, u));
                }
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (secondcolorcheck == true)
            {
                secondcolor.BackColor = btn.BackColor;
                secondcolorcheck = false;
            }
            else
            { 
                firstcolor.BackColor = btn.BackColor;
            }
            pen.Color = firstcolor.BackColor;
        }
        private void Object_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text == "Triangle")
            {
                swt = Tool.TRIANGLE;
            }
            else if (btn.Text == "Rectangle")
            {
                swt = Tool.RECTANGLE;
            }
            else if (btn.Text == "Circle")
            {
                swt = Tool.CIRCLE;
            }
            else if (btn.Text == "Pen")
            {
                swt = Tool.PEN;
            }
            else if (btn.Text == "Line")
            {
                swt = Tool.LINE;
            }
            else if (btn.Text == "Eraser")
            {
                swt = Tool.ERASER;
            }
            else if(btn.Text == "Fill")
            {
                swt = Tool.FILL;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
            cur = e.Location;
            if (clicked && swt == Tool.PEN)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }
            else if (clicked && swt == Tool.ERASER)
            {
               // pen.Color = secondcolor.BackColor;
                g.DrawLine(new Pen(secondcolor.BackColor,pen.Width), prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            if(swt == Tool.RECTANGLE)
            {
                cur = e.Location;
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                g.DrawRectangle(pen, x, y, w, h);
               // g.DrawEllipse(pen, x, y, w, h);
            }
            else if (swt == Tool.LINE)
            {
                g.DrawLine(pen, prev,cur);
            }
            else if (swt == Tool.CIRCLE)
            {
                cur = e.Location;
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                
                g.DrawEllipse(pen, x, y, w, h);
                
            }
            else if (swt == Tool.TRIANGLE)
            {
                cur = e.Location;
                if (prev.X < cur.X && prev.Y < cur.Y)
                {
                    g.DrawLine(pen, prev.X, cur.Y, cur.X, cur.Y);
                    g.DrawLine(pen, cur.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                    g.DrawLine(pen, prev.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                }
                if (prev.X > cur.X && prev.Y > cur.Y)
                {
                    g.DrawLine(pen, prev.X, prev.Y, cur.X, prev.Y);
                    g.DrawLine(pen, cur.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                    g.DrawLine(pen, prev.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                }
                if (prev.X < cur.X && prev.Y > cur.Y)
                {
                    g.DrawLine(pen, prev.X, prev.Y, cur.X, prev.Y);
                    g.DrawLine(pen, cur.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                    g.DrawLine(pen, prev.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                }
                if (prev.X > cur.X && prev.Y < cur.Y)
                {
                    g.DrawLine(pen, prev.X, cur.Y, cur.X, cur.Y);
                    g.DrawLine(pen, cur.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                    g.DrawLine(pen, prev.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                }
            }
            pictureBox1.Refresh();
        }

        private void firstcolor_Click(object sender, EventArgs e)
        {
            //firstcolorcheck = true;

        }

        private void secondcolor_Click(object sender, EventArgs e)
        {
            secondcolorcheck = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int size = int.Parse(textBox1.Text);
                pen.Width = size;
                
        }
       

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics gv = e.Graphics;
            if(swt == Tool.LINE&&clicked)
            {
                gv.DrawLine(pen, prev, cur);
            }
            else if(swt == Tool.RECTANGLE && clicked)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                gv.DrawRectangle(pen, x, y, w, h);
            }
            else if (swt == Tool.CIRCLE && clicked)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                gv.DrawEllipse(pen, x, y, w, h);
            }
            else if(swt ==Tool.TRIANGLE && clicked)
            {
                if (prev.X < cur.X && prev.Y < cur.Y)
                {
                    gv.DrawLine(pen, prev.X, cur.Y, cur.X, cur.Y);
                    gv.DrawLine(pen, cur.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                    gv.DrawLine(pen, prev.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                }
                if (prev.X > cur.X && prev.Y > cur.Y)
                {
                    gv.DrawLine(pen, prev.X, prev.Y, cur.X, prev.Y);
                    gv.DrawLine(pen, cur.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                    gv.DrawLine(pen, prev.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                }
                if (prev.X < cur.X && prev.Y > cur.Y)
                {
                    gv.DrawLine(pen, prev.X, prev.Y, cur.X, prev.Y);
                    gv.DrawLine(pen, cur.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                    gv.DrawLine(pen, prev.X, prev.Y, (cur.X + prev.X) / 2, cur.Y);
                }
                if (prev.X > cur.X && prev.Y < cur.Y)
                {
                    gv.DrawLine(pen, prev.X, cur.Y, cur.X, cur.Y);
                    gv.DrawLine(pen, cur.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                    gv.DrawLine(pen, prev.X, cur.Y, (cur.X + prev.X) / 2, prev.Y);
                }
            }
        }

       
    }
}
//move,
//color,object,erase,