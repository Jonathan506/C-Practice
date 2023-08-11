
namespace Operaciones_InterfaceG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Número1 = new System.Windows.Forms.TextBox();
            this.txt_Número2 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_Multiplicacion = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // txt_Número1
            // 
            this.txt_Número1.Location = new System.Drawing.Point(206, 63);
            this.txt_Número1.Name = "txt_Número1";
            this.txt_Número1.Size = new System.Drawing.Size(40, 23);
            this.txt_Número1.TabIndex = 3;
            this.txt_Número1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Número2
            // 
            this.txt_Número2.Location = new System.Drawing.Point(206, 117);
            this.txt_Número2.Name = "txt_Número2";
            this.txt_Número2.Size = new System.Drawing.Size(40, 23);
            this.txt_Número2.TabIndex = 4;
            this.txt_Número2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(206, 173);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(40, 23);
            this.txt_Resultado.TabIndex = 5;
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Suma
            // 
            this.btn_Suma.Location = new System.Drawing.Point(66, 265);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(75, 23);
            this.btn_Suma.TabIndex = 6;
            this.btn_Suma.Text = "Suma";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Location = new System.Drawing.Point(147, 265);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(75, 23);
            this.btn_Resta.TabIndex = 7;
            this.btn_Resta.Text = "Resta";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_Multiplicacion
            // 
            this.btn_Multiplicacion.Location = new System.Drawing.Point(228, 265);
            this.btn_Multiplicacion.Name = "btn_Multiplicacion";
            this.btn_Multiplicacion.Size = new System.Drawing.Size(100, 23);
            this.btn_Multiplicacion.TabIndex = 8;
            this.btn_Multiplicacion.Text = "Multiplicación";
            this.btn_Multiplicacion.UseVisualStyleBackColor = true;
            this.btn_Multiplicacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(334, 265);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(75, 23);
            this.btn_Division.TabIndex = 9;
            this.btn_Division.Text = "División";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(334, 121);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 376);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Multiplicacion);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Número2);
            this.Controls.Add(this.txt_Número1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Número1;
        private System.Windows.Forms.TextBox txt_Número2;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Multiplicacion;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_clear;
    }
}

