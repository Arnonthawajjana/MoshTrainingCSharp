using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03_4
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
            Console.WriteLine("Create name of variable by type name or their behavior or type exit to close");
            while (true)
            {
                keyInput.Append(Console.ReadLine());
                if (IsKeyExit(keyInput) || keyInput.Length == 0) break;
                var splitText = keyInput.ToString().ToLower().Split(' ');
                for (int index = 0; index < splitText.Length; index++)
                {
                    splitText[index] = splitText[index]
                        .Replace(
                            (splitText[index])[0],char.ToUpper((splitText[index])[0]));
                    Console.Write($"{splitText[index]}");
                }
                Console.WriteLine("");
                keyInput.Clear();
            }
        }
    }
}
