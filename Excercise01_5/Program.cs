using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int divideBy = 3;
            const int expectResult = 0;
            int equalZeroCounter = 0;

            for (int number = 1; number <= 100; number++)
            {
                if (number % divideBy == expectResult) equalZeroCounter++;
            }
            Console.WriteLine($"result for divide by 3 eqaul 0 have {equalZeroCounter} numbers");

        }
    }
}
