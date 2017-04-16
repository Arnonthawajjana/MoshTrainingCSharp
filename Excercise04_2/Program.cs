using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for detail of how difference file vs fileinfo */
            /*https://stackoverflow.com/questions/1324788/what-is-the-difference-between-file-and-fileinfo-in-c*/
            var currentfile = @"e:\testfile\textexample.txt";

            while (true)
            {
                /* old version
                List<String> words = File.ReadAllText(currentfile).Split(' ').ToList();
                var duplicateKeys = words.GroupBy(x => x)
                    .Where(group => group.Count() > 1)
                    .OrderBy(group => group.Count())
                    .Select(group => new {word = group.Key,times = group.Count()})
                    .Take(3);
                */
                /* New version with linq */
                var duplicateKeys = File.ReadAllText(currentfile).Split(' ').ToList().GroupBy(x => x)
                   .Where(group => group.Count() > 1)
                   .OrderBy(group => group.Key).ThenBy(group => group.Count())
                   .Select(group => new { word = group.Key, times = group.Count()})
                   .Take(3);

                foreach (var s in duplicateKeys)
                    Console.WriteLine(s);

                Console.ReadLine(); 


            }
        }
    }
}
