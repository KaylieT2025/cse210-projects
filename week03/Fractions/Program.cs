using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.WriteLine();
        Fractions fractions = new Fractions();
        Console.WriteLine();
        Fractions fractions1 = new Fractions(6);
        Console.WriteLine();
        Fractions fractions2 = new Fractions(6, 8);
        Console.WriteLine();
        Console.WriteLine(fractions.GetTop());
        Console.WriteLine();
        Console.WriteLine(fractions.GetBottom());
        Console.WriteLine();
        fractions.SetTop(5);
        fractions.SetBottom(9);
        Console.WriteLine();
        Console.WriteLine(fractions.GetFractionsString());
        Console.WriteLine();
        Console.WriteLine(fractions.GetDecimalValue());
        Console.WriteLine("Displaying information.");
        Console.WriteLine();

    }
}