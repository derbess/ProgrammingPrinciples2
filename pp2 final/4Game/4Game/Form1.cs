using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Game
{
    public partial class Form1 : Form
    {
        int shtuk = 0;
        Graphics g;
        int it = 0;
        Point p;
        List<Point> pt = new List<Point>();
        List<int> move = new List<int>();
        Color color = Color.Black;
        List<Color> lc = new List<Color>();
        List<bool> isDel = new List<bool>();
        List<bool> isClicked = new List<bool>();
        bool havePrev = false;
        int prev = 0;
        public Form1()
        {
            InitializeComponent();
            game();
            g = CreateGraphics();
            label1.Text = "Score : ";
            label3.Text = "0";
            label2.Text = "Out : ";
            label4.Text = "0";
        }
        void game()
        {
            Button bt = new Button();
            bt.Size = new Size(100, 100);
            bt.Location = new Point(Width / 2 - 100, Height / 2 - 100);
            bt.Click += timerenabled;
            bt.Text = "New Game";
            Controls.Add(bt);
        }
        void timerenabled(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Visible = false;
            forcreate.Enabled = true;
            forfall.Enabled = true;
        }
        private void forcreate_Tick(object sender, EventArgs e)
        {
            Random bl = new Random();
            int hs = bl.Next(10, Width - 10);
            p = new Point(hs, 0);
            pt.Add(p);
            Random col = new Random();
            int we = bl.Next(1, 5);

            if (we == 1)
            {
                color = Color.Black;
            }
            else if (we == 2)
            {
                color = Color.Blue;
            }
            else if (we == 3)
            {
                color = Color.Green;
            }
            else color = Color.Red;

            lc.Add(color);
            move.Add(0);
            isDel.Add(false);
            isClicked.Add(false);
        }
      
        private void forfall_Tick(object sender, EventArgs e)
        {
            it = 1;
            g.Clear(Color.White);
            for (int i = 0; i < pt.Count; i++)
            {
                move[i] += it;
                g.FillEllipse(new SolidBrush(lc[i]),pt[i].X, pt[i].Y+move[i] , 50, 50);
                if (isClicked[i])
                {
                    g.DrawEllipse(new Pen(Color.Black, 2), pt[i].X, pt[i].Y + move[i], 50, 50);
                }
                if (pt[i].Y + move[i] > this.Height && isDel[i] == false)
                {
                    label4.Text = (int.Parse(label4.Text) + 1).ToString();
                }
            }
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < pt.Count; i++)
            {
                if (e.Location.X >= pt[i].X && e.Location.X <= pt[i].X + 50 && e.Location.Y  >= pt[i].Y + move[i] && e.Location.Y <= pt[i].Y + move[i] + 50)
                {
                    if (havePrev)
                    {
                        havePrev = false;
                        if (lc[i] == lc[prev] && i != prev)
                        {
                            lc[i] = Color.White;
                            lc[prev] = Color.White;
                            isDel[i] = true;
                            isDel[prev] = true;
                            label3.Text = (int.Parse(label3.Text) + 1).ToString();    
                        }
                        isClicked[prev] = false;
                    }
                    else
                    {
                        isClicked[i] = true;
                        havePrev = true;
                        prev = i;
                    }
                }
            }
        }
    }
}
