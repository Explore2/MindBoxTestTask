namespace ShapeLib;

public class Circle : IShape
{
    /// <summary>
    /// Counts area of a circle
    /// </summary>
    public double Area => Math.PI * (Radius * Radius);

    private double radius;
    public double Radius {
        get => radius;
        set 
        {
            radius = value;
            if (!DoesExist) throw new Exception("Circle does not exist");
        }
}
    /// <summary>
    /// Checks if a circle does exist
    /// </summary>
    private bool DoesExist => Radius > 0;

    public Circle() : this(1)
    {
        
    }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
}