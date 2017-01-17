using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Right answer like these
            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
             */
            var number = 0;
            Console.WriteLine("Please insert how large for factorial");
            int.TryParse(Console.ReadLine(), out number);
            number = Recursive(number);
            Console.WriteLine();
            Console.WriteLine("Result : {0}", number);

        }

        public static int Recursive(int number)
        {
            Console.Write("{0}", number);
            if (number != 2)
            {

                Console.Write("x");
                return number = number * Recursive(number - 1);
            }
            else
                return 1;
        }

    }
}
