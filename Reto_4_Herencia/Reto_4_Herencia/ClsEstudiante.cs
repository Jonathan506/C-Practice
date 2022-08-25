using System;
using System.Collections.Generic;
using System.Text;

namespace Reto_4_Herencia
{
    class ClsEstudiante: ClsPersona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public ClsEstudiante() {}

        public ClsEstudiante(double promedio, string grado, string nombre, int edad):base(nombre, edad)
        {
            this.Promedio = promedio;
            this.Grado = grado;
        }

        public void Estudiar() 
        {
            Console.WriteLine("Es hora de estudiar para {0}, del grado {1} ", Nombre, Grado);
        }

        public void IrAClase() 
        {
            Console.WriteLine("{0} es hora de entrar a clases ", Nombre);
        }

        public override void Saludar()
        {
            Console.WriteLine("{0} es el mejor alumno y está saludando al público ", Nombre);
        }

        public override string ToString()
        {
            return string.Format("{0} es el mejor estudiante del grado: {1}, con un promedio de :{2} y con tan solo {3} años", Nombre, Grado ,Promedio, Edad );
        }
    }
}
