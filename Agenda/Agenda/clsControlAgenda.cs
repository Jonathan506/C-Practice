using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class clsControlAgenda
    {
        private clsAgenda _agenda;

        public clsControlAgenda(clsAgenda agenda)
        {
            this._agenda = agenda;
        }

        public void VerContactos() 
        {
            Limpiar();
            MostrarMenu();
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ver contactos en orden ascendente");
                    _agenda.MostrarContactos();
                    break;

                case "2":
                    Console.WriteLine("Ver contactos en orden descente");
                    _agenda.MostrarContactosDesc();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
            PresioneParaContinuar();
        }

        public void AgregarContacto() 
        {
            Limpiar();

            Console.WriteLine("Nuevo Contacto");

            clsContacto contacto = new clsContacto();

            Console.WriteLine("Nombre: ");
            contacto.Nombre = Console.ReadLine();

            Console.WriteLine("Teléfono: ");
            contacto.Telefono = Console.ReadLine();

            Console.WriteLine("Email: ");
            contacto.Email = Console.ReadLine();

            _agenda.AgregarContacto(contacto);
            Console.WriteLine("Contacto agregado exitosamente");

            PresioneParaContinuar();
        }

        public void BorrarUltimoContacto() 
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            Console.WriteLine("Contacto borrado exitosamente");
            PresioneParaContinuar();
        }

        public void BuscarPorNombre() 
        {
            Limpiar();
            Console.WriteLine("Buscar Contacto");
            Console.Write("");
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            clsContacto contacto = _agenda.BuscarPorNombre(nombre);

            if (contacto != null)
            {
                Console.WriteLine("Datos: " + contacto);
            }
            else 
            {
                Console.WriteLine("Contacto no encontrado");
            }

            PresioneParaContinuar();

        }

        public void AcercaDe() 
        {
            Limpiar();
            Console.WriteLine("Jonathan Blandón Paniagua");
            PresioneParaContinuar();
        }

        public void MostrarMenu() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 Mostrar contactos en orden ascendente");
            sb.AppendLine("2 Mostrar contactos en orden descendente");
            sb.AppendLine("3 Volver al menú principal");
            sb.Append("Seleccione una opción: ");

            Console.Write(sb.ToString());
        }

        private static void PresioneParaContinuar() 
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        private static void Limpiar() 
        {
            Console.Clear();
        }
    }
}
