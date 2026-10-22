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
    public partial class GenerarBase : Form
    {
        public GenerarBase()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //La conxion a usar con autentificacion de windows
            // Indicando la base de datos master
            SqlConnection cnn = new SqlConnection(@"Server= localhost\SQLEXPRESS;Database=master;Integrated security=True;");
            //La orden T-SQL para crear la base de datos es
            string CrearBD = "Create database " + "BD_Avanzada";

            //Creacion de la tabla clientes
            string tClientes = "Use BD_Avanzada;" +
                "Create table Clientes(" +
                "id_Cliente int identity(1,1)," +
                "NombreCliente varchar(40)" +
                "constraint PK_Clientes primary key(id_Cliente));";

            //Creacion de la tabla Libros
            string tLibros = "Use BD_Avanzada;" +
            "create table Libros(" +
            "id_Libro int identity(1,1)," +
            "NombreLibro varchar(100)," +
            "Autor varchar(30)" +
            "constraint PK_Libros primary key (id_Libro));";

            //Creacion de la tabla Pedidos
            string tPedidos = "Use BD_Avanzada;" +
                "create table Pedidos(" +
                "id_Pedido int identity(1,1)," +
                "id_Cliente int not NULL," +
                "id_Libro int not NULL," +
                "CantidadPedido int," +
                "FechaPedido varchar(70)," +
                "constraint PK_pedido primary key (id_Pedido)," +
                "constraint FK_Cliente foreign key (id_Cliente)" +
                "references Clientes (id_Cliente)," +
                "constraint FK_Libro foreign key (id_Libro)" +
                "references Libros (id_Libro));";


            //Asignacion de las sentencias a los sqlcommand
            SqlCommand cmd = new SqlCommand(CrearBD, cnn);
            SqlCommand cmd1 = new SqlCommand(tClientes, cnn);
            SqlCommand cmd2 = new SqlCommand(tLibros, cnn);
            SqlCommand cmd3 = new SqlCommand(tPedidos, cnn);

            //Ejecucion de las sentencias para que se cree la base de datos y las tablas
            // Utilizando el try y catch para verificar su ejecucion y posibles errores
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Base de datos" +
                    "\nCreada Correctamente...", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message,
                    "Error al crear la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Boton que llama al formulario donde se registran los clientes
            FormClientes formu1 = new FormClientes();
            this.Hide();
            formu1.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //Boton que llama el formulario donde se registran los pedidos
            FormPedidos formu1 = new FormPedidos();
            this.Hide();
            formu1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Boton para salir de la aplicacion
            Application.Exit();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            //Boton para llamar al formulario donde se registran los libros
            FormLibros formu1 = new FormLibros();
            this.Hide();
            formu1.Show();
        }
    }
}
