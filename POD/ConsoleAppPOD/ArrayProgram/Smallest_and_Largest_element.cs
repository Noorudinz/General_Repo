using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.ArrayProgram
{
    public class Smallest_and_Largest_element
    {
        static void MainProgram()
        {
            int[] arr = { 24, 65, 45, 78, 22, 54, 63 };
            int smallest = 5, largest = 4;

            Array.Sort(arr);

            foreach (int i in arr)
                Console.Write(" " + i);

            Console.WriteLine("\n Kth smallest element position of {0} is {1}", smallest, arr[smallest - 1]);

            Array.Reverse(arr);

            foreach (int i in arr)
                Console.Write(" " + i);

            Console.WriteLine("\n Kth largest element position of {0} is {1}", largest, arr[largest - 1]);
        }
       
    }
}
