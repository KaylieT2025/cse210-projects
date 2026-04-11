using System;

public class ChecklistGoal : Goal
{

    public int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetStringDetails()
    {

    }

    public string GetStringRepestantion()
    {

    }
}