// Enrique Ibarra for BYU-PW
// Exceeding requirements: the randomizer takes into account words that have already been hidden.
// The program also hides words based on user difficulty level input.

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureList =
        [
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
        ];

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("You will be shown a series of scriptures. Try to memorize while we hide some words");
        Console.Write("Press Enter the difficulty level (1 = easy, 2 = medium, 3 = hard): ");
        int difficultyLevel = Console.ReadLine() switch
        {
            "1" => 1,
            "2" => 2, 
            "3" => 3, 
            _ => 2 // Default to easy if input is invalid
        };

        foreach (Scripture scripture in scriptureList)
        {
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Scripture:");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("");
                Console.WriteLine("Press Enter to hide some words...");
                Console.ReadLine();
                scripture.HideRandomWords(difficultyLevel);
            }
        }
    }
}