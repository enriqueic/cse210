class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write($"How long, in seconds, how you like your session? ");
    }

    public void DisplayEndingMessage()
    {
        ShowSpinner(1);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowSpinner(1);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "—", "\\" };
        for (int i = 0; i < seconds; i++)
        {
            foreach (string frame in spinner)
            {
                Console.Write(frame);
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000);
            if (i >= 10)
                Console.Write("\b\b \b\b");
            else
            Console.Write("\b \b");
        }
    }
}