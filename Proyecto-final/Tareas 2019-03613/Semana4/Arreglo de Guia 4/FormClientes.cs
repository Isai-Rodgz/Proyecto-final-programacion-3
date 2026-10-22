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
    public partial class FormClientes : Form
    {
        //Variables para la interaccion con la base de datos
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public FormClientes()
        {
            InitializeComponent();
            //Objeto de conexion
            Conexion cn = new Conexion();
            //Acceso a la funcion conec de la clase conexion
            cn.conec();
            //Variable para la cadena de conexion
            sCn = cn.cadena;
            //Conexion
            conn = new SqlConnection(sCn);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Boton para ingresar los clientes
            //Utilizando el try y catch para ejecutar las sentencias y verificar su valides
            try
            {
                conn.Open();
                //Variable insertar
                string insertarCliente;
                insertarCliente = "insert into Clientes(NombreCliente) values (@nombreCliente)";
                insert1= new SqlCommand(insertarCliente, conn);
                insert1.Parameters.Add(new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                insert1.Parameters["@nombreCliente"].Value = txtNombreCli.Text;
                insert1.ExecuteNonQuery();
                txtNombreCli.Clear();
                MessageBox.Show("Registro ingresado...", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch
            {
                MessageBox.Show("El registro no fue registrado","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Boton para limpiar el textbox
            txtNombreCli.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Boton para volver al formulario principal
            GenerarBase formu1 = new GenerarBase();
            formu1.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para salir de la aplicacion
            Application.Exit();
        }
    }
}
