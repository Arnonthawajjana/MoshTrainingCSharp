using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] words = Console.ReadLine().ToCharArray();
            Array.Reverse(words);
            String reverseString = new string(words);
            Console.WriteLine($"After Reverse: {reverseString}");
        }
    }
}
