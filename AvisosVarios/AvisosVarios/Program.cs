using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            clsAvisoTrafico av1 = new clsAvisoTrafico();

            av1.mostrarAviso();
            Console.WriteLine();
            Console.WriteLine();

            clsAvisoTrafico av2 = new clsAvisoTrafico("Glen Rodriguéz", "Exceso de velocidad", "25/05/2022");
            Console.WriteLine();

            Console.WriteLine(av2.getFecha());
            av2.mostrarAviso();
        }
    }
}
