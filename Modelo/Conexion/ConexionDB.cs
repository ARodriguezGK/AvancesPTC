using System;

using System.Collections.Generic;

using System.Data.SqlClient;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


using System.ComponentModel;

using System.Data;

using System.Drawing;


namespace Modelo.Conexion

{

    public class ConexionDB

    {

        private static string servidor = "t0t0-gk-PSG99\\SQLEXPRESS";

        private static string database = "Administracion_deportiva";

        public static SqlConnection AbrirConexion()

        {

            string cadena = $"Data Source={servidor};initial catalog ={database}; integrated security = true;";

            SqlConnection Conexion = new SqlConnection(cadena);

            Conexion.Open();


            return Conexion;

        }

    }

}

