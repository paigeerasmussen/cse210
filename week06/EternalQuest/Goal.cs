using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    // do whatever is necessary for each kind of goal and return point value associated with recording the event including bonuses


    public abstract bool IsComplete();
    // return if the goal is completed, different for each type of goal

    public virtual string GetDetailsString()
    {
        // returns details of a goal that could be shown ina list including checkbox, short name, and description. For the Checklist goal it should be overriden to show number of times the goal has been accomplished
        return "details";
    }

    public abstract string GetStringRepresentation();
    // Provide all details of the goal in an easy to save and load way
}