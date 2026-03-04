using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random magicGenerator = new Random();
        int magicNumber = magicGenerator.Next(1, 11);

        Console.Write("Please enter your guess: ");
        int userGuess = int.Parse(Console.ReadLine());

        while (userGuess != magicNumber)
        {
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
            Console.Write("Please enter new guess: ");
            userGuess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("That is the correct number.");

    }
}