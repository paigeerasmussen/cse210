using System;
using System.Runtime.InteropServices;

// Exceeding requirements: There is a menu option to catch any invalid options the user inputs. There is a stretching activity added as an extra activity. 
class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while (option != "5")
        {
            Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflection activity\n 3. Start listing activity\n 4. Start stretching activity\n 5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                BreathingActivity o1 = new BreathingActivity();
                o1.Run();
            }

            else if (option == "2")
            {
                ReflectingActivity o3 = new ReflectingActivity();
                o3.Run();
            }

            else if (option == "3")
            {
                ListingActivity o2 = new ListingActivity();
                o2.Run();
            }

            else if (option == "4")
            {
                StrechingActivity o4 = new StrechingActivity();
                o4.Run();
            }

            else if (option == "5")
            {
                Console.WriteLine("Have a great day!");
            }

            else
            {
                Console.WriteLine("This is not a valid option. Please try again.");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}