using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine("\nPrompt: " + prompt);
        Console.WriteLine("Start listing your items:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    items.Add(input);
                }
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndActivity();
    }
}
