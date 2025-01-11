using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System;

public class Entry
{
    // Properties for journal entry
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

     // Parameterless constructor for XmlSerializer
    public Entry() {}
    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }
}

public class Journal
{
    // List of journal entries
    public List<Entry> Entries { get; set; } = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(string prompt, string response)
    {
        Entries.Add(new Entry(prompt, response));
    }

    public void SaveToFile(string filename)
    {
        // Serialize the list of entries to an XML file
        using (var writer = new StreamWriter(filename))
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            serializer.Serialize(writer, Entries);
        }
    }

    public void LoadFromFile(string filename)
    {
        // Deserialize the XML file to a list of entries
        using (var reader = new StreamReader(filename))
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            Entries = (List<Entry>)serializer.Deserialize(reader);
        }
    }
}

public class Program
{
    // Create a journal and a list of prompts
    private static Journal journal = new Journal();
    private static List<string> prompts = new List<string>()
    {
        "Where did I go today?",
        "How did I help someone today?",
        "What scripture did I read today?",
        "What fun did I have today?",
        "What do I want to accomplish tomorrow?",
        "What am I grateful for today?",
        "What challenges did I face today?",
        "What did I learn today?"
    };

    // Main method to display the menu and handle user input
    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Helper methods to perform the menu actions
    private static void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();
        journal.AddEntry(prompt, response);
        Console.WriteLine("Entry added successfully!");
    }

    // Display all journal entries
    private static void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        if (journal.Entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in journal.Entries)
            {
                Console.WriteLine($"\nDate: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
            }
        }
    }

    // Save the journal to a file
    private static void SaveJournalToFile()
    {
        Console.Write("\nEnter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load the journal from a file
    private static void LoadJournalFromFile()
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine($"Journal loaded from {filename}");
    }
}