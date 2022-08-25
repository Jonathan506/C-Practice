using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_4_Herencia
{
    class ClsPersona
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }

        public ClsPersona() {}

        public ClsPersona(string nombre, int edad )
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public virtual void Saludar() 
        {
            Console.WriteLine("Hola mi nombre es : {0}", this.Nombre);
        }

        public override string ToString()
        {
            return string.Format(" {0}, {1} años ", this.Nombre, this.Edad);
        }
    }
}
