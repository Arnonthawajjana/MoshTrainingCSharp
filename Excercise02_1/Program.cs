using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initail variable
            var likeListName = new List<string>();
            var inputFromKeyboard = new StringBuilder();

            Console.WriteLine("Some one like buy add new Name?");
            while (true)
            {
                inputFromKeyboard.Append(Console.ReadLine());
                if(inputFromKeyboard.ToString().)
                likeListName.Add(inputFromKeyboard.ToString());
                inputFromKeyboard.Clear();
            }
        }
    }
}
