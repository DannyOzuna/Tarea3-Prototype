using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Teachers: IActors
    {
        //Propiedades de la clase
        private string id;
        private string name;
        private string lastName;
        private int telephone;
        private double salary;
        private string subject; 

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
            Console.Write("Subject: ");
            subject = Console.ReadLine();
        }
        public string Teaching()
        {
            return "Software Developer";
        }
        public double lifeSure()
        {
            return salary * 0.3;
        }
        public string payment()
        {
            return "Cheque";
        }

        //Impresion
        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nLast name: {lastName}\nTelephone: {telephone}\nSalary: {salary}\n" +
                $"Subject: {subject}";
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.WriteLine(ToString());
            Console.WriteLine($"Teaching: {Teaching()}\nLife Sure: {lifeSure()}\nPayment: {payment()}");
        }
    }
}
