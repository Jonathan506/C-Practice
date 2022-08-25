using System;
using System.Collections.Generic;

namespace Collections_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //Agregando elementos a la Cola

            foreach (int item in new int[5] {2,4,6,8,10})
            {
                numeros.Enqueue(item);
            }


            Console.WriteLine("Recorriendo la Cola");

            foreach (int item2 in numeros)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("Eliminando elementos de la Cola");

            numeros.Dequeue();

            foreach (int item2 in numeros)
            {
                Console.WriteLine(item2);
            }
        }
    }
}
