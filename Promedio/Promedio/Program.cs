    using System;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:

            Console.WriteLine("Introduzca valores comprendidos entre 0 y 10 según su nota obtenida");
            Console.WriteLine();

            int nota1 = 1;
            int nota2 = 1;
            int nota3 = 1;
            try
            {
                Console.WriteLine("Introduzca la nota del primer parcial");
                Console.WriteLine();
                nota1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca la nota del segundo parcial");
                Console.WriteLine();
                nota2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca la nota del tercer parcial");
                Console.WriteLine();
                nota3 = Int32.Parse(Console.ReadLine());

                int promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio < 65)
                {
                    Console.WriteLine(" Aplazado, promedio insuficiente ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Felicidades, su promedio es de: {0} ", promedio);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datos invalidos");
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            goto inicio;
        }
    }
}