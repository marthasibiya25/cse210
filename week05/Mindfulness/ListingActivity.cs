using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
        : base("Listing",
        "This activity will help you reflect on the good things in your life.")
    {
    }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        End();
    }
}
