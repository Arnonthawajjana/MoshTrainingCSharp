using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            var y = 0;

            var needExit = true;
            while (needExit)
            {
                    Console.Write("Insert Number X :");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.Write("Insert Number Y :");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine(x == y ? "Both Equal" : x < y ? "Y is greater" : "X is greater");
            }
        }
    }
}
