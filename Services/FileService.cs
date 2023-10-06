using System;
using Microsoft.Extensions.Logging;
using Herrera_A6.Models;

namespace Herrera_A6.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class FileService : IFileService
{

    public void Read(string mediaType)
    {
        Media medium;
        string filename;

        if (mediaType == "Movie")
        {
            medium = new Movie();
            filename = "movies.csv";
        }

        else if (mediaType == "Show")
        {
            medium = new Show();
            filename = "shows.csv";
        }
        else if (mediaType == "Video")
        {
            medium = new Video();
            filename = "videos.csv";
        }
        else
        {
            Console.WriteLine("Error: media type not deteced");
            return;
        }

        medium.Display(filename);
    }

}