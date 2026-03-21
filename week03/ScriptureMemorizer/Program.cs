using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Creative and Excceding Reqirments.
        //I added a method to Scriptures.cs to color the underscores red as they appear in the program. 
        //I also made sure the program quit if you type in Quit or quit.

        //Scrpture.
        Refrence refrence = new Refrence("Alma", 34, 10);
        string text = "For it is expedient that there should be a great and last sacrifice; yea, not a sacrifice of man, neither of beast, neither of any manner of fowl; for it shall not be a human sacrifice; but it must be an infinite and eternal sacrifice.";
        Scripture scriptures = new Scripture(refrence, text);

        while (true)
        {
            //This will clear the console.
            Console.Clear();
            scriptures.Display();

            if (scriptures.IsCompletlyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words hidden. Program ending.");
                Console.WriteLine();
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or type quit to end program.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Quit has been entered. Program ended.");
                Console.WriteLine();
                break;
            }

            scriptures.HideRandomWords(3);
        }



       


    }
}