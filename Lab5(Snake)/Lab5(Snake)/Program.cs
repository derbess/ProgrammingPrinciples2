using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Snake_
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 1;
            Body zmeika = new Body();
            Wall stena = new Wall(level);
            Food zhuk = new Food(level);
            bool t = true;
            int m = 0;
            while (t)
            {

                ConsoleKeyInfo btn = Console.ReadKey();

                if (btn.Key == ConsoleKey.DownArrow && m != 1)
                {
                    zmeika.Move(0, 1);
                    m = 2;
                }

                if (btn.Key == ConsoleKey.UpArrow && m != 2)
                {
                    zmeika.Move(0, -1);
                    m = 1;
                }
                if (btn.Key == ConsoleKey.LeftArrow && m != 4)
                {
                    zmeika.Move(-1, 0);
                    m = 3;
                }

                if (btn.Key == ConsoleKey.RightArrow && m != 3)
                {
                    zmeika.Move(1, 0);
                    m = 4;
                }

                if (btn.Key == ConsoleKey.R)
                {
                    level = 1;
                    zmeika = new Body();
                    stena = new Wall(level);
                    zhuk = new Food(level);
                    m = 0;
                }
                if(zmeika.CollisionWithBody() || zmeika.CollisionWithWall(stena))
                {
                    Console.Clear();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("GAME OVER!!!");
                    zmeika = new Body();
                    level = 1;
                    stena = new Wall(level);
                    Console.ReadKey();
                    
                }
                if(zmeika.cnt == 200)
            {
                    level++;
                    stena = new Wall(level);
                }
                Console.Clear();
                zmeika.Draw();
                zhuk.Draw();
                stena.Draw();

            }
            
        }
    }
}
