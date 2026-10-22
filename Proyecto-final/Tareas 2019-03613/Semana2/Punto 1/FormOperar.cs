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
    public partial class FormOperar : Form
    {       
           
            
            
 
        public FormOperar()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // codigo para que el grupbox utensilio inicie inabilitado
            gbxutensilio.Enabled = false;
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Instancia de la clase producto que permite acceder al metodo que almacena los datos principales del producto
             Producto prod = new Producto();
            prod.almacenar(txtnombre.Text, txtcodigo.Text, txtmarca.Text, txtprecio.Text);

            if (rdbpapel.Checked)   //Condicion para que se pueda ejecutar el metodo que corresponde 
                                    //al producto que se ha elegido registrar
            {
                // Aqui se trabajara con el producto Papel, se ejecuta el metodo que lo almacena
                Producto.Papeles pap = new Producto.Papeles();
                pap.selecpapel(txttipo.Text, txtcolor.Text, txttamanio.Text);
            }
            else if(rdbutensilios.Checked == Enabled)
            {
                // Aqui se trabajara con el producto Utensilio, se ejecuta el metodo que lo almacena
                Producto.utensilios utl = new Producto.utensilios();
                utl.selecutensilio(txtcategoria.Text, txtmaterial.Text, txtpeso.Text);
            }
        }

        // Metodo que trabaja con los radiobuttons para que se inhabilite o habilite el grupbox correspondiente
        private void rdbpapel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpapel.Checked)
            {
                gbxpapel.Enabled = true;
                gbxutensilio.Enabled = false;
            }
        }

        // Metodo que trabaja con los radiobuttons para que se inhabilite o habilite el grupbox correspondiente
        private void rdbutensilios_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbutensilios.Checked)
            {
                gbxpapel.Enabled = false;
                gbxutensilio.Enabled = true;
            }
        }

        // Boton para limpiar los textbox
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcategoria.Text = "";
            txtcodigo.Text = "";
            txtcolor.Text = "";
            txtmarca.Text = "";
            txtmaterial.Text = "";
            txtnombre.Text = "";
            txtpeso.Text = "";
            txtprecio.Text = "";
            txttamanio.Text = "";
            txttipo.Text = "";
        }

        // Boton para salir de la aplicacion
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
