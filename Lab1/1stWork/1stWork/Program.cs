using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = int.Parse(arr[i]);
                if (sum == 1) Console.WriteLine("NO");
                else
                {
                    int e = 0;
                    for (int j = 2; j <= sum; j++)
                    {
                        if (sum % j == 0) e++;
                    }
                    if (e == 1 || sum % 2 != 0) Console.WriteLine("NO");
                    else Console.WriteLine("YES");
                }
            }

            Console.ReadKey();          
        }
    }
    
}
