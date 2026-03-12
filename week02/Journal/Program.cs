using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");

        //#1-Random prompt from list. Save response and date as Entry: Date. 
        //#2-Display all journal entries.
        //#3-Prompt for a file name and save to list. 
        //#4-Prompt for a file name to disply all entries from that file. 
        //#5-Menu to choose from actions.✅ 
        //#6-At least 5 diffrent prompts in the list. 
        //Make sure interface looks like the video. 
        /*Menu oprtion need to be (1) write, (2) display, (3) load, (4) save, and (5) quit.✅*/

        /*Create a class for every major componet. Contain at least 2 classes in addition to Program class.
        Use member variables and methods appropiatly.✅*/

        //Remember to show creativity to get 100%.

        Entry testEntry = new Entry();

        testEntry._date = "10/30/2024";
        testEntry._promptText = "Do you dress up for Halloween?";
        testEntry._entryText = "Yes, I dressed as a bat last year.";
        testEntry.Display();


        int userInput = 0;

        while (userInput != 5)
        {

            Console.WriteLine("Please enter number coressponding to the menu option: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("New journal entry.");

            }
            else if (userInput == 2)
            {
                Console.WriteLine("Display all journal entries.");

            }
            else if (userInput == 3)
            {
                Console.WriteLine("Load journal from file.");
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Save journal to file.");
            }

            else if (userInput == 5)
            {
                Console.WriteLine("Quit the program.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }

}