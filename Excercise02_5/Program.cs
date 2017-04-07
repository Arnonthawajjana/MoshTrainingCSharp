using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Excercise02_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initial
            const Char breakChar = ',';
            const Char exitChar = '!';

            var numbers = new List<Int32>();
            var inputString = new StringBuilder();
            var patternAlphabet = @"([a-zA-z])";
            var patternDigits = @"([^\d])";
            #endregion

            Console.WriteLine("Please insert number sperate with comma");
            Console.WriteLine("like: 7, 10, 11 ; or ! for Exit");
            while (true)
            {
                #region Manipulate input
                var number = Console.ReadLine();
                /* exit when type !*/
                if (number.Contains(exitChar)) break;
                /*2 level Replace by regex*/
                number = String.IsNullOrEmpty(number)
                    ? ""
                    : Regex.Replace(Regex.Replace(number, patternAlphabet, String.Empty), patternDigits, breakChar.ToString());
                #endregion

                if (!String.IsNullOrEmpty(number))
                {
                    FillNumbersList(number, breakChar, inputString, numbers);
                    ShowNumbersList(numbers);
                    Console.WriteLine($"That's all");
                }
                else
                {
                    Console.WriteLine($"Please reinsert again");
                }

            }

        }
        #region Additional Method
        public static void ShowNumbersList(List<Int32> numbers)
        {
            foreach (Int32 showNumber in numbers)
            {
                Console.WriteLine("Number: {0}", showNumber);
            }
        }

        public static void FillNumbersList(string number, char breakChar, StringBuilder inputString, List<Int32> numbers)
        {
            for (int index = 0; index < number.Length; index++)
            {
                if (!number[index].Equals(breakChar))
                {
                    inputString.Append(number[index]);
                }
                else
                {
                    numbers.Add(Convert.ToInt32(inputString.ToString()));
                    inputString.Clear();
                }
            }
            if (inputString.Length > 0)
            {
                numbers.Add(Convert.ToInt32(inputString.ToString()));
                inputString.Clear();
            }
        }

        public static Int32 LastIndex(String varriableLikeArray)
        {
            return varriableLikeArray.Length.Equals(0)? 0
                : varriableLikeArray.Length-1;
        }
        #endregion
    }
}
