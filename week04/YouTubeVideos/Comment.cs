using System;

class Comment
{
    private string _commenter;
    private string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string GetDisplayText()
    {
        return $"{_commenter} said \"{_comment}\"";
    }
}