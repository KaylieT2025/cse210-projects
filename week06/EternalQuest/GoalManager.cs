using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private int _level = 0;
    private int _streak = 0;
    private DateTime _lastCompletedEvent = DateTime.MinValue;

    public GoalManager()
    {

    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Enter option: ");
            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
            }

        }
    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine();
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"Score: {_score} pts.");
        Console.WriteLine($"Streak: 🔥 {_streak} 🔥");
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

        if (_goals.Count == 0)
        {
            Console.WriteLine("No available goals.");
            return;
        }

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

            /*if (newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("Goal created.");
            }*/
        }
        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created.");
            Console.WriteLine($"GOAL COUNT: {_goals.Count}");
        }
    }

    public void RecordEvent()
    {

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
            
        }

        Console.WriteLine("Current goals: ");
        ListGoalNames();

        Console.WriteLine("Select accomplished goal: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int index = choice - 1;
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        UpdateStreak();
        LevelUp();
        Console.WriteLine($"Goal complete! You hav earned {pointsEarned} pts.");
        Console.WriteLine($"You have a total: {_score} pts.");


    }

    public void SaveGoals()
    {

        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {

            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(_streak);
            writer.WriteLine(_lastCompletedEvent);

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
        _level = int.Parse(lines[1]);
        _streak = int.Parse(lines[2]);
        _lastCompletedEvent = DateTime.Parse(lines[3]);

        for (int i = 4; i < lines.Length; i++) 
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0].Trim();
            string[] details = parts[1].Split("|");

            Goal goal = null;

            if (goalType == "Simple Goal")
            {
                string name = details[0];
                string description = details[1];
                string points = details[2];
                bool isComplete = bool.Parse(details[3]);
                //goal = new SimpleGoal(parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), bool.Parse(parts[4].Trim()));
                goal = new SimpleGoal(name, description, points);

                if (isComplete)
                {
                    goal.RecordEvent();
                }
                //_goals.Add(goal);
            }
            else if (goalType == "Eternal Goal")
            {

                string name = details[0];
                string description = details[1];
                string points = details[2];

                //goal = new Eternal(parts[1].Trim(), parts[2].Trim(), parts[3].Trim());
                goal = new Eternal(name, description, points);
                //_goals.Add(goal);
            }
            else if (goalType == "Checklist Goal")
            {
                string name = details[0];
                string description = details[1];
                string points = details[2];
                int target = int.Parse(details[3]);
                int amountCompleted = int.Parse(details[4]);
                int bonus = int.Parse(details[5]);

                //goal = new ChecklistGoal(parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), int.Parse(parts[4].Trim()), int.Parse(parts[5].Trim()));
                goal = new ChecklistGoal(name, description, points, target, bonus);
                //goal.SetAmountComplete(amountCompleted);
                ((ChecklistGoal)goal).SetAmountComplete(amountCompleted);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
           // _goals.Add(goal);
        }

        Console.WriteLine($"Goals loaded from {filename}.");
        ListGoalDetails();
    }

    private void LevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine();
            Console.WriteLine($"LEVEL UP!");
            Console.WriteLine($"You are now level {_level}!");
        }
    }

    private void UpdateStreak()
    {

        DateTime today = DateTime.Today;

        if (_lastCompletedEvent == DateTime.MinValue)
        {
            _streak = 1;
        }
        else if (_lastCompletedEvent == today.AddDays(-1))
        {
            _streak++;
        }
        else if (_lastCompletedEvent != today)
        {
            _streak = 1;
        }

        _lastCompletedEvent = today;
        Console.WriteLine($"You current streak is 🔥 {_streak} 🔥 day(s).");
    }
    

}