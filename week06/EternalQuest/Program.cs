using System;
// Exceeding requirements: there is code to catch some user options that arent valid. There is also a goodbye message and try again messages.
class Program
{
    static void Main(string[] args)
    {
        GoalManager g1 = new GoalManager();
        g1.Start();
    }
}