using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agenda de Contactos");
            Console.WriteLine();

            Console.WriteLine("1. Ver Contactos");
            Console.WriteLine("2. Agregar Nuevo Contacto");
            Console.WriteLine("3. Borrar Último Contacto");
            Console.WriteLine("4. Buscar Contacto");
            Console.WriteLine("5. Salir");

            int opc=0;
            bool op = true;

            try
            {
                opc = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Opción No Registrada try");
            }

            do
            {
                switch (opc)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Saliendo de la Agenda");
                        break;

                    default:
                        Console.WriteLine("Opción No Registrada");
                        break;
                }
            } while (opc > 1 && opc >=5 );

            Console.WriteLine();
            Console.WriteLine("Sistema Finalizado");
        }
    }
}
