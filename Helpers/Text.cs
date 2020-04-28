using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.net_C_Sharp.Helpers
{
    public class Lingo
    {
        public static bool CheckIfPalindrome(string word)
        {
            string originalWord = word;
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);
            string reversedWord = string.Concat(letters);
            if (originalWord == reversedWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
