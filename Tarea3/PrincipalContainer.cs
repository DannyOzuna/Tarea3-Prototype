using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class PrincipalContainer
    {
        IActors actors;
        private int option;
        public void principalMenu()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.WriteLine("PRINCIPAL MENU");
            Console.WriteLine("|*-----------------------*-*-----------------------*|");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Create Teacher");
            Console.WriteLine("3. Create Administratives");
            Console.WriteLine("4. Create Director");
            Console.WriteLine("5. Create Parents");
            Console.WriteLine("6. Leave");
            Console.WriteLine("|*-----------------------*-*-----------------------*|");
            Console.Write("Option: ");
            option = int.Parse(Console.ReadLine());
            if (option >= 6)
            {
                Environment.Exit(0);
            }
            else if (option <= 0)
            {
                Environment.Exit(0);
            }
            else
            {
                actors = Creator.Actors(option);
                actors.creator();
                Console.WriteLine("\n\nHAS BEEN CREATED SUCCESSFULLY!...");
                Console.WriteLine("PRESS A KEY TO SHOW!...");
                Console.ReadKey();
                actors.Show();
                Console.WriteLine("\n\nPRESS A KEY TO BACK!...");
                Console.ReadKey();
                principalMenu();
            }
        }
    }
}
