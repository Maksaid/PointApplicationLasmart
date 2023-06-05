namespace Presentation.Models;

public class PointModel
{
    public int X { get; set; }
    public int Y { get; set; }
    public int R { get; set; }
    public string Color { get; set; }

    public PointModel(int x, int y, int r, string color)
    {
        X = x;
        Y = y;
        R = r;
        Color = color;
    }
}