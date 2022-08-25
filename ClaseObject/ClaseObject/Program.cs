using System;

namespace ClaseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            clsPersona p1 = new clsPersona("Jonathan",23);
            clsPersona p2 = new clsPersona("Jonathan", 23);
            clsPersona p3 = p1;

            //Compración por referencia 
            Console.WriteLine("Referencias p1 y p2 son iguales: ");
            Console.WriteLine(p1==p2);

            Console.WriteLine("Referencias p2 y p3 son iguales: ");
            Console.WriteLine(p2 == p3);

            Console.WriteLine("Referencias p1 y p3 son iguales: ");
            Console.WriteLine(p1 == p3);


            Console.WriteLine("Comparación entre objetos");
            Console.WriteLine("Referencias p1 y p2 son iguales: ");
            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine("Referencias p2 y p3 son iguales: ");
            Console.WriteLine(p2.Equals(p3));

            Console.WriteLine("Referencias p1 y p3 son iguales: ");
            Console.WriteLine(p1.Equals(p3));
        }
    }
}
