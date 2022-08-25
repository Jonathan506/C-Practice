using System;
using System.Collections.Generic;
using System.Text;

namespace Reto2
{
    class clsPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int _edad; 

        public int Edad
        {
            get { return _edad; }
            set 
            {
                if (value < 0)
                {
                    _edad = 0;
                }
                else 
                {
                    _edad = value;
                }
            }
        }

        public clsPersona(string nombre)
        {
            this.Nombre = nombre;
        }

        public clsPersona(string nombre, string apellido): this(nombre) 
        {
            this.Apellido = apellido;
        }

        public clsPersona(string nombre, string apellido, int edad) :this(nombre, apellido)
        {
            this.Edad = edad;
        }

        public clsPersona() { }

        public void Saludar() 
        {
            Console.WriteLine("Hola mi nombre es: {0} {1}", Nombre, Apellido);
        }

        public override string ToString()
        {
            return string.Format("Nombre : {0}, apellido : {1}, edad : {2}", Nombre, Apellido, Edad);
        }
    }
}
