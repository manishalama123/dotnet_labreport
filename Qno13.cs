using System;

class Qno13
{
    static void Main()
    {
        
        string[] stringArray = { "Hello", "world", "this", "is", "C#" };
        string result = ConvertArrayToString(stringArray, " ");
        Console.WriteLine(result);
        Console.ReadKey();
    }

    static string ConvertArrayToString(string[] array, string delimiter)
    {
        return string.Join(delimiter, array);
    }
}
