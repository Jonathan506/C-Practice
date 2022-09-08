using System;
using System.Collections.Generic;

namespace Lamdas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Jonathan";
            p1.Edad = 23;

            Persona p2 = new Persona();
            p2.Nombre = "Daniela";
            p2.Edad = 35;

            /*Usar Delegado con la expresión Lamda*/
            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));



            /********************Conocer si hay numeros pares en la lista************************/

            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            //foreach (int pares in numerosPares)
            //{
            //    Console.WriteLine(pares);
            //}
        }

        public delegate bool ComparaPersonas(int edad1, int edad2);
    }

    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
