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
            int x = elements[0];

            for (int i = 0; i < (elements.Length - 1); i++)
                elements[i] = elements[i + 1];

            elements[(elements.Length - 1)] = x;

            for (int i = 0; i < elements.Length; i++)
                Console.Write(elements[i] + " ");
        }

        public static void rightRotationOfArrayBy1()
        {

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
