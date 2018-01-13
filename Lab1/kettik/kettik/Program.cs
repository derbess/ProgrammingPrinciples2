using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kettik
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            Rectangle c = new Rectangle(w,h);
            //c.findArea();

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
