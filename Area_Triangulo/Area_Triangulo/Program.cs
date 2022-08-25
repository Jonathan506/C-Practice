using System;

namespace Area_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"  /\");
            Console.WriteLine(@" /  \");
            Console.WriteLine(@"/____\");
            double trianguloBase=0;
            double trianguloAltura=0;
            bool estado = true;

            Console.WriteLine("Introduzca el valor de la base de su triangulo");
            do
            {
                try
                {
                    trianguloBase = double.Parse(Console.ReadLine());
                    estado = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorrecto, por favor ingrese la base de su triangulo");
                    Console.WriteLine();
                }
            } while (estado==true);

            Console.WriteLine("Introduzca el valor de la altura de su triangulo");
            estado = true;
            do
            {
                try
                {

                    trianguloAltura = double.Parse(Console.ReadLine());
                    estado = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorrecto, por favor ingrese la altura de su triangulo");
                    Console.WriteLine();
                }

            } while (estado==true);


            Console.WriteLine($"El área del triangulo es de: {CalculoArea(trianguloBase,trianguloAltura)}");
        }

        public static double CalculoArea(double tBase, double tAltura)
        {
            double calculoArea = (tBase * tAltura) / 2;

            return calculoArea;
        }
    }
}
