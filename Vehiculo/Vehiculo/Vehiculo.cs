using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class Vehiculo
    {
        public void ArrancarMotor() 
        {
            Console.WriteLine("Encendiendo el motor");
        }

        public void PararMotor() 
        {
            Console.WriteLine("El motor se detiene");
        }

        public virtual void Conducir() 
        {
            Console.WriteLine("Conduciendo");
        }
    }
}
