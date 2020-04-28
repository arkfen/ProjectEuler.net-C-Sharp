using System.Collections.Generic;
using System.Linq;
using ProjectEuler.net_C_Sharp.Helpers;

namespace ProjectEuler.net_C_Sharp
{
    public class Problem4 : IProblem
    {
        List<int> palindromes = new List<int>();
        
        public string GetResult()
        {
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99 - 1; j--)
                {
                    int product = (i * j);
                    if (Lingo.CheckIfPalindrome(product.ToString()))
                    {
                        palindromes.Add(product);
                    }
                }
            }

            if(palindromes.Count() > 0)
            {
                palindromes.Sort();
                palindromes.Reverse();
                return palindromes.ElementAt(0).ToString();
            }
            else
            {
                return string.Empty;
            }
        }


    }
}
