using System;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2016;
        job1._jobTitle = "Software Engineer";

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Web developer";
        job2._startYear = 2014;
        job2._endYear = 2025;



        Resume jobResume = new Resume();
        jobResume._jobList.Add(job1);
        jobResume._jobList.Add(job2);
        Console.Write("What is your name? ");
        // string name = Console.ReadLine();
        jobResume._personName = Console.ReadLine();
        jobResume.DisplayResume();
       



        



    }
}