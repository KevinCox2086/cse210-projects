using System;
using System.Diagnostics;

public class Spinner
{
    // Attributes 
    int counter;


    // Methods
    public void Stopwatch()
    {
        // Create a new stopwatch
        Stopwatch timer = new Stopwatch();
        // Start the stopwatch
        timer.Start();
        while (timer.Elapsed.TotalSeconds < 10)
        {
            Console.Write("+");

            Thread.Sleep(500);
            // Erase the last character
            Console.Write("\b \b"); 
            // Replace it with the - character
            Console.Write("-"); 
        }
        // Stop the stopwatch
        timer.Stop();

    }

    private void ConsoleSpinner()
    {
        counter = 0;
    }
    public void Turn()
    {
        counter++;
        // Set the cursor position to the beginning of the line
        switch (counter % 4)
        {
            case 0: Console.Write("=>"); break;
            case 1: Console.Write("==>"); break;
            case 2: Console.Write("===>"); break;
            case 3: Console.Write("====>"); break;
        }
        // Set the cursor position to the beginning of the line
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

    public void ShowSimplePercentage()
    {
        // Display a simple percentage
        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"\rGet Ready... {i}%   ");
            Thread.Sleep(50);
        }
        // Clear the line
        Console.Write("\rGet Ready...      ");
    }

    public void ShowSpinner()
    {
        // Display a spinner
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            // Set the cursor position to the beginning of the line
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(100);
        }
    }

    public void ShowSpinnerReady()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            // Display a spinner
            switch (counter % 4)
            {
                case 0: Console.Write("Get ready... /"); break;
                case 1: Console.Write("Get ready... -"); break;
                case 2: Console.Write("Get ready... \\"); break;
                case 3: Console.Write("Get ready... |"); break;
            }
            // Set the cursor position to the beginning of the line
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);
            counter++;
            Thread.Sleep(75);
        }
    }
    public void ShowSpinnerDone()
    {
        // Display a spinner
        Console.WriteLine();
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("Well done!! /"); break;
                case 1: Console.Write("Well done!! -"); break;
                case 2: Console.Write("Well done!! \\"); break;
                case 3: Console.Write("Well done!! |"); break;
            }
            // Set the cursor position to the beginning of the line
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop);
            counter++;
            Thread.Sleep(75);
        }
    }




}