using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Body
    {
        List<Point> body;
        string sign;
        ConsoleColor colour;
        public int cnt;
        public Body()
        {
            body = new List<Point>();
            body.Add(new Point(15, 15));
            sign = "*";
            colour = ConsoleColor.Black;
            cnt = 0;
        }
        public void Move(int cx, int cy)
        {
            cnt++;
            if(cnt % 20==0)
            {
                body.Add(new Point(1, 1));
            }
           
                
            for(int i = body.Count - 1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += cx;
            body[0].y += cy;

            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x > Console.WindowWidth - 1)
                body[0].x = 1;

            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y > Console.WindowHeight - 1)
                body[0].y = 1;
        }
        public void Draw()
        {
            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.Black;
                else
                    Console.ForegroundColor = colour;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
        }
        public bool CollisionWithWall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }
        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }
    }
}
