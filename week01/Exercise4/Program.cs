using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        //List to add users numbers to a list.

        List<int> userNumbers = new List<int>();
        Console.WriteLine("Please enter a number. Enter 0 to finish.");

        while (true)
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine("Data Entery Ended.");
                int sum = userNumbers.Sum();
                Console.WriteLine($"The sum is: {sum}");
                double average = userNumbers.Average();
                Console.WriteLine($"The average is: {average}");
                int maxium = userNumbers.Max();
                Console.WriteLine($"The biggest number enter is: {maxium}");
                break;
            }
            userNumbers.Add(userNumber);
            
        }
    }
}
