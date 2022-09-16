using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio05_Biblioteca;

namespace Ejercicio05_02
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.lstPais.Items.Add("Argentina");
            this.lstPais.Items.Add("Chile");
            this.lstPais.Items.Add("Uruguay");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string genero = "No especificado";
            string[] cursos = new string[3];
            int i=0;

            foreach(RadioButton item in grpGenero.Controls)
            {
                if (item.Checked)
                {
                    genero = item.Text;
                    item.Checked = false;
                }
            }

            foreach (CheckBox item in grpCursos.Controls)
            {
                if(item.Checked)
                {
                    cursos[i] = item.Text;
                    item.Checked = false;
                    i++;
                }
            }

            if(!String.IsNullOrWhiteSpace(this.txtNombre.Text) && !String.IsNullOrWhiteSpace(this.txtDireccion.Text) && this.lstPais.SelectedItem is not null)
            {
                Ingresante ingresante = new Ingresante(this.txtNombre.Text, this.txtDireccion.Text, genero, this.lstPais.SelectedItem.ToString(), cursos, (int)nbrEdad.Value);

                this.txtNombre.Text = "";
                this.txtDireccion.Text = "";
                this.nbrEdad.Value = 0;
                this.lstPais.SelectedItem = null;

                MessageBox.Show(ingresante.Mostrar());

            }
        }
    }
}
