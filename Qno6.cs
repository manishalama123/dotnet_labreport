using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_labreport
{
    internal class Qno6
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Before swapping:");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);

            // Swap the numbers
            int temp = num1;
            num1 = num2;
            num2 = temp;

            // Display the numbers after swapping
            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);
            Console.ReadKey();
        }

    }
}
