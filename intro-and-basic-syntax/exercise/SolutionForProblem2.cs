//CONFIRMED from todorstanchev
using System;

namespace Pr2RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            //In the first line we reciev width;
            double widthRect = double.Parse(Console.ReadLine());
            //In the second line we reciev height;
            double heightRect = double.Parse(Console.ReadLine());
            //We calculate area
            double areaRect = widthRect * heightRect;
            //Print result
            Console.WriteLine($"{areaRect:F2}");
        }
    }
}
