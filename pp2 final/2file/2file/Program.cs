using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace _2file
{
    class Program
    {
        static bool IsPrime(int t)
        {
            int u = 0;
            if (t == 1) return false;
            else
            {
                for (int i = 2; i < Math.Floor(Math.Sqrt(t)); i++)
                {
                    if (t % i == 0) 
                    {
                        u++;
                    }
                }
                if(u==0) return true;
                else return false;
            }
            
        }
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\User\Desktop\pp2 final\Final");
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            string name = "";
            foreach(FileSystemInfo f in fs)
            {
                StreamReader sr = new StreamReader(f.FullName);
                string s = sr.ReadToEnd();
                int g = 1;
                for(int i = 0;i<s.Length;i++)
                {
                    if (s[i] == ' ') g++;
                }
                string[] ss = s.Split(' ');
                for (int j = 0; j < g; j++)
                {
                    int k = int.Parse(ss[j]);
                    if(IsPrime(k))
                    {
                        name += (k.ToString())+ " ";
                        name += f.Name;
                        break;
                    }
                    name += "// ";
                }
            }
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
