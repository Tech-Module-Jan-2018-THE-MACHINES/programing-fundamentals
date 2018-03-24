//CONFIRMED from petiatodorova

using System;

public class Program
{
    public static void Main()
    {   //Reading from the console product name 
        var productName = Console.ReadLine();

        //Reading from the console product volume
        var volumeForProduct = double.Parse(Console.ReadLine());

        //Reading from the console product energy content per 100ml 
        var energyContentPer100ml = double.Parse(Console.ReadLine());

        //Reading from the console product sugar content per 100ml 
        var sugarContentPer100ml = double.Parse(Console.ReadLine());

        //Printing volume and name
        Console.WriteLine($"{volumeForProduct}ml {productName}:");

        //Calculating and print kcal and sugar
        Console.WriteLine($"{(energyContentPer100ml * volumeForProduct / 100)}kcal, {(sugarContentPer100ml * volumeForProduct / 100)}g sugars");
    }
}
