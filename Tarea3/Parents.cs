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
        public int Telephone { get; set; }
        public double Salary { get; set; }
        public int Account { get; set; }

        //Metodos de la clase
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
        public override string ToString()
        {
            return $"Identification: {Indentification}\n Name: {Name}\n Last name: {LastName}\n Telephone: {Telephone}\n Salary: {Salary}\n " +
                $"Account: {Account}";
        }
    }
}
