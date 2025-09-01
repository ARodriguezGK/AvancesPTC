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
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string correo;
        private string contraseña;
        private string estado;
        private int idRol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public static DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = ConexionDB.AbrirConexion())
            {
                string query = "SELECT idUsuario, nombre, correo, contraseña, estado, idRol FROM Usuario";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Insertar un usuario
        public void InsertarUsuario()
        {
            using (SqlConnection conexion = ConexionDB.AbrirConexion())
            {
                string query = @"INSERT INTO Usuario (nombre, correo, contraseña, estado, idRol) 
                                 VALUES (@nombre, @correo, @contraseña, @estado, @idRol)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@correo", this.Correo);
                cmd.Parameters.AddWithValue("@contraseña", this.Contraseña);
                cmd.Parameters.AddWithValue("@estado", this.Estado);
                cmd.Parameters.AddWithValue("@idRol", this.IdRol);
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar un usuario
        public void ActualizarUsuario()
        {
            using (SqlConnection conexion = ConexionDB.AbrirConexion())
            {
                string query = @"UPDATE Usuario 
                                 SET nombre=@nombre, correo=@correo, contraseña=@contraseña, estado=@estado, idRol=@idRol 
                                 WHERE idUsuario=@idUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", this.IdUsuario);
                cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@correo", this.Correo);
                cmd.Parameters.AddWithValue("@contraseña", this.Contraseña);
                cmd.Parameters.AddWithValue("@estado", this.Estado);
                cmd.Parameters.AddWithValue("@idRol", this.IdRol);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar un usuario
        public void EliminarUsuario()
        {
            using (SqlConnection conexion = ConexionDB.AbrirConexion())
            {
                string query = "DELETE FROM Usuario WHERE idUsuario=@idUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", this.IdUsuario);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
