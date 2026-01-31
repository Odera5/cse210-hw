using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "CodeWithKingsley", 600);
        video1.AddComment(new Comment("James", "Very helpful video!"));
        video1.AddComment(new Comment("Sarah", "I finally understand classes."));
        video1.AddComment(new Comment("Michael", "Nice explanation 👍"));
        videos.Add(video1);

        Video video2 = new Video("OOP Concepts Explained", "TechSimplified", 750);
        video2.AddComment(new Comment("Ada", "Abstraction makes sense now."));
        video2.AddComment(new Comment("John", "Great examples."));
        video2.AddComment(new Comment("Blessing", "Please do encapsulation next."));
        videos.Add(video2);

        Video video3 = new Video("Beginner Programming Tips", "DevBasics", 480);
        video3.AddComment(new Comment("Chris", "This helped a lot."));
        video3.AddComment(new Comment("Lily", "Clear and concise."));
        video3.AddComment(new Comment("Sam", "Thanks for this!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
        }
    }
}
