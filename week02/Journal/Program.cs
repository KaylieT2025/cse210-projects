using System;
using System.Security.Cryptography.X509Certificates;

partial class Program
{
    static void Main(string[] args)
    {
        //Remember to show creativity to get 100%.

        int userInput = 0;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (userInput != 5)
        {

            Console.WriteLine("Please enter number coressponding to the menu option: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userInput == 1)
            {
                Console.WriteLine("New journal entry.");
                //Prompt and response.
                string promt = promptGenerator.GetPrompt();
                Console.WriteLine(promt);
                Console.Write(">");
                string response = Console.ReadLine();
                //Save entry.
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = promt;
                entry._entryText = response;
                //Add to journal.
                journal.AddEntry(entry);
                Console.WriteLine("Entry has been added.");
                Console.WriteLine();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Display all journal entries.");
                //Displaying entries.
                journal.DisplayAll();

            }
            else if (userInput == 3)
            {
                Console.WriteLine("Load journal from file. Enter file name: ");
                //Loading from file.
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                journal.DisplayAll();
                Console.WriteLine("Journal has been fully loaded.");
                Console.WriteLine();
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Save journal to file. Enter file name: ");
                //Saving to file.
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Journal has been saved.");
                Console.WriteLine();
                
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