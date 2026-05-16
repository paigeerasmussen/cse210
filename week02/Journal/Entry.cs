using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("MM-dd-yyyy");
        _promptText = prompt;
        _entryText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}