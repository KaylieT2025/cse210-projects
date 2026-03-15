using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    /*public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _entryText = entryText;
        _promptText = promptText;

    }*/
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt; {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
} 


