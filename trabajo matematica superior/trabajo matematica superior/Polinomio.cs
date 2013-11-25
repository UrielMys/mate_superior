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

        public Polinomio (Tabla tabla)
        {
            InitializeComponent();
            this.polProgresivo = new Pol(tabla.posiciones_en_x_progresivas(),tabla.coeficientes_progresivos());
            this.progresivo_textBox.Text = this.polProgresivo.construir_polinomio().ToString();
            this.polRegresivo = new Pol(tabla.pusiciones_en_x_regresivas(),tabla.coeficientes_regresivos());
            this.regresivo_textBox.Text = this.polRegresivo.construir_polinomio().ToString();
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

        private void boton_evaluacion_Click(object sender, EventArgs e)
        {
            Evaluacion_Polinomio ev_pol = new Evaluacion_Polinomio(polProgresivo, polRegresivo);
            ev_pol.Show();
            this.Close();
        }
    }
}
