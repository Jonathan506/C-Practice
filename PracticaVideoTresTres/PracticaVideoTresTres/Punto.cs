using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaVideoTresTres
{
    class Punto
    {
        public Punto(int x, int y) 
        {
            //Console.WriteLine($"Coordenadas x: {x}, coordenadas y:{y} ");
            this.x = x;
            this.y = y;
            contadorObjetos++;
        }
        public Punto() 
        {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }
        public double Distancia(Punto otroPunto) 
        {
            int xdif = this.x - otroPunto.x;
            int ydif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xdif,2)+Math.Pow(ydif,2));
            return distanciaPuntos;
        }
        //este metodo es para usar la variable de tipo static de la clase
        public static int ContadorDeObjetos() => contadorObjetos;


        private int x;
        private int y;
        //Esta variable de tipo estatica es solo modificable desde la clase.contadorObjeto y no desde un objeto instanciado
        //Puede servir como un contador general utilizandola con un metodo estatico o no 
        private static int contadorObjetos=0;
    }
   
}
