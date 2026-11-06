
using System;
using System.Collections.Generic;
using System.IO;

// The program uses a separate FileManager class to isolate file operations
// and a PromptGenerator class to manage random journal questions.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        FileManager fileManager = new FileManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to your Personal Journal , your place to reflect!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");

                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response);

                    journal.AddEntry(entry);

                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string saveFilename = Console.ReadLine();

                    fileManager.Save(saveFilename, journal);
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string loadFilename = Console.ReadLine();

                    fileManager.Load(loadFilename, journal);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye! Keep writing.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}