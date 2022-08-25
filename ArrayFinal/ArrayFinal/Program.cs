using System;

namespace ArrayFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el MAIN");
            foreach (int variable in arrayElementos) Console.WriteLine(variable);

            //PARTE 2 que sirve para el ejemplo 1 y 2
            
            //int[] numeros = new int[4];

            //numeros[0] = 14;
            //numeros[1] = 40;
            //numeros[2] = 48;
            //numeros[3] = 22;

            //ProcesaDatos(numeros);
        }
        //Array por parametros
        //PARTE 1                                                      ejemplo 1
        //static void ProcesaDatos(int[] datos) 
        //{
        //    foreach (int i in datos)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //                                                           //Ejemplo 2
        ////SI SE QUIERE MODIFICAR EL ARRAY SE TIENE QUE HACER CON UN FOR PORQUE EL FOREACH ES SOLO PARA RECORRERLO
        //  static void ProcesaDatos(int[] datos)
        //  {

        //      for(int i=0;i<4; i++)
        //      {
        //          datos[i] += 10;                       A los datos se les sumó 10
        //          Console.WriteLine(datos[i]);
        //      }
        //  }

        //     Ejemplo 3
        static int[] LeerDatos()
        {
            int numElementos;
            //try
            //{
            Console.WriteLine("Cuántos elementos quieres que tenga el Array?");
                numElementos = Convert.ToInt32(Console.ReadLine());
                
                int[] nombre = new int[numElementos];

                for (int i = 0; i < numElementos; i++)
                {
                    Console.WriteLine($"introduce el dato para la posición {i+1}");

                    int respuesta = Convert.ToInt32(Console.ReadLine());

                   nombre[i] = respuesta;
                }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Debes ingresar un valor de tipo numerico");
            //}
            return nombre;
        }
    }
}