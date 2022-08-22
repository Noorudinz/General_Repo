using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Sorting_Algorithms
    {        
        public void SelectionSort()
        {
            //selection sort loop
            //loop 1: 26, 52, 74, 42, 89, 54, 88
            //loop 2: 26, 42, 74, 52, 89, 54, 88
            //loop 3: 26, 42, 52, 74, 89, 54, 88
            //loop 4: 26, 42, 52, 54, 89, 74, 88
            //loop 5: 26, 42, 52, 54, 74, 89, 88
            //loop 6: 26, 42, 52, 54, 74, 88, 89

            int[] arr = { 54, 52, 74, 42, 89, 26, 88 };
            int n = arr.Length;

            //move 1 by 1 boundry of unsorted array
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_index = i;

                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_index])
                        min_index = j;

                // Swap the found minimum element with the first element
                int temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;

            }

            // Prints the array
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public void BubbleSort()
        {
            //Bubble sort starts with very first two elements, comparing them to check which one is greater.
            //loop i 1st pass:
            // loop j: 52, 54, 42, 74, 89, 26, 88
            //loop i 2nd pass:
            // loop j: 52, 42, 54, 74, 26, 88, 89  
            //loop i 3rd pass:
            // loop j: 42, 52, 54, 26, 74, 88, 89 
            //loop i 4th pass:
            // loop j: 42, 52, 26, 54, 74, 88, 89 
            //loop i 5th pass:
            // loop j: 42, 26, 52, 54, 74, 88, 89 
            //loop i 6th pass:
            // loop j: 26, 42, 52, 54, 74, 88, 89 
            // loop i 7th pass:
            // Now, the array is already sorted, but our algorithm does not know if it is completed.
            // The algorithm needs one whole pass without any swap to know it is sorted.

            int[] arr = { 54, 52, 74, 42, 89, 26, 88 };
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    //compare two element next to next to swap arr[i]
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public void MergeSort()
        {
            //Merge sort
            //54, 52, 74, 42, 89, 26, 88
            //split 1: 54,52,74 | 42,89,26,88
            //split 2: 54 | 52,74 | 42,89 | 26,88
            //merge 1: 54 | 52,74 | 42,89 | 26,88
            //merge 2: 52,54,74 | 26,42,88,89
            //merge 3: 26,42,52,54,74,88,89

            //int[] numbers = { 54, 52, 74, 42, 89, 26, 88 };
            int[] numbers = { 54, 52, 74, 42 };
            int max = numbers.Length;

            SortMerge(numbers, 0, max - 1);

            for (int i = 0; i < max; i++)
                Console.Write(numbers[i] + " ");
            Console.ReadLine();
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
