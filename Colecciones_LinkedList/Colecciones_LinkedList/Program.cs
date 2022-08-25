using System;
using System.Collections.Generic;

namespace Colecciones_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] {10,8,6,4,2,0})
            {
                numeros.AddFirst(numero);
            }

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
