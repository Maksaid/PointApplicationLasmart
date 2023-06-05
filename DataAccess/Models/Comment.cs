using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Comment
{
    public Guid Id { get; set; }
    public String CommentText { get; set; }
    public String Color { get; set; }
    public virtual Point? Point { get; set; }
    public Guid PointId { get; set; }

    public Comment(Guid id, string commentText, string color, Point point)
    {
        Id = id;
        CommentText = commentText;
        Color = color;
        Point = point;
        PointId = point.Id;
    }

    protected Comment() { }
}