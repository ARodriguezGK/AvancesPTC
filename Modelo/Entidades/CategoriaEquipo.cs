using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class CategoriaEquipo
    {
        private int idCategoria;
        private string nombreCategoria;
        private int edadMinima;
        private int edadMaxima;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public int EdadMaxima { get => edadMaxima; set => edadMaxima = value; }

        public static DataTable MostrarCategorias()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("SELECT idCategoria, nombreCategoria FROM CategoriaEquipo", cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

    }
}
