using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSea_ver._1._0_
{
    public partial class Form1 : Form
    {
        Button[,] playerfield = new Button[11,11];
        Button[,] iifield = new Button[11,11];
        int whichofship = 0;
        int countofDrackar = 1;
        int countofKarabella = 2;
        int countofGallera = 3;
        int countofBoat = 4;
        bool click = false;
        bool drackar = false;
        bool karabella = false;
        bool gallera = false;
        bool boat = false;
        int t = 0;
        int ver = 0;
        int countoftype = 0;
        public Form1()
        {
            InitializeComponent();
            PlayersField();
            
        }
        public void PlayersField()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.Blue;
                    btn.Location = new Point(30 + i * 31, 30 + j * 31);
                    btn.Text = (i + j * 10).ToString();
                    //btn.Click += ChooseShip;
                    btn.Click += playerfield_Click;
                    btn.ForeColor = btn.BackColor;
                    Controls.Add(btn);
                    playerfield[i, j] = btn;
                   
                }
            }
        }
        public void playerfield_Click(object sender, EventArgs e)
        {
            Button cell = sender as Button;
            if (click)
            {
                int est = 0;
                int i = int.Parse(cell.Text);
                int j = i / 10;
                i = i % 10;
                label6.Text = i.ToString();
                label7.Text = j.ToString();
                label5.Text = cell.Text;
                if (drackar == true && countofDrackar != 0 && i + 4 <= 10)
                {
                    for (int jj = j - 1; jj < j + 1; jj++)
                    {
                        for (int ii = i-1; ii < i + whichofship+1; ii++)
                        {
                            if (playerfield[ii, jj].BackColor == Color.Red)
                            {
                                est++;
                                label8.Text = est.ToString();
                                label9.Text = jj.ToString();
                                label10.Text = ii.ToString();
                            }
                        }
                    }
                    if (est == 0)
                    {
                        int countofship = int.Parse(label1.Text);
                        countofship--;
                        label1.Text = countofship.ToString();
                       // countofDrackar--;
                        for (int k = 0; k < whichofship; k++)
                        {
                            playerfield[i + k, j].BackColor = Color.Red;
                            playerfield[i + k, j].ForeColor = Color.Red;
                        }
                    }

                }
                else if (karabella == true && countofKarabella != 0 && i + 3 <= 10)
                {
                    for (int jj = j - 1; jj < j + 1; jj++)
                    {
                        for (int ii = i; ii < i + whichofship; ii++)
                        {
                            if (playerfield[ii, jj].BackColor == Color.Red)
                            {
                                est++;
                                label8.Text = est.ToString();
                            }
                        }
                    }
                    if (est == 0)
                    {
                        int countofship = int.Parse(label2.Text);
                        countofship--;
                        label2.Text = countofship.ToString();
                        countofKarabella--;
                        for (int k = 0; k < whichofship; k++)
                        {
                            playerfield[i + k, j].BackColor = Color.Red;
                            playerfield[i + k, j].ForeColor = Color.Red;
                        }
                    }

                }
                else if (gallera == true && countofGallera != 0 && i + 2 <= 10)
                {
                    
                    for (int jj = j - 1; jj < j + 1; jj++)
                    {
                        for (int ii = i; ii < i + whichofship; ii++)
                        {
                            if (playerfield[ii, jj].BackColor == Color.Red)
                            {
                                est++;
                                label8.Text = est.ToString();
                            }
                        }
                    }
                    if (est == 0)
                    {
                        int countofship = int.Parse(label3.Text);
                        countofship--;
                        label3.Text = countofship.ToString();
                        countofGallera--;
                        for (int k = 0; k < whichofship; k++)
                        {
                            playerfield[i + k, j].BackColor = Color.Red;
                            playerfield[i + k, j].ForeColor = Color.Red;
                        }
                    }
                }
                
                else if (boat == true && countofBoat != 0 && i + 1 <= 10)
                {
                    for (int jj = j - 1; jj < j + 1; jj++)
                    {
                        for (int ii = i; ii < i + whichofship; ii++)
                        {
                            if (playerfield[ii, jj].BackColor == Color.Red)
                            {
                                est++;
                                label8.Text = est.ToString();
                            }
                        }
                    }
                    if (est == 0)
                    {
                        int countofship = int.Parse(label4.Text);
                        countofship--;
                        label4.Text = countofship.ToString();
                        countofBoat--;
                        for (int k = 0; k < whichofship; k++)
                        {
                            playerfield[i + k, j].BackColor = Color.Red;
                            playerfield[i + k, j].ForeColor = Color.Red;
                        }
                    }
                }
                else { }
            }

            else
            {
                int i = int.Parse(cell.Text);
                int j = i / 10;
                i = i % 10;
                label5.Text = cell.Text;
                if (drackar == true && countofDrackar != 0 && j + 4 <= 10)
                {
                    int countofship = int.Parse(label1.Text);
                    countofship--;
                    label1.Text = countofship.ToString();
                    countofDrackar--;
                    for (int k = 0; k < whichofship; k++)
                    {
                        playerfield[i , j+k].BackColor = Color.Red;
                        playerfield[i , j+k].ForeColor = Color.Red;
                    }

                }
                
                else if (karabella == true && countofKarabella != 0 && j + 3 <= 10)
                {
                    int countofship = int.Parse(label2.Text);
                    countofship--;
                    label2.Text = countofship.ToString();
                    countofKarabella--;
                    for (int k = 0; k < whichofship; k++)
                    {
                        playerfield[i , j+k].BackColor = Color.Red;
                        playerfield[i , j+k].ForeColor = Color.Red;
                    }

                }
                else if (gallera == true && countofGallera != 0 && j + 2 <= 10)
                {
                    int countofship = int.Parse(label3.Text);
                    countofship--;
                    label3.Text = countofship.ToString();
                    countofGallera--;
                    for (int k = 0; k < whichofship; k++)
                    {
                        playerfield[i, j + k].BackColor = Color.Red;
                        playerfield[i, j + k].ForeColor = Color.Red;
                    }

                }
                else if (boat == true && countofBoat != 0 && j + 1 <= 10)
                {
                    int countofship = int.Parse(label4.Text);
                    countofship--;
                    label4.Text = countofship.ToString();
                    countofBoat--;
                    for (int k = 0; k < whichofship; k++)
                    {
                        playerfield[i , j+k].BackColor = Color.Red;
                        playerfield[i , j+k].ForeColor = Color.Red;
                    }

                }
                else { }
            }
            if(countofDrackar==0)
            {
                Drackar.Enabled = false;
                countoftype++;
            }
            if(countofGallera==0)
            {
                Gallera.Enabled = false;
                countoftype++;
            }
            if(countofKarabella==0)
            {
                Karavella.Enabled = false;
                countoftype++;
            }
            if(countofBoat==0)
            {
                Boat.Enabled = false;
                countoftype++;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        private void ChooseShip(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(b.Text == "Drackar")
            {
                drackar = true;
                whichofship = 4;
            }
            else if(b.Text == "Karabella")
            {
                karabella = true;
                whichofship = 3;
            }
            else if(b.Text =="Gallera")
            {
                gallera = true;
                whichofship = 2;
            }
            else if(b.Text == "Boat")
            {
                boat = true;
                whichofship = 1;
            }
            label5.Text = Convert.ToString(whichofship);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Button chng = sender as Button;
            if (ver % 2 == 0)
            {
                chng.Text = "Horizontal";
                click = true;
                //Change.BackColor = Color.DodgerBlue;
            }
            else
            {
                chng.Text = "Vertical";
                click = false;
                //Change.BackColor = Color.HotPink;
            }
            ver++;
        }
    }
}
