namespace Inheritance_Interface;

public class Rectangle : IShape
{
    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    private float Width { get; set; }
    private float Height { get; set; }
    
    public float Area()
    {
        return Width * Height;
    }

    public float Perimeter()
    {
        return (Width + Height) * 2;
    }
}