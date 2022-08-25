using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    abstract class clsEmpleado
    {
        public String Nombre { get; set; }
        public String Puesto { get; set; }

        public abstract Decimal Salario { get; }

        public clsEmpleado(String nombre, String puesto) 
        {
            this.Nombre = nombre;
            this.Puesto = puesto;
        }

        public void Saludar() 
        {
            Console.WriteLine("Método de la clase empleado");
        }

        public abstract void Trabajar();

    }
}
