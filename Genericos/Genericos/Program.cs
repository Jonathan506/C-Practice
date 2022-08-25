using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //clsAlmacenaObjetos archivos = new clsAlmacenaObjetos(4);
            clsAlmacenaObjetos<clsEmpleado> archivos = new clsAlmacenaObjetos<clsEmpleado>(4);

            //archivos.agregar("Denis");
            //archivos.agregar("Martha");
            //archivos.agregar("Daniela");
            //archivos.agregar("Jonathan");


            //Console.WriteLine(archivos.getElemento(0));
            //Console.WriteLine(archivos.getElemento(1));
            //Console.WriteLine(archivos.getElemento(2));
            //Console.WriteLine(archivos.getElemento(3));


            /*OTRA FORMA DE OBTENER LOS DATOS*/
            /*Se realiza una conversión explicita ya que el tipo de dato guardado es de tipo OBJECT*/
            //string obtenerNombres = (string)archivos.getElemento(1);
            //Console.WriteLine(obtenerNombres);




            //clsAlmacenaObjetos files = new clsAlmacenaObjetos(4);

            archivos.agregar(new clsEmpleado(1000));
            archivos.agregar(new clsEmpleado(1500));
            archivos.agregar(new clsEmpleado(2000));
            archivos.agregar(new clsEmpleado(2500));

             /*Con una clase de tipo GENÉRICA se evitan estar realizadon las conversiones(Casteo)*/
            clsEmpleado salarioEmpleado = archivos.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());
        }
    }
}
