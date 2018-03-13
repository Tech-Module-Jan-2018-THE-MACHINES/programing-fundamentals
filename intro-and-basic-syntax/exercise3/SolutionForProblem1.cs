using System;

public class Program
{
    public static void Main()
    {
        var firtsNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        var thirdNum = int.Parse(Console.ReadLine());
        var fourthNum = int.Parse(Console.ReadLine());
        Console.WriteLine($"{firtsNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}");
    }
}
