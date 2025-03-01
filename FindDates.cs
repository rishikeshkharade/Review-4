using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_4
{
    class FindDates
    {
        public static void FindingDates()
        {
            string input = "Dates: 12/05/2023, 2023-05-12, and 01/01/2024.";
            List<string> dates = ExtractDates(input);

            Console.WriteLine("Extracted Dates:");
            foreach (var date in dates)
            {
                Console.WriteLine(date);
            }
        }

        static List<string> ExtractDates(string input)
        {
            
            string pattern = @"(?:(\d{2}/\d{2}/\d{4})|(\d{4}-\d{2}-\d{2}))";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            List<string> dates = new List<string>();
            foreach (Match match in matches)
            {
                
                dates.Add(match.Value);
            }

            return dates;
        }
    }
}