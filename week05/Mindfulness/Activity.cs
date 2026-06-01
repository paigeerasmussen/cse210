using System;

class Activity
{
    // Provides activity name, description, and asks for duration in seconds. Then tells the user to begin and pause for several seconds
    // Ends with message saying good job, pause and then tell them the activity they have completed and the length of time, pause for several seconds before finishing
    // Show user animation whenever application pauses

    private string _name;
    private string _description;
    private string _duration;

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartMessage()
    {
        string startMessage = $"Welcome to the {_name} Activity\n\n{_description}\n\nHow long, in seconds, would you like for your session?";
    }

    public void DisplayEndMessage()
    {
        string endMessage = $"You have completed {_duration} seconds of the {_name} activity";
    }

    public void ShowSpinner(int seconds)
    {
        // finish
    }

    public void ShowCountDown(int seconds)
    {
        // finish
    }
}