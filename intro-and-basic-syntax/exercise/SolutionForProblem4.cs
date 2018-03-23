using System;

public class Program
{
    public static void Main()
    {   //reading from the console product name 
        var productName = Console.ReadLine();
        //reading from the console product volume
        var volume = double.Parse(Console.ReadLine());
        //reading from the console product energy content per 100ml 
        var energyContent = double.Parse(Console.ReadLine());
        //reading from the console product sugar content per 100ml 
        var sugarContent = double.Parse(Console.ReadLine());
        //printing volume and name
        Console.WriteLine($"{volume}ml {productName}:");
        //calculating and print kcal and sugar
        Console.WriteLine($"{(energyContent * volume / 100)}kcal, {(sugarContent * volume / 100)}g sugars");
    }
}
