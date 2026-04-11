using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Shapes Project.");
        //Shape shape = new Shape();
        List<Shape> shape = new List<Shape>();
        shape.Add(new Square("Blue", 5));
        shape.Add(new Rectangle("Yellow", 5, 2));
        shape.Add(new Circle("Orange", 5));


        Console.WriteLine();
        Console.WriteLine($"Area: {shape[0].GetArea()}  Color: {shape[0].GetColor()}");
        Console.WriteLine();
        Console.WriteLine($"Area: {shape[1].GetArea()}  Color: {shape[1].GetColor()}");
        Console.WriteLine();
        Console.WriteLine($"Area: {shape[2].GetArea()}  Color: {shape[2].GetColor()}");
        Console.WriteLine();



    }
}