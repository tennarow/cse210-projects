using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.AddEntry();
            }
            else if (choice == 2)
            {

                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                string result = journal.SaveToFile(filename);
                Console.WriteLine(result);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                string result = journal.LoadFromFile(filename);
                Console.WriteLine(result);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
            }
        }

    }
}