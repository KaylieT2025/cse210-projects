using System;
using System.Runtime.CompilerServices;

public class Breathing : Activity
{
    string _name = "Breathing";

    public void BreathingActivity()
    {
        DisplayStartingMessage(_name);
        Console.WriteLine();
        //Console.WriteLine("You picked breathing.");
        Console.WriteLine("This activity will instruct you on taking deep breaths. Follow the count.");
        Console.WriteLine();
    }

    public void Run()
    {

        Console.Write("Please enter at least 10 seconds. Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        int _duration = duration;

        //Track time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("Get Ready...");
        ShowCountDown(5);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Breathe in.");
            ShowCountDown(5);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Breathe out.");
            ShowCountDown(5);
            Console.WriteLine();
            Console.ResetColor();
        }

        ShowSpinner(5);
        Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("Good job! Activity complete!");
        //Console.WriteLine($"You have completed {duration} seconds of the breathing activity.");
        DisplayEndingMessage(_name, _duration);
        Console.ResetColor();
        Console.WriteLine();

    }
}