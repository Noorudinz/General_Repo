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

            String givenStr = Console.ReadLine();

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
    }
}
