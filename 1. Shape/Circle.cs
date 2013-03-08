using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{
    public Circle(int width) : base (width, width)
    {
        this.width = width;
        this.height = this.width;
    }

    public override double CalculateSurface()
    {
        return 2 * Math.PI * width;
    }
}
