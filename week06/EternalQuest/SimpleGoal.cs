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
        if (!_isComplete)
        {
            _isComplete = true;
            return int.Parse(GetPoints());
        }
        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()}: {GetDescription()} ({GetPoints()} pts.)";
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
}