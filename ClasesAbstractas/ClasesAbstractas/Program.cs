using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleadosHonorarios eh = new clsEmpleadosHonorarios("Jonathan","Gerente", 15000);
            eh.Trabajar();
            Console.WriteLine("Salario por honorarios :{0}" , eh.Salario);

            clsEmpleadoNomina en = new clsEmpleadoNomina("Daniela","Propietaria",30000);
            en.Trabajar();
            Console.WriteLine("Salario por nomina : {0}", en    .Salario);
        }
    }
}
