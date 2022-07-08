namespace ShapeLib;

public class Circle : IShape
{
    /// <summary>
    /// Returns area of circle
    /// </summary>
    public double Area => Math.PI * (Radius * Radius);
    public double Radius { get; set; }

    public Circle() : this(1)
    {
        
    }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
}