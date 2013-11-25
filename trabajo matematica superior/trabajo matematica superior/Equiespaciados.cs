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
    public partial class Equiespaciados : Form
    {
        public Equiespaciados()
        {
            InitializeComponent();
        }

        private void h_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            VentanaPrincipal formVentanaPrincipal = new VentanaPrincipal();
            formVentanaPrincipal.Show();
            this.Close();
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void continuar_button_Click(object sender, EventArgs e)
        {
            int h = int.Parse(h_textBox.Text);
            ingreso_puntos formIngresoPuntos = new ingreso_puntos();
            formIngresoPuntos.set_h(h);
            formIngresoPuntos.Show();
            this.Hide();
        }

    }
}
