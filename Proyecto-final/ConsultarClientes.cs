using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibreria;

namespace Proyecto_final 
{
    public partial class ConsultarClientes : Consultas
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGV("Clientes").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim())==false)
            {
                try
                {
                    DataSet ds;

                    string cmd = "Select *from Clientes where Nom_cli LIKE '%"+txtBuscar.Text.Trim()+"%'";
                    ds = Utilidades.ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un Error" + ex.Message);
                }
            }


        }
    }
}
