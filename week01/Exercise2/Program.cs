using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Asking for users grade percentage.

        Console.Write("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();

        //Converting into string into int.

        int gradeIntoInt = int.Parse(gradePercentage);

        // Using if, else is, and else to get letter grade.

        if (gradeIntoInt >= 90)
        {
            Console.WriteLine("A");
        }
        else if (gradeIntoInt >= 80)
        {
            Console.WriteLine("B");
        }
        else if (gradeIntoInt >= 70)
        {
            Console.WriteLine("C");
        }
        else if (gradeIntoInt >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (gradeIntoInt >= 70)
        {
            Console.WriteLine("You passed! Go get that ice cream! You deserve it! WOO!");
        }
        else
        {
            Console.WriteLine("You did not pass. Go sit in the corner till you can do better.");
        }

    }
}



