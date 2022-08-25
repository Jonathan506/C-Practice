using System;

namespace MenuCalculos
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:

            Console.WriteLine("                               Menú de Operaciones");
            Console.WriteLine();
            Console.WriteLine();
            int opc = 0;

            Console.WriteLine(" 1.   Cálculo de los factores del 1 al 10 de un número dado");
            Console.WriteLine();
            Console.WriteLine(" 2.   Cálculo de la sumatoria de dos números");
            Console.WriteLine();
            Console.WriteLine(" 3.   Cálculo de un número para saber si es primo o no");
            Console.WriteLine();
            Console.WriteLine(" 4.   Terminar Cálculo");
            Console.WriteLine();

            opc = Convert.ToInt32(Console.ReadLine());

            //do
            //{
                switch (opc)
                {
                    case 1:
                    Console.WriteLine("Introduzca un número para conocer sus factores");
                    Console.WriteLine();
                    int valor = 1;
                        valor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Los factores del número {0} son :", valor);
                    Console.WriteLine();
                    for (int i = 1; i <= 10; i++)
                        {
                            if (valor%i==0)
                            {     
                                Console.WriteLine(i);
                            }
                        }
                    break;

                    case 2:
                        int num1 = 0, num2 = 0;

                        Console.WriteLine("Introduzca el primer valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Introduzca el segundo valor");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("La suma de los dos valores es de : {0}", num1 + num2);
                    Console.WriteLine();
                    break;

                    case 3:
                    Console.WriteLine("Introduzca un valor numerico para calcular si es o no primo");
                    int valor2 = 3;
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    EsPrimo(valor2);
                    
                    break;

                    case 4:
                        Console.WriteLine("Saliendo del menú");
                        break;

                    default:
                        Console.WriteLine("Valor no especificado");
                        break;
                }
            //} while (opc!=4);
            
            goto inicio;

            static void EsPrimo(int numero)
            {
                int c = 0;
                for (int i = 1; i < (numero+1); i++)
                {
                    if (numero % i == 0)
                    {
                        c++;                     
                    }
                }
                if (c!=2) Console.WriteLine("El número que indicó no es primo");

                else Console.WriteLine("{0} es primo", numero);

            }
        }
    }
}
