using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System;

public class Entry
{
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
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entries.Add(new Entry(prompt, response));
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            serializer.Serialize(writer, Entries);
        }
    }

    public void LoadFromFile(string filename)
    {
        using (var reader = new StreamReader(filename))
        {
            var serializer = new XmlSerializer(typeof(List<Entry>));
            Entries = (List<Entry>)serializer.Deserialize(reader);
        }
    }
}

public class Program
{
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

    private static void SaveJournalToFile()
    {
        Console.Write("\nEnter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine($"Journal saved to {filename}");
    }

    private static void LoadJournalFromFile()
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine($"Journal loaded from {filename}");
    }
}