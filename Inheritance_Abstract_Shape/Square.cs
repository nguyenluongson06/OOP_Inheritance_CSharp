namespace OOP_Inheritance;

public class Square : Shape
{
    public Square()
    {
    }

    public Square(float side)
    {
        Side = side;
    }

    private float Side { get; set; }

    public override float Area()
    {
        return Side * Side;
    }

    public override float Perimeter()
    {
        return Side * 4;
    }
}