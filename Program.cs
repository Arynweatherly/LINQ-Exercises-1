using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given the collections of items shown below, use LINQ to build the 
            //requested collection, and then Console.WriteLine() each item in 
            //that resulting collection.

            //RESTRICTION/ FILTERING OPERATIONS:

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = fruits.Where(fruit =>
            {
                bool lFruit = fruit.StartsWith("L");
                return lFruit;

            }).ToList();

            foreach (var f in LFruits)
            {
                Console.WriteLine(f);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            List<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0)
                .ToList();
            foreach (var num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

        }

    }
}