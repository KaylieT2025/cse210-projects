using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");


        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("03/17/2023", 30, 3.0));
        activities.Add(new Cycling("03/17/2023", 45, 15.0));
        activities.Add(new Swimming("03/17/2023", 60, 20));

        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}