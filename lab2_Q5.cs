using System;

class Animal1
{
    // Virtual method that can be overridden in derived classes
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog1 : Animal1
{
    // Override the virtual method to provide a specific implementation
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat1 : Animal1
{
    // Override the virtual method to provide a specific implementation
    public override void Sound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program11
{
    /*static void Main()
    {
        // Create objects of the base and derived classes
        Animal1 animal = new Animal1();
        Dog1 dog = new Dog1();
        Cat1 cat = new Cat1();

        // Call the Sound method on each object
        animal.Sound();  // Calls the base class method
        dog.Sound();     // Calls the Dog's overridden method
        cat.Sound();     // Calls the Cat's overridden method
        Console.ReadKey();
    }*/
}
