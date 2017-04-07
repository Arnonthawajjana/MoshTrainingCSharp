using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise01_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const float kmPerDemeritPoint = 5.0f;
            const float susspenedDemeritPoint = 12.0f;

            var speedLimit = 0.0f;
            var currentSpeed = 0.0f;
            var demerit = 0.0f;
            
            Console.WriteLine("This is speed camera innitail");
            Console.WriteLine("Please fill speed limit :km/h");
            float.TryParse(Console.ReadLine(), out speedLimit);

            while (true)
            {
                Console.WriteLine("insert current speed :km/h");
                float.TryParse(Console.ReadLine(), out currentSpeed);

                if (currentSpeed <= speedLimit) Console.WriteLine("OK");
                else
                {
                    demerit = (currentSpeed - speedLimit) / kmPerDemeritPoint;
                    Console.WriteLine(demerit < susspenedDemeritPoint ? $"demerit {demerit} point" :
                        "You license is suspended");
                }
            }
        }
    }
}
