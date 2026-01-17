using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Write a new entry\n2. Display journal\n3. Save journal\n4. Load journal\n5. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Random rnd = new Random();
                    string prompt = prompts[rnd.Next(prompts.Count)];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry e = new Entry { _prompt = prompt, _response = response, _date = DateTime.Now.ToShortDateString() };
                    myJournal.AddEntry(e);
                    break;

                case "2":
                    myJournal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.Save(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.Load(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
