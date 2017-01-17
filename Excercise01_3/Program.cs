using System;

namespace Excercise01_3
{
     class Program
    {
        //fix concept by use Enum

        public enum ImageOrientation
        {
            Landscape,
            Portrait,
            Square
        }

        private static void Main()
        {
            int height;
            int width;

            Console.Write("insert height:");
            int.TryParse(Console.ReadLine(), out height);
            Console.Write("insert width:");
            int.TryParse(Console.ReadLine(), out width);

            Console.WriteLine("Image Orientation :");
            Console.WriteLine(height == width
                ? ImageOrientation.Square.ToString()
                : height < width
                    ? ImageOrientation.Landscape.ToString()
                    : ImageOrientation.Portrait.ToString());
        }
    }
}