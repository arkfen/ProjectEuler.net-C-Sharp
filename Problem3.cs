using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.net_C_Sharp
{
    class Problem3
    {
        private const long _Number = 600851475143;



        public long GetResult()
        {
            int pairFactor = 2;
            long factor;
            do
            {
                factor = GetFactor(pairFactor);
                pairFactor++;
                if (factor == 0)
                {
                    continue;
                }
                else
                {
                    if (isPrime(factor))
                    {
                        break;
                    }

                }
            }
            while (factor != 1);
            return factor;
        }




        private bool isPrime(long number)
        {
            bool isPrime = true;
            for (long i = 3; i < number; i += 2)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }




        private long GetFactor(int pairFactor)
        {
            if (_Number % pairFactor == 0)
            {
                return _Number / pairFactor;
            }
            else
            {
                return 0;
            }
        }

    }
}
