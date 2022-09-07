using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.ArrayProgram
{
    public class Find_Occurence
    {
        static void MainProgram()
        {
            int[] arr = { 1, 1, 2, 2, 2, 3, 3, 3, 3, 4 };
            int n = arr.Length;
            int x = 2;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (x == arr[i])
                    count++;
            }

            Console.WriteLine("Occurence of {0} is : {1}", x, count);
        }
    }
}
