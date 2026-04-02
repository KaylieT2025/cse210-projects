using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Mark Yakton", "Math");
        Console.WriteLine();
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Section 9.2", "Problems 1-20", "Mark Yakton", "Math");
        Console.WriteLine();
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

    }
}