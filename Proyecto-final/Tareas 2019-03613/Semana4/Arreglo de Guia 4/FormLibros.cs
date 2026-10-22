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
    public partial class FormLibros : Form
    {
        //Variables para la interaccion con la base de datos
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public FormLibros()
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
            //Boton para registrar un nuevo libro
            try
            {
                conn.Open();
                //Variable insertar
                string insertarLibro;
                insertarLibro = "insert into Libros(NombreLibro, Autor) values (@nombreLibro, @autor)";
                insert1 = new SqlCommand(insertarLibro, conn);
                insert1.Parameters.Add(new SqlParameter("@nombreLibro", SqlDbType.VarChar));
                insert1.Parameters["@nombreLibro"].Value = txtNomLibro.Text;
                insert1.Parameters.Add(new SqlParameter("@autor", SqlDbType.VarChar));
                insert1.Parameters["@autor"].Value = txtAutor.Text;
                insert1.ExecuteNonQuery();
                txtNomLibro.Clear();
                txtAutor.Clear();
                MessageBox.Show("Registro ingresado...", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch
            {
                MessageBox.Show("El registro no fue registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Boton para limpiar los textbox del formulario
            txtAutor.Text = "";
            txtNomLibro.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Boton para volver al formulario principal
            GenerarBase formu1 = new GenerarBase();
            this.Hide();
            formu1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para salir de la aplicacion
            Application.Exit();
        }
    }

    
}
