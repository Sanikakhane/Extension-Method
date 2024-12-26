using System;
using System.Collections.Generic;

namespace sample
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.PrintElements();
            Console.WriteLine($"Average: {numbers.Average()}");

            
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.DisplayType();
            dog.Sleeping();
            dog.MakeSound();

            cat.DisplayType();
            cat.Sleeping();
            cat.MakeSound();

            string sampleText = "Hello Extension Methods!";
            int vowelCount = sampleText.CountVowels();
            Console.WriteLine($"The string \"{sampleText}\" has {vowelCount} vowels.");
        }
    }
}
