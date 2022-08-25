using System;
using System.Collections.Generic;
using System.Text;

namespace Genericos
{
    class clsAlmacenaObjetos <T>
    {
        public clsAlmacenaObjetos(int z) 
        {
            datosElementos = new T/*object*/[z];
        }

        public void agregar( T /*object*/ obj) 
        {
            datosElementos[i] = obj;
            i++;
        }

        public T /*Object*/ getElemento(int i)
        {
            return datosElementos[i];
        }

        private T/*object*/[] datosElementos;
        private int i = 0; 
    }
}
