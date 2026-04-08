using System;
using System.Collections.Generic;

public class Reflecting : Activity
{

    private List<string> _questions = new List<string>();
    private List<string> _prompts = new List<string>();

    string _name = "Reflecting";


    public void ReflectionActivity()
    {
        Console.WriteLine();
        //Console.WriteLine("You picked reflecting.");
        DisplayStartingMessage(_name);
        Console.WriteLine("A prompt will be given to think about.");
        Console.WriteLine("Answer the questions to yourself to reflect on the prompt.");
        Console.WriteLine();

        //Prompt list.

        _prompts = new List<string>();
        _prompts.Add("Think of a time you stood up for someone.");
        _prompts.Add("Think of a time you did something really diffcult.");
        _prompts.Add("Think of a time you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //Questions list.

        _questions = new List<string>();
        _questions.Add("Why was this expirence meaningful?");
        _questions.Add("Have you ever done something like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time diffrent than other times when you were not as sucessful?");
        _questions.Add("What is your favorite thing about this exprince?");
        _questions.Add("What could you learn about yourself through this experience?");
        _questions.Add("How can you keep this exprience in mind in the future?");
    }

    public void Run()
    {
        //Console.WriteLine("Get Ready...");
        //ShowCountDown(5);

        Console.Write("Please enter at least 10 seconds. Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        int _duration = duration;

        Console.WriteLine("Get Ready...");
        ShowCountDown(5);
        Console.WriteLine();

        //Track time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();
            //Console.WriteLine();

            DisplayQuestion();
            Console.WriteLine();

        }

        Console.ForegroundColor = ConsoleColor.Green;
        DisplayEndingMessage(_name, _duration);
        Console.ResetColor();
        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {

        Random random = new Random();

        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        //Console.WriteLine(" Reflection Prompt ");
        //Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        //Console.WriteLine();
        Thread.Sleep(1000);
        ShowCountDown(5);

    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        ShowCountDown(5);
    }
}