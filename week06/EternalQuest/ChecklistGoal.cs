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

    public override int RecordEvent()
    {
        if (_amountComplete < _target)
        {
            _amountComplete++;
        }
    }

    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Progress: {_amountComplete}/{_target} - Bonus: {_bonus} points";
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {GetDetailsString()} - Completed: {_amountComplete}/{_target}";
    }
}