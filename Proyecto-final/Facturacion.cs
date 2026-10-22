using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MyLibreria;


namespace Proyecto_final
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where id_usuario=" + VentanaLogin.codigo;

            DataSet ds;

            ds = Utilidades.ejecutar(cmd);

            LblAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigoCli.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("Select Nom_cli from Clientes Where id_clientes = '{0}'",TxtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.ejecutar(cmd);

                    TxtCliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();

                    TxtCodigoPro.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error:" + error.Message);
                }


            }
        }
        public static int cont_fila = 0;
        public static double total;
            
        private void BtnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Validarformulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dataGridView1.Rows.Add(TxtCodigoPro.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text);

                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if(Fila.Cells[0].Value.ToString() == TxtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }

                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;

                    }
                    else
                    {
                        dataGridView1.Rows.Add(TxtCodigoPro.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text);

                        double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                        cont_fila++;
                    }
                }

            }
            total = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                total += Convert.ToDouble(Fila.Cells[4].Value);
            }
            LblTotal.Text = "RD$ " + total.ToString();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                LblTotal.Text = "RD$ " + total.ToString();


                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();

            ConCli.ShowDialog();
            if(ConCli.DialogResult== DialogResult.OK)
            {

                TxtCodigoCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtCliente.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                TxtCodigoPro.Focus();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConPro = new ConsultarProductos();

            ConPro.ShowDialog();
            if (ConPro.DialogResult == DialogResult.OK)
            {

                TxtCodigoPro.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtDescripcion.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TxtPrecio.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                TxtCantidad.Focus();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            TxtCodigoCli.Text = "";
            TxtCliente.Text = "";
            TxtCodigoPro.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            TxtCantidad.Text = "";
            LblTotal.Text = "RD$ 0";
            dataGridView1.Rows.Clear();
            cont_fila = 0;
            total = 0;
            TxtCodigoCli.Focus();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if(cont_fila!= 0)
            {

                try
                {
                    string cmd = string.Format("Exec ActualizarFacturas '{0}'", TxtCodigoCli.Text.Trim());


                    DataSet ds = Utilidades.ejecutar(cmd);

                    string Numfac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        cmd = string.Format("Exec ActualizarDetalles '{0}','{1}','{2}','{3}'", Numfac, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString());
                        ds = Utilidades.ejecutar(cmd);

                    }

                    cmd = "Exec DatosFacturas " + Numfac;
                    ds = Utilidades.ejecutar(cmd);

                    //Ventana reporte
                    Reporte rp = new Reporte();

                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();

                    Nuevo();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }
        }
    }
}
