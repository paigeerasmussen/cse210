using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates 3-4 videos, sets values, and adds 3-4 comments with commentor name. Each video is in a list. The program iterates through the list and displays the title, author, length, and number of comments and lists all the comments

        // Figure out how to display multiple/different number of comments

        Comment c1 = new Comment("Tracy R.", "This is a very helpful demonstration.");
        Comment c2 = new Comment("Peter C.", "Great video!");
        Comment c3 = new Comment("John S.", "I understand Python now.");

        Video v1 = new Video(c1, "Programming in Python", "John Smith", 655);
        Video v2 = new Video(c2, "Cooking Chicken Tacos", "Debra Johnson", 423);
        Video v3 = new Video(c3, "How to Grow Tulips", "Joseph Turner", 329);
        Video v4 = new Video(c3, "Sunset Yoga", "Emily Larson", 1256);

        // Console.WriteLine(v1.GetDisplayText());
        // Console.WriteLine(v2.GetDisplayText());
        // Console.WriteLine(v3.GetDisplayText());
        // Console.WriteLine(v4.GetDisplayText());
    }
}