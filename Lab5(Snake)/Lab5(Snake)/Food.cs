using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5_Snake_
{
    class Food
    {
        public Point insect;
        public string sign;
        public ConsoleColor colour;
       /* public bool CheckObject(int level,Point pp)
        {
            StreamReader local = new StreamReader(@"C:\Users\User\Desktop\PP2 Labs\Lab4(Snake)\level" + level + ".txt");
            string s = local.ReadLine();
            if (s[pp.x] != '-')
            {
               
                return true;

            }
            else return false;
            local.Close();
        }
        */
        public Food(int level)
        {
            
            sign = "+";
            colour = ConsoleColor.Green;
            insect = new Point(6, 6);
           
        }
        public void RandomLoc()
        {
            Random rx = new Random();
            Random ry = new Random();
            int x = rx.Next(0, 30);
            int y = ry.Next(0, 30);
        }
        public void Draw()
        {
            Console.ForegroundColor = colour;
            
                Console.SetCursorPosition(insect.x, insect.y);
                Console.Write(sign);
            
        }

    }
}
