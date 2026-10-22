using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_final 
{
    public partial class CambiarEstatus : Form
    {
        //Cadena de conexion de la base de datos
        SqlConnection con;
        string cadena = @"Server= localhost\SQLEXPRESS;Database=ProgIII;Integrated security=True;";
       
        public CambiarEstatus()
        {

            InitializeComponent();
            // Desde que inicia la aplicacion se ejecuta la coneccion
            con = new SqlConnection(cadena);
        }
        public void LlenarComb()
        {
            //llenar el combobox de Productos
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select nombrepro from Productos", con );
            da.Fill(ds, "Productos");
            cbbxProducto.DataSource = ds.Tables[0].DefaultView;
            cbbxProducto.ValueMember = "nombrepro";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Llamando el metodo para llenar el combobox cuando el formulario cargue
            LlenarComb();
            //Codigo para llenar el datagridview cuadno el formulario cargue
            string consulta = "select Codigo, Nombre, Ubicacion, Existencia, Estatus from View_1 ";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(consulta, con);
            adp.Fill(dt);
            dtgProducto.DataSource = dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Boton para modificar el estatus por medio de los radiobutom
            //Utilizando condiciones y el try y catch para estar mas seguro de que ejecute la accion
            con.Open();
            if (rdbActivar.Checked== true)
            {
                try
                {
                    rdbDesactivar.Checked = false;
                    string activar = "update Productos set estatuspro= 'A' where nombrepro='" + cbbxProducto.Text + "'";
                    SqlCommand cmd = new SqlCommand(activar, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estatus modificado...", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("No se pudo modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (rdbDesactivar.Checked== true)
            {
                try
                {
                    rdbActivar.Checked = false;
                    string desactivar = "update Productos set estatuspro= 'I' where nombrepro='" + cbbxProducto.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(desactivar, con);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Estatus modificado...", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("No se pudo modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Boton de buscar los productos y asi verificar que se ha modificado el estatus
            //Codigo que contiene la sentencia de busqueda por el nombre del producto
            string buscar = "select Codigo, Nombre, Ubicacion, Existencia, Estatus from View_1 where Nombre like '%"
                + txtBuscar.Text + "%'";
            DataTable table = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(buscar, con);
            adt.Fill(table);
            dtgProducto.DataSource = table;
        }
    }
}
