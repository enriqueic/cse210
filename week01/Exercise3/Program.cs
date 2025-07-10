using System;

class Program
{
    static void Main(string[] args)
    {
        string userOption = "";
        int acum = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        do
        {
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                acum += 1;
            }
            while (guess != magicNumber);

            Console.WriteLine($"It took you {acum} guesses");
            Console.Write("Would you like to play again?: ");
            userOption = Console.ReadLine();
            acum = 0;
            magicNumber = randomGenerator.Next(1, 101);
            Console.WriteLine("");
        }
        while (userOption != "no"); // stretch                    
    }
}