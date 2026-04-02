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

    }
}