using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class EuclidExtendedAlgorithm
    {
        private long a, b;

        public static void UseEuclid()
        {
            Console.WriteLine("Wprowadź liczbę a:");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź liczbę b:");
            long b = long.Parse(Console.ReadLine());

            EuclidExtendedAlgorithm ea = new EuclidExtendedAlgorithm(a, b);
            EuclidExtendedAlgorithmSolution result = ea.Algorithm();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("d = {0} \nx = {1} \ny = {2}", result.D, result.X, result.Y);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public EuclidExtendedAlgorithm(long a, long b)
        {
            this.a = a;
            this.b = b;
        }

        public EuclidExtendedAlgorithmSolution Algorithm()
        {
            long x0 = 1, xn = 1;
            long y0 = 0, yn = 0;
            long x1 = 0;
            long y1 = 1;
            long q;
            long r = a % b;

            while (r > 0)
            {
                q = a / b;
                xn = x0 - q * x1;
                yn = y0 - q * y1;

                x0 = x1;
                y0 = y1;
                x1 = xn;
                y1 = yn;
                a = b;
                b = r;
                r = a % b;
            }

            return new EuclidExtendedAlgorithmSolution(xn, yn, b);
        }




    }
}

