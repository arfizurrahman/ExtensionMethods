using System;
using ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {

        int i = 10;

        bool result = i.IsGreaterThan(100);

        Console.Write(result);
        Console.ReadKey();
    }
}

