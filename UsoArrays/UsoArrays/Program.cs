using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] edades = new int[4];


            //edades[0] = 15;
            //edades[1] = 27;
            //edades[2] = 19;
            //edades[3] = 80;
            //// 0 es el valor por defecto.

            //Console.WriteLine(edades[2]);

            //Array Implicito
            var datos = new[] {"Jonathan", "Blandón", "Costa Rica" };
            var numeros = new[] { 2, 5, 2.2, 3.5, 9.6 };

            //Array  de objetos
            Empleado[] arrayEmpleado =new Empleado[3];
            arrayEmpleado[0] = new Empleado("Jonathan",22);

            Empleado ana = new Empleado("Ana", 22); 
            arrayEmpleado[1] = ana;

            arrayEmpleado[2] = new Empleado("Pedro", 15);

            for (int i = 0; i < arrayEmpleado.Length; i++)
            {
                Console.WriteLine(arrayEmpleado[i].getInfo());
            }

            //Console.WriteLine(arrayEmpleado[0]);
            //Console.WriteLine(arrayEmpleado[1]);

            //Arrays de clases o tipos anonimos
            var persona = new[] {

              new{nombre="Martha", edad=40 }, /*[0]*/
              new{nombre="Martha", edad=49 }, /*[1]*/
              new{nombre="Martha", edad=14 }  /*[2]*/
            };
            //Console.WriteLine(persona[1]);

            for (int i = 0;i <numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

    }
    public class Empleado
    {
        public Empleado(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo()
        {
            return  "El nombre es " + nombre + " Su edad es de: " + edad;
        }

        private string nombre;
        private int edad;
    }
}