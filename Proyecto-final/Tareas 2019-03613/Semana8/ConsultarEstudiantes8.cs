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
    public partial class ConsultarEstudiantes8 : Form
    {
        public ConsultarEstudiantes8()
        {
            InitializeComponent();
        }

        private void ConsultarEstudiantes_Load(object sender, EventArgs e)
        {
          try
            {
                DataSet ds = new DataSet();
                string sql = "Exec Llenardatagrid";
                ds= Conectar8.Ejecutar(sql);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string bus = string.Format ("Exec ConsultarEstudiantes '%"+ txtnombre.Text + "%'");
                ds = Conectar8.Ejecutar(bus);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
