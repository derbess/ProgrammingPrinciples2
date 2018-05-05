using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,c;
            int palcount = 0;
            int count = 0;
            string str = Console.ReadLine();
            int g = int.Parse(str);
            for (int y = 0; y < g; y++)
            {
                
                s = Console.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        count++;
                    }
                }
                count++;
                //Console.WriteLine((Convert.ToString(count)));
                string[] ss = s.Split(' ');
                for (int j = 0; j < ss.Count(); j++)
                {
                    string h = ss[j];
                    int pal = 0;
                    for (int l = 0; l < h.Length; l++)
                    {
                        if (h[l] == h[h.Length - l - 1]) pal++;
                    }
                    if (pal == h.Length)
                    {
                        palcount++;
                    } 
                }
                //Console.WriteLine((Convert.ToString(palcount)));
            }
            Console.WriteLine((Convert.ToString(count)));
            Console.WriteLine((Convert.ToString(palcount)));
            Console.ReadKey();
        }
    }
}
