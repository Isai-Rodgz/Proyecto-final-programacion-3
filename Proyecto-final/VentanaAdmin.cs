using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibreria;


namespace Proyecto_final
{
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + VentanaLogin.codigo;

            DataSet Ds = Utilidades.ejecutar(cmd);

            LblAdmin.Text = Ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            LblUsuariAd.Text= Ds.Tables[0].Rows[0]["account"].ToString();
            LblCodAd.Text= Ds.Tables[0].Rows[0]["id_usuario"].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal Conp = new ContenedorPrincipal();
            this.Hide();
            Conp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmUsuarios ver = new AdmUsuarios();
            this.Hide();
            ver.Show();
        }
    }
}
