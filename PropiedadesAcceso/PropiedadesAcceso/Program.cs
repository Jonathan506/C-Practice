using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleado jonathan = new clsEmpleado("Jonathan");

            //jonathan.setSalario(250000);
            //jonathan.getSalario();

            //Console.WriteLine($"El salario es de {jonathan.getSalario()}");

            //double nuevoSalario = jonathan.getSalario() + 50000;


            jonathan.Salario = 625000;
            jonathan.Salario += 100000;
            Console.WriteLine($"El salario de jonathan es de: {jonathan.Salario}");
        }
    }
}
