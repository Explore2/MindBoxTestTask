namespace ShapeLib;

public class Circle : Shape
{
    private double radius;
    
    public double Area => Math.PI * (Radius * Radius);

    public double Radius
    {
        get => radius;
        set => radius = value;
    }

    public Circle() : this(1)
    {
        
    }
    
    public Circle(double radius)
    {
        this.Radius = radius;
    }
}