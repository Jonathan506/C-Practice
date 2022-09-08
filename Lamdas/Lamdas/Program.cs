using System;

namespace Lamdas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso del delegado Lamda, presindimos de las funciones

            OperacionesMatematicas operacion = new OperacionesMatematicas(/*Cuadrado*/ num => num*num);//Con la expresión Lambda se reducirá el código
            Console.WriteLine(operacion(4));


            OperacionMatematica operacion2 = new OperacionMatematica(/*Suma*/ (num1, num2) => num1 + num2); //cuando son dos parametros estos van entre parentesis
            Console.WriteLine(operacion2(5,3));
        }



        //public static int Cuadrado(int num) 
        //{
        //    return num * num;
        //}
        public delegate int OperacionesMatematicas(int numero);
                                                                     //CON DOS PARAMETROS /****/
        //public static int Suma(int num1, int num2) 
        //{
        //    return num1 + num2;
        //}
        public delegate int OperacionMatematica(int numero1, int numero2);
    }
}
