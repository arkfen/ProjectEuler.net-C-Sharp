using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.net_C_Sharp
{
    class Problem1 : IProblem
    {
        /// <summary>
        /// Using same loop to itterate every multiple of 3 and 5 to get the summ of all of them... and subsctucting exrtra multiple of 15 (because it is a product of 3 and 5)
        /// </summary>
        /// <returns>Summ of all multiples of 3 and 5 up to 1000</returns>
        public string GetResult()
        {
            int sum = 0;
            int current3 = 3;
            int current5 = 5;
            int current15 = 15;
            int limit = 1000;
            while (current3 < limit || current5 < limit)
            {
                // Adding multiples of 5 until last of them reaches the limit (because it does this earlier than any multiple of 3 does)
                sum += (current5 >= limit ? 0 : current5) + current3;
                // Subsctructing extra multiples of 15
                sum -= current15 >= limit ? 0 : current15;
                current3 += 3;
                current5 += 5;
                current15 += 15;
            }
            return sum.ToString();
        }
    }
}


