using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class Avion:Vehiculo
    {
        public void Aterrizar() 
        {
            Console.WriteLine("Aterrizando");
        }

        public void Despegar() => Console.WriteLine("Despegando");

        public override void Conducir()
        {
            Console.WriteLine("El avión se está piloteando");
        }
    }
}
