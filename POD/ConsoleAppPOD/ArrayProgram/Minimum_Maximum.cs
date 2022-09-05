using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.ArrayProgram
{
    public class Minimum_Maximum
    {
        public static void MainProgram()
        {
            int[] arr = { 25, 45, 96, 35, 52, 75 };
            int n = arr.Length;
            int min, max;

            max = arr[0];
            min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Minimum element : " + min);
            Console.WriteLine("Maximun element : " + max);
        }
     
    }
}
