using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = AddNumbers(num1, num2);

        Console.WriteLine($"The sum is: {result}");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
