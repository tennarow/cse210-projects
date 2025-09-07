using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);


        Console.Write("What is your guess? ");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);

        if (guess < magicNumber)
        {
            Console.WriteLine("Too low!");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("You guessed it! What are the odds?!?");
        }
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }
        }
    }
}