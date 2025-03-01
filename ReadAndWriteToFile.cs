using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_4
{
    class ReadAndWriteToFile
    {
        public static void Data()
        {
            string path = "D:/Access Meditech BridgeLabz/Review 4/ReadWriteFile.txt";

            if (File.Exists(path))
                Console.WriteLine("File Exists");
            else
            {
                Console.WriteLine("File Not Found, Creating one");
                File.Create(path);
            }

            string[] Customers =
            {
                "Sanket Pote",
                "Amol Gosavi",
                "Tanmay Lohakare"
            };

            File.WriteAllLines(path, Customers);

            foreach (string cust in File.ReadAllLines(path))
            {
                Console.WriteLine($"Customer: {cust}");
            }
        }
    }
}
     