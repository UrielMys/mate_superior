﻿namespace WindowsFormsApplication1
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ingreso_puntos = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingreso_puntos
            // 
            this.ingreso_puntos.Location = new System.Drawing.Point(234, 136);
            this.ingreso_puntos.Name = "ingreso_puntos";
            this.ingreso_puntos.Size = new System.Drawing.Size(172, 53);
            this.ingreso_puntos.TabIndex = 1;
            this.ingreso_puntos.Text = "Ingresar puntos";
            this.ingreso_puntos.UseVisualStyleBackColor = true;
            this.ingreso_puntos.Click += new System.EventHandler(this.ingreso_puntos_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(450, 347);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(172, 53);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculo de polinomios interpolantes";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.ingreso_puntos);
            this.Name = "VentanaPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingreso_puntos;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
    }
}