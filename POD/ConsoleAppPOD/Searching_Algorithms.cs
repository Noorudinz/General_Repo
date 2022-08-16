using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Searching_Algorithms
    {
        public static void BinarySearch()
        {
            //for binary search we have to sort the elements first
            int[] arr = { 10, 20, 25, 30, 55, 65, 70, 80 };
            int searchItem = 70;
            int position = 0;

            int LOW = 0;
            int MID = 0;
            int HIGH = 0;

            HIGH = arr.Length - 1;
            MID = (LOW + HIGH) / 2;

            //check low index with high index
            while (LOW <= HIGH)
            {
                //if search element found break the loop
                if (searchItem == arr[MID])
                {
                    position = MID + 1;
                    break;
                }
                else if (searchItem < arr[MID])
                {
                    HIGH = MID - 1;
                    MID = (LOW + HIGH) / 2;
                }
                else if (searchItem > arr[MID])
                {
                    LOW = MID + 1;
                    MID = (LOW + HIGH) / 2;
                }

            }

            if (position == 0)
                Console.WriteLine("Item not found");
            else
                Console.WriteLine("Item found {0} on position {1}", searchItem, position);
        }
    }
}
