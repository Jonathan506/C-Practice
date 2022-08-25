using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseObject
{
    class clsPersona
    {
        public string Nombre  { get; set; }
        public  int Edad { get; set; }

        public clsPersona(string nombre, int edad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public override bool Equals(object obj)                                 /*Metodo EQUALS */
        {
            if (obj==null)
            {
                return false;
            }

            clsPersona p = obj as clsPersona;

            if (p == null)
            {
                return false;
            }
            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }
        /*HASCODE  */
        /*SI SOBREESCRIBO UN METODO TENGO QUE SOBREESCRIBIR EL OTRO*/
        public override int GetHashCode()
        {
            int has = 17;
            has = (has * 7) + Nombre.GetHashCode();
            has = (has * 7) + Edad.GetHashCode();

            return has;
        }
    }
}
