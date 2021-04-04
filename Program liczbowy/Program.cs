using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp9
{
    class Program
    {
        private static readonly ConsoleKey[] validMenuKeys = new ConsoleKey[]
        {
            ConsoleKey.D1,
            ConsoleKey.D2,
            ConsoleKey.D3,
            ConsoleKey.D4,
            ConsoleKey.D5,
            ConsoleKey.D6,
            ConsoleKey.D7,
            ConsoleKey.D8,
            ConsoleKey.D9,
            ConsoleKey.Escape,
        };
        static void Main(string[] args)
        {
            do
            {
                Program.DisplayMenu();
            }
            while (Program.TakeAction(Program.ValidateKey()));
        }

        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|---------Program liczbowy---------|");
            Console.WriteLine("|---Marcin Konstantynowicz 24557---|");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|Jaki jest twoj wybor? (od 1 do 6):|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Generowanie wszystkich liczb pierwszych.");
            Console.WriteLine("2. Sprawdzenie pierwszości testem Fermana.");
            Console.WriteLine("3. Wylicza oraz prezentuje czynniki pierwsze tej liczby.");
            Console.WriteLine("4. Funkcja Eurela dla wprowadzonej liczby.");
            Console.WriteLine("5. Odwrotność modulo wprowadzonych liczb rozszerzonym algorytmem Euklidesa.");
            Console.WriteLine("6. System szyfrowania danych RSA.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ESC. Zakończ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r----------------------------------");
        }

        private static ConsoleKey ValidateKey()
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();

                if (Array.IndexOf(Program.validMenuKeys, keyInfo.Key) != -1)
                {
                    return keyInfo.Key;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nProgram nie posiada takiej opcji, wybierz ponownie!");
                    Console.ForegroundColor = ConsoleColor.White;

                }

            } while (true);
        }

        private static bool TakeAction(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    return false;
                case ConsoleKey.D1:
                    Console.WriteLine("------Generowanie wszystkich liczb pierwszych------\r");
                    Program.CreateNewPrimesGenerator();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("------Sprawdzenie pierwszości testem Fermana------\r");
                    Program.CreateNewFermatTest();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("------Czynniki pierwsze wprowadzonej liczby------\r");
                    Program.CreateNewPrimeFactors();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("------Działanie funkcji Eulera na wprowadzonej liczbie------\r");
                    Program.CreateNewEulerFunction();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("------Rozszerzony algorytm Euklidesa na wprowadzonych liczbach------\r");
                    Program.CreateNewEuclidesAlgorithm();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("------System szyfrowania danych RSA------\r");
                    Program.CreateNewRSAGenerator();
                    break;
            }
            return true;
        }
        private static void CreateNewPrimesGenerator()
        {
            PrimesGenerator.CreatePrimesGenerator();
        }

        private static void CreateNewFermatTest()
        {
            FermatTest.CreateFermatTest();
        }

        private static void CreateNewPrimeFactors()
        {
            PrimeFactors.PrimeFactory();
        }

        private static void CreateNewEulerFunction()
        {
            EulerFunction.UseEulerFunction();
        }

        private static void CreateNewEuclidesAlgorithm()
        {
            EuclidExtendedAlgorithm.UseEuclid();
        }
        private static void CreateNewRSAGenerator()
        {
            RSAGenerator.CreateNewRSAGenerator();
        }
    }
}
