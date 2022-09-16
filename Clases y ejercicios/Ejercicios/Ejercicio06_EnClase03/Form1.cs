using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06_EnClase03
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(this.txtImporte.Text);

            if (i>=5000)
            {
                this.txtDescuento.Text = (i * 0.2).ToString();
                this.txtTotal.Text = (i * 0.8).ToString();
            }
            else if (i>=3000)
            {
                this.txtDescuento.Text = (i * 0.1).ToString();
                this.txtTotal.Text = (i * 0.9).ToString();
            }
            else
            {
                this.txtDescuento.Text = ("0");
                this.txtTotal.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in grpInfo.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = "";
                }
            }
        }
    }
}
