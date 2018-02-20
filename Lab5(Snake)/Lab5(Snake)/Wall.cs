using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5_Snake_
{
    class Wall
    {
        public List<Point> stenka;
        public string sign;
        public ConsoleColor colour;
        public void StartLevel(int level)
        {
            StreamReader location = new StreamReader(@"C:\Users\User\Desktop\PP2 Labs\Lab4(Snake)\level" + level + ".txt");
            int n = int.Parse(location.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string s = location.ReadLine();
                for(int j = 0; j < s.Length;)
                {
                    if(s[j] == '-')
                    {
                        stenka.Add(new Point(j, i));
                    }
                    j++;
                }
            }
            location.Close();
            
        }
        public Wall(int level)
        {
            stenka = new List<Point>();
            sign = "#";
            colour = ConsoleColor.Yellow;
            StartLevel(level);
        }
        public void Draw()
        {
            Console.ForegroundColor = colour;
            foreach(Point p in stenka)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
