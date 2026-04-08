using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{

    private string _name;
    private string _desription;
    private int _duratation;

    public Activity()
    {

    }

    public void DisplayStartingMessage(string name)
    {
        _name = name;
        Console.WriteLine($"You have chosen: {_name}.");

    }

    public void DisplayEndingMessage(string name, int duration)
    {
        _name = name;
        _duratation = duration;

        Console.WriteLine("Good job! You have completed the activity!");
        Console.WriteLine($"You have completed {_duratation} seconds of {_name}.");
    }

    public void ShowSpinner(int seconds)
    {

        string[] spinner = { "|", "/", "|", "\\" };
        DateTime startTime = DateTime.Now;
        int i = 0;
        while((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            //Color changer.
            switch (i)
            {
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); //Erase.
            //Console.Write(" "); //Replace 
            Console.ResetColor();
        }
    }
}