using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class FermatTest
    {
        public static int PowerModulo(int a, int b, int m)
        {
            int i;
            long result = 1;
            long x = a % m;

            for (i = 1; i <= b; i <<= 1)
            {
                x %= m;
                if ((b & i) != 0)
                {
                    result *= x;
                    result %= m;
                }
                x *= x;
            }

            return (int)result % m;
        }

        public static bool FermatPrimarityTest(int n, int k)
        {
            int w, i;
            Random rand = new Random();

            if (n < 4)
            {
                return true;
            }

            for (i = 0; i < k; i++)
            {
                w = (int)rand.Next(n - 2) + 2;
                if (PowerModulo(w, n - 1, n) != 1)
                {
                    return false;
                }
            }

            return true;
        }
        public static void CreateFermatTest()
        {
            int n, k;

            Console.WriteLine("Wpisz liczbę do sprawdzenia:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ilość sprawdzeń.");
            k = int.Parse(Console.ReadLine());

            if (FermatPrimarityTest(n, k))
            {
                Console.WriteLine("Liczba jest piersza.");
            }
            else
            {
                Console.WriteLine("Liczba jest złożona.");
            }
        }
    }
}
