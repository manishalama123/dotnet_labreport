using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_labreport
{
    internal class Qno7
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Convert the input string to an integer
            if (int.TryParse(input, out int number))
            {
                
                Console.WriteLine($"\nMultiplication Table for {number}:\n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadKey();
        }
    }
}
