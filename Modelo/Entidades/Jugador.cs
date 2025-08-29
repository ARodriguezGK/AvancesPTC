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
    public class Jugador
    {
        private int idJugador;
        private string nombreJugador;
        private string apellidoJugador;
        private int idPosicion;
        private int dorsal;
        private DateTime fechaNacimiento;
        private int idEquipo;
        private int idJugador1;

        public int IdJugador1 { get => idJugador; set => idJugador = value; }
        public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
        public string ApellidoJugador { get => apellidoJugador; set => apellidoJugador = value; }
        public int IdPosicion { get => idPosicion; set => idPosicion = value; }
        public int Dorsal { get => dorsal; set => dorsal = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public int IdJugador { get => idJugador1; set => idJugador1 = value; }


        public static DataTable MostrarJugadores()
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            {
                string query = @"SELECT 
                                Jugador.idJugador,
                                Jugador.nombre,
                                Jugador.apellido,
                                Jugador.edad,
                                Jugador.dorsal,
                                Jugador.idPosicion,
                                Posicion.Nombre AS Posicion
                             FROM Jugador
                             INNER JOIN Posicion ON Jugador.idPosicion = Posicion.idPosicion";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void InsertarJugador(string nombre, string apellido, int edad, int dorsal, int idPosicion)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            {
                string query = @"INSERT INTO Jugador(nombre, apellido, edad, dorsal, idPosicion)
                                 VALUES(@nombre, @apellido, @edad, @dorsal, @idPosicion)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@dorsal", dorsal);
                cmd.Parameters.AddWithValue("@idPosicion", idPosicion);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ActualizarJugador(int idJugador, string nombre, string apellido, int edad, int dorsal, int idPosicion)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            {
                string query = @"UPDATE Jugador
                                 SET nombre=@nombre,
                                     apellido=@apellido,
                                     edad=@edad,
                                     dorsal=@dorsal,
                                     idPosicion=@idPosicion
                                 WHERE idJugador=@idJugador";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idJugador", idJugador);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@dorsal", dorsal);
                cmd.Parameters.AddWithValue("@idPosicion", idPosicion);
                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarJugador(int idJugador)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            {
                string query = "DELETE FROM Jugador WHERE idJugador=@idJugador";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idJugador", idJugador);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable BuscarJugadores(string nombre)
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            {
                string query = @"SELECT 
                                    Jugador.idJugador,
                                    Jugador.nombre,
                                    Jugador.apellido,
                                    Jugador.edad,
                                    Jugador.dorsal,
                                    Jugador.idPosicion,
                                    Posicion.Nombre AS Posicion
                                 FROM Jugador
                                 INNER JOIN Posicion ON Jugador.idPosicion = Posicion.idPosicion
                                 WHERE Jugador.nombre LIKE '%' + @nombre + '%'";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
