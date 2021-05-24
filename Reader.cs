using System;
using System.IO;

namespace TeamSaturnProject
{
    public class Reader : IReadable
    {
        public void Read(string path)
        {
            try
            {
                string content = "";

                //This checks if the file exists
                if (File.Exists(path))
                {
                    //This allows file content to be read
                    content = File.ReadAllText(path);
                }

                Console.WriteLine("FIFA WORLD CUP WINNERS");
                Console.WriteLine();

                Console.WriteLine(($"{"Country",-15}   {"Wins",-4}  {"Years",-15}"));
                //This prints the File content on the Console
                Console.WriteLine(content);

                //This prevent the app from closing
                Console.ReadKey();
            }

            //catches any Exception
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
