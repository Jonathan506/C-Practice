using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class clsAgenda
    {
        private const int TAM = 10;
        private clsContacto[] _contactos;
        private int _index;

        public int NumContactos
        {
            get
            {
                return _index;
            }
        }

        public clsAgenda()
        {
            _index = 0;
            _contactos = new clsContacto[TAM];
        }

        public void AgregarContacto(clsContacto contacto)
        {
            if (_index < TAM)
            {
                _contactos[_index] = contacto;
                _index++;
            }
            else
            {
                Console.WriteLine("Agenda Llena");
            }

        }

        public void BorrarUltimoContacto()
        {
            if (_index > 0)
            {
                _contactos[_index] = null;
                _index--; 
            }
            else
            {
                Console.WriteLine("No hay Contactos Existentes");
            }
        }

        private bool NoHayContactos() 
        {
            if (_index==0)
            {
                Console.WriteLine("No Hay Contactos");
                return true;
            }

            return false;
        }

        public void MostrarOrdenados()
        {
            if (NoHayContactos()) { return; }

            clsContacto[] ordenados = new clsContacto[_index];
            Array.Copy(_contactos, ordenados, _index);
            Array.Sort(ordenados);

            Console.WriteLine(Cadenacontactos(ordenados)); //ordenados
            Console.WriteLine(Cadenacontactos(ordenados));
        }

        public void MostrarContactosDesc()
        {
            if (NoHayContactos()) { return; }

            clsContacto[] ordenados = new clsContacto[_index];
            Array.Copy(_contactos, ordenados, _index);
            Array.Sort(ordenados);
            Array.Reverse(ordenados);

            Console.WriteLine(Cadenacontactos(ordenados)); //ordenados
        }

        public clsContacto BuscarPorNombre(string nombre) 
        {
            foreach (clsContacto contacto in _contactos)
            {
                if (contacto != null && contacto.Nombre == nombre )
                {
                    return contacto;
                }

            }

            return null;
        }

        public void MostrarContactos() 
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return Cadenacontactos(_contactos);
        }

        private string Cadenacontactos(clsContacto[] contactos) 
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _index; i++)
            {
                if (contactos[i] == null)
                {
                    continue;
                }
                string dato = string.Format("{0}. {1} ", i + 1, contactos[i]);
                sb.AppendLine(dato);
            }
            return sb.ToString();
        }
    }
}
