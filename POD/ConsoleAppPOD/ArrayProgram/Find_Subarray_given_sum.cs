using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.ArrayProgram
{
    public class Find_Subarray_given_sum
    {
        static void MainProgram()
        {
            Find_Subarray_given_sum arraysum = new Find_Subarray_given_sum();
            int[] arr = { 2, 3, 8, 6, 4, 7, 6, 9 };
            int sum = 22;
            int n = arr.Length;
            arraysum.SubArray(arr, n, sum);
        }

        int SubArray(int[] arr, int n, int sum)
        {
            int curSum, i, j;

            for (i = 0; i < n; i++)
            {
                curSum = arr[i];

                for (j = i + 1; j <= n; j++)
                {
                    if (curSum == sum)
                    {
                        int p = j - 1;
                        Console.Write("Sum found between indexes {0} and {1}", i, p);
                        return 1;
                    }

                    if (curSum > sum || j == n)
                        break;

                    curSum = curSum + arr[j];
                }
            }

            Console.WriteLine("No subarray found");
            return 0;
        }
    }
}
