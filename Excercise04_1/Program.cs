using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for detail of how difference file vs fileinfo */
            /*https://stackoverflow.com/questions/1324788/what-is-the-difference-between-file-and-fileinfo-in-c*/
            var currentfile = @"e:\testfile\textexample.txt";

            while (true)
            {
                if (!Directory.Exists(Path.GetDirectoryName(currentfile)))
                {
                    Console.WriteLine("Directory does not Exists");
                    break;
                }
                if (!File.Exists(currentfile))
                {
                    Console.WriteLine("File does not Exists");
                    break;
                }
                else
                { 
                    Console.WriteLine(Path.GetDirectoryName(currentfile));
                    Console.WriteLine(Path.GetFileName(currentfile));
                    Console.WriteLine(Path.GetExtension(currentfile));
                    Console.WriteLine("Have "+File.ReadAllText(currentfile).Split(' ').Length+" Words.");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
