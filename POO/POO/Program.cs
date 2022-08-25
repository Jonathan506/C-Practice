using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();

            Console.WriteLine($"El área del circulo es: "+ miCirculo.calculoArea(5));


            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.cambioValorEuro(1.45);

            Console.WriteLine(obj.convierte(50));

        }
    }

    class Circulo 
    {
       const double pi = 3.1416;

       public double calculoArea(double radio) 
       {
            //return pi * radio * radio;
            return pi * (System.Math.Pow(radio, 2));
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambioValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;
            else
            euro = nuevoValor;        
        }
    }
}
