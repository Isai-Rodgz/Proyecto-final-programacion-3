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
    public partial class FormAlumnos : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        //defino una variable de tipo dataAdapter
        private SqlDataAdapter da1;
        private string sCn;

        public FormAlumnos()
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

        private void btnInsertar_Al_Click(object sender, EventArgs e)
        {
            try
            {
                
                //creo la variable que contendra la consulta sql de insercion
                string insertparticipantes;
                insertparticipantes = "Insert into Alumnos values('"+ txtCod_alu_In.Text+"','" + txtPri_nombre.Text + "', '" + 
                txtSeg_nomb.Text + "','" +txtPri_apellido.Text +"', '"+ txtSeg_apellido.Text+"', '" +int.Parse(txtEdad.Text)+ "', '" +
                txtDireccion.Text +"')";
                insert1 = new SqlCommand(insertparticipantes, conn);
                insert1.CommandType= CommandType.Text;
                insert1.ExecuteNonQuery();
                //limpiamos los textbox
                txtCod_alu_In.Text = "";
                txtPri_nombre.Text = "";
                txtSeg_nomb.Text = "";
                txtPri_apellido.Text = "";
                txtSeg_apellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
                conn.Close();
                MessageBox.Show("¡Registro Guardado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusc_Alu1_Click(object sender, EventArgs e)
        {
            //Boton para buscar los alumnos por el nombre
            //variable que tendra la consutla
            string seleccion;
            seleccion = "select *from Alumnos where PrimerNombre like '%" + txtBusc_Alu.Text + "%'";
            DataTable dt = new DataTable();
            da1 = new SqlDataAdapter(seleccion, conn);
            da1.Fill(dt);
            dtgv_Alum.DataSource = dt;
        }

        private void dtgv_Alum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Este metodo es para seleccionar las filar y las muestre en los textbox
            txtCod_alu_In.Text = dtgv_Alum.CurrentRow.Cells[0].Value.ToString();
            txtPri_nombre.Text= dtgv_Alum.CurrentRow.Cells[1].Value.ToString();
            txtSeg_nomb.Text= dtgv_Alum.CurrentRow.Cells[2].Value.ToString();
            txtPri_apellido.Text= dtgv_Alum.CurrentRow.Cells[3].Value.ToString();
            txtSeg_apellido.Text= dtgv_Alum.CurrentRow.Cells[4].Value.ToString();
            txtEdad.Text= dtgv_Alum.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text= dtgv_Alum.CurrentRow.Cells[6].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Codigo para que el datagridview cargue la tablal al iniciar el formulario
            string cad = "Select CodigoAlumno, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Edad, Direccion from Alumnos";
            DataTable data = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cad,conn);
            adap.Fill(data);
            dtgv_Alum.DataSource = data;
        }

        private void btnModificar_Al_Click(object sender, EventArgs e)
        {
            // try y catch para que ejecute la accion de modificar algun campo, si ocurre algun error me lo dira
            try
            {
                string modificar = "Update Alumnos set PrimerNombre= '" + txtPri_nombre.Text + "', SegundoNombre= '" + txtSeg_nomb.Text +
                    "', PrimerApellido= '" + txtPri_apellido.Text + "', SegundoApellido= '" + txtSeg_apellido.Text +
                    "', Edad= '" + txtEdad.Text + "', Direccion= '" + txtDireccion.Text + "' where CodigoAlumno= '" + txtCod_alu_In.Text + "'";
                insert1 = new SqlCommand(modificar, conn);
                insert1.CommandType = CommandType.Text;
                insert1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Datos Modificados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiamos los textbox
                txtCod_alu_In.Text = "";
                txtPri_nombre.Text = "";
                txtSeg_nomb.Text = "";
                txtPri_apellido.Text = "";
                txtSeg_apellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
            }
            catch
            {
                MessageBox.Show("Eror al modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Al_Click(object sender, EventArgs e)
        {
            //Boton para eliminar los alumnos registrados igualmete use el try y catch
            try
            {
                string eliminar = "Delete from Alumnos where CodigoAlumno= '" + txtCod_alu_In.Text + "'";
                insert1 = new SqlCommand(eliminar,conn);
                insert1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Datos eliminados","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiamos los textbox
                txtCod_alu_In.Text = "";
                txtPri_nombre.Text = "";
                txtSeg_nomb.Text = "";
                txtPri_apellido.Text = "";
                txtSeg_apellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
            }
            catch
            {
                MessageBox.Show("Eror al eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Metodo para volver al menu principal
            MenuOpcion menu = new MenuOpcion();
            this.Hide();
            menu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para salir
            Application.Exit();
        }
    }
}
