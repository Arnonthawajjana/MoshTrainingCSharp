using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise01_6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* this is answer use list is fucking noob here
            if (input.ToLower() == "ok")
                break;

            sum += Convert.ToInt32(input);
            */
            const string okStr = "ok";

            var input = new StringBuilder();
            var numberOfAll = new List<int>();

            Console.WriteLine("Please type number for sum all your type ");
            while (!input.ToString().Contains(okStr))
            {
                input.Clear();
                input.Append(Console.ReadLine().ToLower());
                try
                {
                    numberOfAll.Add(int.Parse(input.ToString()));
                    Console.WriteLine($"List have {numberOfAll.Count} number sumall equal {numberOfAll.Sum()}");
                }
                catch
                {
                    // ignored
                }
            }
            Console.WriteLine("Exit completed...");
            Console.Read();
        }
    }
}
