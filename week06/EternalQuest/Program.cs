using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();

        Goal goal = new SimpleGoal("Test Goal", "This is a test goal.", "100");
        Console.WriteLine();
        Console.WriteLine(goal.GetStringRepresentation());
        Console.WriteLine();

        manager.DisplayPlayerInfo();
        Console.WriteLine();

        manager.CreateGoal();
        Console.WriteLine();
    }
}