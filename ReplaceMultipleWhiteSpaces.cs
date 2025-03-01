using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_4
{
    class ReplaceMultipleWhiteSpaces
    {
        public static void ReplaceWhiteSpaces()
        {
            string input = "This is     a string   with  multiple    spaces";
            string result = SingleSpace(input);

            Console.WriteLine($"Input String: {input}");
            Console.WriteLine($"Modified String: {result}");
        }

        static string SingleSpace(string input)
        {
            string pattern = @"\s+";
            return Regex.Replace(input, pattern, " ");
        }
    }
}
