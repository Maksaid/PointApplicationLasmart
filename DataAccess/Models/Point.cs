namespace DataAccess.Models;

public class Point
{
    public Guid Id { get; set; } 
    public int X { get; set; }
    public int Y { get; set; }
    public int R { get; set; }
    public string Color { get; set; }
    public virtual List<Comment> Comments { get; set; } = new();

    protected Point() { }

    public Point(Guid id,int x, int y, int r, string color, List<Comment> comments)
    {
        X = x;
        Y = y;
        R = r;
        Color = color;
        Comments = comments;
    }
}