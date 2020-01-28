using System;
using System.IO;
using MySerializer.JsonTools;

namespace MySerializer
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.Write("File path: ");
                string path = Console.ReadLine();
                using StreamReader sr = File.OpenText(path);
                string s = sr.ReadToEnd();
                Console.WriteLine("File: ");
                Console.WriteLine(s);
                Console.WriteLine("Converting to JSON:");
                
                MyConverter converter = new ConvertCSVtoJSON();
                string json = converter.Convert(s);
                Console.WriteLine(json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }            
        }
    }
}
