using System;

public partial class Person
{
    public int Age;

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {Age} from second partial class");
    }
}

class Program2
{
    /*static void Main(string[] args)
    {
        // Creating an object of the partial class Person
        Person person = new Person();

        // Accessing members from both parts of the partial class
        person.FirstName = "Manisha";
        person.LastName = "Lama";
        person.Age = 30;

        // Displaying the data
        person.DisplayFullName();  // From Person_Part1.cs
        person.DisplayAge();       // From Person_Part2.cs
        Console.ReadKey();
    }*/
}
