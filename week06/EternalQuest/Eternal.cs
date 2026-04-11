using System;

public class Eternal : Goal
{

    public Eternal(string name, string description, string points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {

        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {GetDetailsString()}";
    }
}