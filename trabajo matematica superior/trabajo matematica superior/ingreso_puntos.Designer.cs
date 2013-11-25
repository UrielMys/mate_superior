namespace WindowsFormsApplication1
{
    partial class ingreso_puntos
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
            this.salir_equi = new System.Windows.Forms.Button();
            this.volver_ing_equi = new System.Windows.Forms.Button();
            this.calcular_equi = new System.Windows.Forms.Button();
            this.pos_y_label = new System.Windows.Forms.Label();
            this.pos_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pos_x = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_h_label = new System.Windows.Forms.Label();
            this.cant_puntos_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salir_equi
            // 
            this.salir_equi.Location = new System.Drawing.Point(450, 347);
            this.salir_equi.Name = "salir_equi";
            this.salir_equi.Size = new System.Drawing.Size(172, 53);
            this.salir_equi.TabIndex = 7;
            this.salir_equi.Text = "salir";
            this.salir_equi.UseVisualStyleBackColor = true;
            // 
            // volver_ing_equi
            // 
            this.volver_ing_equi.Location = new System.Drawing.Point(12, 347);
            this.volver_ing_equi.Name = "volver_ing_equi";
            this.volver_ing_equi.Size = new System.Drawing.Size(172, 53);
            this.volver_ing_equi.TabIndex = 8;
            this.volver_ing_equi.Text = "volver a menu principal";
            this.volver_ing_equi.UseVisualStyleBackColor = true;
            // 
            // calcular_equi
            // 
            this.calcular_equi.Location = new System.Drawing.Point(231, 347);
            this.calcular_equi.Name = "calcular_equi";
            this.calcular_equi.Size = new System.Drawing.Size(172, 53);
            this.calcular_equi.TabIndex = 9;
            this.calcular_equi.Text = "calcular polinomio";
            this.calcular_equi.UseVisualStyleBackColor = true;
            this.calcular_equi.Click += new System.EventHandler(this.calcular_equi_Click);
            // 
            // pos_y_label
            // 
            this.pos_y_label.AutoSize = true;
            this.pos_y_label.Location = new System.Drawing.Point(228, 124);
            this.pos_y_label.Name = "pos_y_label";
            this.pos_y_label.Size = new System.Drawing.Size(69, 13);
            this.pos_y_label.TabIndex = 10;
            this.pos_y_label.Text = "posicion en y";
            // 
            // pos_y
            // 
            this.pos_y.Location = new System.Drawing.Point(332, 121);
            this.pos_y.Name = "pos_y";
            this.pos_y.Size = new System.Drawing.Size(71, 20);
            this.pos_y.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "posicion en x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pos_x
            // 
            this.pos_x.Location = new System.Drawing.Point(332, 77);
            this.pos_x.Name = "pos_x";
            this.pos_x.Size = new System.Drawing.Size(71, 20);
            this.pos_x.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "ingresar otro punto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.valor_h_label.Size = new System.Drawing.Size(35, 13);
            this.valor_h_label.TabIndex = 16;
            this.valor_h_label.Text = "label3";
            // 
            // cant_puntos_label
            // 
            this.cant_puntos_label.AutoSize = true;
            this.cant_puntos_label.Location = new System.Drawing.Point(573, 22);
            this.cant_puntos_label.Name = "cant_puntos_label";
            this.cant_puntos_label.Size = new System.Drawing.Size(35, 13);
            this.cant_puntos_label.TabIndex = 18;
            this.cant_puntos_label.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "cantidad puntos:";
            // 
            // ingreso_puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.cant_puntos_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valor_h_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pos_x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pos_y);
            this.Controls.Add(this.pos_y_label);
            this.Controls.Add(this.calcular_equi);
            this.Controls.Add(this.volver_ing_equi);
            this.Controls.Add(this.salir_equi);
            this.Name = "ingreso_puntos";
            this.Text = "ingreso_puntos_equiespaciados";
            this.Load += new System.EventHandler(this.ingreso_puntos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir_equi;
        private System.Windows.Forms.Button volver_ing_equi;
        private System.Windows.Forms.Button calcular_equi;
        private System.Windows.Forms.Label pos_y_label;
        private System.Windows.Forms.TextBox pos_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pos_x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valor_h_label;
        private System.Windows.Forms.Label cant_puntos_label;
        private System.Windows.Forms.Label label4;
    }
}