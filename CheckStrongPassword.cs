using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_4
{
    class CheckStrongPassword
    {
        public static void CheckPassword()
        {
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();

            if (IsStrongPassword(password))
            {
                Console.WriteLine("The password is strong");
            }
            else
            {
                Console.WriteLine("The password is weak. It must contain: " +
                    "\nAt least 1 uppercase letter" +
                    "\nAt least 1 lowercase letter" +
                    "\nAt least 1 digit" +
                    "\nAt least 1 special character");
            }


        }

        static bool IsStrongPassword(string password) {

            Regex pattern = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+[\]{};':""\\|,.<>\/?~`-]).{8,}$");

            return pattern.IsMatch(password);
        
        }
    }
}
