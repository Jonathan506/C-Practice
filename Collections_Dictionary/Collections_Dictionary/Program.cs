using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //Agregando elementos al Dictionary

            edades.Add("Jonathan", 23);
            edades.Add("Daniela", 35);
            edades.Add("Martha", 41);
            edades.Add("Dany", 16);
            edades.Add("Denis", 50);

            edades["Joseph"] = 24;

            //Recorriendo el Dictionary
            Console.WriteLine("Recorriendo el Dictionary");
            Console.WriteLine();

            foreach (KeyValuePair<string, int> item in edades)
            {
                //Console.WriteLine(item);
                Console.WriteLine("Nombre: {0} edad: {1} ", item.Key,item.Value );
            }
        }
    }
}
