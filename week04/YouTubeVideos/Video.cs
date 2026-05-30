using System;

class Video
{
    // append video to a list and display by iterating through the list
    private string _title;
    private string _author;
    private int _length;
    private Comment _comment;

    private List<Video> _video = new List<Video>();

    public Video(Comment Comment, string title, string author, int length)
    {
        _comment = Comment;
        // _title = title;
        // _author = author;
        // _length = length;

        _video.Add(new Video { _title = title, _author = author, _length = length });
    }

    // public string GetDisplayText()
    // {
    //     string videoInfo = $"{_title}, by {_author} is {_length} seconds. Comments: {_comment.GetDisplayText()}";

    //     return videoInfo;
    // }
}