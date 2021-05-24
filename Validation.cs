using System;

namespace TeamSaturnProject
{
    public class Validation
    {
        public static int ValidateAllIntInput(string inputtedNumber)
        {
            int number;

            while (!int.TryParse(inputtedNumber, out number))
            {
                Console.WriteLine("Enter a Valid Number: ");
                inputtedNumber = Console.ReadLine();
            }
            return number;
        }
        public static string ValidateAllStringInput(string fileName)
        {
            while (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Enter a Name: ");
                fileName = Console.ReadLine();
            }
            return fileName;
        }

        public static string ValidateYearInput(string inputtedYear)
        {
            while (string.IsNullOrWhiteSpace(inputtedYear))
            {
                Console.WriteLine("Enter the Year: ");
                inputtedYear = Console.ReadLine();
            }
            return inputtedYear;
        }
    }
}