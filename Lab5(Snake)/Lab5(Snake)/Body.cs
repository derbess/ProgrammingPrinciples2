using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Snake_
{
    class Body
    {
        List<Point> telo;
        public int cnt;
        public string sign;
        public ConsoleColor colour;
        public Body()
        {
            telo = new List<Point>();
            telo.Add(new Point(15, 15));
            sign = "*";
            colour = ConsoleColor.Red;
            cnt = 0;
        }
        public void Move(int cx,int cy)
        {
            
            cnt++;
            if(cnt % 10 == 0)
            {
                telo.Add(new Point(1, 1));
            }
            
            for(int i = telo.Count-1 ; i > 0; i--)
            {
                telo[i].x = telo[i - 1].x;
                telo[i].y = telo[i - 1].y;
            }
            telo[0].x += cx;
            telo[0].y += cy;
            if (telo[0].x < 1)
                telo[0].x = Console.WindowWidth - 1;
            if (telo[0].x > Console.WindowWidth - 1)
                telo[0].x =  1;

            if (telo[0].y < 1)
                telo[0].y = Console.WindowHeight - 1;
            if (telo[0].y > Console.WindowHeight - 1)
                telo[0].y = 1;
        }
        public void Draw()
        {
            int index = 0;
            foreach(Point p in telo)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = colour;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
        }
        public bool CollisionWithWall(Wall w)
        {
            foreach(Point st in w.stenka)
            {
                if(st.x==telo[0].x && st.y==telo[0].y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CollisionWithBody()
        {
            for(int i = 1; i < telo.Count-1;i++)
            {
                if(telo[i].x == telo[0].x && telo[i].y == telo[0].y)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
