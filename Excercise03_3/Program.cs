using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03_3
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
            var tryParseTimespan = new TimeSpan();

            //Process//
            Console.WriteLine("Please Input time in the right 00:00 - 23:59 or exit");
            while (true)
            {
                keyInput.Append(Console.ReadLine());
                if (IsKeyExit(keyInput)) break;
                Console.WriteLine(!TimeSpan.TryParse(keyInput.ToString(), out tryParseTimespan)
                    ? $"Invalid Time"
                    : $"OK [{tryParseTimespan}] \n");
                keyInput.Clear();
            }
        }
    }
}
