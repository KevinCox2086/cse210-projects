using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "What are some of your favorite things to do?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What are some of your favorite memories?",
    "What are some of your favorite things about yourself?",
    
    };
    private List<string> _userList = new List<string>();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


    // Constructors
    // Methods
    public ListingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
    private string GetRandomPrompt()
    {
        // Get a random prompt
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    public void ReturnPrompt(int seconds)
    {
        //insert blank line to start
        Console.WriteLine();
        // Get a random prompt
        var question = GetRandomPrompt();
        // Display the prompt
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        // Start the timer
        CountDown(8);
        Timer(seconds);
    }
    public void Timer(int seconds)
    {
        Stopwatch timer = new Stopwatch();
        // Start the timer
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write("> ");
            _userList.Add(Console.ReadLine());
        }
        // Stop the timer
        timer.Stop();
        int listLength = _userList.Count;
        // Display the number of items listed
        Console.WriteLine($"\nYou listed {listLength} items!");
    }





}