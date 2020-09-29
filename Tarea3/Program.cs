using System;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrincipalContainer principal = new PrincipalContainer();
            Console.WriteLine("WELCOME TO EDUCATIONAL CENTER ADMINISTRATION SYSTEM\n\n");
            Console.WriteLine("\n\nPRESS A KEY TO CONTINUOUS...");
            Console.ReadKey();
            principal.principalMenu();
        }
    }
}
