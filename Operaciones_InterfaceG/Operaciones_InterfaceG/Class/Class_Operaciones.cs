using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones_InterfaceG.Class
{
    class Class_Operaciones:Class_Datos
    {
        public void sumar() 
        {
            resultado = numero1 + numero2;
        }

        public void restar()
        {
            resultado = numero1 - numero2;
        }
        public void multiplicar()
        {
            resultado = numero1 * numero2;
        }

        public void dividir()
        {
            resultado = numero1 / numero2;
        }
    }
}
