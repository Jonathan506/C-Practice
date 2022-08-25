using System;

namespace ArrayObject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Object de clase*/
            Object[] parametros = { "Jonathan", 23, true };
            new Program().metodo(parametros);
        }

        private void metodo(Object[] parametros) 
        { 
          string nombre = (string)parametros[0];
            int edad = (int)parametros[1];
            bool valor=(bool)parametros[2];
        }
    }
}
