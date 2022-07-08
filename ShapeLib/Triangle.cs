namespace ShapeLib;

public class Triangle : Shape
{
    private const float Tolerance = 0.0001f;
    private List<double> sides;
    /// <summary>
    /// Returns area of triangle
    /// </summary>
    public double Area
    {
        get
        {
            if (IsRight) return Sides.Where(x => Math.Abs(x - Sides.Max()) > Tolerance).Aggregate(0.5d, (current, side) => current * side);
            var halfPerimeter = Perimeter/2;
            var ret = Sides.Aggregate(1d, (current, side) => current * (halfPerimeter - side));
            return Math.Sqrt(halfPerimeter * ret);
        }
    }
    /// <summary>
    /// Returns perimeter of a triangle
    /// </summary>
    public double Perimeter => Sides.Sum();
    
    /// <summary>
    /// Returns true if one of triangle angles is right
    /// </summary>
    public bool IsRight
    {
        get
        {
            var hypotenuse = Sides.Max();
            var legs = Sides.Where(x => Math.Abs(x - hypotenuse) > Tolerance).Aggregate(0d, (current, side) => current + (side * side));
            return Math.Abs(hypotenuse * hypotenuse - legs) < Tolerance;

        }
    }
    
    /// <summary>
    /// Checks whether triangle exists or not
    /// </summary>
    private bool DoesExist
    {
        get
        {
            var hypotenuse = Sides.Max();
            var legs = Sides.Where(x => Math.Abs(x - hypotenuse) > Tolerance).Aggregate(0d, (current, side) => current + (side));
            return hypotenuse < legs;
        }
    }

    public List<double> Sides
    {
        get => sides;
        set
        {
            sides = value;
            if (!DoesExist) throw new Exception("Triangle does not exist");
        }
    }

    public Triangle() : this(1, 1, 1)
    {
        
    }
    public Triangle(double sideA, double sideB, double sideC)
    {
        Sides = new List<double>{sideA, sideB, sideC}.OrderBy(x => x).ToList();
        if (!DoesExist) throw new Exception("Triangle does not exist");
    }

  
}