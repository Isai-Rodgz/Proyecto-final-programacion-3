using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;




namespace MyLibreria
{
    public class Utilidades
    {
        
        public static DataSet ejecutar(string cmd)
        {
            //instanciamos lo que es la conceccion ala bace de datos
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            DataSet Ds = new DataSet(); 
            SqlDataAdapter Dp = new SqlDataAdapter(cmd, con); 
            Dp.Fill(Ds); 
            con.Close(); 
 
            return Ds;

        }
        public static Boolean Validarformulario(Control objeto, ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in objeto.Controls)
            {
                if (Item is ErrorTextBox)
                {
                    ErrorTextBox obj = (ErrorTextBox)Item;

                    if (obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj, "Este campo no puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    if (obj.SoloNumeros == true)
                    {
                        int count = 0, letrasEncontradas = 0;
                        foreach (char letra in obj.Text.Trim())
                        {
                            if (Char.IsLetter(obj.Text.Trim(), count))
                            {
                                letrasEncontradas++;
                            }
                            count++;
                        }
                        if (letrasEncontradas != 0)
                        {
                            HayErrores = true;
                            errorProvider.SetError(obj, "Solo numeros");
                        }
                    }

                }

            }
            return HayErrores;
        }

    }
}
