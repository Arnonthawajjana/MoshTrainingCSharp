using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsConsecu(int firstNumber, int secondNumber)
            {
                return (firstNumber.Equals(secondNumber - 1) || firstNumber.Equals(secondNumber + 1));
            }

            var numberList = new List<int>();
            var numberInput = new StringBuilder();
            var numberReal = new StringBuilder();

            Console.WriteLine("Please insert number Similiar '1-2-3-4-5' or '9-8-7-6-5-4'");
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
                        if (CompareProcess(IsConsecu, numberList, numberReal)) break;
                        numberReal.Clear();

                    }
                }
                if (!CompareProcess(IsConsecu, numberList, numberReal)) Console.WriteLine("Consecutive");
                numberList.Clear();
                numberInput.Clear();
                numberReal.Clear();
            }
        }

        private static bool CompareProcess(Func<int, int, bool> isConsecu, List<int> numberList, StringBuilder numberReal)
        {
            if (!isConsecu(numberList[(numberList.Count - 1)], int.Parse(numberReal.ToString())))
            {
                Console.WriteLine("Not Consecutive");
                numberReal.Clear();
                return true;
            }
            else
            {
                numberList.Add(int.Parse(numberReal.ToString()));
            }
            return false;
        }
    }
}
