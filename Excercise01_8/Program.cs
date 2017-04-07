using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Right Answer
            /* Another way of answer
                public void Exercise4()
            {
                var number = new Random().Next(1, 10);

                Console.WriteLine("Secret is " + number);
                for (var i = 0; i < 4; i++)
                {
                    Console.Write("Guess the secret number: ");
                    var guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("You won!");
                        return;
                    }
                }

                Console.WriteLine("You lost!");
            }*/
            #endregion

            //initail variable for use
            const int misslimit = 4;
            var number = new Random().Next(1, 10);
            var inputNumber = 0;
            var miss = 0;

            //main program works here
            Console.WriteLine("Can you answer, what is the number in my mind!!");
            while (miss < misslimit)
            {
                int.TryParse(Console.ReadLine(), out inputNumber);
                if (number.Equals(inputNumber))
                {
                    Console.WriteLine($"You win!");
                    break;
                }
                else Console.WriteLine($"You miss!");
                miss++;
            }
            if(miss == misslimit) Console.WriteLine($"You Lost!"); 
        }
    }
}
