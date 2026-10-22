using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_final 
{
    class ConexionCRUD 
    {
        //Variable para la cadena
        public string cadena;
        //Metodo que ocupa la cadena de coneccion
        public void conec()
        {
            cadena = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ProgIII; Integrated Security= True";
        }
    }
}
