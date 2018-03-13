using System;

namespace Pr2RectangleArea
{
    class SolutionForProblem2
    {
        static void Main(string[] args)
        {
            double widthRect = double.Parse(Console.ReadLine());
            double heightRect = double.Parse(Console.ReadLine());
            double areaRect = widthRect * heightRect;
            Console.WriteLine($"{areaRect:F2}");
        }
    }
}
