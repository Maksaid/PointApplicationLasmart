namespace Presentation.Models;

public class CommentModel
{
    public string Text { get; set; }
    public string PointId { get; set; }
    public string Color { get; set; }

    public CommentModel(string text, string pointId, string color)
    {
        Text = text;
        PointId = pointId;
        Color = color;
    }
}