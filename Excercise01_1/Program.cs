using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;

            while (true)
            {
                Console.WriteLine($"Please Insert Number: ");
                int.TryParse(Console.ReadLine(),out number);

                if (number > 0 && number <= 10)
                    Console.WriteLine($"!!Number is valid!!");
                else{
                    Console.WriteLine($"!!Number is not valid");
                    break;
                }
            }
        }
    }
}
