using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.IO;

namespace Herrera_A6.Models
{
    public class Movie : Media
    {
        public string Genres { get; set; }

        public Movie() { }

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
                        Console.WriteLine($"Movie ID: {items[0]}");
                        Console.WriteLine($"Movie Title (Release Year): {items[1]}");
                        Console.WriteLine("Genre(s):");
                        var genres = items[2].Split('|');
                        foreach (string genre in genres)
                        {
                            Console.WriteLine($"\t{genre}");
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