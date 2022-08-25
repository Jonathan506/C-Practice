using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Destructores
{
    class clsManejodeArchivos
    {
        StreamReader archivo = null;
        int contador = 0;

        string linea;

        public clsManejodeArchivos() 
        {
            archivo = new StreamReader(@"C:\Users\Jonathan\Desktop\Ejercicios C#\Destructores\Texto.txt");

            while ((linea = archivo.ReadLine()) != null) 
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void mensaje() 
        {
            Console.WriteLine("Hay {0} lineas ", contador);
        }

        ~clsManejodeArchivos() 
        {
            archivo.Close();
        }
    }
}
