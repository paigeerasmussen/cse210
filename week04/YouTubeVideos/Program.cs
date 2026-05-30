using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Programming in Python", "John Smith", 655);
        Comment c11 = new Comment("Tracy R.", "This is a very helpful demonstration.");
        Comment c12 = new Comment("Peter C.", "Great video!");
        Comment c13 = new Comment("John S.", "I understand Python now.");
        v1.AddComment(c11);
        v1.AddComment(c12);
        v1.AddComment(c13);

        Video v2 = new Video("Cooking Chicken Tacos", "Debra Johnson", 423);
        Comment c21 = new Comment("Amy L", "Looks good!");
        Comment c22 = new Comment("Mark T.", "I want to try this.");
        Comment c23 = new Comment("Sara P.", "Easy recipe.");
        v2.AddComment(c21);
        v2.AddComment(c22);
        v2.AddComment(c23);

        Video v3 = new Video("How to Grow Tulips", "Joseph Turner", 329);
        Comment c31 = new Comment("Ben K.", "Nice guide.");
        Comment c32 = new Comment("Lisa M.", "Very helpful.");
        Comment c33 = new Comment("Tom H.", "I Learned something new.");
        v3.AddComment(c31);
        v3.AddComment(c32);
        v3.AddComment(c33);

        Video v4 = new Video("Sunset Yoga", "Emily Larson", 1256);
        Comment c41 = new Comment("Emma J.", "So relaxing");
        Comment c42 = new Comment("Chris B.", "I liked this video.");
        Comment c43 = new Comment("Olivia W.", "Great routine.");
        v4.AddComment(c41);
        v4.AddComment(c42);
        v4.AddComment(c43);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideoInfo());
            Console.WriteLine($"There are {video.CommentCount()} comments on this video:");
            Console.WriteLine(video.DisplayComments());
        }

    }
}