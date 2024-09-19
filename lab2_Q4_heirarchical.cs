using System;

class Mammal
{
    public void Eat()
    {
        Console.WriteLine("Mammal is eating.");
    }
}

class Canine : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Canine is barking.");
    }
}

class Feline : Mammal
{
    public void Roar()
    {
        Console.WriteLine("Feline is roaring.");
    }

    /*static void Main(string[] args)
    {
        Canine canine = new Canine();
        canine.Eat();   // Inherited from Mammal
        canine.Bark();  // Method from Canine

        Feline feline = new Feline();
        feline.Eat();   // Inherited from Mammal
        feline.Roar();  // Method from Feline4
        Console.ReadKey();
    }*/
}
