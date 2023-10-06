using System;
using System.IO;

namespace Herrera_A6.Models
{
    public class Show : Media
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string Writers { get; set; }

        public Show() { }

        public override void Display(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);

                //Remove first line (headers) from output.
                sr.ReadLine();

                while (sr.EndOfStream != true)
                {
                    var line = sr.ReadLine();
                    var items = line.Split(',');
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"Show ID: {items[0]}");
                        Console.WriteLine($"Title: {items[1]}");
                        Console.WriteLine($"Season: {items[2]}");
                        Console.WriteLine($"Episode: {items[3]}");
                        Console.WriteLine($"Writer: {items[4]}");
                        Console.WriteLine();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}