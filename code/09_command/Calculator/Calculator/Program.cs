using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create user and let her compute
            User user = new User();
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            // Undo 4 commands
            user.Undo(4); 
            // Redo 3 commands
            user.Redo(3); 
            // Wait for user
            Console.Read();
        }
    }
}
