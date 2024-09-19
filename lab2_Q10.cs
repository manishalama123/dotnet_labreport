using System;

class Shape
{
    // Properties for Length and Breadth
    public double Length { get; set; }
    public double Breadth { get; set; }

    // Default constructor
    public Shape()
    {
        Length = 0;
        Breadth = 0;
    }

    // Parameterized constructor
    public Shape(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
}

class Rectangle : Shape
{
    // Constructor for Rectangle using the base class constructor
    public Rectangle(double length, double breadth) : base(length, breadth)
    {
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return Length * Breadth;
    }

    // Method to display the dimensions and area
    public void Display()
    {
        Console.WriteLine($"Length: {Length}");
        Console.WriteLine($"Breadth: {Breadth}");
        Console.WriteLine($"Area of Rectangle: {CalculateArea()}");
    }
}

class Program22
{
   /* static void Main()
    {
        // Create a Rectangle object using parameterized constructor
        Rectangle rect = new Rectangle(9, 19);

        // Display the details of the rectangle
        rect.Display();
        Console.ReadKey();
    }*/
}
