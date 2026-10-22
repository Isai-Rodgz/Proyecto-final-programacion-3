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
    public partial class FormCRUD : Form
    {
        //Variables para la interaccion con la base de datos
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public FormCRUD()
        {
            InitializeComponent();
            //Objeto de conexion
            ConexionCRUD cn = new ConexionCRUD();
            //Acceso a la funcion conec de la clase conexion
            cn.conec();
            //Variable para la cadena de conexion
            sCn = cn.cadena;
            //Conexion
            conn = new SqlConnection(sCn);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Boton para registrar los clientes con la sentencia insert usando el try y catch
            try
            {
                conn.Open();
                string cadn = "insert into Clientes values ('" + int.Parse(txtcodigoCli.Text) + "' , '" + txtnombreCli.Text +
                    "' , '" + txtApellidoCli.Text + "' , '" + txtEdadCli.Text + "','" + txtDireccion.Text + "', '" + txtEstatus.Text + "')";
                insert1 = new SqlCommand(cadn, conn);
                insert1.CommandType = CommandType.Text;
                insert1.ExecuteNonQuery();
                txtcodigoCli.Text = "";
                txtnombreCli.Text = "";
                txtApellidoCli.Text = "";
                txtEdadCli.Text = "";
                txtDireccion.Text = "";
                txtEstatus.Text = "";
                MessageBox.Show("¡Cliente Registrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Boton para modificar los clientes usando la sentencia update y aplicando el try y catch
            try
            {
                conn.Open();
                string cd = "Update Clientes set nombrecli= '" + txtnombreCli.Text + "', apellidocli= '" + txtApellidoCli.Text + 
                    "', edadcli= '" + txtEdadCli.Text + "', direccioncli= '"+ txtDireccion.Text +"', estatuscli= '"+ txtEstatus.Text+
                    "' where codcli= '" + txtcodigoCli.Text + "'";
                insert1= new SqlCommand(cd, conn);
                insert1.CommandType = CommandType.Text;
                insert1.ExecuteNonQuery();
                txtcodigoCli.Text = "";
                txtnombreCli.Text = "";
                txtApellidoCli.Text = "";
                txtEdadCli.Text = "";
                txtDireccion.Text = "";
                txtEstatus.Text = "";
                MessageBox.Show("¡Cliente Modificado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Boton para elmininar un cliente con la sentencia delete y aplicando try y catch
            try
            {
                conn.Open();
                string cad = "Delete from Clientes where codcli = '" + txtcodigoCli.Text+ "'";
                insert1 = new SqlCommand(cad, conn);
                insert1.ExecuteNonQuery();
                txtcodigoCli.Text = "";
                txtnombreCli.Text = "";
                txtApellidoCli.Text = "";
                txtEdadCli.Text = "";
                txtDireccion.Text = "";
                txtEstatus.Text = "";
                MessageBox.Show("¡Cliente Eliminado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Codigo para que el formulario cargue los datos de la tabla clientes en el datagrid cuando se ejecute
            DataTable dtb = new DataTable();
            string cadena = "Select codcli, nombrecli, apellidocli, edadcli, direccioncli , estatuscli from Clientes";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, conn);
            adap.Fill(dtb);
            dtgvClientes.DataSource = dtb;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Boton para consultar o buscar los clientes mediante su nombre utilizando select y la condicion de where
            DataTable dtb = new DataTable();
            string cadena = "Select codcli, nombrecli, apellidocli, edadcli, direccioncli, estatuscli from Clientes where nombrecli like'%" +
                this.txtNombreBusc.Text + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, conn);
            adap.Fill(dtb);

            dtgvClientes.DataSource = dtb;

        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Metodo para que cuando seleccione una fila del datagridview me muestre los datos en los textbox
            txtcodigoCli.Text = dtgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtnombreCli.Text = dtgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellidoCli.Text = dtgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtEdadCli.Text = dtgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtEstatus.Text = dtgvClientes.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para salir de la aplicacion
            Application.Exit();
        }
    }
}
