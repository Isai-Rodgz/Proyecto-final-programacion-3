using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_final 
{
    class Conexion7
    {
        //Metodo para poder ejecutar cualquier sentencia en mi base de datos
        public static DataSet Ejecutar(string cmd)
        {
            //instanciamos lo que es la conceccion a la bace de datos
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Control_Pedidos;Integrated Security=True");
            con.Open();

            DataSet Ds = new DataSet();
            SqlDataAdapter Dp = new SqlDataAdapter(cmd, con);
            Dp.Fill(Ds);
            con.Close();

            return Ds;

        }
        
    }
}
