using System;

class Car
{
    public string Make;
    public string Model;
    public int Year;

    // Default constructor
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    // Parameterized constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Copy constructor
    public Car(Car otherCar)
    {
        Make = otherCar.Make;
        Model = otherCar.Model;
        Year = otherCar.Year;
    }
    static Car()
    {
        Console.WriteLine("This is static constructor");
    }
    // Method to display car details
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }

   /* static void Main()
    {
        // Using the default constructor
        Car car1 = new Car();
        car1.DisplayInfo();

        // Using the parameterized constructor
        Car car2 = new Car("Toyota", "Camry", 2021);
        car2.DisplayInfo();

        // Using the copy constructor
        Car car3 = new Car(car2);
        car3.DisplayInfo();
        Console.ReadKey();
    }*/
}
