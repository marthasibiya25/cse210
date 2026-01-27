using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Sam", "Loved this video."));
        videos.Add(video1);

        Video video2 = new Video("OOP Concepts Explained", "DevSimplified", 480);
        video2.AddComment(new Comment("Jane", "Abstraction finally makes sense."));
        video2.AddComment(new Comment("Mike", "Great examples."));
        video2.AddComment(new Comment("Lebo", "Thanks for this."));
        videos.Add(video2);

        Video video3 = new Video("GitHub for Beginners", "TechWorld", 720);
        video3.AddComment(new Comment("Chris", "Exactly what I needed."));
        video3.AddComment(new Comment("Nina", "Well structured."));
        video3.AddComment(new Comment("Tom", "Please make more videos."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
