using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsDuplicated(List<int> Listnumber, int number)
            {
                return Listnumber.Contains(number);
            }

            var numberList = new List<int>();
            var numberInput = new StringBuilder();
            var numberReal = new StringBuilder();

            Console.WriteLine("Please insert number Similiar '1-2-3-4-5' or '9-8-7-6-5-4'\nto filter duplicate number");
            while (true)
            {
                Console.Write("Input:");
                numberInput.Append(Console.ReadLine());
                foreach (char digit in numberInput.ToString())
                {
                    if (char.IsNumber(digit)) { numberReal.Append(digit); }
                    else
                    {
                        if (numberList.Count == 0)
                        {
                            numberList.Add(int.Parse(numberReal.ToString()));
                            numberReal.Clear();
                            continue;
                        }
                        if(IsDuplicated(numberList, int.Parse(numberReal.ToString())))
                        {
                            Console.WriteLine($"Duplicate {numberReal}");
                            break;
                        }
                        numberList.Add(int.Parse(numberReal.ToString()));
                        numberReal.Clear();
                    }
                }
                if (IsDuplicated(numberList, int.Parse(numberReal.ToString())))
                {
                    Console.WriteLine($"Duplicate {numberReal}");
                }
                numberInput.Clear();
                numberList.Clear();
                numberReal.Clear();
            }
        }


    }
}
