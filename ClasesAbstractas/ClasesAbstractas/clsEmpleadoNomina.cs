using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class clsEmpleadoNomina: clsEmpleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario
        {
            get
            {
                return SueldoBase;
            }

        }

        public clsEmpleadoNomina(string nombre, string puesto, decimal sueldobase) : base(nombre, puesto)
        {
            this.SueldoBase = sueldobase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por Nomina");
        }
    }
}
