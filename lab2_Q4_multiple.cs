using System;

interface IAnimal
{
    void Eat();
}

interface IFlyable
{
    void Fly();
}

class Bird : IAnimal, IFlyable
{
    public void Eat()
    {
        Console.WriteLine("Bird is eating.");
    }

    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }

    /*static void Main(string[] args)
    {
        Bird bird = new Bird();
        bird.Eat();   // From IAnimal
        bird.Fly();   // From IFlyable
        Console.ReadKey();
    }*/
}
