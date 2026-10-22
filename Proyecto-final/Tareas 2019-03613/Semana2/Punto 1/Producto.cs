using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final 
{
   public class Producto: FormOperar    //clase producto que hereda los datos del formulario
    {

        //metodo para almacenar los datos principales del producto
        public void almacenar(string Nombre, string Codigo, string Marca, string Precio)
        {
            MessageBox.Show ("Hemos almacenado "+ Nombre + "\nEl codigo de barras " + Codigo + " de la marca " +
                Marca + "\nCon un precio de " + Precio, "Info. Producto", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public class Papeles : Producto     //clase papeles que hereda datos de la clase producto, es decir es un tipo de producto
        {
           //metodo para agregar los datos del producto elegido que es papel, este almacena los datos particulares del producto
            public void selecpapel(string Tipo, string Color, string Tamanio)
            {
                MessageBox.Show("\nEs de papel de " + Tipo + "\nSu color es " + Color + " con tamaño de "+ Tamanio, "Producto Papel", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
       public class utensilios: Producto    //clase utensilio que hereda de la clase producto, es decir es un tipo de producto
        {
            //metodo utilizado para guardar los datos particulares del producto utensilio
            public void selecutensilio( string Categoria, string Material, string Peso)
            {

                MessageBox.Show("Es de la categoria " + Categoria + " de " + Material + " con un peso de "+ Peso, "Producto Utensilio",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
