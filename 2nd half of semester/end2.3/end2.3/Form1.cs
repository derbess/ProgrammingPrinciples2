using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end2._3
{
    public partial class Form1 : Form
    {
        bool swt = false;
        Point p;
        double i = 0,k=0;
        int j = 0;
        TextBox[] tx = new TextBox[11];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            p = new Point(e.Location.X, e.Location.Y);
            if (swt==false)
            {
                i++;
                swt = true;
                Button bt = new Button();
                bt.Location = new Point(p.X,p.Y);
                bt.Click += bt_click;
                bt.Text = i.ToString();
                bt.Size = new Size(40, 40);
                bt.ForeColor = bt.BackColor;
                Controls.Add(bt);
            }
            else
            {
                k++;
                swt = false;
                TextBox txx = new TextBox();
                txx.Location = new Point(p.X, p.Y);
                txx.Text = k.ToString();
                txx.Size = new Size(40, 40);
                tx[j] = txx;
                j++;
                Controls.Add(txx);                
            }
        }
        void bt_click(object sender, EventArgs e)
        {
            Button btt = sender as Button;
            for(int l = 0;l < j; l++)
            {
               if((int.Parse(btt.Text)) == (int.Parse(tx[l].Text)))
                {
                    TextBox t = new TextBox();
                    t.Location = tx[l].Location;
                    t.Size = tx[l].Size;
                    t.Text = "Hello";
                    Controls.Add(t);
                    tx[l].Visible = false;
                    
                }
               
            }
        }
    }
}
