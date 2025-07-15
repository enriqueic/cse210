using System;

public class Prompts()
{
    public List<String> _prompts = new List<String>();

    public String GetRandomPrompt()
    {

        if (_prompts.Count() != 0)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, _prompts.Count);
            string randomPrompt = _prompts[randomNumber - 1];
            _prompts.RemoveAt(randomNumber - 1);

            return randomPrompt;
        }
        else
        {
            Console.WriteLine("Out of prompts");
            return "";
        }
    }

    public void DisplayAll()
    {
        foreach (String prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public void AddPrompts(String prompt)
    {
        _prompts.Add(prompt);
    }

    public void Load()
    {
        _prompts.Clear();
        string myfile = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(myfile);

        foreach (string line in lines)
        {
            if (line != "")
            {
                AddPrompts(line);
            }
        }
    }

    public void Save()
    {
        string myfile = "prompts.txt";
        using (StreamWriter writer = new(myfile))
        {
            foreach (String prompt in _prompts)
            {
                writer.WriteLine(prompt);
            }
        }
    }
}