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
    public partial class VentanaUser : FormBase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + VentanaLogin.codigo;

            DataSet Ds = Utilidades.ejecutar(cmd);

            LblNomU.Text = Ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            LblUsuarioU.Text = Ds.Tables[0].Rows[0]["account"].ToString();
            LblCodU.Text = Ds.Tables[0].Rows[0]["id_usuario"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal Conp = new ContenedorPrincipal();
            this.Hide();
            Conp.Show();
            Conp.mantenimientoToolStripMenuItem.Visible = false;
        }
    }
}
