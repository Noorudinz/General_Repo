using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.ArrayProgram
{
    public class MoveNegativeNumbersToOneSide
    {
        static void MainProgram()
        {
            int[] arr = { 12, -56, 41, -75, 36, -96, 85, -25 };
            Array.Sort(arr);

            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
