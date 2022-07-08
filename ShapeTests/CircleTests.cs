namespace ShapeTests;

using ShapeLib;

public class CircleTests
{
    private const double Delta = 0.0001f;
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void AreaTest()
    {
        Circle circle = new Circle(2);
        Assert.That(circle.Area, Is.EqualTo(12.56637).Within(Delta));
    }

    [Test]
    public void ExistenceTest()
    {
        //Circle does not exist
        try
        {
            Circle circle = new Circle(-1);
            Assert.Fail();
        }
        catch (AssertionException e)
        {
            Assert.Fail();
        }
        catch (Exception e)
        {
            Assert.Pass();
        }
        //Circle exists
        try
        {
            Circle circle = new Circle(1);
        }
        catch (Exception e)
        {
            Assert.Fail();
        }
    }
}