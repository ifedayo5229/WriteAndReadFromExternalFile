using System;
using System.IO;

namespace TeamSaturnProject
{
    public class Writer : IWritable
    {
        public void Write(string path)
        {
            try
            {
                string content = "";

                // string dataFile = @"C:\WorldCupWinners.txt";
                System.Console.WriteLine("How many Countries are you Adding?");
                string numberOfCountry = Console.ReadLine();
                //checks and handles user error, if input is number or letter
                int validatedNumberOfCountry = Validation.ValidateAllIntInput(numberOfCountry);

                //loops through the number of countries to be added. so to add multiple countries
                for (int i = 1; i <= validatedNumberOfCountry; i++)
                {
                    string numberOfYears = "";

                    Console.WriteLine($"Name of Number {i} Country: ");
                    string countryName = Console.ReadLine();
                    string validatedCountryName = Validation.ValidateAllStringInput(countryName);

                    Console.WriteLine("Number of World Cups Won: ");
                    string numberOfCup = Console.ReadLine();
                    int ValidatedNumberOfCup = Validation.ValidateAllIntInput(numberOfCup);

                    for (int j = 1; j <= ValidatedNumberOfCup; j++)
                    {
                        Console.WriteLine($"Year Won the Number {j} Cup: ");
                        string year = Console.ReadLine();
                        string validatedYear = Validation.ValidateYearInput(year);

                        numberOfYears += validatedYear + " ";
                    }

                    content = ($"{validatedCountryName,-15}   {ValidatedNumberOfCup,-4}   {numberOfYears,-15}");

                    //This checks if the file exists, if doesn't it creates the file
                    if (File.Exists(path))
                    {
                        //---> This allows the texts to be wrtten in an external file 
                        //---> without overwriting the texts in the file initially.
                        //---> The AppendAllText method takes in two arguments, the file that we want write to nd the content we want to write to the file
                        // ---> The Environment.NewLine allows a text to be written on the next line in the external file 
                    
                        File.AppendAllText($"{path}", content + Environment.NewLine);
                    }
                }
                Console.WriteLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
