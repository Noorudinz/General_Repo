using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class MaxOccurenceCharacter
    {

        //This program get max char occur including space, max char if repeat same
        //eg: 'i,a,p' appears 3 times will display first occurance 'i' 
        public static void getMaxOccurrenceCharacter()
        {
            int[] countArray = new int[256];
            int maxValue = 0;
            char resultChar = '\0'; //char initialization

            string givenStr = Console.ReadLine();

            for (int i = 0; i < givenStr.Length; i++)
            {
                //This count repeated char otherwise 0
                countArray[givenStr[i]]++;

                //Check repeated char with already stored max value
                if (countArray[givenStr[i]] > maxValue)
                {
                    maxValue = countArray[givenStr[i]];
                    resultChar = givenStr[i]; //stored char which repeated count is max
                }
            }

            Console.WriteLine(resultChar);
        }

        //Exact program for maximum char occurence using linq and dictionary
        public static void getMaxCharOccurence()
        {
            string message = "This is the program of csharp done by noorudin";
            Dictionary<char, int> dict = message.Replace(" ", string.Empty)
                                           .GroupBy(c => c)
                                           .ToDictionary(gr => gr.Key, gr => gr.Count());

            foreach (var e in dict)
            {
                if (dict.Values.Max() == e.Value)
                    Console.WriteLine("Character '" + e.Key + "' occur number of times is " + e.Value);
            }
        }
    }
}
