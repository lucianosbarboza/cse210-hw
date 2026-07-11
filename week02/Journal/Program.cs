using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {randomPrompt}");
                Console.Write("> ");
                string responseText = Console.ReadLine();

                Console.Write("What is your current mood? ");
                string currentMood = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry
                {
                    _date = dateText,
                    _promptText = randomPrompt,
                    _entryText = responseText,
                    _mood = currentMood
                };

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number from 1 to 5.");
            }
        }
    }
}