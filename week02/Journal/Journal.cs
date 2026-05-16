using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        string prompt = newPrompt.GetRandomPrompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
         lines.Add($"{entry._date}, {entry._promptText}, {entry._entryText}");
        }

        File.WriteAllLines($"{fileName}", lines);
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines($"{fileName}");

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            Entry entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0];

            _entries.Add(entry);
        }
    }
}