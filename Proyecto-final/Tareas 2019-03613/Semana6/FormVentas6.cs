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
using System.Threading;

namespace Proyecto_final 
{
    public partial class FormVentas6 : Form
    {
        // Realizo la Conexión a la Base de Datos
        string connectionString = @"Server=.\sqlexpress;Database=Productos;Trusted_Connection=True;";
        //Variables que utilizare mas adelante
        DateTime hoy = DateTime.Now;
        public FormVentas6()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(connectionString);
             string actualizar = "select idventa, idclie, nombreclie, nombrepost, preciopost, cantidad, fecha from Ventas";
             SqlDataAdapter adp = new SqlDataAdapter(actualizar, con);
             DataSet ds = new DataSet();
             adp.Fill(ds);
             dataGridView1.DataSource = ds.Tables[0];

            /*SqlConnection con = new SqlConnection(connectionString);
            string fact = "select max (idventa) from Ventas";
            SqlCommand cmm = new SqlCommand(fact, con);
            cmm.CommandType = CommandType.Text;
            SqlDataAdapter ad = new SqlDataAdapter(fact,con);
            DataSet dd = new DataSet();
            ad.Fill(dd);
            lblVenta.Text= dd.Tables[0].DefaultView.ToString();*/

            /*SqlDataReader red;
            con.Open();
            red = cmm.ExecuteReader();
            lblVenta.Text= red[0].ToString();
            con.Close();*/

            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tsbModificar.Enabled = false;
            grbClientes.Enabled = false;
            grbProductos.Enabled = false;
            txtcantidadProd.Enabled = false;
            dateTimePicker1.Enabled = false;
            lblVenta.Text = dataGridView1.Rows.Count.ToString();

        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            MenuPrinc6 men = new MenuPrinc6();
            this.Hide();
            men.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbModificar.Enabled = true;
            grbClientes.Enabled = true;
            grbProductos.Enabled = true;
            txtcantidadProd.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtIdcli.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            // Defino los Estados para los elementos de mi Formulario cuando hago click en el botón Cancelar.
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tsbModificar.Enabled = false;
            tstID.Enabled = true;
            tsbBuscar.Enabled = true;
            grbClientes.Enabled = false;
            grbProductos.Enabled = false;
            txtcantidadProd.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtIdcli.Text = "";
            txtNombrecli.Text = "";
            txtApellidoclie.Text = "";
            txtPrecioProd.Text = "";
            txtIdProd.Text = "";
            txtNombreProd.Text = "";
            txtcantidadProd.Text = "";
            dateTimePicker1.Value = hoy;

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Nuevo que proceda la inserción de un registro en la Base de Datos.
            string sql = "INSERT INTO Ventas ( idclie, idpost, nombreclie, apellidoclie, nombrepost, preciopost, cantidad, fecha)"
                           + "VALUES ('" + txtIdcli.Text + "', '" + txtIdProd.Text + "', '" + txtNombrecli.Text +
                           "', '" + txtApellidoclie.Text + "','" + txtNombreProd.Text + "','" + txtPrecioProd.Text +
                           "', '" + txtcantidadProd.Text + "','" + dateTimePicker1.Value + "')";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro ingresado correctamente!", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();

                // Actualizare mi datagridview automaticamente se guarde todo
                string actualizar = "select idventa, idclie, nombreclie, nombrepost, preciopost, cantidad, fecha from Ventas";
                SqlDataAdapter adp = new SqlDataAdapter(actualizar, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                lblVenta.Text = dataGridView1.Rows.Count.ToString();

            }



        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            // Si hago click en el botón eliminar procedo a eliminar en la Base de Datos.
            string sql = "DELETE FROM Ventas WHERE idventa=" + tstID.Text;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro eliminado correctamente!", "Eliminado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error debe agregar un codigo o: " + ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
                // Actualizare mi datagridview automaticamente se guarde todo
                //SqlConnection con = new SqlConnection(connectionString);
                string actualizar = "select idventa, idclie, nombreclie, nombrepost, preciopost, cantidad, fecha from Ventas";
                SqlDataAdapter adp = new SqlDataAdapter(actualizar, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                lblVenta.Text= dataGridView1.Rows.Count.ToString();
            }

            // Defino los Estados para los elementos de mi Formulario cuando hago click en el botón Eliminar.
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tsbModificar.Enabled = false;
            tstID.Enabled = true;
            tsbBuscar.Enabled = true;
            grbClientes.Enabled = false;
            grbProductos.Enabled = false;
            txtcantidadProd.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtIdcli.Text = "";
            txtIdProd.Text = "";
            txtNombrecli.Text = "";
            txtNombreProd.Text = "";
            txtApellidoclie.Text = "";
            txtPrecioProd.Text = "";
            txtcantidadProd.Text = "";
            dateTimePicker1.Value = hoy;
            tstID.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cuando hago click en el botón Buscar, procedo a buscar en la Base de Datos.
                string sql = "SELECT * FROM Ventas WHERE idventa=" + tstID.Text;
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);

                ad.Fill(dt);
                dataGridView1.DataSource = dt;

                tsbNuevo.Enabled = true;
                tsbGuardar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbEliminar.Enabled = true;
                tsbModificar.Enabled = true;
                tstID.Enabled = true;
                tsbBuscar.Enabled = true;
                grbClientes.Enabled = false;
                grbProductos.Enabled = false;
                txtcantidadProd.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, esta venta no existe o" + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnBus_Cli_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Buscar, procedo a buscar en la Base de Datos.
            string sql = "SELECT * FROM Clientes WHERE idcli=" + txtIdcli.Text;

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
                    tsbEliminar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbBuscar.Enabled = true;
                    txtIdProd.Focus();
                    txtIdcli.Text = reader[0].ToString();
                    txtNombrecli.Text = reader[1].ToString();
                    txtApellidoclie.Text = reader[2].ToString();
                }
                else
                    MessageBox.Show("Ningun registro encontrado con el Id ingresado!","Revisar", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }

        }

        private void btnBusc_Prod_Click(object sender, EventArgs e)
        {
            // Cuando hago click en el botón Buscar, procedo a buscar en la Base de Datos.
            string sql = "SELECT * FROM postres WHERE id=" + txtIdProd.Text;

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
                    tsbEliminar.Enabled = false;
                    tsbModificar.Enabled = true;
                    tsbBuscar.Enabled = true;
                    txtIdProd.Text = reader[0].ToString();
                    txtNombreProd.Text = reader[1].ToString();
                    txtPrecioProd.Text = reader[2].ToString();
                    txtcantidadProd.Focus();
                }
                else
                    MessageBox.Show("Ningun registro encontrado con el Id ingresado!", "Revisar", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // Procedo a realizar la actualización del registro en la Base de Datos.
            string sqlq = "UPDATE Ventas SET idclie='" + txtIdcli.Text +
                "', idpost='" + txtIdProd.Text +
                "', nombreclie='" + txtNombrecli.Text +
                "', apellidoclie='" + txtApellidoclie.Text +
                "', nombrepost='" + txtNombreProd.Text +
                "', preciopost='" + txtPrecioProd.Text +
                "', cantidad='" + txtcantidadProd.Text +
                "', fecha='" + dateTimePicker1.Value + "' WHERE idventa=" + tstID.Text + "";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand comd = new SqlCommand(sqlq, con);
            comd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = comd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro actualizado correctamente!", "Modificado", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                // Cierro la Conexión.
                con.Close();

                // Defino los Estados para los elementos de mi Formulario después de actualizar el registro.
                tsbNuevo.Enabled = true;
                tsbGuardar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbEliminar.Enabled = false;
                tsbModificar.Enabled = false;
                tstID.Enabled = true;
                tsbBuscar.Enabled = true;
                grbClientes.Enabled = false;
                grbProductos.Enabled = false;
                txtcantidadProd.Enabled = false;
                dateTimePicker1.Enabled = false;
                txtIdcli.Text = "";
                txtIdProd.Text = "";
                txtNombrecli.Text = "";
                txtApellidoclie.Text = "";
                txtNombreProd.Text = "";
                txtPrecioProd.Text = "";
                txtcantidadProd.Text = "";
                tstID.Text = "";
                dateTimePicker1.Value = hoy;

                // Actualizare mi datagridview automaticamente se guarde todo
                string actualizar = "select idventa, idclie, nombreclie, nombrepost, preciopost, cantidad, fecha from Ventas";
                SqlDataAdapter adp = new SqlDataAdapter(actualizar, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}
