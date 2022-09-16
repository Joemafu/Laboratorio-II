using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05_01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Se deben completar los siguientes campos:");
                if (String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    sb.AppendLine("Nombre");
                }
                if (String.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    sb.AppendLine("Apellido");
                }
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmSecundario fs = new frmSecundario(this.Text, $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cmbMateria.Text}.");
                fs.ShowDialog(this);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            this.cmbMateria.Items.Add("Programación I");
            this.cmbMateria.Items.Add("Laboratorio I");
            this.cmbMateria.Items.Add("Matemática");
            this.cmbMateria.Items.Add("Inglés I");
            this.cmbMateria.Items.Add("Sistemas de procesamiento de datos");
            this.cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            this.cmbMateria.Items.Add("Programación II");
            this.cmbMateria.Items.Add("Laboratorio II");
            this.cmbMateria.Items.Add("Estadística");
            this.cmbMateria.Items.Add("Inglés II");
            this.cmbMateria.Items.Add("Metodología de la investigación");
            this.cmbMateria.SelectedItem = "Laboratorio II";
            this.cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
