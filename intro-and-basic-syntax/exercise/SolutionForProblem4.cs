﻿using System;

public class Program
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var volume = double.Parse(Console.ReadLine());
        var energy = double.Parse(Console.ReadLine());
        var sugar = double.Parse(Console.ReadLine());
        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{(energy * volume / 100)}kcal, {(sugar * volume / 100)}g sugars");
    }
}
