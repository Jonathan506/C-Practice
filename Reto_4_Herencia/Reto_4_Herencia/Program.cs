using System;

namespace Reto_4_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona p = new ClsPersona("Jonathan", 23);
            p.Saludar();

            ClsEmpleado1 e = new ClsEmpleado1("Dennis", 48, "Soldador", 350000);
            e.Saludar();
            e.trabajar();

            /*Metodo ToString*/
            Console.WriteLine(e);

            ClsEstudiante est = new ClsEstudiante( 95.8, "Quinto año", "Jonathan", 23);

            est.Estudiar();
            est.IrAClase();
            est.Saludar();
            Console.WriteLine(est);
        }
    }
}
