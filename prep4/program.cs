using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();

        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        Console.WriteLine("Names in the list:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
