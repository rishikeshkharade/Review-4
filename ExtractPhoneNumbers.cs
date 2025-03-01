using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractPhoneNumbers
{
    public static void ExtractNumbers()
    {
        string input = "Here are some phone numbers: 1234567890, 555-123-4567, and 9876543210.";
        List<string> phoneNumbers = ExtractedNumbers(input);

        Console.WriteLine("Extracted Phone Numbers:");
        foreach (var number in phoneNumbers)
        {
            Console.WriteLine(number);
        }
    }

    static List<string> ExtractedNumbers(string input)
    {
       
        string pattern = @"(?<!\d)(\d{10})(?!\d)";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        List<string> phoneNumbers = new List<string>();
        foreach (Match match in matches)
        {
            phoneNumbers.Add(match.Value);
        }

        return phoneNumbers;
    }
}