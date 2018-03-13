using System;

namespace Pr2RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double widthRectangle = double.Parse(Console.ReadLine());
            double heightRectangle = double.Parse(Console.ReadLine());
            double areaRectangle = widthRectangle * heightRectangle;
            Console.WriteLine($"{areaRectangle:F2}");
        }
    }
}
