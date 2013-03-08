using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Shape
{
    public double width, height;
    public Shape(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public abstract double CalculateSurface();
}

