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
    public partial class FormPedidos7 : Form
    {
        public FormPedidos7()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            //Cuando el formularion cargue se ejecutara el metodo que lo llenara
            dataGridView1.DataSource = LlenarDataGV("Pedidos").Tables[0];
        }
        //Metodo que para ejecutarlo cuando el formilario cargue
        public DataSet LlenarDataGV(string tabla)
        {
            DataSet Ds;

            string cmd = string.Format("Select * from " + tabla); //Cadena que va a contener la tabla que lo va a llenar
            Ds = Conexion7.Ejecutar(cmd); //Utilozo el metodo de la clase de conexion para que se ejecute con la sentencia de este metodo

            return Ds;

        }

        //Boton para buscar el pedido por el ID
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;

                string cmd = "Select idpedido, idproducto, cantidad_pedido from Pedidos where idpedido=" + txtBuscar.Text.Trim();
                ds = Conexion7.Ejecutar(cmd);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error" + ex.Message);
            }
        }

        //Boton para ingresar un nuevo pedido
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Ejecuta la sentencia con el metodo de la clase de conexion
                string sql = string.Format("Exec InsertarPedidos '{0}', '{1}' ", txtIdProd.Text.Trim(), txtCantidad.Text.Trim());
                Conexion7.Ejecutar(sql);
                MessageBox.Show("¡Se ha guardado Correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio mis textbox despues de finalizar y actualizo los datos de datagridview
            txtIdProd.Text = "";
            txtCantidad.Text = "";
            dataGridView1.DataSource = LlenarDataGV("Pedidos").Tables[0];
        }

        //Boton para modificar los pedidos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Ejecuta la sentencia con el metodo de la clase de conexion
                string sql = string.Format("Exec ModificarPedidos '{0}', '{1}','{2}' ", txtIdpedido.Text.Trim(), txtIdProd.Text.Trim(),
                    txtCantidad.Text.Trim());
                Conexion7.Ejecutar(sql);
                MessageBox.Show("¡Se ha Modificado correctamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Limpio mis textbox despues de finalizar y actualizo los datos de datagridview
            txtIdpedido.Text = "";
            txtIdProd.Text = "";
            txtCantidad.Text = "";
            dataGridView1.DataSource = LlenarDataGV("Pedidos").Tables[0];
        }

        //Metodo para mostrar lo que hay en el datagridview en los textbox 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdpedido.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtIdProd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        //Boton para cerrar la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton para ir al formulario de productos
        private void btnIrProducto_Click(object sender, EventArgs e)
        {
            FormProductos7 prod = new FormProductos7();
            this.Hide();
            prod.Show();
        }
    }
    
}
