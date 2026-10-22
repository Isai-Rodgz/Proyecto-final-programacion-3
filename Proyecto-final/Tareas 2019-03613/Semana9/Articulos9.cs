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
    public partial class Articulos9 : Form
    {
        public Articulos9()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "select *from Articulos";
            ds = Conexion9.Ejecutar(sql);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("Exec InsertarArticulos '{0}','{1}', '{2}', '{3}', {4}", txtcodigo.Text.Trim(),
                txtnombre.Text.Trim(), txtprecio.Text.Trim(), txtprecioventa.Text.Trim(), cbbxestatus.Text.Trim());
                Conexion9.Ejecutar(sql);
                
                MessageBox.Show("Se ha ingresado correctamente", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataSet ds = new DataSet();
                string sql2 = "select *from Articulos";
                ds = Conexion9.Ejecutar(sql2);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIrHistorial_Click(object sender, EventArgs e)
        {
            Historial9 llam = new Historial9();
            this.Hide();
            llam.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
