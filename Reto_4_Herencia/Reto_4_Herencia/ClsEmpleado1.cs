using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_4_Herencia
{
    class ClsEmpleado1: ClsPersona
    {
        public String Puesto { get; set; }
        public decimal Sueldo { get; set; }

        public ClsEmpleado1(string nombre, int edad, string puesto, decimal sueldo):base(nombre, edad)
        {
            this.Puesto = puesto;
            this.Sueldo = sueldo;
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola, soy {0} y mi puesto es {1}", Nombre, Puesto);
        }

        public void trabajar() 
        {
            Console.WriteLine("{0} esta trabajando... ", Nombre);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años, {2}, sueldo ${3}", Nombre, Edad, Puesto, Sueldo);
        }
    }
}
