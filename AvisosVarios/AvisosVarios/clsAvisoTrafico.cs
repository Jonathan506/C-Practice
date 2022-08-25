using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    class clsAvisoTrafico: IAvisos
    {
                                                 /*Constructores*/
        public clsAvisoTrafico()
        {
            remitente = "Oficial de Transito";
            mensaje = "Sanción cometida, Pague antes de tres días al plazo estipulado para evitar cargos en el monto final";
            fecha = "";
        }

        public clsAvisoTrafico(string Remitente, string Mensaje, String Fecha)
        {
            this.remitente = Remitente;
            this.mensaje = Mensaje;
            this.fecha = Fecha;
        }
                                          /*Interfaces*/
        public void mostrarAviso() 
        {
            Console.WriteLine("Mensaje: {0} ha sido enviado por: {1} el día: {2}", mensaje, remitente, fecha);
        }

        public string getFecha() 
        {
            return fecha;
        }


        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
