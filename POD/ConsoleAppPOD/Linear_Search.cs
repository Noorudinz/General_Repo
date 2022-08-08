using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Linear_Search
    {
        public static void Linear_Search_Program()
        {
            int[] arr = { 2, 3, 4, 10, 40, 54, 87, 99, 101, 145 };
            int x = 101;

            //Function call
            int result = searchElement(arr, x);
            if (result == -1)
                Console.WriteLine("The element is not presented in array");
            else
                Console.WriteLine("Element presented at index {0}", +result);
        }

        public static int searchElement(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
  
}
