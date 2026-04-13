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

        Console.WriteLine("Select goal type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();
        Console.WriteLine("Enter Choice (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter points: ");
        string points = Console.ReadLine();
        Console.WriteLine();

        Goal newGoal = null;

        if (choice == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (choice == 2)
        {
            newGoal = new Eternal(name, description, points);
        }
        else if (choice == 3)
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            Console.WriteLine();

            newGoal = new ChecklistGoal(name, description, points, target, bonus);

            if (newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("Goal created.");
            }
        }
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

        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {

            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}.");
    }

    public void LoadGoals()
    {

        Console.Write("Enter file name: ");
        string filename = Console.ReadLine();

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0].Trim();

            Goal goal = null;
            if (goalType == "Simple Goal")
            {
                goal = new SimpleGoal(parts[1].Trim(), parts[2].Trim(), parts[3].Trim());
            }
            else if (goalType == "Eternal Goal")
            {
                goal = new Eternal(parts[1].Trim(), parts[2].Trim(), parts[3].Trim());
            }
            else if (goalType == "Checklist Goal")
            {
                goal = new ChecklistGoal(parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), int.Parse(parts[4].Trim()), int.Parse(parts[5].Trim()));
            }
            _goals.Add(goal);
        }

        Console.WriteLine($"Goals loaded from {filename}.");
    }

}