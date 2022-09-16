using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06_EnClase02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir de la aplicación?", "Atención!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Clear();
            this.lstTabla.Items.Clear();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar==(char)Keys.Enter)
            {
                string numeroIngresado = this.txtNumero.Text;
                int entero = int.Parse(numeroIngresado);

                int i;
                lstTabla.Items.Clear();
                for (i=1;i<11;i++)
                {
                    this.lstTabla.Items.Add($"{entero} * {i} = {entero * i}");
                }
            }
        }
    }
}
