using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones_InterfaceG.Class;

namespace Operaciones_InterfaceG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class_Operaciones obj_operaciones = new Class_Operaciones();

        private void button3_Click(object sender, EventArgs e)
        {
            obj_operaciones.numero1 = double.Parse(txt_Número1.Text);
            obj_operaciones.numero2 = double.Parse(txt_Número2.Text);

            obj_operaciones.multiplicar();

            txt_Resultado.Text = obj_operaciones.resultados + "";
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            obj_operaciones.numero1 = double.Parse(txt_Número1.Text);
            obj_operaciones.numero2 = double.Parse(txt_Número2.Text);

            obj_operaciones.sumar();

            txt_Resultado.Text = obj_operaciones.resultados + "";
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            obj_operaciones.numero1 = double.Parse(txt_Número1.Text);
            obj_operaciones.numero2 = double.Parse(txt_Número2.Text);

            obj_operaciones.restar();

            txt_Resultado.Text = obj_operaciones.resultados + "";
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            obj_operaciones.numero1 = double.Parse(txt_Número1.Text);
            obj_operaciones.numero2 = double.Parse(txt_Número2.Text);

            obj_operaciones.dividir();

            txt_Resultado.Text = obj_operaciones.resultados + "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Número1.Clear();
            txt_Número2.Clear();
            txt_Resultado.Clear();
        }
    }
}
