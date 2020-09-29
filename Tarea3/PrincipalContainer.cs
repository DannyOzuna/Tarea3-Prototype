using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea3
{
    class PrincipalContainer
    {
        //Referencia para crear el archivo de texto
        TextWriter archivo; 

        //Referencia de la interface
        IActors actors;

        //Atributo de la clase
        private int option;

        //Metodo de la clase
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
                if (option == 1)
                {
                    Console.Clear();
                    //Aqui se esta creando el objeto original
                    Students students = new Students();
                    students.creator();
                    Console.WriteLine("\n\nHAS BEEN CREATED SUCCESSFULLY!...");
                    Console.WriteLine("PRESS A KEY TO CLONE!...");
                    Console.ReadKey();
                    Console.Clear();
                    //Aqui se esta creando el primer clon del objeto original "Lo que esta entre parentisis se llama Casting"
                    Students students1 = (Students) students.clone();
                    Console.WriteLine("|*---MODIFY CLONE DATA 1---*|");
                    students1.creator();
                    Console.WriteLine("\n\nCLONE MODIFY SUCCESSFULLY!...");
                    Console.WriteLine("PRESS A KEY TO CLONE!...");
                    Console.ReadKey();
                    Console.Clear();
                    //Aqui se esta creando el segundo clon
                    Students students2 = (Students)students.clone();
                    Console.WriteLine("|*---MODIFY CLONE DATA 2---*|");
                    students2.creator();
                    Console.WriteLine("\n\nCLONE MODIFY SUCCESSFULLY!...");
                    Console.WriteLine("PRESS A KEY TO SHOW!...");
                    Console.ReadKey();
                    Console.Clear();
                    //Aqui se empienza a imprimir por pantalla
                    Console.WriteLine("*------EDUCATION SYSTEM------*");
                    Console.WriteLine("\n*---ORIGINAL---*\n");
                    Console.WriteLine(students.Show());
                    Console.WriteLine("\n*---CLONE 1---*\n");
                    Console.WriteLine(students1.Show());
                    Console.WriteLine("\n*---CLONE 2---*\n");
                    Console.WriteLine(students2.Show());
                    //Aqui se esta creando el archivo de texto
                    using (archivo = new StreamWriter("Archivo.txt"))
                    {
                        //Aqui se agregan los resultados al archivo plano txt
                        archivo.WriteLine("ORIGINAL\n\n" + students.Show() + "\n\nCLONE 1\n\n" + students1.Show() +
                            "\n\nCLONE 2\n\n" + students2.Show());
                    }
                    Console.WriteLine("\n\nCREATED TEXT ARCHIVE!...");
                    Console.WriteLine("PRESS A KEY TO BACK!...");
                    Console.ReadKey();
                    principalMenu();
                }
                else
                {
                    actors = Creator.Actors(option);
                    actors.creator();
                    Console.WriteLine("\n\nHAS BEEN CREATED SUCCESSFULLY!...");
                    Console.WriteLine("PRESS A KEY TO SHOW!...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("*------EDUCATION SYSTEM------*");
                    Console.WriteLine(actors.Show());
                    Console.WriteLine("\n\nPRESS A KEY TO BACK!...");
                    Console.ReadKey();
                    principalMenu();
                }
            }
        }
    }
}
