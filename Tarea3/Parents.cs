using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Parents: IActors
    {
        //Propiedades de la clase
        public int Indentification { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long Telephone { get; set; }
        public double Salary { get; set; }
        public int Account { get; set; }

        //Metodos de la clase
        public void creator()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Indentification: ");
            Indentification = int.Parse(Console.ReadLine());
            Console.Write("Telephone: ");
            Telephone = Convert.ToInt64(Console.ReadLine());
            Console.Write("Salary: ");
            Salary = double.Parse(Console.ReadLine());
            Console.Write("Account: ");
            Account = int.Parse(Console.ReadLine());
        }
        public double lifeSure()
        {
            return Salary * 0.4;
        }
        public string payment()
        {
            return "En efectivo";
        }
        public double commission()
        {
            return Salary * 0.1;
        }

        //Impresion
        public string Show()
        {
            return $"Identification: {Indentification}\nName: {Name}\nLast name: {LastName}\nTelephone: {Telephone}\nSalary: {Salary}\n" +
                $"Account: {Account}\nCommission: {commission()}\nLife Sure: {lifeSure()}\nPayment: {payment()}";
        }
    }
}
