using System;

namespace ImplementacionDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = 4;
            int resultado1 = Cuadrado(numA);
            int resultado2 = Cuadrado(12);
            int resultado3 = Cuadrado(resultado1*3);
            Console.WriteLine(resultado3);
        }

        public static int Cuadrado(int l) 
        {
            return l*l;
        }
    }
}
