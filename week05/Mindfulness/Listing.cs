using System;
using System.Collections.Generic;

public class Listing : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>();
    string _name = "Listing";

    public void ListingActivity()
    {
        _prompts = new List<string>();
        _prompts.Add("Who are you the people you appreciate?");
        _prompts.Add("What are personal strengths you have?");
        _prompts.Add("Who are the people you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heros?");
    }

    public void Run()
    {

        ListingActivity();

        DisplayStartingMessage(_name);
        Console.WriteLine("This activity will help you reflect on the good things in your life.");
        Console.WriteLine("Having you list as many things as you can in a certain area.");
        Console.WriteLine("You will get a prompt to think about and then you will put as many answers as possible for that topic.");
        Console.WriteLine();
        Console.Write("Please enter at least 10 seconds. Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        int _duration = duration;

        Console.WriteLine("Get Ready...");
        ShowCountDown(5);
        Console.WriteLine();

        //Track time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string prompt = GetRandomPrompt();
        _count = 0;
        Console.WriteLine(prompt);
        Console.Write("> ");
        Console.ResetColor();


        while (DateTime.Now < endTime)
        {
            //GetRandomPrompt();
            //Console.WriteLine(GetRandomPrompt());
            Console.ReadLine();
            _count++;
        }

        ShowSpinner(5);
        Console.ForegroundColor = ConsoleColor.Green;
        DisplayEndingMessage(_name, _duration);
        Console.WriteLine($"You have written {_count} entries.");
        Console.ResetColor();
        Console.WriteLine();




    }

    public string GetRandomPrompt()
    {

        //ListingActivity();

        Random random = new Random();

        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}