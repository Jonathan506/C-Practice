using System;

namespace TablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa muestra las tablas de multiplicar según el número indicado");
            Console.WriteLine();
            Console.WriteLine("Digite un número del 1 al 12 para visualizar la respectiva tabla de valores");

            int num = Int32.Parse(Console.ReadLine());

            if (num > 0 && num < 13)
            {
                for (int i = 1; i <= 12; i++)
                {
                    int tabla = i * num;
                    Console.WriteLine(num + " * " + i + " = " + tabla );
                }
            }
            else {
                Console.WriteLine("El valor proporcionado está fuera del rango de valores establecido");
            }
        }
    }
}
