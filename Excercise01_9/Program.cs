using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Excercise01_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Answer
            /* 
                 public void Exercise5()
            {
                Console.Write("Enter commoa separated numbers: ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');

                // Assume the first number is the max 
                var max = Convert.ToInt32(numbers[0]);

                foreach (var str in numbers)
                {
                    var number = Convert.ToInt32(str);
                    if (number > max)
                        max = number;
                }

                Console.WriteLine("Max is " + max);

            }
        }
    }*/
            #endregion

            #region Variable
            //initail constant
            const char delimeter = ',';
            const string oldString = " ";
            const string newString = "";

            //initail variable
            var inputString = new StringBuilder();
            var parseNumber = new StringBuilder();
            var listnumber = new List<int>();
            var number = 0;
            #endregion

            Console.WriteLine("Please type number and spereate with comma");
            Console.WriteLine("to find the largest number ");
            inputString.Append(Console.ReadLine());
            inputString.Replace(oldString, newString);
            foreach (var charInString in inputString.ToString())
            {
                if (charInString.Equals(delimeter))
                {
                    number = PassStringNumberToList(parseNumber, listnumber);
                }
                else
                {
                    parseNumber.Append(charInString);
                }
            }
            if (number != 0) PassStringNumberToList(parseNumber, listnumber);
            Console.WriteLine("Largest number is {0}", listnumber.Max());



        }

        private static int PassStringNumberToList(StringBuilder parseNumber, ICollection<int> listnumber)
        {
            int number;
            int.TryParse(parseNumber.ToString(), out number);
            parseNumber.Clear();
            listnumber.Add(number);
            return number;
        }
    }
}
