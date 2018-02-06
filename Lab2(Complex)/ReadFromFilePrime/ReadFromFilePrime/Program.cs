using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFromFilePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string ot = "";
            string text = System.IO.File.ReadAllText(@"C:\Users\User\Desktop\PP2 Labs\Lab2\PrimeIn.txt");

            string[] arr = text.Split(' ');
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = int.Parse(arr[i]);
                if (sum == 1) continue;
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
                        ot = ot + arr[i] + " ";
                    cnt = 0;
                }
            }
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\PP2 Labs\Lab2\PrimeOut.txt", ot);
        }
    }
}
