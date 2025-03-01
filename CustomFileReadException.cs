using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Review_4
{
    class CustomFileReadException
    {
        public static void FileReadException()
        {
            
            string filePath = "D:/Access Meditech BridgeLabz/Review 4/FileReadException.txt";
            //File.Create(filePath);

            long maxSize = 1024 * 1024;

            try
            {
                CheckFileSize(filePath, maxSize);
                Console.WriteLine("File size is within the acceptable limit.");
            }
            catch (FileSizeTooLargeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }   

        static void CheckFileSize(string filePath, long maxSize)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("This file doesn't Exist.", filePath);
            }

            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Length > maxSize)
            {
                throw new FileSizeTooLargeException($"The file size is too large");
            }
        }
    }

    class FileSizeTooLargeException : Exception
    {
        public FileSizeTooLargeException() { } 
           public FileSizeTooLargeException(string message) : base(message) { }
        }
    }
