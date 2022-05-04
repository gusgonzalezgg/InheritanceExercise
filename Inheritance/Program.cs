using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - Done
            // give this class 4 members that all Animals have in common- Done


            // Create a class Bird- Done
            // give this class 4 members that are specific to Bird- Done
            // Set this class to inherit from your Animal Class- Done

            // Create a class Reptile- Done
            // give this class 4 members that are specific to Reptile- Done
            // Set this class to inherit from your Animal Class- Done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("Let's talk about the Bald Eagle");
            Console.WriteLine();
            Console.ReadKey();

            var Pal = "Buddy";
            int Six = 6;


            Bird Eagle = new Bird();
            Eagle.WingCount = 2;
            Eagle.Beak = "Yes";
            Eagle.AbleToFly = "You betcha " + Pal ;
            Eagle.WingSpan = "between " + Six + " & 7 1/2 ft";

            Console.WriteLine($"It has {Eagle.WingCount} large wings, sitting {Eagle.WingSpan}");
            Console.ReadKey();
            Console.WriteLine($"Can it fly? {Eagle.AbleToFly}");
            Console.ReadKey();
            Console.WriteLine("....");
            Console.WriteLine("You asked if it has a beak?");
            Console.ReadKey();
            Console.WriteLine("....");
            Console.ReadKey();
            Console.WriteLine(Eagle.Beak);
            Console.ReadKey();

            Console.WriteLine("Okay on to the next animal!");


            Reptile Lizard = new Reptile();
            Lizard.Scales = "They likely are scaley, depends on which type. Idk, not sure.";
            Lizard.ColdBlooded = "Yes I think?";
            Lizard.LegCount = 2;
            Lizard.Tail = "I want to say yes, don't quote me";

            Console.WriteLine("Here we have a lizard - I don't know much, if anything, about them so we're gonna wing it");
            Console.ReadKey();
            Console.WriteLine("They have scales right? " + Lizard.Scales);
            Console.ReadKey();
            Console.WriteLine("Are they cold blooded? " + Lizard.ColdBlooded);
            Console.ReadKey();
            Console.WriteLine("For the most part I know they all have at least " + Lizard.LegCount + " legs");
            Console.ReadKey();
            Console.WriteLine("They have tails right? " + Lizard.Tail);
            Console.ReadKey();
            Console.WriteLine("Sorry I wish I was more knowledgeable - see ya!");







            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
