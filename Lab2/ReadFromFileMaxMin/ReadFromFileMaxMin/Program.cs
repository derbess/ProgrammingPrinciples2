using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFromFileMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string ot = "";
            string text = System.IO.File.ReadAllText(@"C:\Users\User\Desktop\PP2 Labs\Lab2\MaxMinIn.txt");

            string[] arr = text.Split(' ');
            int min = 1000000000;
            int max = -111111111;
            int sum = 0;
            string mn = "", mx = "";
            for(int i = 0;i<=(arr.Length)-1;i++)
            {
                sum = int.Parse(arr[i]);
                if (sum < min)
                {
                    min = sum;
                    mn = arr[i];
                }
                if (sum > max)
                {
                    max = sum;
                    mx = arr[i];
                }
                
            }
            ot = mn + " " + mx;
            System.IO.File.WriteAllText(@"C:\Users\User\Desktop\PP2 Labs\Lab2\MaxMinOut.txt", ot);
        }
    }
}
