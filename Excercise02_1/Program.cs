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

            Console.WriteLine("Some one like by add new Name? leave blank and Enter when is enough");
            while (true)
            {
                inputFromKeyboard.Append(Console.ReadLine());
                if (!inputFromKeyboard.ToString().Equals(String.Empty))
                {
                    likeListName.Add(inputFromKeyboard.ToString());
                    inputFromKeyboard.Clear();
                }
                else
                {
                    Console.WriteLine("Let't see who like you");
                    for (int index = 0; index < likeListName.Count(); index++)
                    {
                        if (index < 2)
                        {
                            Console.WriteLine(likeListName[index]);
                        }
                        else
                        {
                            Console.WriteLine("And {0} other like you too", likeListName.Count()-2);
                            break;
                        }

                    }

                }
            }
        
        }
    }
}
