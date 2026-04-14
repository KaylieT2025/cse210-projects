using System;

public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_amountComplete < _target)
        {
            _amountComplete++;
            int points = int.Parse(GetPoints());

            if (_amountComplete == _target)
            {
                return points + _bonus;
            }
            return points;
        }
        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {GetDetailsString()} - Completed: {_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {base.GetDetailsString()}";
    }
}