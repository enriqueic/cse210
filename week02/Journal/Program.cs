using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        string userOption = "";
        Journal myJournal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userOption = Console.ReadLine();

            if (userOption == "1")
            {
                Prompts PromptsGenerator = new();
                String randomPrompt = PromptsGenerator.GetRandomPrompt();
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
                
                myJournal.AddEntry(userEntry);
            }

            if (userOption == "2")
            {
                myJournal.DisplayAll();
                Console.WriteLine("Successfully displayed");
            }

            if (userOption == "3")
            {
                myJournal.Load();
            }

            if (userOption == "4")
            {
                myJournal.Save();
            }
        }
        while (userOption != "5");
    }
}