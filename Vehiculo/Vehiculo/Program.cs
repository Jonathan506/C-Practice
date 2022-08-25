using System;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo objeto1 = new Vehiculo();
            Avion objeto2 = new Avion();
            Coche objeto3 = new Coche();

            Console.WriteLine("Probando el Coche");
            objeto3.Conducir();

            Console.WriteLine();

            Console.WriteLine("Probando el avión");

            objeto2.ArrancarMotor();
            objeto2.Despegar();
            objeto2.Conducir();
            objeto2.Aterrizar();
            objeto2.PararMotor();
        }
    }
}
