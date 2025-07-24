using System;

class Comment
{
    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }
    private string _author;

    private string _content;
    public void DisplayComment()
    {
        Console.WriteLine($"{_author}: {_content}");
    }
}