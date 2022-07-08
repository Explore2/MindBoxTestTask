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
        Triangle rightTriangle = new Triangle(3, 4, 5);
        Assert.That(rightTriangle.Area, Is.EqualTo(6).Within(Delta));
        Triangle notRightTriangle = new Triangle(4, 8, 6);
        Assert.That(notRightTriangle.Area, Is.EqualTo(11.619).Within(Delta));
    }

    [Test]
    public void IsRightTest()
    {
        Triangle rightTriangle = new Triangle(3, 4, 5);
        Assert.IsTrue(rightTriangle.IsRight);
        Triangle notRightTriangle = new Triangle(4, 8, 6);
        Assert.IsFalse(notRightTriangle.IsRight);
    }

    [Test]
    public void PerimeterTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.Perimeter, Is.EqualTo(12).Within(Delta));
    }

    [Test]
    public void TriangleExistenceTest()
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

    }

}