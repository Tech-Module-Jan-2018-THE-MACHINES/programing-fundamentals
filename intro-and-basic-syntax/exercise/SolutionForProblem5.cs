using System;

public class Program
{
    public static void Main()
    {
        // Recieve name
        var name = Console.ReadLine();
        // Recieve name
        var currentHealth = int.Parse(Console.ReadLine());
        // Recieve name
        var maxHealth = int.Parse(Console.ReadLine());
        // Recieve name
        var currentEnergy = int.Parse(Console.ReadLine());
        // Recieve name
        var maxEnergy = int.Parse(Console.ReadLine());
        // Recieve name
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));
    }
}
