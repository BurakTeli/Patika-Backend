using System;

class BaseGeometricShape
{
    // Common properties
    public double Width { get; set; } // Width of the shape
    public double Height { get; set; } // Height of the shape

    // Method to calculate area (default for all shapes)
    public virtual double CalculateArea()
    {
        return Width * Height;
    }
}

class Square : BaseGeometricShape
{
    // Overriding the method to calculate the area of a square
    public override double CalculateArea()
    {
        return Width * Width; // Area of a square: Side^2
    }
}

class Rectangle : BaseGeometricShape
{
    // No need to override, the base class method works for rectangles
}

class RightTriangle : BaseGeometricShape
{
    // Overriding the method to calculate the area of a right triangle
    public override double CalculateArea()
    {
        return (Width * Height) / 2; // Area of a right triangle: (Base × Height) / 2
    }
}

class Program
{
    static void Main()
    {
        // Creating a square and calculating its area
        BaseGeometricShape square = new Square { Width = 5, Height = 5 };
        Console.WriteLine($"Square Area: {square.CalculateArea()}");

        // Creating a rectangle and calculating its area
        BaseGeometricShape rectangle = new Rectangle { Width = 4, Height = 6 };
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

        // Creating a right triangle and calculating its area
        BaseGeometricShape rightTriangle = new RightTriangle { Width = 3, Height = 4 };
        Console.WriteLine($"Right Triangle Area: {rightTriangle.CalculateArea()}");
    }
}
