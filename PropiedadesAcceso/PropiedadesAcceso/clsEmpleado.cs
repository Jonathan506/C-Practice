using System;
using System.Collections.Generic;
using System.Text;

namespace PropiedadesAcceso
{
    class clsEmpleado
    {

        private string nombre;
        private double salario;


        ///***Propierties***//////
        ///
        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;                   
        }

        public double Salario 
        {
            //get {return this.salario;} 
            get => this.salario;

            //set {this.salario = evaluaSalario(value);} 
            set => this.salario = evaluaSalario(value);
        }

        public clsEmpleado(string nombre)
        {
            this.nombre = nombre;
        }

        //public void setSalario(double salario) 
        //{
        //    if (salario<0)
        //    {
        //        Console.WriteLine("El salario no puede ser un monto negativo, se asignará 0 como salario");

        //        this.salario =salario;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}

        //public double getSalario() 
        //{
        //    return salario;
        //}
    }
}