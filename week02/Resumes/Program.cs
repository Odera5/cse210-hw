using System;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {


        Job job1 = new Job();      
        job1._jobTitle = "Software Engineer";  
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2026;
       //job1.JobInfo();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Backend Developer";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume _myResume = new Resume();
        _myResume._name = "Kingsley";
        
        _myResume._jobs.Add(job1);
        _myResume._jobs.Add(job2);

        //Console.WriteLine(job2.JobInfo());
       // Console.WriteLine(job1.JobInfo());


       // Console.WriteLine(_myResume._jobs[0]._jobTitle);

      _myResume.Display();





    }
}