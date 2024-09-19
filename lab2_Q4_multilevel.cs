using System;

class Creature
{
    public void Eat()
    {
        Console.WriteLine("Creature is eating.");
    }
}

class Wolf : Creature
{
    public void Howl()
    {
        Console.WriteLine("Wolf is howling.");
    }
}

class Cub : Wolf
{
    public void Whine()
    {
        Console.WriteLine("Cub is whining.");
    }

   /* static void Main(string[] args)
    {
        Cub cub = new Cub();
        cub.Eat();   // Inherited from Creature
        cub.Howl();  // Inherited from Wolf
        cub.Whine(); // Method from Cub
        Console.ReadKey();
    }*/
}
