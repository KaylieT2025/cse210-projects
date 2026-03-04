using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayResult();

        //Function to accept name, favorite number, squared favorite number, and display it all.
        static void DisplayResult()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);


        //Function to display welcome message.

            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the program!");
            }

        //Function to ask and return name as string.

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        //Function to ask and return favorie number as int.
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        //Function to accept favorite number and retun it squared as int.
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
                return squaredNumber;
            
        }

            Console.WriteLine($"{userName}, the square of your number is: {squaredNumber}");
        }
    }
}