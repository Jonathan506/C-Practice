using System;
using System.Collections.Generic;
using System.Text;

namespace Structs_y_Enum
{
    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 }   /*enum*/

    class  /*struct*/ Empleado
    {
        private double salarioBase, comision;
        /*private Bonus bonusEmpleado;*/

        public Empleado(Bonus bonusEmpleado, double salarioBase) 
        {
            /*this.bonusEmpleado=bonusEmpleado;*/
            comision = (double)bonusEmpleado;
            this.salarioBase = salarioBase;
        }

        public double getSalario() 
        {
            return salarioBase + comision; /*(double)bonusEmpleado;*/
        }
                                                                       ////////*******Ejemplo de las structs******////

        //public Empleado(int salarioBase, int comision)
        //{   
        //    this.salarioBase = salarioBase;
        //    this.comision = comision;
        //}

        //public override string ToString()
        //{
        //    return string.Format("Salario y comision del empleado ({0},{1})", this.salarioBase, this.comision);
        //}

        //public void cambioSalario(Empleado emp, double incremento)
        //{
        //    emp.salarioBase += incremento;
        //    emp.comision += incremento;
        //}
    }
}
