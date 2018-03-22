using System;

public class Program
{
    public static void Main()
    {
        // Recieve name
        var name = Console.ReadLine();
        // Recieve name
        var health = int.Parse(Console.ReadLine());
        // Recieve name
        var maxHealth = int.Parse(Console.ReadLine());
        // Recieve name
        var energy = int.Parse(Console.ReadLine());
        // Recieve name
        var maxEnergy = int.Parse(Console.ReadLine());
        // Recieve name
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Health: |{0}{1}|", new string('|', health), new string('.', maxHealth - health));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', maxEnergy - energy));
    }
}
