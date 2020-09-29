using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Transactions;

namespace Tarea3
{
    class Director: IActors
    {
        //Referencia de la clase
        private static Director director = null;

        //Propiedades de la clase
        private string id;
        private string name;
        private string lastName;
        private int telephone;
        private double salary;
        private int account;

        //Constructor de la clase, privado para que no se pueda tener una instancia de la clase libremente
        private Director()
        {

        }

        //Metodo para obtener una sola instancia de la clase, aqui se esta aplicando el Singleton
        public static Director GetDirector()
        {
            if (director == null)
            {
                return new Director();
            }
            else
            {
                return director;
            }
        }

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
            Console.Write("Account: ");
            account = int.Parse(Console.ReadLine());
        }
        public double commission()
        {
            return salary * 0.2;
        }
        public double lifeSure()
        {
            return salary * 0.1;
        }
        public string payment()
        {
            return "Transferencia Bancaria";
        }

        //Impresion
        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nLast name: {lastName}\nTelephone: {telephone}\nSalary: {salary}\n" +
                $"Account: {account}";
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("*------EDUCATION SYSTEM------*\n");
            Console.WriteLine(ToString());
            Console.WriteLine($"Commission: {commission()}\nLife Sure: {lifeSure()}\nPayment: {payment()}");
        }
    }
}
