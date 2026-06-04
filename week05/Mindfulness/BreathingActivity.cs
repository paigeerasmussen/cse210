using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
     : base(
            "Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(5);

            Console.Write("\nNow breath out...");
            ShowCountDown(5);

            Console.WriteLine();
        }

        DisplayEndMessage();
    }
}