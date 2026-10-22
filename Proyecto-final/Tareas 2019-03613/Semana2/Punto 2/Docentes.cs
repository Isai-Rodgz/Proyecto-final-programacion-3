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
    public partial class Docentes : Registro
    {
        public Docentes()
        {
            InitializeComponent();
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            //Codigo que utilizo para que se agrege la columna que necesita este formulario
            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "Materia";
            dtgv_Registro.Columns.Add(columna4);

        }

        private void btnguardarR_Click(object sender, EventArgs e)
        {
            // Codigo que agrega el contenido de los textbox en el datagridview
            dtgv_Registro.Rows.Add(txtnomb_R.Text, txtusuario_R.Text, txt_codigo_R.Text, txtmateria_D.Text);
            
        }

        private void btnlimpiaR_Click(object sender, EventArgs e)
        {
            // Este boton es para limpiar los textbox
            txtnomb_R.Text = "";
            txtusuario_R.Text = "";
            txt_codigo_R.Text = "";
            txtmateria_D.Text = "";
        }
    }
}
