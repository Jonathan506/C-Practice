using System;

namespace Triangulo_de_Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int[1];
            Console.WriteLine("Ingrese el número de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= pisos; i++)
            {
                int[] pascal = new int[i];
                for (int j = pisos; j <= i; j--)
                {
                    Console.Write("");
                }
                for (int k = 0; k < i; k++)
                {
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else 
                    {
                        pascal[k] = arreglo[k] + arreglo[k-1];   
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
        }
    }
}
