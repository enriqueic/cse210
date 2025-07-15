using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = [];
    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        string myfile = "./journal.txt";
        using (StreamWriter writer = new(myfile))
        {
            foreach (Entry userEntry in _entries)
            {
                writer.WriteLine($"Date: {userEntry._date} || Prompt: {userEntry._prompt} || {userEntry._text}");
            }
        }
    }

    public void Load()
    {
        _entries.Clear();
        string myfile = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(myfile);

        foreach (string line in lines)
        {
            if (line != "")
            {
                string[] parts = line.Split(" || ");
                string date = parts[0];
                string prompt = parts[1];
                string text = parts[2];
                prompt = prompt[8..^0];
                date = date[6..^0];
                Entry _newEntry = new()
                {
                    _date = date,
                    _prompt = prompt,
                    _text = text
                };
                AddEntry(_newEntry);
            }
            Console.WriteLine("Entry loaded");
        }
    }
}