using System;

namespace Delegados1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación del objeto delegado apuntando a MensajeBienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            //Utilización del delegado para llamar al método SaludoBienvenida
            ElDelegado();


            /************///Ahora apuntamos al otro método de la otra clase
            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado();
        }

        //definición del objeto delegado según la estructura de los métodos a llamar
        delegate void ObjetoDelegado();
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida() 
        {
            Console.WriteLine("Método saludar");
        }    
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Método de despedida");
        }
    }
}
