using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int number;
            Console.WriteLine("write 5 Unique number!!" );
            while (numbers.Count() < 5)
            {
                int.TryParse(Console.ReadLine(), out number);
                if (!numbers.Exists(x => x.Equals(number)))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Re enter All again");
                    Console.WriteLine("Duplicated number Detect");
                }
            }
            numbers.Sort();
            foreach (var itemNumber in numbers)
            {
                Console.WriteLine(itemNumber);
            }
            Console.WriteLine();
            
        }
    }
}
