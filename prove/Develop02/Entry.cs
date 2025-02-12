using System;

public class Entry 
{
    public string _date;
    public string _prompt;
    public string _response;

    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What was the most beautiful thing I saw today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most important thing I learned today?",
        "What was the most important thing I accomplished today?",
        "What was the most important conversation I had today?",
        };

        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }
}