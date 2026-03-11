using System;
using System.Buffers;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Softwear Engineer";
        job1._startYear = 2019;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2026;
        job2._endYear = 2036;

        //Displays company name.
        //Console.WriteLine(job1._companyName);
        //Console.WriteLine(job2._companyName);

        //Displays job title (Company) start date-end date.
        //job1.Display();
        //job2.Display();

        Resume resume = new Resume();

        resume._name = "Penny";

        resume._jobList.Add(job1);
        resume._jobList.Add(job2);

        //Displays just the job title.
        //Console.WriteLine(resume._jobList[0]._jobTitle);
        //Console.WriteLine(resume._jobList[1]._jobTitle);

        //Final display all information.
        resume.Display();
    }
}