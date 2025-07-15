// Enrique Ibarra for BYU-PW
// Exceeding requirements: made it so that it notes the user they have run out of prompts so they don't repeat.
// Made it so that prompts are also loaded from a .txt file and the user can add to them and view them from the menu.

using System;
using System.Runtime.CompilerServices;

class Program
{

    public static Journal myJournal = new();
    public static Prompts myPrompts = new();
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        string userOption = "";
        string userOption2 = "";
        using (StreamWriter w = File.AppendText("journal.txt"))
        using (StreamWriter w2 = File.AppendText("prompts.txt"))
        myPrompts.Load();
        
        do
            {
                Console.WriteLine("Please select one of the following choice:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Add prompt");
                Console.WriteLine("6. Quit");

                userOption = Console.ReadLine();
                Console.WriteLine();

                if (userOption == "1")
                {
                    String randomPrompt = myPrompts.GetRandomPrompt();
                    if (randomPrompt != "")
                    {
                        Console.WriteLine(randomPrompt);

                        String entryText = Console.ReadLine();
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        Entry userEntry = new()
                        {
                            _date = dateText,
                            _prompt = randomPrompt,
                            _text = entryText
                        };
                        Program.myJournal.AddEntry(userEntry);
                    }
                    Console.WriteLine("");
                }

                if (userOption == "2")
                {
                    myJournal.DisplayAll();
                    Console.WriteLine("Successfully displayed");
                    Console.WriteLine("");
                }

                if (userOption == "3")
                {
                    myJournal.Load();
                }

                if (userOption == "4")
                {
                    myJournal.Save();
                    Console.WriteLine();
                }

                if (userOption == "5")
                {
                    do
                    {
                        Console.WriteLine("Current prompts:");
                        myPrompts.DisplayAll();
                        Console.WriteLine("");
                        Console.WriteLine("Add prompt? y/n");
                        userOption2 = Console.ReadLine();
                        if (userOption2 == "y")
                        {
                            Console.Write("New prompt: ");
                            string prompt = Console.ReadLine();
                            myPrompts.AddPrompts(prompt);
                            myPrompts.Save();
                        }
                    }
                    while (userOption2 != "n");
                }
            }
            while (userOption != "6");
    }

}