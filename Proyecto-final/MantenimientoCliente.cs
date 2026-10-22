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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }
        public override Boolean Guardar()
        {
            if (Utilidades.Validarformulario(this, errorProvider1)== false)
            {
                try
                {
                    if (rdbActivo.Checked == false && rdbInactivo.Checked == false)
                    {
                        errorProvider1.SetError(rdbActivo, "Debe elegir uno estatus");
                        errorProvider1.SetError(rdbInactivo, "Debe elegir uno estatus");
                        return false;
                    }
                    else
                    {
                        if (rdbActivo.Checked== true)
                        {
                            string act = "A";
                            string cmd = string.Format("EXEC ActualizarCliente '{0}', '{1}', '{2}', '{3}'", txtIdCli.Text.Trim(), txtNomCli.Text.Trim(), txtApeCli.Text.Trim(), act.Trim());
                            Utilidades.ejecutar(cmd);
                            MessageBox.Show("¡Se ha guardado Correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider1.Clear();
                            return true;
                        }
                        if (rdbInactivo.Checked== true)
                        {
                            string inac = "I";
                            string cmd = string.Format("EXEC ActualizarCliente '{0}', '{1}', '{2}', '{3}'", txtIdCli.Text.Trim(), txtNomCli.Text.Trim(), txtApeCli.Text.Trim(), inac.Trim());
                            Utilidades.ejecutar(cmd);
                            MessageBox.Show("¡Se ha guardado Correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            errorProvider1.Clear();
                            return true;
                        }
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtIdCli.Text.Trim());
                Utilidades.ejecutar(cmd);
                MessageBox.Show("¡Se ha Eliminado!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtIdCli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNomCli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtApeCli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
