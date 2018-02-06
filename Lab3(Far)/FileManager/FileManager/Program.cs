using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileManager
{
    class Program
    {
        static void refresh(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            for (int i = 0;i < files.Length; i++)
            {
                if(files[i].GetType()==typeof(FileSystemInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                    Console.ForegroundColor = ConsoleColor.White;
                if (i == cursor)
                    Console.BackgroundColor = ConsoleColor.Yellow;
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(files[i].Name);
            }


        }
        static void Main(string[] args)
        {
            DirectoryInfo Dir = new DirectoryInfo(@"C:\");
            int cursor = 0;
            int n = Dir.GetFileSystemInfos().Length - 1;
            refresh(Dir, cursor);
            bool onoff = true;
            while(onoff)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.UpArrow:
                        cursor--;
                        if (cursor < 0)
                            cursor = n;
                        break;
                    case ConsoleKey.DownArrow:
                        cursor++;
                        cursor = cursor % n;
                        break;
                    case ConsoleKey.Enter:
                        if (Dir.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                        {
                            Dir = new DirectoryInfo(Dir.GetFileSystemInfos()[cursor].FullName);
                            cursor = 0;
                            n = Dir.GetFileSystemInfos().Length - 1;
                        }
                        else
                        {

                        }
                }
            }
        }
    }
}
