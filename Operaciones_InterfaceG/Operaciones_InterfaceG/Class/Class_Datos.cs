using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones_InterfaceG.Class
{
    class Class_Datos
    {
        internal double numero1;
        internal double numero2;
        internal double resultado;

        public double primer_valor
        {
            set 
            {
                numero1 = value;
            }
        
        }

        public double segundo_valor
        {
            set
            {
                numero2 = value;
            }

        }

        public double resultados
        {
            get
            {
                return resultado;
            }

        }

        //public void suma() 
        //{
        //    resultado = numero1 + numero2;
        //}
    }
}
