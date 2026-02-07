using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public override void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int maxStars = 10; // visual bar length

        while (DateTime.Now < endTime)
        {
            // Breathe In
            Console.Write("Breathe in: ");
            for (int i = 1; i <= maxStars; i++)
            {
                Console.Write("*");
                Thread.Sleep(300);
            }
            Console.WriteLine();
            PauseAnimation(1);

            // Breathe Out
            Console.Write("Breathe out:");
            for (int i = maxStars; i >= 1; i--)
            {
                Console.Write("\b \b");
                Thread.Sleep(300);
            }
            Console.WriteLine();
            PauseAnimation(1);
        }

        EndActivity();
    }
}
