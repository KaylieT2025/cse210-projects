using System;

public class ChecklistGoal : Goal
{

    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        _amountComplete++;
    }

    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Progress: {_amountComplete}/{_target} - Bonsus: {_bonus} points";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {GetDetailsString()} - Completed: {_amountComplete}/{_target}";
    }
}