using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class EulerFunction
    {
        static int nwd(int a, int b)
        {
            if (a == 0)
                return b;
            return nwd(b % a, a);
        }

        static int phi(int n)
        {
            int result = 1;
            for (int i = 2; i < n; i++)
                if (nwd(i, n) == 1)
                    result++;
            return result;
        }


        public static void UseEulerFunction()
        {
            int n;
            Console.WriteLine("\rWprowadź liczbę:");
            n = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nWartość funkcji Eulera dla liczby " + n + " = " + phi(n));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
