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
        //#5-Menu to choose from actions. 
        //#6-At least 5 diffrent prompts in the list. 
        //Make sure interface looks like the video.

        /*Create a class for every major componet. Contain at least 2 classes in addition to Program class.
        Use member variables and methods appropiatly.✅*/

        //Remember to show creativity to get 100%.

        Entry testEntry = new Entry();

        testEntry._date = "10/30/2024";
        testEntry._promptText = "Do you dress up for Halloween?";
        testEntry._entryText = "Yes, I dressed as a bat last year.";
        testEntry.Display();

        

    }

    

}