using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalinfromic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(LongestPalindromeSubseq("ccc"));
            Console.WriteLine("{0}", LongestPalindrome("jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopwprsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjryjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzlzqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhoscjgpiel"));
            Console.ReadLine();
        }
        //Source of this algorythm: https://www.geeksforgeeks.org/longest-palindromic-subsequence-dp-12/

        //Function GetPalindromeString

        private static string LongestPalindrome(string s)
        {
            int length = s.Length;
            if (s.Length < 2 || s == null)
            {
                return s;
            }
            Boolean[,] isPalindrome = new Boolean[length, length];
            int left = 0;
            int right = 0;
            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Boolean isInnerWordPalindrome = isPalindrome[i + 1, j - 1] || j - i <= 2;
                    if (s.ElementAt(i) == s.ElementAt(j) && isInnerWordPalindrome)
                    {
                        isPalindrome[i, j] = true;
                        if (j - i > right - left)
                        {
                            left = i;
                            right = j;
                        }
                    }
                }
            }
            return JavaStyleSubstring(s, left, right + 1);
        }
        private static string JavaStyleSubstring(string s, int beginIndex,
      int endIndex)
        {
            // simulates Java substring function
            int len = endIndex - beginIndex;
            return s.Substring(beginIndex, len);
        }
    }
}