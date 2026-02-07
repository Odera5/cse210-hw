using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        string prompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine("\nPrompt: " + prompt);
        PauseAnimation(3);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine("\n" + question);
            PauseAnimation(3);
        }

        EndActivity();
    }
}
