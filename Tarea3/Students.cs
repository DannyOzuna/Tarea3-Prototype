using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tarea3
{
    class Students: IActors, IClone
    {
        //Propiedades de la clase
        public Parents Parents { get; set; }
        public int Tuition { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        //Metodo de la clase
        public double lifeSure()
        {
            return 0.0;
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
            clon.Parents = new Parents();
            clon.Parents.Name = Parents.Name;
            clon.Parents.Telephone = Parents.Telephone;
            return clon;
        }

        //Impresion
        public override string ToString()
        {
            return $"Tuition: {Tuition}\n Name: {Name}\n Last name: {LastName}\n Age: {Age}" +
                $"Course: {Course}\n Parents: {Parents.Name}\n Telephone: {Parents.Telephone} ";
        }

    }
}
