using System;

public class BreathingActivity : Activity
{
    // Attributes 
    private string _message1 = "Breathe in...";
    private string _message2 = "Now breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // Constructors
    // Methods
    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        // Display the description
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        // Start the breathing activity
        Console.WriteLine();  
        int secondsTimer = 0;
        // Loop through the seconds
        while (secondsTimer < seconds)
        {
            Console.WriteLine();
            // Loop through the messages  
            for (int i = 4; i > 0; i--)
            {
                // Display the message
                Console.Write($"{_message1}{i}");
                // Wait for 1 second
                Thread.Sleep(1000);
                // Overwrite the line
                string blank = new string('\b', (_message1.Length + 2));  
                Console.Write(blank);
                // Increment the timer
                secondsTimer += 1;
            }
            // Display the last message
            Console.WriteLine($"{_message1}  ");  
            for (int i = 5; i > 0; i--)
            {
                // Display the message
                Console.Write($"{_message2}{i}");
                // Wait for 1 second
                Thread.Sleep(1000);
                // Overwrite the line
                string blank = new string('\b', (_message2.Length + 2));  
                Console.Write(blank);
                // Increment the timer
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message2}  ");  // last prompt
        }
    }
}