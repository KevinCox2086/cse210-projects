using System;

class Reference
{
    // Declare private fields to hold the book, chapter, and verse.
    private string _book, _chapter, _verse;

    // Create a constructor that accepts the book, chapter, and verse as arguments.
    public Reference (string book, string chapter, string verse)
    {
        _book = book;
        _chapter  = chapter;
        _verse = verse;
    }

    // Create a method to return the reference as a string.
    public string toString()
    {
        return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }
}