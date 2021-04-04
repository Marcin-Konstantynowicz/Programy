using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class PrimesGenerator
    {
        public static void CreatePrimesGenerator()
        {
            int firstRangeNumber = 1999900000;
            int lastRangeNumber = 2000099990;
            int prime, num, i;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nPoczątkowa liczba zakresu to: ");
            Console.Write(Convert.ToInt32(firstRangeNumber));
            Console.Write("\nOstatnia liczba zakresu to: ");
            Console.Write(Convert.ToInt32(lastRangeNumber));
            Console.ForegroundColor = ConsoleColor.White;


            Console.Write("\nLiczby pierwsze pomiędzy {0} i {1} to: \n", firstRangeNumber, lastRangeNumber);

            for (prime = firstRangeNumber; prime <= lastRangeNumber; prime++)
            {
                num = 0;

                for (i = 2; i <= prime / 2; i++)
                {
                    if (prime % i == 0)
                    {
                        num++;
                        break;
                    }
                }

                if (num == 0 && prime != 1)
                    Console.Write("{0} ", prime);
            }
            Console.Write("\n");
        }

    }
}
