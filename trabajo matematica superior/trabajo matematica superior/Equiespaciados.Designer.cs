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
            this.label_h = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.continuar_equi = new System.Windows.Forms.Button();
            this.salir_equi = new System.Windows.Forms.Button();
            this.volver_equi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.Location = new System.Drawing.Point(248, 43);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(64, 13);
            this.label_h.TabIndex = 0;
            this.label_h.Text = "distancia (h)";
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(347, 43);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(56, 20);
            this.h.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "valor inicial";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 3;
            // 
            // continuar_equi
            // 
            this.continuar_equi.Location = new System.Drawing.Point(251, 223);
            this.continuar_equi.Name = "continuar_equi";
            this.continuar_equi.Size = new System.Drawing.Size(152, 49);
            this.continuar_equi.TabIndex = 4;
            this.continuar_equi.Text = "continuar";
            this.continuar_equi.UseVisualStyleBackColor = true;
            this.continuar_equi.Click += new System.EventHandler(this.continuar_equi_Click);
            // 
            // salir_equi
            // 
            this.salir_equi.Location = new System.Drawing.Point(450, 347);
            this.salir_equi.Name = "salir_equi";
            this.salir_equi.Size = new System.Drawing.Size(172, 53);
            this.salir_equi.TabIndex = 6;
            this.salir_equi.Text = "salir";
            this.salir_equi.UseVisualStyleBackColor = true;
            // 
            // volver_equi
            // 
            this.volver_equi.Location = new System.Drawing.Point(12, 347);
            this.volver_equi.Name = "volver_equi";
            this.volver_equi.Size = new System.Drawing.Size(172, 53);
            this.volver_equi.TabIndex = 7;
            this.volver_equi.Text = "volver a menu principal";
            this.volver_equi.UseVisualStyleBackColor = true;
            // 
            // Equiespaciados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.volver_equi);
            this.Controls.Add(this.salir_equi);
            this.Controls.Add(this.continuar_equi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label_h);
            this.Name = "Equiespaciados";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_h;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button continuar_equi;
        private System.Windows.Forms.Button salir_equi;
        private System.Windows.Forms.Button volver_equi;
    }
}