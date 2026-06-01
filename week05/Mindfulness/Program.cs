using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while (option != "4")
        {
            Console.Clear();
            // fix this so error message displays instead of clearing

            Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflection activity\n 3. Start listing activity\n 4. quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("1");
            }

            else if (option == "2")
            {
                Console.WriteLine("2");
            }

            else if (option == "3")
            {
                Console.WriteLine("3");
            }

            else if (option == "4")
            {
                Console.WriteLine("Have a great day!");
            }

            else
            {
                Console.WriteLine("Sorry, this is not a valid option. Please try again");
            }
        }
    }
}