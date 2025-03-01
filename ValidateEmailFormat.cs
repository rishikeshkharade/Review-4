using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_4
{
    class ValidateEmailFormat
    {
        public static void EmailValidate()
        {
            Console.WriteLine("Enter an email address to validate: ");
            string email = Console.ReadLine();

            if (IsEmailValid(email))
            {
                Console.Write("The email address is valid.");
            }
            else
            {
                Console.Write("The email address is invalid");
            }


        }

        static bool IsEmailValid(string email)
        {
            Regex regex = new Regex(@"^[a-z0-9._-]+@[a-z]+\.[a-z]{2,}$");
            return regex.IsMatch(email);
        }
    }
}
