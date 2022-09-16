using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06_EnClase
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblSaludo.Visible = true;
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            this.Text = "Saludo desde un Form";
            this.lblSaludo.Visible = false;
        }
    }
}
