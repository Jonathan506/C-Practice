using System;

namespace Reto2
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPersona persona1 = new clsPersona("Jonathan", "Blandón", 23);
            clsPersona persona2 = new clsPersona("Martha", "Paniagua", 41);

            persona1.Saludar();
            persona2.Saludar();

            Console.WriteLine(persona1);
        }
    }
}
