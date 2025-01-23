using System;

class Scripture
{
    // Declare private fields to hold the scripture text and reference.
    private string _scriptureText;
    private Reference _scriptureReference;

    // Create a constructor that accepts the scripture reference and text as arguments.
    public Scripture (Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        _scriptureText = scriptureText;
    }

    // Create a method to return the scripture text as a string.
    public string toString()
    {
        return string.Format("{0}", _scriptureText);
    }
}