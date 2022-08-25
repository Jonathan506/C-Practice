using System;
using System.Collections.Generic;
using System.Text;

namespace Genericos
{
    class clsEmpleado
    {
        public clsEmpleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario() 
        {
            return salario;
        }

        private double salario;
    }
}
