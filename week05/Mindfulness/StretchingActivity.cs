using System;
using System.Security.Cryptography;

class StrechingActivity : Activity
{
    private List<string> _stretches = ["Neck stretch: gently tilt your head side to side.",
    "Shoulder rolls: roll shoulders forward and backward.",
    "Cross-body arm stretch: pull one arm across your chest.",
    "Overhead stretch: reach up high and lengthen your body.",
    "Chest opener: clasp hands behind your back and open chest.",
    "Forward fold: slowly reach toward your toes.",
    "Quad stretch: pull one foot toward your glutes.",
    "Hamstring stretch: extend one leg and lean forward slightly.",
    "Calf stretch: step back and press heel into the ground.",
    "Childs pose: sit back and stretch arms forward on the floor."];
    public StrechingActivity()
     : base(
            "Stretching Activity",
            "This activity will help you loosen your body and improve flexibility by gently guiding you through simple stretches. Move slowly, stay present, and focus on how your muscles feel as you stretch and release tension.")
    {

    }

    public void Run()
    {
        DisplayStartMessage();

        DisplayStretches();

        DisplayEndMessage();
    }

    public string GetRandomQuestion()
    {
        int index = RandomNumberGenerator.GetInt32(_stretches.Count);
        string stretch = _stretches[index];
        return stretch;
    }

    public void DisplayStretches()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(GetRandomQuestion());
            ShowSpinner(10);
            Console.WriteLine();
        }
    }
}