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

                if (nota1 > 5 && nota2 > 5 && nota3 > 5)
                {
                    int promedio = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine(" Felicidades su promedio es de {0}", promedio);
                    Console.WriteLine();
                }
                else
                {
                    if (nota1 <= 5 && nota2 <= 5 && nota3 <= 5) Console.WriteLine("Usted se encuentra completamente aplazado");

                    else if (nota1 <= 5) Console.WriteLine("  Usted está aplazado, la nota del primer parcial es insuficiente ");

                    else if (nota2 <= 5) Console.WriteLine(" Usted está aplazado, la nota del segudo parcial es insuficiente ");

                    else Console.WriteLine(" Usted está aplazado, la nota del tercer parcial es insuficiente ");

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