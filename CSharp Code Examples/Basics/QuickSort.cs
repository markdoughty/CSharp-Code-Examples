using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{



    class QuickSort
    // Authors: Jakub Grela
    // A Quick sort asking the user for an array of 5 integers which then sorts and outputs to the console
    {
        public static void run()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array: [" + string.Join(", ", arr) + "]");
            Console.ReadLine();
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;
            return i + 1;
        }
    }
}