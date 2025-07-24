using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John Doe", 10);
        video1.AddComment("Alice", "Great video on C#!");
        video1.AddComment("Bob", "Very informative!");
        video1.AddComment("Charlie", "Thanks for the tips!");

        Video video2 = new Video("Advanced C#", "Jane Smith", 15, 30);
        video2.AddComment("David", "Loved the advanced concepts!");
        video2.AddComment("Eve", "This helped me a lot with my project!");
        video2.AddComment("Frank", "Can't wait for the next video!");

        Video video3 = new Video("C# Best Practices", "Alice Johnson", 12, 45);
        video3.AddComment("Grace", "Loved the examples!");
        video3.AddComment("Hank", "Very well explained!");
        video3.AddComment("Ivy", "Keep up the good work!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }   
    }
}