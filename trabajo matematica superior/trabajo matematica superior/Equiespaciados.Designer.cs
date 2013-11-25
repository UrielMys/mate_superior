namespace WindowsFormsApplication1
{
    partial class Equiespaciados
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
            this.h_label = new System.Windows.Forms.Label();
            this.h_textBox = new System.Windows.Forms.TextBox();
            this.valorInicial_label = new System.Windows.Forms.Label();
            this.valorInicial_textBox = new System.Windows.Forms.TextBox();
            this.continuar_button = new System.Windows.Forms.Button();
            this.salir_button = new System.Windows.Forms.Button();
            this.volver_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.Location = new System.Drawing.Point(248, 43);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(66, 13);
            this.h_label.TabIndex = 0;
            this.h_label.Text = "Distancia (h)";
            // 
            // h_textBox
            // 
            this.h_textBox.Location = new System.Drawing.Point(347, 43);
            this.h_textBox.Name = "h_textBox";
            this.h_textBox.Size = new System.Drawing.Size(56, 20);
            this.h_textBox.TabIndex = 1;
            this.h_textBox.TextChanged += new System.EventHandler(this.h_textBox_TextChanged);
            // 
            // valorInicial_label
            // 
            this.valorInicial_label.AutoSize = true;
            this.valorInicial_label.Location = new System.Drawing.Point(248, 115);
            this.valorInicial_label.Name = "valorInicial_label";
            this.valorInicial_label.Size = new System.Drawing.Size(60, 13);
            this.valorInicial_label.TabIndex = 2;
            this.valorInicial_label.Text = "Valor inicial";
            // 
            // valorInicial_textBox
            // 
            this.valorInicial_textBox.Location = new System.Drawing.Point(347, 112);
            this.valorInicial_textBox.Name = "valorInicial_textBox";
            this.valorInicial_textBox.Size = new System.Drawing.Size(56, 20);
            this.valorInicial_textBox.TabIndex = 3;
            // 
            // continuar_button
            // 
            this.continuar_button.Location = new System.Drawing.Point(251, 223);
            this.continuar_button.Name = "continuar_button";
            this.continuar_button.Size = new System.Drawing.Size(152, 49);
            this.continuar_button.TabIndex = 4;
            this.continuar_button.Text = "Continuar";
            this.continuar_button.UseVisualStyleBackColor = true;
            this.continuar_button.Click += new System.EventHandler(this.continuar_button_Click);
            // 
            // salir_button
            // 
            this.salir_button.Location = new System.Drawing.Point(450, 347);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(172, 53);
            this.salir_button.TabIndex = 6;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // volver_button
            // 
            this.volver_button.Location = new System.Drawing.Point(12, 347);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(172, 53);
            this.volver_button.TabIndex = 7;
            this.volver_button.Text = "Volver al menu principal";
            this.volver_button.UseVisualStyleBackColor = true;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // Equiespaciados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.volver_button);
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.continuar_button);
            this.Controls.Add(this.valorInicial_textBox);
            this.Controls.Add(this.valorInicial_label);
            this.Controls.Add(this.h_textBox);
            this.Controls.Add(this.h_label);
            this.Name = "Equiespaciados";
            this.Text = "Ingresar distancia y valor inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label h_label;
        private System.Windows.Forms.TextBox h_textBox;
        private System.Windows.Forms.Label valorInicial_label;
        private System.Windows.Forms.TextBox valorInicial_textBox;
        private System.Windows.Forms.Button continuar_button;
        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.Button volver_button;
    }
}