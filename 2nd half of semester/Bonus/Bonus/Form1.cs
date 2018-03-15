using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
       // Button play = new Button();
        int cnt = 0;
        List<Button> body = new List<Button>();

       /* private void Form1_Load(object sender, EventArgs e)
        {
            gamer.Location = new Point(30, 30);
            gamer.Size = new Size(20, 20);
            Controls.Add(gamer);
        }*/

        
        

        private void forfall_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i<body.Count;i++)
            {
                if(body[i].Location.X < 0)
                {
                    body[i].Visible = false;
                    cnt++;
                }
              
               
                body[i].Location = new Point(body[i].Location.X - 10, body[i].Location.Y ); 
            }
        }

        private void forcreate_Tick(object sender, EventArgs e)
        {
            
            Random cs = new Random();
            int hs = cs.Next(0, Height-20 );
            hs = cs.Next(hs, Height - 20);
            hs = cs.Next(0, hs);

            Button btn = new Button();
            btn.Location = new Point(Width - 20, hs);
            btn.Size = new Size(20, 20);
            Controls.Add(btn);
            body.Add(btn);
            score.Text = "Score: " + cnt.ToString();
            for (int i = 0; i < body.Count; i++)
            {
                if (Math.Abs(body[i].Location.X - player.Location.X) <= player.Width && Math.Abs(body[i].Location.Y - player.Location.Y) <= player.Height)
                {
                    move.Hide();
                    player.Hide();
                    for (int j = 0; j < body.Count; j++)
                    {
                        body[j].Hide();
                    }
                    player.Visible = false;
                    forcreate.Stop();
                    forfall.Stop();
                    gameover.Visible = true;
                    final.Text += score.Text.ToString();
                    score.Visible = false;
                    final.Visible = true;
                    
                }
            }
        }

       

        private void move_Scroll(object sender, ScrollEventArgs e)
        {
            player.Location = new Point(player.Location.X, move.Value *5);
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
    
}
