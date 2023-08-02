using System;

namespace CSharp_Code_Examples
{
    class StringManipulation
    {
        //Authors: Ahmed Dafalla
        //Demonstrates some basic string manipulations in C#
        public static void run()
        {
            // Declare a basic string
            string example = "Hello, Lincoln!";

            // Print original string
            Console.WriteLine($"Original string: {example}");

            // Convert the string to uppercase and print
            string uppercase = example.ToUpper();
            Console.WriteLine($"Uppercase string: {uppercase}");

            // Convert the string to lowercase and print
            string lowercase = example.ToLower();
            Console.WriteLine($"Lowercase string: {lowercase}");

            // Find the index of a substring within the string
            int index = example.IndexOf("Lincoln");
            Console.WriteLine($"Index of 'Lincoln': {index}");

            // Replace a substring within the string and print
            string replaced = example.Replace("Lincoln", "World");
            Console.WriteLine($"Replaced string: {replaced}");

            // Split the string into words and print
            string[] words = example.Split(' ');
            Console.WriteLine("Split string into words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
