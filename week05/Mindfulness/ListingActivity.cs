using System;
using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    // Show a random prompt
    // Give countdown of several seconds then prompt to keep listing items
    // Continue until specified time has been reached, display number of items entered and conclude

    private int _count;
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month", "Who are some of your personal heroes?"];
    public ListingActivity(string name, string description, string duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
        _count = count;
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        // finish
    }

    public void Run()
    {
        // finish
    }

    public void GetRandomPrompt()
    {
        // finish
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
        // finish and return user list instead
    }

}