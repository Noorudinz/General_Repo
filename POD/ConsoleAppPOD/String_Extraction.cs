using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class String_Extraction
    {
        public static void getExtractedStrings()
        {
            string givenRawString = "Q@WsdfbksadfADFF354352367%34^&D3!25^st&56(";

            StringBuilder capsAlphabet = new StringBuilder();
            StringBuilder smallsAlphabet = new StringBuilder();
            StringBuilder number = new StringBuilder();
            StringBuilder specialCharacters = new StringBuilder();

            for (int i = 0; i < givenRawString.Length; i++)
            {
                if (Char.IsDigit(givenRawString[i])) //extract numbers
                    number.Append(givenRawString[i]);
                else if (givenRawString[i] >= 'A' && givenRawString[i] <= 'Z') //extract CAPS
                    capsAlphabet.Append(givenRawString[i]);
                else if (givenRawString[i] >= 'a' && givenRawString[i] <= 'z') //extract smalls
                    smallsAlphabet.Append(givenRawString[i]);
                else //otherwise special chars will store 
                    specialCharacters.Append(givenRawString[i]);
            }

            Console.WriteLine("Caps = " + capsAlphabet.ToString());
            Console.WriteLine("Smalls = " + smallsAlphabet.ToString());
            Console.WriteLine("Special Chars = " + specialCharacters.ToString());
            Console.WriteLine("Numbers = " + number.ToString());
        }
    }
}
