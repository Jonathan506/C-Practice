using System;

namespace LanzamientosExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Introduce el número del mes que desees");

            int numeroMes =1;

            do
            {
                try
                {
                    // Console.WriteLine(NombreDelMes(int.Parse(Console.ReadLine())));

                    numeroMes = int.Parse(Console.ReadLine());
                    Console.WriteLine(NombreDelMes(numeroMes));
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    Console.WriteLine("Introduce un número comprendido entre el 1 y el 12");
                }
            } while (numeroMes>12 || numeroMes == 0);

        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return " Enero ";
                case 2:
                    return " Febrero ";
                case 3:
                    return " Marzo ";
                case 4:
                    return " Abril ";
                case 5:
                    return " Mayo ";
                case 6:
                    return " Junio ";
                case 7:
                    return " Julio ";
                case 8:
                    return " Agosto ";
                case 9:
                    return " Séptiembre ";
                case 10:
                    return " Octubre ";
                case 11:
                    return " Noviembre ";
                case 12:
                    return " Diciembre ";
                default:
                   throw new ArgumentOutOfRangeException();      //throw es lanzar.
                    //esta execption es para cuando se introduce un valor fuera de los rangos definidos
            } 
        }
    }
}
