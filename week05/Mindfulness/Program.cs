using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");
        //For my creative aspect I made the countdown in bretahing a diffrent color for each diget.
        //I also kept the coloring as consitent as I could through out the program messages.
        //I used a count down timmer and a spinner throughout.

        int userEntry = -1;
        Breathing breathing = new Breathing();
        Reflecting reflecting = new Reflecting();
        Listing listing = new Listing();

        while (userEntry != 0)
        {
            Console.WriteLine("Enter the number corresponing with the action you would like to take: ");
            Console.WriteLine("0. Quit.");
            Console.WriteLine("1. Listing.");
            Console.WriteLine("2. Reflection.");
            Console.WriteLine("3. Breathing.");
            userEntry = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userEntry == 1)
            {
                //Console.WriteLine("Listing activity.");
                listing.Run();

            }
            else if (userEntry == 2)
            {
                reflecting.ReflectionActivity();
                Thread.Sleep(1000);
                reflecting.Run();
                //reflecting.DisplayPrompt();
                //reflecting.DisplayQuestion();
            }
            else if (userEntry == 3)
            {

                //Breathing breathing = new Breathing();
                breathing.BreathingActivity();
                breathing.Run();
                Thread.Sleep(1000);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Program has ended. Thank you for your participation.");
                Console.ResetColor();
            }
        }
    }
}