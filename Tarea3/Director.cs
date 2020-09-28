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
        private Director director = null;

        //Propiedades de la clase
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        public double Salary { get; set; }
        public int Account { get; set; }

        //Constructor de la clase, privado para que no se pueda tener una instancia de la clase libremente
        private Director()
        {

        }

        //Metodo para obtener una sola instancia de la clase, aqui se esta aplicando el Singleton
        public Director GetDirector()
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
        public double commission()
        {
            return Salary * 0.2;
        }
        public double lifeSure()
        {
            return Salary * 0.1;
        }
        public string payment()
        {
            return "Transferencia Bancaria";
        }

        //Impresion
        public override string ToString()
        {
            return $"Id: {Id}\n Name: {Name}\n Last name: {LastName}\n Telephone: {Telephone}\n Salary: {Salary}\n " +
                $"Account: {Account}";
        }
    }
}
