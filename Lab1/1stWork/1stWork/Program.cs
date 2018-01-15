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
                if (sum == 1) Console.WriteLine(arr[i]);
                else
                {
                    int j = 0;
                    int cnt = 0;
                    for (j = 2; j <= Math.Sqrt(sum); j++)
                    {
                        if (sum % j == 0)
                        {
                            //Console.WriteLine("composite");
                            cnt = 1;
                            break;
                        }
                    }
                    if (cnt == 0)
                    Console.WriteLine(arr[i]);
                    cnt = 0;
                }
            }
            Console.ReadKey();
        }
    }

}