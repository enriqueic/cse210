class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _count = 0;

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area") { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index); // Exceeding requirements
        return prompt;
    }
    private List<string> GetListFromUser()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" ---{GetRandomPrompt()}--- ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        List<string> responses = new List<string>();
        do
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }
        while (DateTime.Now < futureTime);
        return responses;
    }
    public void Run()
    {
        DisplayStartingMessage();

        _count = GetListFromUser().Count;

        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}