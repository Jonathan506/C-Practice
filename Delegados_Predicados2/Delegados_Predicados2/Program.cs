using System;
using System.Collections.Generic;

namespace Delegados_Predicados2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El delegado comprobará si en una lista hay alguien que se llame Jonathan*/


            List<Personas> gente = new List<Personas>(); /*Creamos una lista*/

            Personas p1 = new Personas(); /*Instanciamos y creamos un objeto para darle valor a los campos de clase*/

            p1.Nombre = "Jonathan";
            p1.Edad = 23;

            Personas p2 = new Personas(); 

            p2.Nombre = "Daniela";
            p2.Edad = 16;

            Personas p3 = new Personas(); 

            p3.Nombre = "Martha";
            p3.Edad = 41;


            //Ahora agregaremos los 3 objetos a la lista 
            gente.AddRange(new Personas[] {p1,p2,p3 });

            //Creación del Delegado Predicado
            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJonathan);

            bool existe = gente.Exists(elPredicado);

            if (existe) Console.WriteLine("Si hay personas que se llamen Jonathan");
            else Console.WriteLine("No hay nadie con ese nombre");

        }

        static bool ExisteJonathan(Personas persona) 
        {
            if (persona.Nombre == "Jonathan") return true;
            else return false;
        }
    }


    class Personas 
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
