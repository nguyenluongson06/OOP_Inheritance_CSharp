namespace OOP_Inheritance;

public class Rectangle : Shape
{
    public Rectangle()
    {
    }

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    private float Width { get; set; }
    private float Height { get; set; }
    
    /// <summary>
    /// Get area of shape
    /// </summary>
    /// <returns></returns>
    public override float Area()
    {
        return Height * Width;
    }

    /// <summary>
    /// Get perimeter of shape
    /// </summary>
    /// <returns></returns>
    public override float Perimeter()
    {
        return (Width + Height) * 2;
    }
}