using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall
    {
        public List<Point> wall;

        public void StartLevel(int level)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\PP2 Labs\level" + level + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '-')
                        wall.Add(new Point(j, i));
                }
            }
            sr.Close();
        }
        public Wall(int level)
        {
            wall = new List<Point>();

            StartLevel(level);
        }
        public void Draw()
        {
            foreach (Point p in wall)
            {
               
                Console.SetCursorPosition(p.x, p.y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("#");
            }
        }
    }
}
