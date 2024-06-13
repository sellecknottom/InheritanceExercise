using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird robin = new Bird();
            robin.Feathers = true;
            robin.LaysEggs = true;
            robin.FeatherColor = "Red";
            robin.LandWaterAir = "Airforce";
            robin.Grows = true;
            robin.Motile = true;
            robin.FoodType = "Worms";
            robin.Organs = true;

            Console.WriteLine($"Does a robin have feathers? {robin.Feathers}. Does a robin lay eggs? {robin.LaysEggs}. \n" +
                $"What is the prominant color on a robin? {robin.FeatherColor}. If a robin was in the military, what branch" +
                $"would it likely join? {robin.LandWaterAir}. \n" +
                $"Is the robin alive - does it grow? {robin.Grows}. What does a robin eat? {robin.FoodType}. \n" +
                $"Does a robin have avian organs? {robin.Organs}. Can the robin fly and hop? {robin.Motile}.");
            Console.WriteLine();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile tRex = new Reptile();
            tRex.HasFeathers = true;
            tRex.IsExtinct = true;
            tRex.IsCarnivore = true;
            tRex.NumberOfLegs = 4;
            tRex.Grows = false;
            tRex.Motile = false;
            tRex.FoodType = "Triceratops";
            tRex.Organs = false;

            Console.WriteLine($"Let's talk about another avian beast... the T. Rex! Is the T. Rex extinct? {tRex.IsExtinct}. \n" +
                $"Did the T. Rex have feathers? {tRex.HasFeathers}. Did it eat meat? {tRex.IsCarnivore}. \n" +
                $"How many limbs did it have? {tRex.NumberOfLegs}. If you see a T. Rex now, does it grow? {tRex.Grows}. \n" +
                $"Does it move? {tRex.Motile}. Does it even have internal organs? {tRex.Organs}. \n" +
                $"\n" +
                $"When it was alive, what did T. Rex eat? {tRex.FoodType}!");
        }
    }
}
