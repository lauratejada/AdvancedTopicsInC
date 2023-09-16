using Microsoft.VisualBasic;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string fileName = "theMachineStops.txt";

            // We set the current directory to my Documents path directory
            // https://learn.microsoft.com/en-us/dotnet/standard/io/file-path-formats
            Directory.SetCurrentDirectory(@"C:\Users\Laura\Documents\");

            // Get the full path of the file
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            // Console.WriteLine(filePath);
            // Console.WriteLine(Directory.GetCurrentDirectory());

            if (File.Exists(filePath))
            {
                // Read the contents of the file
                string fileContent = File.ReadAllText(filePath);

                // Replace every period with the word "STOP"
                string modifiedContent = fileContent.Replace(".", "STOP");

                // Create a new file named "TelegramCopy" in the same directory
                string newFilePath = Path.Combine(Directory.GetCurrentDirectory(), "TelegramCopy.txt");

                // Creates a new file and write the modified content to the new file
                File.WriteAllText(newFilePath, modifiedContent);

                Console.WriteLine("File processing complete. Modified content saved as 'TelegramCopy.txt'.");
            }
            else
            {
                Console.WriteLine("The specified file does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
