namespace Inheritance_Interface;

public class Square : IShape
{
    private float Side { get; set; }

    public Square(float side)
    {
        Side = side;
    }

    public Square()
    {
    }

    public float Area()
    {
        return Side * Side;
    }

    public float Perimeter()
    {
        return Side * 4;
    }
}