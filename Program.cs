using System;
using System.IO;

namespace TeamSaturnProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderFilePath = "";

            Console.WriteLine("Enter Folder Name You wanted to Create:");
            string nameOfFolder = Console.ReadLine();
            //Validates Folder Name to ensure empty values are not entered
            string validatedNameOfFolder = Validation.ValidateAllStringInput(nameOfFolder);

            // string folderPath = @"C:\" + nameOfFolder;
            string folderPath = @"C:\" + validatedNameOfFolder;

            // call a Method
            var returnedFolderPath = EnsureFolderOrFileExists.CreateFolder(folderPath);

            // Create a file name for the file you want to create.
            Console.WriteLine("Enter File Name You wanted to Create:");
            string fileName = Console.ReadLine();
            //Validates File Name to ensure empty values are not entered
            string validatedFileName = Validation.ValidateAllStringInput(fileName);

            string fileNameConvertToTxtFile = validatedFileName + ".txt";

            // Use Combine again to add the file name to the path.
            folderFilePath = Path.Combine(returnedFolderPath, fileNameConvertToTxtFile);

            var returnedFilePath = EnsureFolderOrFileExists.CreateFile(folderFilePath);
            Console.WriteLine("Path to my file: {0}\n", returnedFilePath);

            IWritable writer = new Writer();
            writer.Write(returnedFilePath);

            IReadable reader = new Reader();
            reader.Read(returnedFilePath);
        }
    }
}
