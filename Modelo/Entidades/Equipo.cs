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
    public class Equipo
    {
        private int idEquipo;
        private string nombreEquipo;
        private int idCategoria;
        private int idUsuario;

        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public static DataTable MostrarEquipos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(@"SELECT e.idEquipo, e.nombre, c.nombreCategoria, u.nombre AS nombreUsuario FROM Equipo e INNER JOIN CategoriaEquipo c ON e.idCategoria = c.idCategoria INNER JOIN Usuario u ON e.idUsuario = u.idUsuario", cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        public static void Insertar(Equipo eq)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Equipo(nombre, idCategoria, idUsuario) VALUES(@nombre, @idCategoria, @idUsuario)", cn))
            {
                cmd.Parameters.AddWithValue("@nombre", eq.NombreEquipo);
                cmd.Parameters.AddWithValue("@idCategoria", eq.IdCategoria);
                cmd.Parameters.AddWithValue("@idUsuario", eq.IdUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Equipo eq)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Equipo SET nombre=@nombre, idCategoria=@idCategoria, idUsuario=@idUsuario WHERE idEquipo=@idEquipo", cn))
            {
                cmd.Parameters.AddWithValue("@nombre", eq.NombreEquipo);
                cmd.Parameters.AddWithValue("@idCategoria", eq.IdCategoria);
                cmd.Parameters.AddWithValue("@idUsuario", eq.IdUsuario);
                cmd.Parameters.AddWithValue("@idEquipo", eq.IdEquipo);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar(int idEquipo)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Equipo WHERE idEquipo=@idEquipo", cn))
            {
                cmd.Parameters.AddWithValue("@idEquipo", idEquipo);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
