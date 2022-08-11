using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Rotate_an_array
    {
        public static void leftRotationOfArrayBy1()
        {
            int[] elements = { 2, 3, 4, 5, 6, 7 };
            int x = elements[0]; //put 0th element in x = 2

            for (int i = 0; i < (elements.Length - 1); i++)
                elements[i] = elements[i + 1]; //3,4,5,6,7,7

            elements[(elements.Length - 1)] = x;

            for (int i = 0; i < elements.Length; i++)
                Console.Write(elements[i] + " ");
        }

        public static void rightRotationOfArrayBy1()
        {
            int[] elements = { 2, 3, 4, 5, 6, 7 };
            int x = elements[(elements.Length - 1)]; //display 7 index num 5

            for (int i = (elements.Length - 1); i > 0; i--)
            {
                elements[i] = elements[i - 1]; //finally array arranged 2,2,3,4,5,6
            }

            elements[0] = x; //put value 7 on 0th index

            for (int i = 0; i < elements.Length; i++)
                Console.Write(elements[i] + " ");
        }

        public static void rotateAnArrayByAnySide()
        {
            int[] elements = { 2, 3, 4, 5, 6, 7 };
            int n = 2; //dynamic change by any side 
            IEnumerable<int> newEnd = elements.Take(n - 1); //2
            IEnumerable<int> newBegin = elements.Skip(n - 1); //3, 4, 5, 6, 7
            var arr = newBegin.Union(newEnd).ToArray();

            foreach (int i in elements)
                Console.Write(i);

            Console.WriteLine();

            foreach (int i in arr)
                Console.Write(i);
        }
    }
}
