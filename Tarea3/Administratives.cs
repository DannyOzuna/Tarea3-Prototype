using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Administratives: IActors
    {
        //Propiedades de la clase
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }

        //Metodos de la clase
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
            return Salary * 0.1;
        }

        //Impresion
        public override string ToString()
        {
            return $"Id: {Id}\n Name: {Name}\n Last name: {LastName}\n Telephone: {Telephone}\n Salary: {Salary}\n " +
                $"Position: {Position}";
        }
    }
}
