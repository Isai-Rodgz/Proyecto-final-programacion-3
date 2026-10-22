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
using MyLibreria;

namespace Proyecto_final
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static string codigo = "";

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", TxtAcc.Text.Trim(), TxtCont.Text.Trim());

                DataSet ds = Utilidades.ejecutar(CMD);
                codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == TxtAcc.Text.Trim() && contra == TxtCont.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["status_admin"]) == true)
                    {
                        VentanaAdmin venad = new VentanaAdmin();
                        this.Hide();
                        venad.Show();
                    }
                    else
                    {
                        VentanaUser venUs = new VentanaUser();
                        this.Hide();
                        venUs.Show();
                        
                    }
                }
                


            }
            catch(Exception error)  
            {
                MessageBox.Show("Usuario o contraseña incorrecta....." + error);
            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
