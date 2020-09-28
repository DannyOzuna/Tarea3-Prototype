using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Teachers: IActors
    {
        //Propiedades de la clase
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Telephone { get; set; }
        public double Salary { get; set; }
        public string Subject { get; set; }

        //Metodos de la clase
        public string Teaching()
        {
            return "Software Developer";
        }
        public double lifeSure()
        {
            return Salary * 0.3;
        }
        public string payment()
        {
            return "Cheque";
        }

        //Impresion
        public override string ToString()
        {
            return $"Id: {Id}\n Name: {Name}\n Last name: {LastName}\n Telephone: {Telephone}\n Salary: {Salary}\n " +
                $"Subject: {Subject}";
        }
    }
}
