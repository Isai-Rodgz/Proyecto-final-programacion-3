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
    public partial class FormProductos7 : Form
    {
        public FormProductos7()
        {
            InitializeComponent();
        }

        private void FomProductos_Load(object sender, EventArgs e)
        {
            //Cuando el formularion cargue se ejecutara el metodo que lo llenara
            dataGridView1.DataSource = LlenarDataGV("Producto").Tables[0];
        }

        //Metodo que para ejecutarlo cuando el formilario cargue
        public DataSet LlenarDataGV(string tabla)
        {
            DataSet Ds;

            string cmd = string.Format("Select * from " + tabla); //Cadena que va a contener la tabla que lo va a llenar
            Ds = Conexion7.Ejecutar(cmd); //Utilozo el metodo de la clase de conexion para que se ejecute con la sentencia de este metodo

            return Ds;

        }

        //Boton para buscar el producto por el nombre
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;

                string cmd = "Select *from Producto where nombreproducto LIKE '%" + txtBuscar.Text.Trim() + "%'";
                ds = Conexion7.Ejecutar(cmd);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error" + ex.Message);
            }
        }

        //Boton para ingresar un nuevo producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Ejecuta la sentencia con el metodo de la clase de conexion
                string sql = string.Format("Exec InsertarProductos '{0}', '{1}','{2}', '{3}', '{4}' ", txtIdprod.Text.Trim(),
                    txtNombreprod.Text.Trim(), txtExistencia.Text.Trim(), txtprecio.Text.Trim(), txtpreciov.Text.Trim());
                Conexion7.Ejecutar(sql);
                MessageBox.Show("¡Se ha guardado Correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio mis textbox despues de finalizar y actualizo los datos de datagridview
                txtIdprod.Text = "";
                txtNombreprod.Text = "";
                txtExistencia.Text = "";
                txtprecio.Text = "";
                txtpreciov.Text = "";
                dataGridView1.DataSource = LlenarDataGV("Producto").Tables[0];
        }

        //Boton para modificar los prodcutos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Ejecuta la sentencia con el metodo de la clase de conexion
                string sql = string.Format("Exec ModificarProductos '{0}', '{1}','{2}', '{3}', '{4}' ", txtIdprod.Text.Trim(), 
                    txtNombreprod.Text.Trim(), txtExistencia.Text.Trim(), txtprecio.Text.Trim(),txtpreciov.Text.Trim());
                Conexion7.Ejecutar(sql);
                MessageBox.Show("¡Se ha Modificado correctamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio mis textbox despues de finalizar y actualizo los datos de datagridview
            txtIdprod.Text = "";
            txtNombreprod.Text = "";
            txtExistencia.Text = "";
            txtprecio.Text = "";
            txtpreciov.Text = "";
            dataGridView1.DataSource = LlenarDataGV("Producto").Tables[0];
        }

        //Metodo para mostrar lo que hay en el datagridview en los textbox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdprod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombreprod.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtExistencia.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtprecio.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtpreciov.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        //Boton para cerrar la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para ir al formulario de pedidos
        private void btnIrPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos7 pedi = new FormPedidos7();
            this.Hide();
            pedi.Show();
        }
    }
}
