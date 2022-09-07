using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Agenda
{
    class clsContacto : IComparable<clsContacto>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public clsContacto()
        {

        }
        public clsContacto(string nombre, string telefono, string email)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Email = email;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            clsContacto c = obj as clsContacto;

            if (c == null)
            {
                return false;
            }

            return string.Equals(Nombre, c.Nombre) && string.Equals(Telefono, c.Telefono); 
        }

        public override int GetHashCode()
        {
            int hashNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
            int hashTelefono = (Telefono != null ? Telefono.GetHashCode() : 0);
            return (hashNombre * 397) ^ (hashTelefono);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}\nEmail: {1}\nTeléfono: {2}\n", Nombre, Email, Telefono);
        }

        public int CompareTo(clsContacto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }
}
