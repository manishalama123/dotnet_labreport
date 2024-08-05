using System;


namespace dotnet_labreport
{
    internal class Qno3
    {
        static void Main()
        {
            
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            
            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();

            
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            
            Console.WriteLine("\nYour entered information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Email: " + email);
            Console.ReadKey();
        }
    }
}
