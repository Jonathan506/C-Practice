using System;

namespace CalculoCosto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule el costo de construir una casa

            //El programa pedirá el total de habitaciones y las dimensiones de cada una
            //El costo por m2 de habitación es de $300 con impuesto de 5%
            //El costo por m2 de cocina  y sanitario es de $375 com impuesto del 12%
            //El costo por m2 de jardín es de $120 com impuesto de 0%

            double granTotal = 0.0;
            int numHabitaciones = 0;
            double area = 0.0;
            double costoHabitacion = 0.0;

            Console.WriteLine("Ingrese la cantidad de habitaciones");
            numHabitaciones = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numHabitaciones; i++)
            {
                area = CalcularArea();

                Console.WriteLine("¿Qué tipo es?  1. Habitación  2. Cocina  3. Jardín");
                int tipo = Convert.ToInt32(Console.ReadLine());

                if (tipo ==1)
                {
                    costoHabitacion = CalcularCosto(area,300.0,0.05);
                }
                if (tipo == 2)
                {
                    costoHabitacion = CalcularCosto(area, 375.0, 0.12);
                }
                if (tipo == 3)
                {
                    costoHabitacion = CalcularCosto(area, 120.0, 0.0);
                }


                granTotal += costoHabitacion;
            }

            Console.WriteLine($"El costo total de la obra es de: {granTotal}");
        }

        public static double CalcularArea() 
        {
            double area = 0.0;
            double ancho = 0.0;
            double largo = 0.0;

            Console.WriteLine("Ingrese el ancho de la habitación");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el largo de la habitación");
            largo = Convert.ToInt32(Console.ReadLine());

            area = ancho * largo;

            return area;
        }

        public static double CalcularCosto(double area, double pM2, double impuesto) 
        {
            double costo = 0.0;
            double imp = 0.0;
            double total = 0.0;

            costo = area * pM2;
            imp = costo * impuesto;
            total = costo + imp;

            return total;
        }
    }
}
