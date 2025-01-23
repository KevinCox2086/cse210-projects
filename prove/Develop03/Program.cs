using System;

//As a stretch challenge, I tried to randomly select from only those words that are not already hidden.
class Program
{
    static void Main(string[] args)
    {
        // Initialize a new scripture reference object.
        Reference scriptureReference = new Reference("3 Nephi", "25", "5-6");
        // Initialize a new scripture object.
        Scripture scripture = new Scripture(scriptureReference, "Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the Lord; And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.");
        // Initialize a new scripture memorizer object.
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        // Initialize a string to hold the user's input.
        string userInput = "";

        // Loop through the memorization process until the user types "quit" or there are no words left to memorize.
        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            // Clear the console.
            Console.Clear();
            // Display the scripture reference and the scripture memorizer.
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            // Display a blank line for readability.
            Console.WriteLine();
            // Prompt the user to press enter to remove random words.
            Console.WriteLine("Press enter to remove random words.");
            // Prompt the user to type "quit" to exit the program.
            Console.WriteLine("Type 'quit' to exit the program.");
            // Read the user's input.
            userInput = Console.ReadLine();
            // Remove words from the scripture memorizer.
            scriptureMemorizer.removeWordsFromText();
        }
        // Display the final state of the scripture text (one word remaining).
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
        Console.WriteLine();
        // Display a congratulatory message to the user.
        Console.WriteLine("Great job, keep up the good work!");
    }
}