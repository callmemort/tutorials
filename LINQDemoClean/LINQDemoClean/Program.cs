using System;

namespace LINQDemoClean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pony> allPonies = Pony.GetListOfPonies();
            foreach (Pony pony in allPonies)
            {
                Console.WriteLine(pony.Name);
            }

            //Things you can do with LINQ

            //Where - filter a collection
            List<Pony> demo = new List<Pony>();
            foreach(Pony pony in allPonies)
            {
                if(pony.HairColor == "purple")
                {
                    demo.Add(pony);
                }
            }
            var purpleHairedPonies = allPonies.Where(p => p.HairColor == "purple");
            Console.WriteLine("Here are all the ponies with purple hair: ");
            foreach (Pony aPony in purpleHairedPonies)
            {
                Console.WriteLine(aPony.Name);
            }
            Console.WriteLine();
            List<Pony> moreThan10ItemPonies = allPonies.Where(p => p.CutieMark.Quantity > 10).ToList();
            Console.WriteLine("Here are all the ponies with more than 10 items in their cutie marks: ");

            foreach (Pony aPony in moreThan10ItemPonies)
            {
                Console.WriteLine(aPony.Name);
            }
            Console.WriteLine();


            //Select - mostly used to "transform" the objects in a collection to another type of object
            var specialListOfBrandNewObjectsThatHasPonyNameAndCutieMarkName = allPonies.Select(p => new { p.Name, p.CutieMark.Mark }).ToList();
            foreach (var specialPony in specialListOfBrandNewObjectsThatHasPonyNameAndCutieMarkName)
            {
                Console.WriteLine($"{specialPony.Name} has a {specialPony.Mark} for her cutie mark");
            }

            //First() - get the first object in the collection
            // First() and FirstOrDefault() - return only one object from the collection, the "First" one that matches your condition, or the first one in a sorted state, or even just the first one. 
            Pony greenHairedPony = allPonies.FirstOrDefault(p => p.HairColor == "green");

            //using First() with OrderBy()
            Pony firstAlphabetically = allPonies.OrderBy(p => p.Name).FirstOrDefault();
            Console.WriteLine($"The first pony alphabetically is: {firstAlphabetically.Name}");

            // - Any() - returns a boolean value that tells you if any objects in your collection meet a condition.
            // similar to what you might think of as .contains() but can take an entire function or drill down into an object to find nested properties and things like that


            // All() - also returns a boolean answering whether all the things meet a specific condition

            // SelectMany() - How to flatten a collection. This is used when you have one collection of objects, and the objects contain another 
            //collection inside. We are probably not going to get to this today but I wanted to leave it here so you've heard of it.

        }
    }
}