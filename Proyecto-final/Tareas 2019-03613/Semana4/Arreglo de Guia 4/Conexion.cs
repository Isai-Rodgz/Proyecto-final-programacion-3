using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final 
{
    class Conexion
    {
        //Variable para la cadena
        public string cadena;
        //Metodo que ocupa la cadena de coneccion
        public void conec()
        {
            cadena = @"Server= localhost\SQLEXPRESS;Database=BD_Avanzada;Integrated security=True;";
        }

    }
}
