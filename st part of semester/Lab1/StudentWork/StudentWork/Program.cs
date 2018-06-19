using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string stdname = Console.ReadLine();
            string stdlast = Console.ReadLine();
            double stdgpa = double.Parse(Console.ReadLine());
            Student studentt = new Student(stdname,stdlast,stdgpa);
            Console.WriteLine(studentt);
            Console.ReadKey();
        }
    }
}