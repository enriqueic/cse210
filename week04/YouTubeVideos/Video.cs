using System;

class Video
{
    public Video(string title, string author, int minutes)
    {
        _title = title;
        _author = author;
        _length = $"{minutes:D2}:00";
    }

    public Video(string title, string author, int minutes, int seconds)
    {
        _title = title;
        _author = author;
        _length = $"{minutes:D2}:{seconds:D2}";
    }

    private string _length;
    private string _title;
    private string _author;
    private List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void AddComment(string author, string content)
    {
        _comments.Add(new Comment(author, content));
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}
    