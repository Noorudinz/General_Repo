using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.String
{
    public class Reverse_words
    {
        public static void MainProgram()
        {
            string s = "I know c# program very well";
            char[] word = reverseWord(s.ToCharArray());
            Console.WriteLine(word);
        }

        static char[] reverseWord(char[] s)
        {
            // Reversing individual words as explained in the first step
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // If we see a space, we reverse the previous word (word between the indexes start and end-1
                // i.e., s[start..end-1]
                if (s[i] == ' ')
                {
                    reverse(s, start, i);
                    start = i + 1;
                }
            }

            // Reverse the last word
            reverse(s, start, s.Length - 1);

            // Reverse the entire String
            reverse(s, 0, s.Length - 1);

            return s;
        }

        static void reverse(char[] str, int start, int end)
        {
            char temp; //temp variable;

            while (start <= end)
            {
                // Swapping the first and last character
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }

        }
    }
}
