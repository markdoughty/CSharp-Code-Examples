using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Code_Examples


class HeapSort
{
    public static void run()
    //Authors: Jakub Grela
    //A heapsort which asks for user input, uses the sort and displays output to console
    {
        // Ask the user to input 5 numbers
        Console.WriteLine("Please enter 5 numbers:");
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--;
            }
        }

        // Sort the numbers using heap sort
        HeapSort(numbers);

        // Output the sorted numbers to the console
        Console.WriteLine("Sorted numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }

    static void HeapSort(int[] array)
    {
        // Build a max heap from the array
        for (int i = array.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(array, array.Length, i);
        }

        // Heap sort
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Swap(array, 0, i);
            Heapify(array, i, 0);
        }
    }

    static void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            Swap(array, i, largest);
            Heapify(array, n, largest);
        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
