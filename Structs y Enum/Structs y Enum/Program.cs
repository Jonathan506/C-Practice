using System;

namespace Structs_y_Enum
{
    class Program
    {
        //enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 }     /*Ejemplo del bonus sin clase*/

        /*ENUMS  y suelen declararse en los namespace*/

        //enum Estaciones {Primavera, Verano, Otoño, Invierno};     /*Ejemplo enum de las estaciones del año*/

        static void Main(string[] args)
        {
            //Empleado empleado1 = new Empleado(1200 , 250);                       /*********/
                                                                          /***Primer ejemplo de structs*/
            //empleado1.cambioSalario(empleado1, 100);                             /*********/    

            //Console.WriteLine(empleado1);



            //Estaciones alergia = Estaciones.Invierno
            //Console.WriteLine(alergia);                                  /*Ejemplo enum de las estaciones*/


            //Bonus jonathan = Bonus.extra;

            //double bonoEmpleado = (double)jonathan;        /************Ejemplo del bonus sin clase*********/

            //Console.WriteLine(jonathan);
            //Console.WriteLine(bonoEmpleado);

            Empleado Daniela = new Empleado(Bonus.bueno, 650000);

            Console.WriteLine(Daniela.getSalario());
        }
    }
}
 