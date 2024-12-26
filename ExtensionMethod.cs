using System;
using System.Collections.Generic;

namespace sample
{
    public static class ExtensionMethods
    {
        //This is normal extension method which we can use as the in built method
        public static void PrintElements(this List<int> list)
        {
            Console.WriteLine("List Elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // this method implement the default method of the interface

        public static void Sleeping(this IAnimal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} is sleeping.");
        }

        public static int CountVowels(this string str)
        {
            int count = 0;
            foreach (var ch in str.ToLower())
            {
                if ("aeiou".Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static void MakeSound(this IAnimal animal)
        {
            if (animal is Dog)
            {
                Console.WriteLine("Dog says: Woof!");
            }
            else if (animal is Cat)
            {
                Console.WriteLine("Cat says: Meow!");
            }
            else
            {
                Console.WriteLine("Unknown animal sound.");
            }
        }
    }

    public interface IAnimal
    {
        void DisplayType();
    }

    public class Dog : IAnimal
    {
        public void DisplayType()
        {
            Console.WriteLine("I am a Dog.");
        }
    }

    public class Cat : IAnimal
    {
        public void DisplayType()
        {
            Console.WriteLine("I am a Cat.");
        }
    }
}
