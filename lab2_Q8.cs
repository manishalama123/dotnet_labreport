using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor to initialize X and Y coordinates
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overload the binary + operator
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Method to display the point coordinates
    public void Display()
    {
        Console.WriteLine($"Point coordinates: ({X}, {Y})");
    }
}

class Program123
{
   /* static void Main()
    {
        // Create two Point objects
        Point point1 = new Point(3, 4);
        Point point2 = new Point(5, 7);

        // Display the original points
        Console.WriteLine("Original Points:");
        point1.Display();
        point2.Display();

        // Use the overloaded + operator to add the two points
        Point result = point1 + point2;

        // Display the result
        Console.WriteLine("\nAfter Addition:");
        result.Display();
        Console.ReadKey();
    }*/
}
