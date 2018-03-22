using System;

namespace Pr2RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            //In the first line we reciev width;
            double widthRectangle = double.Parse(Console.ReadLine());
            //In the second line we reciev height;
            double heightRectangle = double.Parse(Console.ReadLine());
            //We calculate area
            double areaRectangle = widthRectangle * heightRectangle;
            //Print result
            Console.WriteLine($"{areaRectangle:F2}");
        }
    }
}
