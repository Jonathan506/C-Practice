using System;
using System.Collections.Generic;

namespace Collections_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <int> numeros = new Stack <int>();

            /*Agregando Elemetos al Stack*/
                
            foreach (int numero in new int[5] {1,2,3,4,5})
            {
                numeros.Push(numero);
            }

            //Recorriendo el Stack
            Console.WriteLine("Recorriendo los elementos del Stack");
            Console.WriteLine();
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elemetos del Stack
            Console.WriteLine("Eliminando elementos del Stack");
            Console.WriteLine();

            numeros.Pop();

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
