using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            int num = randomGenerator.Next(1, 101); // 1 to 100 inclusive
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

            while (guess != num)
            {
                Console.Write("What is your guess? ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Please enter a valid number: ");
                }

                guessCount++;

                if (guess > num)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play the game again? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
