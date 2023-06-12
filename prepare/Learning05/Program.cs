using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5, "blue");
        circle.GetColor();
        circle.GetArea();

        Rectangle rectangle = new Rectangle(4, 6, "red");
        rectangle.GetColor();
        rectangle.GetArea();

        Square square = new Square(5, "green");
        square.GetArea();
        square.GetColor();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}