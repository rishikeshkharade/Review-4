using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_4
{
    class CheckPalindromeUsingLamda
    {
        public static void PalindromeUsingLamda()
        {
            Func<string, bool> isPalindrome = str =>
            {
                string normalized = str.Replace(" ", "").ToLower();

                char[] charArray = normalized.ToCharArray();
                Array.Reverse(charArray);
                return normalized == new string(charArray);
            };

            string[] testStrings = { "Hello", "Racecar", "12321", "it" };

            foreach(var testString in testStrings)
            {
                Console.WriteLine($"Is {testString} a palindrome? {isPalindrome(testString)}");
            }
            
        }
    }
}
