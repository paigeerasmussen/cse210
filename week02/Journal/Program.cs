using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        int userNumber = -1;
        while (userNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber == 1)
            {
                journal.AddEntry();
            }
            else if (userNumber == 2)
            {
                journal.DisplayAll();
            }
            else if (userNumber == 3)
            {
                journal.SaveToFile();
            }
            else if (userNumber == 4)
            {
                journal.LoadFromFile();
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("Thank you for using the Journal Program. Come again soon!");
            }
            else
            {
                Console.WriteLine("This is not a valid choice. Please try again.");
            }
        }
    }
}