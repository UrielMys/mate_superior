﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ingreso_puntos_Click(object sender, EventArgs e)
        {
            Equiespaciados formIngreso = new Equiespaciados();
            formIngreso.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
