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
    public partial class FormMaterias : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        //defino una variable de tipo dataAdapter
        private SqlDataAdapter da1;
        private string sCn;

        public FormMaterias()
        {
            InitializeComponent();
            //Usando la clase conectar
            // creo un nuevo objeto de tipo conexion y lo asigno a cn
            Conectar cn = new Conectar();
            //acceso a la funcion conec de la clase conexion
            cn.conex();
            //agrego la variable sCn a la cadena conexion
            sCn = cn.Cadena;
            //creo la conexion pasandole como argumento la cadena
            conn = new SqlConnection(sCn);
            //abro la conexion
            conn.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Metodo para mostrar los datos del datagridview en los textbox
            txtCod_Mate_In.Text = dtgv_Mate.CurrentRow.Cells[0].Value.ToString();
            txtNomb_Mate_In.Text = dtgv_Mate.CurrentRow.Cells[1].Value.ToString();
            txtUV_In.Text = dtgv_Mate.CurrentRow.Cells[2].Value.ToString();
            txtPrerequi_In.Text = dtgv_Mate.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnInsertar_Mat_Click(object sender, EventArgs e)
        {
            try
            {

                //creo la variable que contendra la consulta sql de insercion
                string insertparticipantes;
                insertparticipantes = "Insert into Materia values('" + txtCod_Mate_In.Text + "','" + txtNomb_Mate_In.Text + "', '" +
                int.Parse(txtUV_In.Text) + "', '"+ txtPrerequi_In.Text+"')";
                insert1 = new SqlCommand(insertparticipantes, conn);
                insert1.CommandType = CommandType.Text;
                insert1.ExecuteNonQuery();
                //limpiamos los textbox
                txtCod_Mate_In.Text = "";
                txtNomb_Mate_In.Text = "";
                txtUV_In.Text = "";
                txtPrerequi_In.Text = "";
                conn.Close();
                MessageBox.Show("¡Registro Guardado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusc_Mat_Re_Click(object sender, EventArgs e)
        {    
            //Este boton es para buscar la matera por nombre
            //variable que tendra la consutla
            string seleccion;
            seleccion = "select *from Materia where NombreMateria like '%" + txtbusc_Mate.Text + "%'";
            DataTable dt = new DataTable();
            da1 = new SqlDataAdapter(seleccion, conn);
            da1.Fill(dt);
           dtgv_Mate.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Metodo para que el formulario cargue el datagridview con la tabla de materia
            string cad = "Select CodigoMateria, NombreMateria, UV, Prerequisitos from Materia";
            DataTable data = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cad, conn);
            adap.Fill(data);
            dtgv_Mate.DataSource = data;
        }

        private void btnModif_Mat_Click(object sender, EventArgs e)
        {
            //Boton para modificar los campos de la materia, utilizando el try y catch para comprobar si hay error
            try
            {
                string modificar = "Update Materia set NombreMateria= '" + txtNomb_Mate_In.Text + "', UV= '" + int.Parse(txtUV_In.Text) +
                    "', '"+ txtPrerequi_In.Text+ "'";
                insert1 = new SqlCommand(modificar, conn);
                insert1.CommandType = CommandType.Text;
                insert1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Datos Modificados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiamos los textbox
                txtCod_Mate_In.Text = "";
                txtNomb_Mate_In.Text = "";
                txtUV_In.Text = "";
                txtPrerequi_In.Text = "";
            }
            catch
            {
                MessageBox.Show("Eror al modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElim_Mat_Click(object sender, EventArgs e)
        {
            //Boton para eliminar los registros de materias
            try
            {
                string eliminar = "Delete from Materia where CodigoMateria= '" + txtbusc_Mate.Text + "'";
                insert1 = new SqlCommand(eliminar, conn);
                insert1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Datos eliminados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiamos los textbox
                txtCod_Mate_In.Text = "";
                txtNomb_Mate_In.Text = "";
                txtUV_In.Text = "";
                txtPrerequi_In.Text = "";
            }
            catch
            {
                MessageBox.Show("Eror al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Mat_Click(object sender, EventArgs e)
        {
            //Boton para volver al formulario del menu principal
            MenuOpcion menu = new MenuOpcion();
            this.Hide();
            menu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para salir de la aplicacion
            Application.Exit();
        }
    }
}
