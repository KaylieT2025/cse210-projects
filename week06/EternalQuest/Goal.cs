using System;

public class Goal : GoalManager
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {

        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
       
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} pts.)";
    }

    public virtual string GetStringRepresentation()
    {

        return "";
    }

    public string GetName()
    {

        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

}