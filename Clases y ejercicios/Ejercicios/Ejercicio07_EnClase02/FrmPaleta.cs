﻿using System;
using System.Windows.Forms;
using Ejercicio07_Biblioteca;
//agregar using a las entidades


namespace Ejercicio07_EnClase02
{
    public partial class FrmPaleta : Form
    {
        private Paleta paleta;
        public FrmPaleta()
        {
            InitializeComponent();

            this.paleta = 3;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //con getter
                //this.paleta += frm.ObtenerTempera();
                //con propiedad
                this.paleta += frm.TemperaDelForm;

                this.txtVisor.Clear();
                this.txtVisor.Text = (string)this.paleta;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            FrmTempera frm = new FrmTempera();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //con getter
                //this.paleta -= frm.ObtenerTempera();
                //con propiedad
                this.paleta -= frm.TemperaDelForm;

                this.txtVisor.Clear();
                this.txtVisor.Text = (string)this.paleta;
            }
        }
    }
}
