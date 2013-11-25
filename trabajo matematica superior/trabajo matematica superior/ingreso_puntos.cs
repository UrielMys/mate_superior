using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ingreso_puntos : Form
    {
        Tabla unaTabla;
        public ingreso_puntos()
        {
            InitializeComponent();
            this.set_cantPuntos(0);
            unaTabla = new Tabla();
        }

        private void calcular_equi_Click(object sender, EventArgs e)
        {
            Polinomio formPolinomio = new Polinomio(unaTabla);
            formPolinomio.Show();
            this.Close();
        }

        private void set_cantPuntos(int cantidadDePuntos) 
        {
            this.cantPuntos_label.Text = cantidadDePuntos.ToString();
        }

        public void set_h(int h) 
        {
            valor_h_label.Text = h.ToString();
        }

        private void ingresarPunto_button_Click(object sender, EventArgs e)
        {
            float puntoX = float.Parse(posX_textBox.Text);
            float puntoY = float.Parse(posY_textBox.Text);
            Punto unPunto = new Punto();
            unPunto.set_x(puntoX);
            unPunto.set_y(puntoY);
            unaTabla.agregar_punto(unPunto);
            this.set_cantPuntos(unaTabla.get_puntos().Count);
            this.posX_textBox.Text = "";
            this.posY_textBox.Text = "";
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void volverEquiespaciado_button_Click(object sender, EventArgs e)
        {
            Equiespaciados formEquiespaciados = new Equiespaciados();
            formEquiespaciados.Show();
            this.Close();
        }

    }
}
