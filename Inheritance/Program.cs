using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your class

            //name, color, song, preditor, int beekLength in inches, int legs, int age, home
            Bird mockingBird = new Bird("Mocking Bird","black and White", "Mixed", true, 1, 2, 5, "Woods" );
            Console.WriteLine($"Here are the features of {mockingBird.Name}, \n Color: {mockingBird.Color} \n What song does it make: {mockingBird.Song}" +
                $"\n T or F, Is it a preditor: {mockingBird.Preditor} \n How long is its beak: {mockingBird.BeekLength} \n " +
                $"Number of Legs: {mockingBird.Legs} \n Age: {mockingBird.Age} \n Home: {mockingBird.Home}");
            Console.WriteLine();
            //name, color, energy, bloodtype, food, int legs, int age, home 
            Reptile beardedDragon = new Reptile("bearded Dragon", "tanish", "High", "Cold Blooded", "worms, crickets...", 4, 15, "My home!"  );
            Console.WriteLine($"Here are the features of {beardedDragon.Name}, \n Color: {beardedDragon.Color} \n Energy Level: {beardedDragon.EnergyLevel}" +
                $"\n Blood Type: {beardedDragon.BloodType} \n Food: {beardedDragon.Food} \n " +
                $"Number of Legs: {beardedDragon.Legs} \n Age: {beardedDragon.Age} \n Home: {beardedDragon.Home}");

        }
    }
}
