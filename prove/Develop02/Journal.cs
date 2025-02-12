using System;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public void NewEntry()
    {
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.GetResponse();
        _entries.Add(userEntry);
    }

    // Display all entries in the journal
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            Console.WriteLine();
        }
    }
    // Load entries from a file
    public void LoadEntries(string filename)
    {
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            // Read the file and display it line by line.
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine();
            }
        }
        // Load entries from a file
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            // Read the file and display it line by line.
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
    // Save entries to a file
    public void SaveEntries(string filename)
    {   
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".csv"))
            {
                // Write the entries to the file
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date:{entry._date},{entry._prompt},{entry._response}");
                    outputFile.WriteLine($"Prompt:{entry._prompt}");
                    outputFile.WriteLine($"{entry._response}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}