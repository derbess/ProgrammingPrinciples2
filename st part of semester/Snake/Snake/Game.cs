using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Game
    {
        public string name;
        public int count;
        public Snake snake;
        public Wall wall;
        public Food food;
        public int score;
        public int level;
        public bool IsAlive;
        public Game()
        {

            score = 0;
            level = 1;
            IsAlive = true;
        }
        public void Start()
        {
            snake = new Snake();
            food = new Food();
            wall = new Wall(level);
        }
        public void MainMenu()
        { 
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.Write("1.New Game");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
            Console.Write("2.Leaders");
            int choise = 0;
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Clear();
                    name = Console.ReadLine();
                    Start();
                    Game.snake.AddPoint();
                    break;
                case 2:
                   
                    ConsoleKeyInfo btn = Console.ReadKey();
                    break;

            }
            /* 
             StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\PP2 Labs\MainMenu");
             int n = int.Parse(sr.ReadLine());
                 for (int i = 0; i < n; i++)
                 {
                     string s = sr.ReadLine();
                     Console.WriteLine(s[i]);
                 }
                 sr.Close();*/
        }
        


    }
}
