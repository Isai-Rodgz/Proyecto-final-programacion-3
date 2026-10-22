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
    public partial class AdmUsuarios : Form
    {
        public AdmUsuarios()
        {
            InitializeComponent();
        }

        private void AdmUsuarios_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("Select *from Usuarios");
            ds = Utilidades.ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                try
                {
                    DataSet ds;

                    string cmd = "Select *from Usuarios where Nom_usu LIKE '%" + txtbuscar.Text.Trim() + "%'";
                    ds = Utilidades.ejecutar(cmd);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un Error" + ex.Message);
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Validarformulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("Exec InsertartUsuarios '{0}', '{1}', '{2}','{3}', '{4}'", txtID.Text.Trim(),
                    txtNombre.Text.Trim(), txtcuenta.Text.Trim(), txtcontrasena.Text.Trim(), cbbxAdm.Text.Trim());
                    Utilidades.ejecutar(cmd);
                    MessageBox.Show("¡Se ha guardado Correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                AdmUsuarios_Load(sender, e);

            }
            else
            {
                errorProvider1.SetError(cbbxAdm, " Este campo no puede estar vacio");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Validarformulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format(" Exec ActualizarUsuarios '{0}', '{1}', '{2}','{3}', '{4}'", txtID.Text.Trim(),
                    txtNombre.Text.Trim(), txtcuenta.Text.Trim(), txtcontrasena.Text.Trim(), cbbxAdm.Text.Trim());
                    Utilidades.ejecutar(cmd);
                    MessageBox.Show("¡Se ha Modificado Correctamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                AdmUsuarios_Load(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("EXEC EliminarUsuarios '{0}'", txtID.Text.Trim());
                Utilidades.ejecutar(cmd);
                MessageBox.Show("¡Se ha Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            AdmUsuarios_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcuenta.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcontrasena.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbbxAdm.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtcuenta.Text = "";
            txtcontrasena.Text = "";
            cbbxAdm.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaAdmin adm = new VentanaAdmin();
            this.Hide();
            adm.Show();
        }
        
    }
}
