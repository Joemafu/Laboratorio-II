using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06_EnClase04
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lstListar.Items.Add(int.Parse(txtIngresar.Text));
            txtIngresar.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rBtnDescendente.Checked||rBtnAscendente.Checked)
            {
                List<int> aux = new List<int>();
                foreach (int item in lstListar.Items)
                {
                    aux.Add(item);
                }
                aux.Sort();
                if(rBtnDescendente.Checked)
                {
                    aux.Reverse();
                }
                lstListar.Items.Clear();
                foreach (int item in aux)
                {
                    lstListar.Items.Add(item);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is TextBox)
                        {
                            ((TextBox)control2).Text = "";
                            continue;
                        }
                        if (control2 is RadioButton)
                        {
                            ((RadioButton)control2).Checked = false;
                            continue;
                        }
                        if (control2 is ListBox)
                        {
                            ((ListBox)control2).Items.Clear();
                        }
                    }
                }
            }
        }
    }
}
