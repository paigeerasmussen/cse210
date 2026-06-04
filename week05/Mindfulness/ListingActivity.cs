using System;
using System.Security.Cryptography;
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month", "Who are some of your personal heroes?"];
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("List as many responses you can to the following prompt:\n");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        List<string> responses = GetListFromUser();
        _count = responses.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndMessage();
    }

    public void GetRandomPrompt()
    {
        int index = RandomNumberGenerator.GetInt32(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"--- {prompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            responses.Add(input);
        }

        return responses;
    }
}