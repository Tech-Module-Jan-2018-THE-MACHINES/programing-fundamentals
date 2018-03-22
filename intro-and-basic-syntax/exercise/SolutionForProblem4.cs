using System;

public class Program
{
    public static void Main()
    {   //reading from the console product name 
        var name = Console.ReadLine();
        //reading from the console product volume
        var volume = double.Parse(Console.ReadLine());
        //reading from the console product energy content per 100ml 
        var energy = double.Parse(Console.ReadLine());
        //reading from the console product sugar content per 100ml 
        var sugar = double.Parse(Console.ReadLine());
        //printing volume and name
        Console.WriteLine($"{volume}ml {name}:");
        //calculating and print kcal and sugar
        Console.WriteLine($"{(energy * volume / 100)}kcal, {(sugar * volume / 100)}g sugars");
    }
}
