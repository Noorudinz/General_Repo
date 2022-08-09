using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Missing_number_from_array
    {
        public static void missingNumber()
        {
            int[] arr = { 111, 112, 115, 117, 114, 113 };

            int n = arr.Length;

            //formula for find sum of sequence including missing number
            int total = ((n + 1) * (n + 2)) / 2;

            for (int i = 0; i < n; i++)
            {
                total -= arr[i];
            }

            Console.WriteLine(total);
        }
    }
}
