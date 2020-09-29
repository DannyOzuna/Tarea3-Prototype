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
            Console.WriteLine("*------EDUCATION SYSTEM------*");
            Console.Write("\nName: ");
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
            parents.Telephone = Convert.ToInt64(Console.ReadLine());
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
        public string Show()
        {
            return $"Tuition: {tuition}\nName: {name}\nLast name: {lastName}\nAge: {age}\n" +
                $"Course: {course}\nParents: {parents.Name}\nTelephone: {parents.Telephone}\n" +
                $"Arrive Class: {arriveClass()}\nScore: {score()}";
        }
    }
}
