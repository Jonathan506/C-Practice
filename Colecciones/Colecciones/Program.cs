using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();  /*Declaración de una Colection de tipo List*/

            //numeros.Add(23);
            //numeros.Add(15);
            //numeros.Add(33);

            int[] listaNumeros = new int[] {23,15,41,49,35};

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

                                                      /*Segundo Ejemplo*/

            List<int> nums = new List<int>();

            Console.WriteLine("Cuántos elementos desea introducir");

            int elementos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elementos; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine("Elementos Agregados");
            Console.WriteLine();

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
        }
    }
}
