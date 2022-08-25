using System;

namespace Reto3ArrayCalificacionesPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de calificaciones para conocer su promedio");
            int calificaciones = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[calificaciones];
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Ingrese el valor de la califición {0} :", i+1);
                notas[i] = Int32.Parse(Console.ReadLine());

                suma += notas[i];
            }

            double promedio = suma/calificaciones;
            Console.WriteLine("Su promedio es de : {0}", promedio);
        }
    }
}
