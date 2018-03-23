using System;

namespace miles
{
    public class P03_MilesToKilometers
    {
        public static void Main(string[] args)
        {
            // We are reading the distance in miles from the Console
            var distanceInMiles = double.Parse(Console.ReadLine());
            // We make a const for the prorortion km to miles
            const double kmPerMiles = 1.60934;
            // The next line calculates the distance in km
            var distanceInKilometers = distanceInMiles * kmPerMiles;
            //Printing the result
            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}
