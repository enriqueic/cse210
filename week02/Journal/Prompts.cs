using System;

public class Prompts()
{
    public List<String> _prompts = new List<String>();

    public String GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I had today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What is a valuable lesson I learned today?");
        _prompts.Add("What is something I did today that will be worth remembering?");
        _prompts.Add("Describe in detail something I did today");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, _prompts.Count);
        return _prompts[randomNumber - 1];
    }
}