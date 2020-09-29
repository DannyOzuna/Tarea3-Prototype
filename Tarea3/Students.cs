using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tarea3
{
    class Students: IActors, IClone
    {
        //Atributos de la clase
        private Parents parents;
        private int tuition;
        private string name;
        private string lastName;
        private int age;
        private string course;

        //Metodo de la clase
        public void creator()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Tuition: ");
            tuition = int.Parse(Console.ReadLine());
            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Course: ");
            course = Console.ReadLine();
            parents = new Parents();
            Console.Write("Parent: ");
            parents.Name = Console.ReadLine();
            Console.Write("Telephone: ");
            parents.Telephone = int.Parse(Console.ReadLine());
        }
        public string arriveClass()
        {
            return "School Bus";
        }
        public int score()
        {
            return 100;
        }

        //Implementado el patron Prototype

        public object clone()
        {
            Students clon = (Students)MemberwiseClone();
            clon.parents = new Parents();
            clon.parents.Name = parents.Name;
            clon.parents.Telephone = parents.Telephone;
            return clon;
        }

        //Impresion
        public override string ToString()
        {
            return $"Tuition: {tuition}\nName: {name}\nLast name: {lastName}\nAge: {age}\n" +
                $"Course: {course}\nParents: {parents.Name}\nTelephone: {parents.Telephone} ";
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.WriteLine(ToString());
            Console.WriteLine($"Arrive Class: {arriveClass()}\nScore: {score()}");
        }

    }
}
