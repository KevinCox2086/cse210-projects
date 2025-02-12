
public class Animations
{
    int counter;

    public Animations()
    {
        // Constructor
        counter = 0;
    }

    public void Turn(string loadingText)
    {
        // Display a spinner
       Console.SetCursorPosition(loadingText.Length, 0);
       // Set the cursor position to the beginning of the linE

        switch (counter % 4)
        {
            case 0: Console.WriteLine("/"); break;
            case 1: Console.WriteLine("-"); break;
            case 2: Console.WriteLine("\\"); break;
            case 3: Console.WriteLine("|"); break;
        }
    }

    // Display a sequenced matrix
    public void SequencedMatrix(int row, int column, int width, int height)
    {
        // Set the cursor position
        Console.SetCursorPosition(column, row);
        
        // Get the current spot
        int spot = counter % width;
        // Create a 2D array
        int[,] array = new int[width, height];
        // Loop through the array
        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                if (y == spot)
                {
                    Console.Write("[X]");
                    continue;
                }

                Console.Write("[ ]");
            }
            Console.WriteLine("");
        }
    }

    // Display a loading bar
    public void LoadingBar(string loadingTest, int row, int column)
    {
        // Set the cursor position
        Console.SetCursorPosition(column, row);
        // Create the loading text
        string loadingText = loadingTest + " [";
        // Create the loading text terminator
        string loadingTextTerminator = "                   ]";
        // Display the loading text
        Console.Write(loadingText + loadingTextTerminator);
        // Loop through the counter
        for (int i = 0; i < counter % 20; i++)
        {
            if (counter == 0)
            {
                Console.SetCursorPosition(column, row);
                Console.Write(loadingText + loadingTextTerminator);
            }
            
            Console.SetCursorPosition(loadingText.Length + i, row);
            // Display the loading bar
            Console.Write("*");
        }
    }

    public void Ready()
    {
        counter++;
        System.Threading.Thread.Sleep(3);
    }
}