using System;

public class Eternal : Goal
{

    public Eternal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return int.Parse(GetPoints());
    }

    public override bool IsComplete()
    {

        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {GetDetailsString()}";
    }
}