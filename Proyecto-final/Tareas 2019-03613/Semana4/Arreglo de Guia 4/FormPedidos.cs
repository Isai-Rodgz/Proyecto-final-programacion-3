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
using System.Security.Cryptography.X509Certificates;

namespace Proyecto_final 
{
    public partial class FormPedidos : Form
    {
        //Variables para la interaccion con la base de datos
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        public FormPedidos()
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
        //Llenar dinaminamicamente Combobox
        public void Llenar()
        {
            //llenar el combobox ID Cliente
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select id_Cliente from Clientes", conn);
            da.Fill(ds, "Clientes");
            cbbxIDClie.DataSource = ds.Tables[0].DefaultView;
            cbbxIDClie.ValueMember = "id_Cliente";

            //Llenar el combobox ID Libro
            DataSet dts = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter("select id_Libro from Libros", conn);
            dap.Fill(dts, "Libros");
            cbbxIDLibro.DataSource = dts.Tables[0].DefaultView;
            cbbxIDLibro.ValueMember = "id_Libro";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Para llenar el combobox cuando carge el form
            Llenar();

            //Para llenar el datagridview
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select *from Vista1", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cbbxIDClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codigo para que se muestre el Nombre del cliente mediante el codigo del combobox
            int numero;
            if (!Int32.TryParse(this.cbbxIDClie.Text, out numero))
            {

            }
            else
            {
                try
                {
                    conn.Open();
                    int num1 = int.Parse(cbbxIDClie.Text);
                    string seleccion;
                    seleccion = "select *from Clientes where id_Cliente="+ num1;
                    da1 = new SqlDataAdapter(seleccion, conn);
                    SqlParameter prm = new SqlParameter("id_Cliente", SqlDbType.Int);
                    prm.Value = num1;
                    da1.SelectCommand.Parameters.Add(prm);
                    dr1 = da1.SelectCommand.ExecuteReader();
                    while (dr1.Read())
                    {
                        lblNombreC.Visible = true;
                        lblNombreC.Text = dr1["NombreCliente"].ToString().Trim();
                    }
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
                if (dr1 !=null)
                {
                    dr1.Close();
                }
            }
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            //Codigo para insertar un nuevo pedido
            try
            {
                conn.Open();
                string insertPedido;
                insertPedido = "insert into Pedidos(id_Cliente, id_Libro, CantidadPedido, FechaPedido)";
                insertPedido += "values (@id_Cliente, @id_Libro, @CantidadPedido, @FechaPedido)";
                insert1 = new SqlCommand(insertPedido,conn);
                insert1.Parameters.Add(new SqlParameter("@id_Cliente", SqlDbType.Int));
                insert1.Parameters["@id_Cliente"].Value = cbbxIDClie.Text;
                insert1.Parameters.Add(new SqlParameter("@id_Libro", SqlDbType.Int));
                insert1.Parameters["@id_Libro"].Value = cbbxIDLibro.Text;
                insert1.Parameters.Add(new SqlParameter("@CantidadPedido", SqlDbType.Int));
                insert1.Parameters["@CantidadPedido"].Value = nudwCantidad.Value;
                insert1.Parameters.Add(new SqlParameter("@FechaPedido", SqlDbType.VarChar, 200));
                insert1.Parameters["@FechaPedido"].Value = dtmpFecha.Text;
                insert1.ExecuteNonQuery();

                cbbxIDClie.Text = "";
                cbbxIDLibro.Text = "";
                nudwCantidad.Value= 0;
                dtmpFecha.Text = "";
                lblNombreC.Text = "";
                lblNombreLib.Text = "";

                MessageBox.Show("Registro agregado...", "Pedido", MessageBoxButtons.OK,MessageBoxIcon.Information);
                conn.Close();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select *from Vista1", conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch
            {
                MessageBox.Show("El registro no fue agregado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            //Boton para limpiar los componentes del formulario
            cbbxIDClie.Text = "";
            cbbxIDLibro.Text = "";
            nudwCantidad.Value= 0;
            lblNombreC.Text = "";
            dtmpFecha.Text = "";
            txtCodPedido.Text = "";

            //Actualizar el datagridview
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select *from Vista1", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnVolverP_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Boton para eliminar los pedidos registrados
            try
            {
            conn.Open();
            string eliminarP;
            eliminarP = "delete from Pedidos where id_Pedido= " + txtCodPedido.Text;
            insert1 = new SqlCommand(eliminarP,conn);
            insert1.ExecuteNonQuery();
            txtCodPedido.Text = "";
            MessageBox.Show("Registro de Pedido Eliminado...", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select *from Vista1", conn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex +"");
            }
            
        }

        private void cbbxIDLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codigo para que se muestre el nombre del libro cuando se elija el codigo
            int numero;
            if (!Int32.TryParse(this.cbbxIDLibro.Text, out numero))
            {

            }
            else
            {
                try
                {
                    conn.Open();
                    int num1 = int.Parse(cbbxIDLibro.Text);
                    string seleccion;
                    seleccion = "select *from Libros where id_Libro=" + num1;
                    da1 = new SqlDataAdapter(seleccion, conn);
                    SqlParameter prm = new SqlParameter("id_Libro", SqlDbType.Int);
                    prm.Value = num1;
                    da1.SelectCommand.Parameters.Add(prm);
                    dr1 = da1.SelectCommand.ExecuteReader();
                    while (dr1.Read())
                    {
                        lblNombreLib.Visible = true;
                        lblNombreLib.Text = dr1["NombreLibro"].ToString().Trim();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
                if (dr1 != null)
                {
                    dr1.Close();
                }
            }
        }

        private void btnBuscarPed_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select id_Pedido, NombreCliente, NombreLibro, Autor, CantidadPedido, " +
                "FechaPedido from Vista1 where id_Pedido= "+txtCodPedido.Text, conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
