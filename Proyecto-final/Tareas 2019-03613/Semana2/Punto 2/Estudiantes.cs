using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final 
{
    public partial class Estudiantes : Registro
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlimpiaR_Click(object sender, EventArgs e)
        {
            // Boton para limpiar los textbox
            txtnomb_R.Text = "";
            txtusuario_R.Text = "";
            txt_codigo_R.Text = "";
        }

        private void btnguardarR_Click(object sender, EventArgs e)
        {
            //Codigo para agregar la informacion de los textbox al datagridview
            dtgv_Registro.Rows.Add(txtnomb_R.Text, txtusuario_R.Text, txt_codigo_R.Text);
        }
    }
}
