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

        public static void TernarySearch()
        {
            int l, r, p, key;
            int[] arr = { 10, 20, 25, 30, 45, 55, 65, 70, 75, 85, 90, 95 };

            l = 0;

            r = arr.Length - 1;

            key = 90;

            p = TernarySearch(l, r, key, arr);

            Console.WriteLine("Index of " + key + " is " + p);
        }

        static int TernarySearch(int l, int r, int key, int[] arr)
        {
            if (r >= l)
            {

                // Find the mid1 and mid2
                int mid1 = l + (r - l) / 3;
                int mid2 = r - (r - l) / 3;

                // Check if key is present at any mid
                if (arr[mid1] == key)
                {
                    return mid1;
                }
                if (arr[mid2] == key)
                {
                    return mid2;
                }

                // Since key is not present at mid,
                // check in which region it is present
                // then repeat the Search operation
                // in that region

                if (key < arr[mid1])
                {
                    // The key lies in between l and mid1
                    return TernarySearch(l, mid1 - 1, key, arr);
                }
                else if (key > arr[mid2])
                {
                    // The key lies in between mid2 and r
                    return TernarySearch(mid2 + 1, r, key, arr);
                }
                else
                {
                    // The key lies in between mid1 and mid2
                    return TernarySearch(mid1 + 1, mid2 - 1, key, arr);
                }
            }

            // Key not found
            return -1;
        }
    }
}
