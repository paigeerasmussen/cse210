using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Net;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        // Initializes an empty list of goals and sets the player's score to be 0
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Main function of the class, runs menu loop
        string menuOption = "";

        while (menuOption != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuOption = Console.ReadLine();

            if (menuOption == "1")
            {
                CreateGoal();
            }

            else if (menuOption == "2")
            {
                Console.WriteLine("The goals are:");
                ListGoalNames();
                ListGoalDetails();
            }

            else if (menuOption == "3")
            {
                SaveGoals();
            }

            else if (menuOption == "4")
            {
                LoadGoals();
            }

            else if (menuOption == "5")
            {
                RecordEvent();
            }

            else if (menuOption == "6")
            {
                Console.WriteLine("Have a great day!");
            }

            else
            {
                Console.WriteLine("This is not a valid selection. Please try again");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string bonusTimesString = Console.ReadLine();
            int bonusTimes = int.Parse(bonusTimesString);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusAmountString = Console.ReadLine();
            int bonusAmount = int.Parse(bonusAmountString);

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, bonusTimes, bonusAmount));
        }
    }
    public void ListGoalNames()
    {
        // Lists name of each goal
        // for (int i = 0; i < _goals.Count; i++)
        // {
        //     Console.WriteLine($"{i + 1}. {_goals[i].ListGoalDetails()}");
        // }
    }

    public void ListGoalDetails()
    {
        // Lists details including weather or not goal is completed of each goal, add currently completed: x/x to show how many times out of the bonus it has been completed for checklist goals
        // string status = "[ ]";
        // if (goal.IsComplete())
        // {
        //     string status = "[X]";
        // }

    }

    public void RecordEvent()
    {
        // Asks user which goal they have done and records it by calling RecordEvent() on that goal
    }

    public void SaveGoals()
    {
        // Saves list of goals to a file
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        List<string> lines = new List<string>();

        lines.Add(_score.ToString());
        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }
        File.WriteAllLines(fileName, lines);
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _score += int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
        }
    }
}