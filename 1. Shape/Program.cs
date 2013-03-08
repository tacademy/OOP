using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(5,4));
        shapes.Add(new Triangle(2,3));

        foreach (var shape in shapes)
        {
            double surface = shape.CalculateSurface();
            Console.WriteLine(surface);
        }

    }
}

