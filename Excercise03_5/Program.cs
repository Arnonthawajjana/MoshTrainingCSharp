using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Local Function //
            bool IsKeyExit(StringBuilder keyInputStringBuilder)
            {
                return keyInputStringBuilder.ToString().ToLower().Equals("exit");
            }

            //Variable//
            var keyInput = new StringBuilder();

            //Process//
            Console.WriteLine("Type any word to count vowels or type exit to close");
            while (true)
            {
                keyInput.Append(Console.ReadLine());
                if (IsKeyExit(keyInput) || keyInput.Length == 0) break;
                var counttext = 0;
                foreach (char charInText in keyInput.ToString())
                {
                    foreach (char comparator in "aeiou".ToCharArray())
                    {
                        if (comparator.Equals(charInText))
                        {
                            counttext++;
                            break;
                        }
                    }

                }
                Console.WriteLine($"found {counttext}");
                keyInput.Clear();
                counttext = 0;
            }
        }
    }
}
