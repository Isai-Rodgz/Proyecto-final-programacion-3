using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_final 
{
   //Clase para la cadena de conexion de la base de datos
    class Conectar
    {
        public string Cadena;

        public void conex()
        {
           Cadena= @"Data Source=localhost\SQLEXPRESS;Initial Catalog= BD_Sucarnet;Integrated Security=True;";
        }
    }
}
