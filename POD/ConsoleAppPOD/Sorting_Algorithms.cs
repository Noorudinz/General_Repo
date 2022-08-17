using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Sorting_Algorithms
    {
        //selection sort loop
        //loop 1: 26, 52, 74, 42, 89, 54, 88
        //loop 2: 26, 42, 74, 52, 89, 54, 88
        //loop 3: 26, 42, 52, 74, 89, 54, 88
        //loop 4: 26, 42, 52, 54, 89, 74, 88
        //loop 5: 26, 42, 52, 54, 74, 89, 88
        //loop 6: 26, 42, 52, 54, 74, 88, 89
        public void SelectionSort()
        {
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
    }
}
