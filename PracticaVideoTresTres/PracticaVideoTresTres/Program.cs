using System;

namespace PracticaVideoTresTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);

            double distancia = origen.Distancia(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia} ");

            Console.WriteLine($"El valor de la variable static es de: {Punto.ContadorDeObjetos()}");

        }
    }
}
