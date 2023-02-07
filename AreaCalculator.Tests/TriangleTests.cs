namespace AreaCalculator.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestGetArea()
    {
        var triangle = new Triangle
        {
            Side1 = 3,
            Side2 = 4,
            Side3 = 5
        };

        var expectedArea = 6;
        var actualArea = triangle.GetArea();

        Assert.AreEqual(expectedArea, actualArea, 0.001, "Triangle area calculation is incorrect");
    }

    [TestMethod]
    public void TestIsRightTriangle()
    {
        var triangle = new Triangle
        {
            Side1 = 3,
            Side2 = 4,
            Side3 = 5
        };

        var expectedResult = true;
        var actualResult = triangle.IsRightTriangle();

        Assert.AreEqual(expectedResult, actualResult, "Triangle type detection is incorrect");
    }
}
