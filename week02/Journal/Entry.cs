using System.Threading.Tasks.Dataflow;

public class Entry
{
    public String _date;
    public String _prompt;

    public String _text;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} || Prompt: {_prompt} || {_text}");
    }
}