using System;

namespace NamespaceA
{
    public class MyClassA
    {
        public string message = "Hello from NamespaceA!";

        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }
    }
}

namespace NamespaceB
{
    public class MyClassB
    {
        public string message = "Hello from NamespaceB!";

        public void DisplayMessage()
        {
            Console.WriteLine(message);
        }

        public void AccessNamespaceA()
        {
            // Accessing class from NamespaceA
            NamespaceA.MyClassA objA = new NamespaceA.MyClassA();

            // Accessing fields and methods from MyClassA
            objA.DisplayMessage();
        }
    }
}

class Program1
{
   /* static void Main(string[] args)
    {
        // Accessing NamespaceB class
        NamespaceB.MyClassB objB = new NamespaceB.MyClassB();

        // Displaying message from NamespaceB
        objB.DisplayMessage();

        // Accessing and displaying message from NamespaceA through NamespaceB
        objB.AccessNamespaceA();
        Console.ReadKey();
    }*/
}
