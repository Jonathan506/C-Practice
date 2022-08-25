using System;
using System.Reflection;

namespace EdadCarnet
{
    class Program
    {
        static void Main(string[] args)
        {

            inicio:
            try
            {
                int edad = 18;

                Console.WriteLine(" Introduzca su edad ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine(" ¿Tiene licencia? ");
                    string carnet = Console.ReadLine();
                    Console.WriteLine();

                    while (carnet != "si" && carnet != "no")
                    {
                        Console.WriteLine("¿Tienes licencia de conducir si o no?");
                        carnet = Console.ReadLine();
                        Console.WriteLine();
                    }
                    if (carnet == "si") Console.WriteLine(" Tienes permiso de conducir ");
                    else Console.WriteLine(" No tienes derecho para conducir por falta de licencia ");
                    Console.WriteLine();
                }
                else Console.WriteLine(" No tiene derecho a conducir por ser menor de edad ");
                     Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Se necesita un valor numerico, por favor introduzca su edad");
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Presiona cualquier tecla para volver a comenzar");
                Console.ReadKey();
                Console.Clear();            
            }
            goto inicio;
        }
    }
}