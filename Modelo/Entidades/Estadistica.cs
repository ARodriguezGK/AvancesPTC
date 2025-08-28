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
    public class Estadistica
    {
        private int idEstadistica;
        private int idJugador;
        private int idPartido;
        private int goles;
        private int asistencias;
        private int tarjetasAmarillas;
        private int tarjetasRojas;
        private int minutosJugados;
        private string observaciones;


        public static DataTable MostrarEstadistica()
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Estadistica", conexionPTC);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //Inventario.DataSource = dt;
                    //Inventario.Columns["idInventario"].Visible = false;
                    return dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                    return null;
                }
            }
        }
    }
}