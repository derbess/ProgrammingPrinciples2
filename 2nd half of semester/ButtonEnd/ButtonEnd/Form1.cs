using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEnd
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[6, 6];

        public Form1()
        {
            InitializeComponent();
            CreateButton();
        }
       
        private void CreateButton()
        {
            for(int i = 0;i<6;i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Button bt = new Button();
                    bt.Size = new Size(40, 40);
                    bt.Location = new Point(50 + i * 41, 20 + j * 41);
                    bt.BackColor = Color.Black;
                    bt.Click += bt_Click;
                    Controls.Add(bt);
                    btn[j, i] = bt;
                }
            }
        }
        void bt_Click(object sender, EventArgs e)
        {
            Button btt = sender as Button;
            if(btt.BackColor == Color.Black)
            {
                btt.BackColor = Color.Red;
            }
            else
            {
                btt.BackColor = Color.Black;
            }
            for(int i = 0;i < 6;i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (btn[j, i] == btt)
                    {
                        for(int l = 0;l<6;l++)
                        {
                            if(btn[j,l].BackColor==Color.Red)
                            {
                                btn[j, l].BackColor = Color.Black;
                            }
                            else
                            {
                                btn[j, l].BackColor = Color.Red;
                            }
                        }
                        for(int k = 0;k < 6;k++)
                        {
                            if(btn[k,i].BackColor==Color.Red)
                            {
                                btn[k, i].BackColor = Color.Black;
                            }
                            else
                            {
                                btn[k, i].BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
       
    }
}
