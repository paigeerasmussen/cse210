using System;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>
        {
            "What was the best part of today, and why?",
            "What is something you handled well this week?",
            "What is one lesson life has been teaching you lately?",
            "When do you feel most like yourself?",
            "What is something you wish more people understood about you?",
            "List three small things you appreciated today.",
            "What fear has been holding you back?",
            "Describe your ideal day from beginning to end.",
            "What motivates you to keep going during hard times?",
            "What would your perfect weekend look like?"
        };

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}