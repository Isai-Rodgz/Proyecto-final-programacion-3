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
    public partial class FormProductos6 : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = @"Server=.\sqlexpress;Database=Productos;Trusted_Connection=True;";
        bool nuevo;
        public FormProductos6()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            // Cargo el estado para el botón Nuevo y los demás elementos.
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            tstID.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            txtNombre.Focus();
            nuevo = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Nuevo que proceda la inserción de un registro en la Base de Datos.
            if (nuevo)
            {
                string sql = "INSERT INTO postres ( nombre, precio, stock)"
                          + "VALUES ('" + txtNombre.Text + "', '" + txtPrecio.Text + "', '" + txtStock.Text + "')";

                string sqlq = "INSERT INTO RespaldoPost ( nombreResp, precioResp, stockResp)"
                          + "VALUES ('" + txtNombre.Text + "', '" + txtPrecio.Text + "', '" + txtStock.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                SqlCommand comd = new SqlCommand(sqlq, con);
                comd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int a = comd.ExecuteNonQuery();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0 && a > 0)
                        MessageBox.Show("Registro ingresado correctamente!","Registrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    // Cierro la Conexión.
                    con.Close();
                }
            }
            else
            {
                // Procedo a realizar la actualización del registro en la Base de Datos.
                string sql = "UPDATE postres SET nombre='" + txtNombre.Text +
                    "', precio='" + txtPrecio.Text +
                    "', " + "stock='" + txtStock.Text + "' WHERE id=" + txtId.Text + "";

                string sqlq = "UPDATE RespaldoPost SET nombreResp='" + txtNombre.Text +
                   "', precioResp='" + txtPrecio.Text +
                   "', " + "stockResp='" + txtStock.Text + "' WHERE idResp=" + txtId.Text + "";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                SqlCommand comd = new SqlCommand(sqlq, con);
                comd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int a = comd.ExecuteNonQuery();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0 && a > 0)
                        MessageBox.Show("Registro actualizado correctamente!", "Modificado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    // Cierro la Conexión.
                    con.Close();
                }
            }

            // Defino los Estados para los elementos de mi Formulario después de actualizar el registro.
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstID.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            // Defino los Estados para los elementos de mi Formulario cuando hago click en el botón Cancelar.
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstID.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            // Si hago click en el botón eliminar procedo a eliminar en la Base de Datos.
            string sql = "DELETE FROM postres WHERE id=" + txtId.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro eliminado correctamente!","Eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }

            // Defino los Estados para los elementos de mi Formulario cuando hago click en el botón Eliminar.
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstID.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Buscar, procedo a buscar en la Base de Datos.
            string sql = "SELECT * FROM postres WHERE id=" + tstID.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Defino los Estados para los elementos de mi Formulario cuando hago click en el botón Buscar.
                    tsbNuevo.Enabled = false;
                    tsbGuardar.Enabled = true;
                    tsbCancelar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    tstID.Enabled = false;
                    tsbBuscar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    txtNombre.Focus();
                    txtId.Text = reader[0].ToString();
                    txtNombre.Text = reader[1].ToString();
                    txtPrecio.Text = reader[2].ToString();
                    txtStock.Text = reader[3].ToString();
                    nuevo = false;
                }
                else
                    MessageBox.Show("Ningun registro encontrado con el Id ingresado!","Revisar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }

            tstID.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Salir cierro el formulario.
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cuando cargue el formulario se deben deshabilitar y habilitar algunos botones y textbox
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            txtId.Enabled = false;
            tsbBuscar.Enabled = true;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            MenuPrinc6 prin = new MenuPrinc6();
            this.Hide();
            prin.Show();

        }
    }
}
