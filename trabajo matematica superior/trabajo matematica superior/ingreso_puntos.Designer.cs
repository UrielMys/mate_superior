namespace WindowsFormsApplication1
{
    public partial class ingreso_puntos
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
            this.salir_button = new System.Windows.Forms.Button();
            this.volverEquiespaciado_button = new System.Windows.Forms.Button();
            this.calcularPolinomio_button = new System.Windows.Forms.Button();
            this.posY_label = new System.Windows.Forms.Label();
            this.posY_textBox = new System.Windows.Forms.TextBox();
            this.posX_label = new System.Windows.Forms.Label();
            this.posX_textBox = new System.Windows.Forms.TextBox();
            this.ingresarPunto_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_h_label = new System.Windows.Forms.Label();
            this.cantPuntos_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salir_button
            // 
            this.salir_button.Location = new System.Drawing.Point(450, 347);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(172, 53);
            this.salir_button.TabIndex = 7;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // volverEquiespaciado_button
            // 
            this.volverEquiespaciado_button.Location = new System.Drawing.Point(12, 347);
            this.volverEquiespaciado_button.Name = "volverEquiespaciado_button";
            this.volverEquiespaciado_button.Size = new System.Drawing.Size(172, 53);
            this.volverEquiespaciado_button.TabIndex = 8;
            this.volverEquiespaciado_button.Text = "Volver";
            this.volverEquiespaciado_button.UseVisualStyleBackColor = true;
            this.volverEquiespaciado_button.Click += new System.EventHandler(this.volverEquiespaciado_button_Click);
            // 
            // calcularPolinomio_button
            // 
            this.calcularPolinomio_button.Location = new System.Drawing.Point(231, 347);
            this.calcularPolinomio_button.Name = "calcularPolinomio_button";
            this.calcularPolinomio_button.Size = new System.Drawing.Size(172, 53);
            this.calcularPolinomio_button.TabIndex = 9;
            this.calcularPolinomio_button.Text = "Calcular polinomio";
            this.calcularPolinomio_button.UseVisualStyleBackColor = true;
            this.calcularPolinomio_button.Click += new System.EventHandler(this.calcular_equi_Click);
            // 
            // posY_label
            // 
            this.posY_label.AutoSize = true;
            this.posY_label.Location = new System.Drawing.Point(228, 124);
            this.posY_label.Name = "posY_label";
            this.posY_label.Size = new System.Drawing.Size(70, 13);
            this.posY_label.TabIndex = 10;
            this.posY_label.Text = "Posicion en y";
            // 
            // posY_textBox
            // 
            this.posY_textBox.Location = new System.Drawing.Point(332, 121);
            this.posY_textBox.Name = "posY_textBox";
            this.posY_textBox.Size = new System.Drawing.Size(71, 20);
            this.posY_textBox.TabIndex = 11;
            // 
            // posX_label
            // 
            this.posX_label.AutoSize = true;
            this.posX_label.Location = new System.Drawing.Point(228, 77);
            this.posX_label.Name = "posX_label";
            this.posX_label.Size = new System.Drawing.Size(70, 13);
            this.posX_label.TabIndex = 12;
            this.posX_label.Text = "Posicion en x";
            // 
            // posX_textBox
            // 
            this.posX_textBox.Location = new System.Drawing.Point(332, 77);
            this.posX_textBox.Name = "posX_textBox";
            this.posX_textBox.Size = new System.Drawing.Size(71, 20);
            this.posX_textBox.TabIndex = 13;
            // 
            // ingresarPunto_button
            // 
            this.ingresarPunto_button.Location = new System.Drawing.Point(231, 197);
            this.ingresarPunto_button.Name = "ingresarPunto_button";
            this.ingresarPunto_button.Size = new System.Drawing.Size(172, 53);
            this.ingresarPunto_button.TabIndex = 14;
            this.ingresarPunto_button.Text = "Ingresar punto";
            this.ingresarPunto_button.UseVisualStyleBackColor = true;
            this.ingresarPunto_button.Click += new System.EventHandler(this.ingresarPunto_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "h:";
            // 
            // valor_h_label
            // 
            this.valor_h_label.AutoSize = true;
            this.valor_h_label.Location = new System.Drawing.Point(368, 163);
            this.valor_h_label.Name = "valor_h_label";
            this.valor_h_label.Size = new System.Drawing.Size(51, 13);
            this.valor_h_label.TabIndex = 16;
            this.valor_h_label.Text = "Distancia";
            // 
            // cantPuntos_label
            // 
            this.cantPuntos_label.AutoSize = true;
            this.cantPuntos_label.Location = new System.Drawing.Point(573, 22);
            this.cantPuntos_label.Name = "cantPuntos_label";
            this.cantPuntos_label.Size = new System.Drawing.Size(99, 13);
            this.cantPuntos_label.TabIndex = 18;
            this.cantPuntos_label.Text = "Cantidad de puntos";

            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(465, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 13);
            this.label.TabIndex = 17;
            this.label.Text = "Cantidad de puntos:";
            // 
            // ingreso_puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.cantPuntos_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.valor_h_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingresarPunto_button);
            this.Controls.Add(this.posX_textBox);
            this.Controls.Add(this.posX_label);
            this.Controls.Add(this.posY_textBox);
            this.Controls.Add(this.posY_label);
            this.Controls.Add(this.calcularPolinomio_button);
            this.Controls.Add(this.volverEquiespaciado_button);
            this.Controls.Add(this.salir_button);
            this.Name = "ingreso_puntos";
            this.Text = "Ingresar puntos equiespaciados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.Button volverEquiespaciado_button;
        private System.Windows.Forms.Button calcularPolinomio_button;
        private System.Windows.Forms.Label posY_label;
        private System.Windows.Forms.TextBox posY_textBox;
        private System.Windows.Forms.Label posX_label;
        private System.Windows.Forms.TextBox posX_textBox;
        private System.Windows.Forms.Button ingresarPunto_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valor_h_label;
        private System.Windows.Forms.Label cantPuntos_label;
        private System.Windows.Forms.Label label;
    }
}