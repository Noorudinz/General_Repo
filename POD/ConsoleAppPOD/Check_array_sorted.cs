using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Check_array_sorted
    {
        public static void ArraySortedOrNotUsingRecursive()
        {
            int[] arr = { 20, 30, 40, 45, 55, 68 };
            int n = arr.Length;

            if (isArraySortedRecursive(arr, n) != 0) //check sorting using recursive method
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        public static int isArraySortedRecursive(int[] arr, int n)
        {
            if (n == 1 || n == 0)
                return 1;

            if (arr[n - 1] < arr[n - 2])//check last two pairs is sorted or not
                return 0;

            return isArraySortedRecursive(arr, n - 1); //keep on checking
        }

        public static void ArraySortedOrNotUsingIteration()
        {
            int[] arr = { 20, 30, 40, 45, 55, 68 };
            int n = arr.Length;

            if (isArraySortedIteration(arr, n)) //check sorting using iteration method
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        static bool isArraySortedIteration(int[] arr, int n)
        {
            if (n == 1 || n == 0)
                return true;

            for (int i = 1; i < n; i++)
            {
                //check if unsorted pair found
                //if you reverse (arr[i - 1] < arr[i]) will check given array is in descending order or not
                if (arr[i - 1] > arr[i]) 
                    return false;
            }

            return true;
        }
    }
}
