using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Mindfulness Program ---");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            if (choice == "4") break;

            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    var breathe = new BreathingActivity(
                        "Breathing Activity",
                        "This activity will help you relax by walking you through breathing in and out slowly.",
                        duration);
                    breathe.Run();
                    break;

                case "2":
                    var reflect = new ReflectionActivity(
                        "Reflection Activity",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience.",
                        duration);
                    reflect.Run();
                    break;

                case "3":
                    var list = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by listing as many as you can.",
                        duration);
                    list.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
    }
}
