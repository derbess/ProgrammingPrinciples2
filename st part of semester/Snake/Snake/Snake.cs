using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;

        public Snake()
        {
            body = new List<Point>();
            sign = "*";
            color = ConsoleColor.DarkRed;
            body.Add(new Point(15, 15));
        }
        public void AddPoint()
        {
            body.Add(new Point(Console.WindowWidth / 2 + i, Console.WindowHeight / 2));
        }
        int a = 2;
        public void Move(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    if (a != 1)
                    {
                        ;
                        a = 2;
                        break;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (a != 2)
                    {
                        direction = Direction.LEFT;
                        a = 1;
                        break;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (a != 3)
                    {
                        direction = Direction.UP;
                        a = 4;
                        break;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (a != 4)
                    {
                        direction = Direction.DOWN;
                        a = 3;
                        break;
                    }
                    break;
            }
        }

    }
}
