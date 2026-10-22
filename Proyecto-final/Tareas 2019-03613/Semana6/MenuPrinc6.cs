using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final 
{
    public partial class MenuPrinc6  : Form
    {
        public MenuPrinc6()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Salir cierro el formulario.
            Application.Exit();
        }

        private void btnReg_Prod_Click(object sender, EventArgs e)
        {
            FormProductos6 prod = new FormProductos6();
            this.Hide();
            prod.Show();
        }

        private void btnReg_Clien_Click(object sender, EventArgs e)
        {
            FormClientes6 cli = new FormClientes6();
            this.Hide();
            cli.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FormVentas6 vend = new FormVentas6();
            this.Hide();
            vend.Show();
        }
    }
}
