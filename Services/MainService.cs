using System;

namespace Herrera_A6.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IFileService _fileService;
    public MainService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Invoke()
    {
        string choice;
        do
        {
            Console.WriteLine("What media type would you like to display?");
            Console.WriteLine("\n1.) Movies\n2.) Shows\n3.) Videos\n4.) Exit\n");
            choice = Console.ReadLine();

            if (choice == "1")
                choice = "Movie";


            else if (choice == "2")
                choice = "Show";


            else if (choice == "3")
                choice = "Video";

            else if (choice == "4")
                break;
            else
                Console.WriteLine("Please enter a valid selection.\n");

            _fileService.Read(choice);
        }
        while (choice != "4");

    }
}
