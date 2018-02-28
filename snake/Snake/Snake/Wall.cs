using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    public class Walls
    {
        /*public List<Point> body;
        public Walls()
        {
            body = new List<Point>();
        }
        public void GenerateWalls(int level = 1)
        {
            body.Clear();

            string path = string.Format(@"C:\Users\User\Desktop\PP2 Labs\level{0}.txt", level);
            string map = File.ReadAllText(path);
            int x = 0, y = 0;
            for (int it = 0; it < map.Length; it++)
            {
                Console.SetCursorPosition(x, y);
                if (map[it] == '-')
                    body.Add(new Point(x, y, '#', ConsoleColor.DarkYellow));
                x++;
                if (map[it] == '!')
                {
                    y++;
                    x = 0;
                }
            }
        }*/
        public List<Point> body;
        
        public void StartLevel(int level)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\PP2 Labs\Lab4(Snake)\level" + level + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '-')
                        body.Add(new Point(j, i, '#', ConsoleColor.DarkYellow));
                }
            }
            sr.Close();
        }
        public Walls(int level)
        {
            body = new List<Point>();
            
            StartLevel(level);
        }
        public void Draw()
        {
            foreach (Point p in body)
            {
                p.Draw();
                //Console.SetCursorPosition(p.x, p.y);
                //Console.ForegroundColor = p.color;
                //Console.Write(p.sym);
            }
        }

    }
}