using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class PrimeFactors
    {
        public static void PrimeFactory()
        {
            int a, b;
            Console.WriteLine("Wprowadź liczbę naturalną");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wybrana liczba to: {a}\n");

            for (b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;

                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Liczba {b} jej czynnikiem pierwszym {x} razy\n\r");
                    Console.ForegroundColor = ConsoleColor.White;
                }


        }
    }
}
