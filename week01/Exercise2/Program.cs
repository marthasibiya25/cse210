using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 50)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
    }
}
