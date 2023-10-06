using System;
using System.IO;

namespace Herrera_A6.Models
{
	public class Video : Media
	{
        public string Format { get; set; }
        public int Length { get; set; }
        public int Regions { get; set; }
		public Video() { }

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
                        Console.WriteLine($"Video ID: {items[0]}");
                        Console.WriteLine($"Title: {items[1]}");
                        Console.WriteLine($"Format: {items[2]}");
                        Console.WriteLine($"Length: {items[3]}");
                        Console.WriteLine($"Region(s):");
                        var regions = items[4].Split('|');
                        foreach (string region in regions)
                        {
                            Console.WriteLine($"\t   {region}");
                        }
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

