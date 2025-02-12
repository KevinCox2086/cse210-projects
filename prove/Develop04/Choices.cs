using System;

public class Choices
{
    // Attributes 
    private string _menu = $@"
Menu Options
===========================================
Please select one of the following options:
1. Start breathing activity
2. Start reflecting activity
3. Start listing activity
4. Quit
===========================================
Select an option from the menu:  ";

    public string _userInput;
    private int _userChoice = 0;

    // Methods
    public int UserChoice()
    // Method to display choices to user
    {
        // Clear the console
        Console.Clear();
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;
        // Try to parse the user input
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        // Catch any format exceptions
        catch (FormatException)
        {
            _userChoice = 0;
        }
        // Catch any other exceptions
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        // Return the user choice
        return _userChoice;
    }



}


