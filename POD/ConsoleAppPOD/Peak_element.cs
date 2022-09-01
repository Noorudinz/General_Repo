using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    //Input: array[]= {5, 10, 20, 15}
    //Output: 20
    //The element 20 has neighbours 10 and 15,
    //both of them are less than 20.

    //Input: array[] = {10, 20, 15, 2, 23, 90, 67}
    //Output: 20 or 90
    //The element 20 has neighbours 10 and 15, 
    //both of them are less than 20, similarly 90 has neighbours 23 and 67.

    public class Peak_element
    {
        static void MainProgram()
        {
            int[] arr = { 1, 2, 3, 1 };
            //int[] arr = { 1, 2, 1, 3, 5, 6, 4 };
            int n = arr.Length;

            Console.Write("Index of a peak point is " +
                    findPeak(arr, n));
        }

        static int findPeak(int[] arr, int n)
        {
            if (n == 1)
                return 0;
            if (arr[0] >= arr[1])
                return 0;
            if (arr[n - 1] >= arr[n - 2])
                return n - 1;

            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] >= arr[i - 1] && arr[i] >= arr[i + 1])
                    return i;
            }

            return 0;
        }
    }
}
