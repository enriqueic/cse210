class BreathingActivity : Activity
{

    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();

        int fullCycles = _duration / 10;
        int remainder = _duration % 10;

        for (int i = 0; i < fullCycles; i++)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.Write("Now breathe out...");
            ShowCountdown(6);
        }
        //Exceeding requirements
        if (remainder > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountdown(remainder);
        }

        DisplayEndingMessage();
    }

}