using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            //Console.SetWindowSize(45, 20);
            int level = 1;
            Body snake = new Body();
            Wall wall = new Wall(level);
            bool t = true; 
            while(t)
            {
                ConsoleKeyInfo btn = Console.ReadKey();

                if (btn.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (btn.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (btn.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (btn.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (btn.Key == ConsoleKey.R)
                {
                    level = 1;
                    snake = new Body();
                    wall = new Wall(level);
                }
                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("GAME OVER!!!!");
                    Console.ReadKey();
                    snake = new Body();
                    level = 1;
                    wall = new Wall(level);
                }
                if (snake.cnt % 400 == 0)
                {
                    level = 2;
                    wall = new Wall(level);
                }

                Console.Clear();
                snake.Draw();
                wall.Draw();
            }
        }
    }
}
