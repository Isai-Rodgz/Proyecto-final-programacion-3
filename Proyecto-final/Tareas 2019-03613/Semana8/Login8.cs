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
    public partial class Login8 : Form
    {
        public Login8()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string login = string.Format("Exec Autenticar '{0}', '{1}'", txtusuario.Text.Trim(), txtcontrasena.Text.Trim());
                ds = Conectar8.Ejecutar(login);

                string usuario = ds.Tables[0].Rows[0]["cuenta_user"].ToString().Trim();
                string contrasena = ds.Tables[0].Rows[0]["contrasena_user"].ToString().Trim();
                string nombre = ds.Tables[0].Rows[0]["nombre_user"].ToString().Trim();

                if (usuario== txtusuario.Text.Trim() && contrasena== txtcontrasena.Text.Trim())
                {
                    MessageBox.Show("Bienvenido(a) "+ nombre, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarEstudiantes8 cons = new ConsultarEstudiantes8();
                    this.Hide();
                    cons.Show();
                }
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrecta","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
