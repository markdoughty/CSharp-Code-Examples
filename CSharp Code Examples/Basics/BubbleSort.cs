using System;
using System.Collections.Generic;

namespace CSharp_Code_Examples

class BubbleSort
{
    //Authors: Jakub Grela
    //Uses the array set by the user and performs a bubble sort then displays to the console.
    public static void run()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", arr));

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", arr));

        Console.ReadLine();
    }
}
