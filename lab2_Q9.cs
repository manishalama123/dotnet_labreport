using System;

class Person1
{
    private string name;
    private int age;
    private string secret;

    // Read-Write Property (allows both getting and setting the value)
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Read-Only Property (allows only getting the value)
    public int Age
    {
        get { return age; }
    }

    // Write-Only Property (allows only setting the value)
    public string Secret
    {
        set { secret = value; }
    }

    // Auto-Implemented Property (simplifies property declaration)
    public string Address { get; set; }

    // Constructor to initialize the name and age
    public Person1(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Method to display person's details
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
    }
}

class Program1234
{
   /* static void Main()
    {
        // Create a new person object
        Person1 person = new Person1("John", 25);

        // Using the read-write property
        person.Name = "Manisha Lama";  // Setting name
        Console.WriteLine($"Updated Name: {person.Name}");  // Getting name

        // Using the read-only property
        Console.WriteLine($"Age: {person.Age}");

        // Using the write-only property
        person.Secret = "This is a secret message.";  // Setting the secret (write-only)

        // Using the auto-implemented property
        person.Address = "123 Main St";
        person.DisplayInfo();
        Console.ReadKey();
    }*/
}
