namespace WindowsFormsApplication1
{
    partial class Polinomio
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
            this.salir_poli = new System.Windows.Forms.Button();
            this.volver_poli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progresivo = new System.Windows.Forms.TextBox();
            this.regresivo = new System.Windows.Forms.TextBox();
            this.agregar_punto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salir_poli
            // 
            this.salir_poli.Location = new System.Drawing.Point(450, 347);
            this.salir_poli.Name = "salir_poli";
            this.salir_poli.Size = new System.Drawing.Size(172, 53);
            this.salir_poli.TabIndex = 8;
            this.salir_poli.Text = "salir";
            this.salir_poli.UseVisualStyleBackColor = true;
            // 
            // volver_poli
            // 
            this.volver_poli.Location = new System.Drawing.Point(12, 347);
            this.volver_poli.Name = "volver_poli";
            this.volver_poli.Size = new System.Drawing.Size(172, 53);
            this.volver_poli.TabIndex = 9;
            this.volver_poli.Text = "volver al menu principal";
            this.volver_poli.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "progresivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "regresivo:";
            // 
            // progresivo
            // 
            this.progresivo.Location = new System.Drawing.Point(170, 102);
            this.progresivo.Name = "progresivo";
            this.progresivo.Size = new System.Drawing.Size(367, 20);
            this.progresivo.TabIndex = 12;
            // 
            // regresivo
            // 
            this.regresivo.Location = new System.Drawing.Point(170, 180);
            this.regresivo.Name = "regresivo";
            this.regresivo.Size = new System.Drawing.Size(367, 20);
            this.regresivo.TabIndex = 13;
            // 
            // agregar_punto
            // 
            this.agregar_punto.Location = new System.Drawing.Point(231, 243);
            this.agregar_punto.Name = "agregar_punto";
            this.agregar_punto.Size = new System.Drawing.Size(172, 53);
            this.agregar_punto.TabIndex = 14;
            this.agregar_punto.Text = "agregar punto";
            this.agregar_punto.UseVisualStyleBackColor = true;
            this.agregar_punto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Polinomio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.agregar_punto);
            this.Controls.Add(this.regresivo);
            this.Controls.Add(this.progresivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volver_poli);
            this.Controls.Add(this.salir_poli);
            this.Name = "Polinomio";
            this.Text = "Polinomio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir_poli;
        private System.Windows.Forms.Button volver_poli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox progresivo;
        private System.Windows.Forms.TextBox regresivo;
        private System.Windows.Forms.Button agregar_punto;
    }
}