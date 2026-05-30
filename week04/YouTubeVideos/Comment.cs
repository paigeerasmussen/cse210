using System;

class Comment
{
    // Tracks commentors name and the comment text

    private string _commenter;
    private string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string GetDisplayText()
    {
        string commentInfo = $"{_commenter}: {_comment}";

        return commentInfo;
    }
}