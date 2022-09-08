using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.ArrayProgram
{
    public class Union_Intersect
    {
        static void MainProgram()
        {
            int[] arr1 = { 2, 5, 8, 7, 10 };
            int[] arr2 = { 1, 5, 3, 2, 9 };

            var union = arr1.Union(arr2).ToArray();
            var intersect = arr1.Intersect(arr2).ToArray();

            Console.WriteLine(union);
            Console.WriteLine(intersect);
        }
    }
}
