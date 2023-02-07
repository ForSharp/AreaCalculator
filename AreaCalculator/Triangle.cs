namespace AreaCalculator;

public class Triangle : IFigure
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public double GetArea()
    {
        var semiPerimeter = (Side1 + Side2 + Side3) / 2;
        var area = Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) *
                                (semiPerimeter - Side2) * (semiPerimeter - Side3));
        return area;
    }

    public bool IsRightTriangle()
    {
        return (Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2) ||
                Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2) ||
                Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2));
    }
}
