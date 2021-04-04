using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class KeysForRSAGenerator
    {
        public ArrayList buffer;
        public void generatePrimes(int toGenerate)
        {
            ArrayList primes = new ArrayList();
            primes.Add(2);
            primes.Add(3);
            while (primes.Count < toGenerate)
            {
                int nextPrime = (int)(primes[primes.Count - 1]) + 2;
                while (true)
                {
                    bool isPrime = true;
                    foreach (int n in primes)
                    {
                        if (nextPrime % n == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        break;
                    }
                    else
                    {
                        nextPrime += 2;
                    }
                }
                primes.Add(nextPrime);
            }
            this.buffer = primes;
        }
        public void KeysGenerator()
        {

            /*ArrayList generatePrimes(int toGenerate)
            {
                ArrayList primes = new ArrayList();
                while (primes.Count < toGenerate)
                {
                    int nextPrime = (int)(primes[primes.Count - 1]) + 2;
                    while (true)
                    {
                        bool isPrime = true;
                        foreach (int n in primes)
                        {
                            if (nextPrime % n == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            break;
                        }
                        else
                        {
                            nextPrime += 2;
                        }
                    }
                    primes.Add(nextPrime);
                }
                return primes;              
            }*/
            this.generatePrimes(5);

            int p = this.buffer.IndexOf(1);
            Console.WriteLine(p);

        }

        private static void GetPrimes()
        {

        }


    }
}
