using System;

namespace TablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            int num  = 1;

            Console.WriteLine("Este programa muestra las tablas de multiplicar según el número indicado");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Digite un número del 1 al 12 para visualizar la respectiva tabla de valores");

                num = Int32.Parse(Console.ReadLine());

                TablaMulti(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("El valor debe ser un dato númerico");
            }
            finally
            {
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            goto inicio;

            void TablaMulti(int Num) 
            {
                if (Num > 0 && Num < 13)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        int tabla = i * Num;
                        Console.WriteLine(Num + " * " + i + " = " + tabla);
                    }
                }
                else
                {
                    Console.WriteLine("El valor proporcionado está fuera del rango de valores establecido");
                }
            }

        }
    }
}
