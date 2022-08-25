using System;

namespace Genericos_Restricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<clsDirector> empleados = new AlmacenEmpleados<clsDirector>(2);
            empleados.agregar(new clsDirector(650000));
            empleados.agregar(new clsDirector(350000));

            AlmacenEmpleados<clsSecretaria> empleada = new AlmacenEmpleados<clsSecretaria>(1);
            empleados.agregar(new clsDirector(300000));

            AlmacenEmpleados<clsElectricista> electrico = new AlmacenEmpleados<clsElectricista>(1);
            empleados.agregar(new clsDirector(380000));


            /*Los tres objetos que se crearon anteriormente son de clases que heradan la interface que pide la 
             * clase GENÉRICA por lo que no hay error*/


            /*A continuación se intenta crear un objeto de una clase que no hereda la interface de Isalario*/


            AlmacenEmpleados<clsEstudiante> estudiante = new AlmacenEmpleados<clsEstudiante>(1);
            estudiante.agregar(new clsEstudiante(300000));

            /*Marca error porque la clase clsEstudiante no hereda la Interface Isalario*/
        }
    }

    /*Clase Genérica*/                 /*CON RESTRICCIONES*/

    class AlmacenEmpleados<T> where T: Isalario
    {
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void agregar(T obj) 
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T getEmpleado(int i) 
        {
            return datosEmpleado[i];
        }
        private int i = 0;
        private T[] datosEmpleado;
    }

    /*Clases*/
    class clsDirector : Isalario
    {
        public double getSalario()
        {
            return salario;
        }
        public clsDirector(double salario) 
        {
            this.salario = salario;
        }

        private double salario;
    }

    class clsSecretaria : Isalario
    {
        public double getSalario()
        {
            return salario;
        }
        public clsSecretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;
    }

    class clsElectricista : Isalario
    {
        public double getSalario()
        {
            return salario;
        }
        public clsElectricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;
    }
           /*Interface*/
    interface Isalario 
    {
        double getSalario();

    }

       /*Clase que no hereda la interface*/
    class clsEstudiante
    {
        public clsEstudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad() 
        {
            return edad;
        }
        private double edad;
        
    }
}
