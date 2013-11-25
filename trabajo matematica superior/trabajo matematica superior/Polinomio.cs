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
    public partial class Polinomio : Form
    {
        private Pol polRegresivo;
        private Pol polProgresivo;

        public Polinomio(List<float> coeficientes_regres, List<float> coeficientes_progres)
        {
            InitializeComponent();
            this.polRegresivo = new Pol();
            this.polProgresivo = new Pol();
            this.polRegresivo.set_coeficientes(coeficientes_regres);
            this.polProgresivo.set_coeficientes(coeficientes_progres);
            this.regresivo_textBox.Text = this.polRegresivo.construir_polinomio().ToString();
            this.progresivo_textBox.Text = this.polProgresivo.construir_polinomio().ToString();
        }

        private void agregar_punto_Click(object sender, EventArgs e)
        {
            ingreso_puntos formIngresoPuntos = new ingreso_puntos();
            formIngresoPuntos.Show();
            this.Close();
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            VentanaPrincipal formVentanaPrincipal = new VentanaPrincipal();
            this.Close();
            formVentanaPrincipal.Show();
        }
    }
}
