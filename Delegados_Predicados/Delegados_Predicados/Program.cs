using System;
using System.Collections.Generic;

namespace Delegados_Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaNumeros = new List<int>();

            ListaNumeros.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10}); /*Esto me permite agregar un rango de valores*/


            //Declaramos delegado predicado
            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            List<int> numPares = ListaNumeros.FindAll(elDelegadoPred);

            foreach (int num in numPares)
            {
                Console.WriteLine(num);
            }
        }

        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
    }
}
