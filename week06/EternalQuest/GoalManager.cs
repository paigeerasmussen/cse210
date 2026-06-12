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
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
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

        if (goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string goalPoints = Console.ReadLine();

            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string goalPoints = Console.ReadLine();

            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string goalPoints = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string bonusTimesString = Console.ReadLine();
            int bonusTimes = int.Parse(bonusTimesString);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusAmountString = Console.ReadLine();
            int bonusAmount = int.Parse(bonusAmountString);

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, bonusTimes, bonusAmount));
        }
        else
        {
            Console.WriteLine("This is not a valid option. Please try again");
        }
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetNames()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();

            string goalString = _goals[index].GetStringRepresentation();
            string[] parts = goalString.Split(',');
            int points = int.Parse(parts[3]);

            if (_goals[index] is ChecklistGoal cg)
            {
                if (cg.IsComplete())
                {
                    points += int.Parse(parts[4]);
                }
            }

            Console.WriteLine($"Congratulations! You have earned {points} points!");
            _score += points;

        }
        // Get checklist bonus to work
    }

    public void SaveGoals()
    {
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
            string[] parts = lines[i].Split(',');
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(parts[1], parts[2], parts[3]);
                if (bool.Parse(parts[4]))
                    g.RecordEvent();
                _goals.Add(g);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal g = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(g);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                int completed = int.Parse(parts[6]);

                for (int j = 0; j < completed; j++)
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
        }
    }
}