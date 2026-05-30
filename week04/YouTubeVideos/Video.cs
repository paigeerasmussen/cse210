using System;

class Video
{
    // append video to a list and display by iterating through the list
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public string DisplayVideoInfo()
    {
        return $"{_title}, by {_author} is {_length} seconds.\n";
    }

    public string DisplayComments()
    {
        string videoComment = "";
        foreach (Comment comment in _comments)
        {
            videoComment += comment.GetDisplayText() + "\n";
        }

        return videoComment;
    }
}