using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine($"You have {_score} pts.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {
        ListGoalNames();

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Select accomplished goal: ");
        Console.WriteLine();
        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;
        _score += int.Parse(_goals[index].GetPoints());
        Console.WriteLine($"Goal complete! You hav earned {_goals[index].GetPoints()} pts.");


    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

}