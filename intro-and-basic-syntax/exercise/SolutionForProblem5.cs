//CONFIRMED from RomanGyolski
using System;

public class Program
{
    public static void Main()
    {
        // Recieve name
        var name = Console.ReadLine();
        // Recieve current health
        var currentHealth = int.Parse(Console.ReadLine());
        // Recieve max health
        var maxHealth = int.Parse(Console.ReadLine());
        // Recieve current energy
        var currentEnergy = int.Parse(Console.ReadLine());
        // Recieve max energy
        var maxEnergy = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));
    }
}
