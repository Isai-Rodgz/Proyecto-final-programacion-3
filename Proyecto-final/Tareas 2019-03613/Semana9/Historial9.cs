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
    public partial class Historial9 : Form
    {
        public Historial9()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Articulos9 volv = new Articulos9();
            this.Hide();
            volv.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Historial9_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "select *from Historial";
            ds = Conexion9.Ejecutar(sql);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
