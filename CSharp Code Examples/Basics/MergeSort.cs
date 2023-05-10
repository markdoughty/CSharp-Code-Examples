using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples

class MergeSort
{// Authors: Jakub Grela
// Code for a MergeSort asks the user for 5 values then sorts and outputs to console.
    public static void run()
    {
        Console.WriteLine("Please enter 5 numbers to sort:");
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write($"Number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    arr[i] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
        }

        Console.WriteLine("Unsorted array: " + string.Join(", ", arr));

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        Console.ReadLine();
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
            Print(arr);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[arr.Length];
        int i, j, k;
        i = left;
        j = mid + 1;
        k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i] < arr[j])
            {
                temp[k++] = arr[i++];
            }
            else
            {
                temp[k++] = arr[j++];
            }
        }

        while (i <= mid)
        {
            temp[k++] = arr[i++];
        }

        while (j <= right)
        {
            temp[k++] = arr[j++];
        }

        for (i = left; i <= right; i++)
        {
            arr[i] = temp[i];
        }
    }

    static void Print(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
