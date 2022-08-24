using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD
{
    public class PrimeNumbers
    {
        //Find given number is prime or not
        public static void IsPrimeOrNot()
        {
            int i, m = 0, flag = 0;

            //input
            int n = 113;
            m = n / 2;
            for (i = 2; i <= m; i++) 
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a prime number");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine(n + " is a prime number");
        }

        //Print prime number between 100 to 200
        public static void DisplayPrimeNumbers()
        {
            bool isPrime = true;

            for (int i = 100; i <= 200; i++)
            {
                for (int j = 2; j <= 200; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.Write("\t" + i);

                isPrime = true;
            }
        }
    }
}
