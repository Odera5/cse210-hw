using System;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready...");
        PauseAnimation(3);
    }

    protected void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        PauseAnimation(3);
    }

    protected void PauseAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public abstract void Run();
}
