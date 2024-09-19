using System;

public partial class Person
{
    public string FirstName;
    public string LastName;

    public void DisplayFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName} from first class");
    }
}
