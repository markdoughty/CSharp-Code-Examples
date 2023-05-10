using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples

class InsertionSort
{
    public static void run()
    // Authors: Jakub Grela
    //An insertion sort which asks the user for numbers and then sorts them with output to the console
    {
        // Ask the user to enter a list of integers separated by spaces
        Console.WriteLine("Enter a list of integers separated by spaces:");
        var input = Console.ReadLine();

        // Convert the input to an array of integers
        var nums = Array.ConvertAll(input.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries), int.Parse);

        // Print the unsorted list
        Console.WriteLine("Unsorted list:");
        Console.WriteLine(string.Join(", ", nums));

        // Sort the array using insertion sort
        for (int i = 1; i < nums.Length; i++)
        {
            int j = i;
            while (j > 0 && nums[j - 1] > nums[j])
            {
                // Swap the elements at positions j and j - 1
                int temp = nums[j - 1];
                nums[j - 1] = nums[j];
                nums[j] = temp;
                j--;

                // Provide feedback on the sorting process
                Console.WriteLine($"Sorting... {string.Join(", ", nums)}");
            }
        }

        // Print the sorted list
        Console.WriteLine("Sorted list:");
        Console.WriteLine(string.Join(", ", nums));

        // Wait for user input before closing the program
        Console.ReadLine();
    }
}
