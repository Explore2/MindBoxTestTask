namespace ShapeTests;

using ShapeLib;

public class TriangleTests
{
    private const double Delta = 0.0001f;
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AreaTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.Area, Is.EqualTo(6).Within(Delta));
        triangle = new Triangle(4, 8, 6);
        Assert.That(triangle.Area, Is.EqualTo(11.619).Within(Delta));
    }

    [Test]
    public void IsRightTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRight);
        triangle = new Triangle(4, 8, 6);
        Assert.IsFalse(triangle.IsRight);
    }

    [Test]
    public void PerimeterTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.Perimeter, Is.EqualTo(12).Within(Delta));
    }

    [Test]
    public void ExistenceTest()
    {
        //Triangle exists
        try
        {
            Triangle triangle = new Triangle(3, 4, 5);
        }
        catch (Exception e)
        {
            Assert.Fail();
        }

        //Triangle does not exist
        try
        {
            Triangle triangle = new Triangle(1, 3, 5);
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
        
        try
        {
            Triangle triangle = new Triangle(-1, 3, 5);
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
    }

}