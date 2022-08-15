using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class Palindrom
    {
        //Palindrome function using numbers
        public static void PalindromNumbers()
        {
            int number = 123291;
            int remainder, sum = 0;
            int temp = number;

            while (number > 0)
            {
                remainder = number % 10;

                sum = (sum * 10) + remainder;

                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine($"Number {temp} is Palindrome.");
            else
                Console.WriteLine($"Number {temp} is not Palindrome.");
        }

        //Palindrome function using strings
        public static void PalindromStrings()
        {
            string givenStr = "abbna";
            string reverse = string.Empty;

            for (int i = givenStr.Length - 1; i >= 0; i--)
            {
                reverse = reverse + givenStr[i];
            }

            if (reverse == givenStr)
                Console.WriteLine("String is palindrome");
            else
                Console.WriteLine("String is not palindrome");
        }

    }
}
