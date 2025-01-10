using System;

class Program
{
    static void Main(string[] args)
    {
       // Part 1: Determine and print letter grade
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else
        {
            Console.WriteLine("Your grade is: F");
        }

        // Part 2: Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, you'll get it next time!");
        }

        // Part 3: Determine letter grade and store it in a variable
        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Part 4: Determine the sign (+ or -)
        string sign = "";
        int lastDigit = gradePercentage % 10; 

        if (lastDigit >= 7 && letter != "A" && letter != "F") // Exclude A+ and F+
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F") // Exclude F-
        {
            sign = "-";
        }

        // Part 5: Handle A+ and F+ exceptions
        if (letter == "A" && sign == "+") 
        {
            sign = ""; // No A+
        }

        // Part 6: Handle F+ and F- exceptions
        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        Console.WriteLine("Your grade is: " + letter + sign);
    }
}