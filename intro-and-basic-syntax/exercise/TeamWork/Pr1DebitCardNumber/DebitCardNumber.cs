using System;

namespace Pr1DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            var fNum = int.Parse(Console.ReadLine());
            var sNum = int.Parse(Console.ReadLine());
            var tNum = int.Parse(Console.ReadLine());
            var fourNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{fNum:D4} {sNum:D4} {tNum:D4} {fourNum:D4}");
        }
    }
}
