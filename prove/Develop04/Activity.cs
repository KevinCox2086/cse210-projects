using System;

public class Activity
{
    // Attributes
    private string _activityName;
    private int _activityTime;
    private string _message = "You may begin in...";

    // Constructors
    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }
    public void GetActivityName()
    {
        // Display the activity name
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
    }
    public void SetActivityName(string activityName)
    {
        // Set the activity name
        _activityName = activityName;
    }
    public int GetActivityTime()
    {
        // Get the activity time
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        // Get the user input
        int userSeconds = Int32.Parse(Console.ReadLine());
        // Set the activity time
        _activityTime = userSeconds;
        // Return the activity time
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }

    // Methods
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        // Display the activity ready message
        spinner.ShowSpinnerReady();
    }

    public void GetDone()
    {
        // Display the activity done message
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have completed another {_activityTime} seconds of the {_activityName} Activity!");
        spinner.ShowSpinner();
    }
     public void CountDown(int time)
    {
        // Start the countdown
        Console.WriteLine();  //insert blank line to start
        for (int i = time; i > 0; i--)
        {
            // Display the message
            Console.Write($"{_message}{i}");
            // Wait for 1 second
            Thread.Sleep(1000);
            // Overwrite the line
            string blank = new string('\b', (_message.Length + 5));
            // Clear the line  
            Console.Write(blank);
        }
        // Display the last message
        Console.WriteLine($"Go:                                  ");  
    }


}