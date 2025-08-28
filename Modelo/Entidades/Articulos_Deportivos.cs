using Modelo.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.Entidades
{
    public class Articulos_Deportivos
    {
        private int idHerramienta;
        private string nombre;
        private int cantidad;
        private int idEstado;
        private DateTime fechaIntegracion;
        private int idInventario;
        private string nombreEstado; // Propiedad para el nombre del estado

        public int IdHerramienta { get => idHerramienta; set => idHerramienta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public DateTime FechaIntegracion { get => fechaIntegracion; set => fechaIntegracion = value; }
        public int IdInventario { get => idInventario; set => idInventario = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }

        public static DataTable MostrarArticulosDeportivos()
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ArticulosInventario", conexionPTC);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener artículos: " + ex.Message);
                    return null;
                }
            }
        }

        public static DataTable BuscarArticulosDeportivos(string nombre)
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Articulos_Deportivos WHERE nombreHerramienta LIKE @nombre", conexionPTC);
                    da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                    return null;
                }
            }
        }

        public static void AgregarArticuloDeportivo(Articulos_Deportivos articulo)
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                string sqlInsertar = "INSERT INTO Articulos_Deportivos (nombre, cantidad, idEstado, fechaIntegracion, idInventario) " +
                     "VALUES (@nombre, @cantidad, @idEstado, @fechaIntegracion, @idInventario)";
                SqlCommand insertar = new SqlCommand(sqlInsertar, conexionPTC);
                insertar.Parameters.AddWithValue("@nombre", articulo.Nombre);
                insertar.Parameters.AddWithValue("@cantidad", articulo.Cantidad);
                insertar.Parameters.AddWithValue("@idEstado", articulo.IdEstado);
                insertar.Parameters.AddWithValue("@fechaIntegracion", articulo.FechaIntegracion);
                insertar.Parameters.AddWithValue("@idInventario", articulo.IdInventario);
                try
                {
                    insertar.ExecuteNonQuery();
                    MessageBox.Show("Artículo deportivo agregado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
            }
        }

        public static void ActualizarArticuloDeportivo(Articulos_Deportivos articulo)
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                string sqlActualizar = "UPDATE Articulos_Deportivos SET nombre = @nombreHerramienta, cantidad = @cantidad, " +
                                       "idEstado = @idEstado, fechaIntegracion = @fechaIntegracion, idInventario = @idInventario " +
                                       "WHERE idHerramienta = @idHerramienta";

                SqlCommand actualizar = new SqlCommand(sqlActualizar, conexionPTC);
                actualizar.Parameters.AddWithValue("@idHerramienta", articulo.IdHerramienta);
                actualizar.Parameters.AddWithValue("@nombreHerramienta", articulo.Nombre); // <-- coincide con SQL
                actualizar.Parameters.AddWithValue("@cantidad", articulo.Cantidad);
                actualizar.Parameters.AddWithValue("@idEstado", articulo.IdEstado);
                actualizar.Parameters.AddWithValue("@fechaIntegracion", articulo.FechaIntegracion);
                actualizar.Parameters.AddWithValue("@idInventario", articulo.IdInventario);

                try
                {
                    actualizar.ExecuteNonQuery();
                    MessageBox.Show("Artículo deportivo actualizado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }

        //public static void ActualizarArticuloDeportivo(Articulos_Deportivos articulo)
        //{
        //    using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
        //    {
        //        string sqlActualizar = "UPDATE Articulos_Deportivos SET nombre = @nombre, cantidad = @cantidad, " +
        //                               "idEstado = @idEstado, fechaIntegracion = @fechaIntegracion, idInventario = @idInventario " +
        //                               "WHERE idHerramienta = @idHerramienta";
        //        SqlCommand actualizar = new SqlCommand(sqlActualizar, conexionPTC);
        //        actualizar.Parameters.AddWithValue("@idHerramienta", articulo.IdHerramienta);
        //        actualizar.Parameters.AddWithValue("@nombre", articulo.NombreHerramienta);
        //        actualizar.Parameters.AddWithValue("@cantidad", articulo.Cantidad);
        //        actualizar.Parameters.AddWithValue("@idEstado", articulo.IdEstado);
        //        actualizar.Parameters.AddWithValue("@fechaIntegracion", articulo.FechaIntegracion);
        //        actualizar.Parameters.AddWithValue("@idInventario", articulo.IdInventario);

        //        try
        //        {
        //            actualizar.ExecuteNonQuery();
        //            MessageBox.Show("Artículo deportivo actualizado correctamente");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al actualizar: " + ex.Message);
        //        }
        //    }
        //}

        public static void EliminarArticuloDeportivo(int idHerramienta)
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                string sqlEliminar = "DELETE FROM Articulos_Deportivos WHERE idHerramienta = @idHerramienta";
                SqlCommand eliminar = new SqlCommand(sqlEliminar, conexionPTC);
                eliminar.Parameters.AddWithValue("@idHerramienta", idHerramienta);

                try
                {
                    eliminar.ExecuteNonQuery();
                    MessageBox.Show("Artículo deportivo eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
