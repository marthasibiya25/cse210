using System;

class Program
{
    static void Main()
    {
        Console.Write("Martha");
        string name = Console.ReadLine();

        Console.Write("25 years ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }
}
