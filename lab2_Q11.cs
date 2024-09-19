using System;

namespace GenericExample
{
    // Define a generic class
    public class MyGenericClass<T>
    {
        // Declare a generic variable
        private T data;

        // Constructor to initialize the generic variable
        public MyGenericClass(T value)
        {
            data = value;
        }

        // Generic method to display the data
        public void Display()
        {
            Console.WriteLine("The value is: " + data);
        }

        // Generic method to swap two values
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a generic class with int type
            MyGenericClass<int> intInstance = new MyGenericClass<int>(10);
            intInstance.Display();

            // Create an instance of a generic class with string type
            MyGenericClass<string> stringInstance = new MyGenericClass<string>("Hello");
            stringInstance.Display();

            // Example of swapping two integer values
            int x = 5, y = 10;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            intInstance.Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            // Example of swapping two string values
            string str1 = "Apple", str2 = "Banana";
            Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
            stringInstance.Swap(ref str1, ref str2);
            Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
            Console.ReadKey();
        }
    }
}
