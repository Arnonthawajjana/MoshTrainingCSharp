using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var inputString = new StringBuilder("Initail Software");
            int number;

            Console.WriteLine("Please input the number ");
            Console.WriteLine("i will distinct that duplicated for you\n");
            while (!inputString.ToString().Equals("Quit"))
            {
                inputString.Clear();
                Console.WriteLine($"insert {numbers.Count + 1}");
                inputString.Append(Console.ReadLine());
                if (int.TryParse(inputString.ToString(), out number))
                {
                    numbers.Add(number);
                }
            }

            foreach (int uniqueNumber in numbers.Distinct())
            {
                Console.WriteLine($"->> {uniqueNumber}");
            }

        }

    }
}
