using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create some videos
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        Video video2 = new Video("Learn Python", "Jane Smith", 800);
        Video video3 = new Video("JavaScript Basics", "Alice Johnson", 500);

        // Add comments to video1
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "I learned a lot."));
        video1.AddComment(new Comment("User4", "Can you make a video on advanced topics?"));

        // Add comments to video2
        video2.AddComment(new Comment("UserA", "Awesome content!"));
        video2.AddComment(new Comment("UserB", "Thanks for sharing."));
        video2.AddComment(new Comment("UserC", "This was very informative."));

        // Add comments to video3
        video3.AddComment(new Comment("UserX", "Good introduction."));
        video3.AddComment(new Comment("UserY", "Looking forward to more videos."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };
        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetComments().Count}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");


            }
        } 
    }
}