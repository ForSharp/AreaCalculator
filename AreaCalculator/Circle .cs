﻿namespace AreaCalculator;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
