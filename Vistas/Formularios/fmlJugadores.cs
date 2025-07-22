using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Conexion;

namespace Vistas.Formularios
{
    public partial class fmlJugadores : Form
    {
        public fmlJugadores()
        {
            InitializeComponent();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            fmlGestion fmlGestion = new fmlGestion();
            fmlGestion.Show();

            this.Hide();
        }

        private void pnlBarraEstado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            fmlPartidos fmlPartidos = new fmlPartidos();
            fmlPartidos.Show();

            this.Hide();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {

        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            fmlinventario fmlinventario = new fmlinventario();
            fmlinventario.Show();

           
            this.Hide();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblJugadoresBasic_Click(object sender, EventArgs e)
        {

        }

        private void btnAñaJugador_Click(object sender, EventArgs e)
        {
            SqlConnection conexionPTC = ConexionDB.AbrirConexion();

            String sqlGuardarJugador = "Insert into dbo.Jugador( nombre , apellido , edad , dorsal , posicion , idUsuario )" +
                " values ( @nombre , @apellido, @edad , @dorsal , @posicion , @idUsuario )";

            SqlCommand insertar = new SqlCommand(sqlGuardarJugador, conexionPTC);

            insertar.Parameters.AddWithValue("@nombre", txtNombreJugadores.Text);
            insertar.Parameters.AddWithValue("@apellido", txtApellidoJugadores.Text);
            insertar.Parameters.AddWithValue("@edad", txtEdadJugadores.Text);
            insertar.Parameters.AddWithValue("@dorsal", txtDorsalJugadores.Text);
            insertar.Parameters.AddWithValue("@posicion", txtPosicionJugadores.Text);
            insertar.Parameters.AddWithValue("@idUsuario", 1 );

            try
            {
                insertar.ExecuteNonQuery();
                MessageBox.Show("Jugador guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionPTC.Close();
            }

        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarJugador_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void fmlJugadores_Load(object sender, EventArgs e)
        {

        }

        private void txtEdadJugadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPosicionJugadores_Click(object sender, EventArgs e)
        {

        }

        private void txtPosicionJugadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDorsalJugadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoJugadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDorsalJugadores_Click(object sender, EventArgs e)
        {

        }

        private void lblEdadJugadores_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidoJugadores_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreJugadores_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreJugadores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
