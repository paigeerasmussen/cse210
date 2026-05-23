using System;
// This program exceeds requirements by adding a restart option to allow the user to restart the program at any point. 
class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        string userResponse = "";

        while (userResponse != "quit" && !s1.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(s1.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue, type 'restart' to start over, or type 'quit' to finish: ");

            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "restart")
            {
                s1.RestartProgram();
            }
            else if (userResponse == "")
            {
                s1.HideRandomWords(3);
                if (s1.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(s1.GetDisplayText());
                    Console.WriteLine("All words are hidden. Thank you for playing.");
                }
            }
            else if (userResponse == "quit")
            {
                Console.Clear();
                Console.WriteLine("Thank you for playing.");
            }


        }
    }
}