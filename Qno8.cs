using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_labreport
{
    internal class Qno8
    {
        static string Reverse(string s)
        {
            // Convert the string to a character array
            char[] charArray = s.ToCharArray();

            // Reverse the character array
            Array.Reverse(charArray);

            // Convert the character array back to a string and return
            return new string(charArray);
            
        }
        static void Main(string[] args)
        {
           
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversed = Reverse(input);
            Console.WriteLine($"Reversed string: {reversed}");
            Console.ReadKey();
        }

    }
}
