namespace AreaCalculator.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void GetArea_WithRadius2_ShouldReturn12Point57()
    {
        // Arrange
        var circle = new Circle { Radius = 2 };

        // Act
        var result = circle.GetArea();

        // Assert
        Assert.AreEqual(12.57, result, 0.01);
    }

    [TestMethod]
    public void GetArea_WithRadius1_ShouldReturn3Point14()
    {
        // Arrange
        var circle = new Circle { Radius = 1 };

        // Act
        var result = circle.GetArea();

        // Assert
        Assert.AreEqual(3.14, result, 0.01);
    }
}