using System;

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

    }

    public void ShowCountDown(int seconds)
    {

        /* Console.Write("Please enter at least 10 seconds. Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        int _duration = duration;

        //Track time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);



        Console.ForegroundColor = ConsoleColor.Green;
        DisplayEndingMessage(_name, _duration);
        Console.ResetColor();
        Console.WriteLine();*/
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