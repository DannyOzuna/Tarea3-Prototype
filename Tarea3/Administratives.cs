using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Administratives: IActors
    {
        //Propiedades de la clase
        private string id;
        private string name;
        private string lastName;
        private int telephone;
        private double salary;
        private string position;

        //Metodos de la clase
        public void creator()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Id: ");
            id = Console.ReadLine();
            Console.Write("Telephone: ");
            telephone = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Position: ");
            position = Console.ReadLine();
        }
        public string payment()
        {
            return "Cuenta Bancaria";
        }
        public string functionality()
        {
            return "Digitador";
        }
        public double lifeSure()
        {
            return salary * 0.1;
        }

        //Impresion
        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nLast name: {lastName}\nTelephone: {telephone}\nSalary: {salary}\n" +
                $"Position: {position}";
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.WriteLine(ToString());
            Console.WriteLine($"Functionality: {functionality()}\nLife Sure: {lifeSure()}\nPayment: {payment()}");
        }
    }
}
