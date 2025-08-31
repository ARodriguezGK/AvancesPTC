using Modelo.Conexion;
using Modelo.Entidades;
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

namespace Vistas.Formularios
{
    public partial class fmlJugadores_ENTRENADORES: Form
    {
        int idJugadorSeleccionado = 0; // Variable para almacenar el ID del jugador seleccionado
        public fmlJugadores_ENTRENADORES()
        {
            InitializeComponent();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxPosicionJugador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownDorsalJugador_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownEdadJugador_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPosicionJugadores_Click(object sender, EventArgs e)
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

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {
            if (idJugadorSeleccionado > 0)
            {
                Jugador.ActualizarJugador(
                    idJugadorSeleccionado,
                    txtNombreJugadores.Text,
                    txtApellidoJugadores.Text,
                    (int)numericUpDownEdadJugador.Value,
                    (int)numericUpDownDorsalJugador.Value,
                    (int)cbxPosicionJugador.SelectedValue
                );
                MostrarJugadores();
            }
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvJugadores.Rows[e.RowIndex];

                // Guardar idJugador seleccionado (para update/delete)
                idJugadorSeleccionado = Convert.ToInt32(fila.Cells["idJugador"].Value);

                // Llenar controles
                txtNombreJugadores.Text = fila.Cells["nombre"].Value.ToString();
                txtApellidoJugadores.Text = fila.Cells["apellido"].Value.ToString();
                numericUpDownEdadJugador.Value = Convert.ToInt32(fila.Cells["edad"].Value);
                numericUpDownDorsalJugador.Value = Convert.ToInt32(fila.Cells["dorsal"].Value);

                //ComboBox de posiciones
                cbxPosicionJugador.SelectedValue = Convert.ToInt32(fila.Cells["idPosicion"].Value);
            }
        }

        private void btnAñaJugador_Click(object sender, EventArgs e)
        {
            Jugador.InsertarJugador(
            txtNombreJugadores.Text,
            txtApellidoJugadores.Text,
            (int)numericUpDownEdadJugador.Value,
            (int)numericUpDownDorsalJugador.Value,
            (int)cbxPosicionJugador.SelectedValue);
            MostrarJugadores();

        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblJugadoresBasic_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            fmlPartidos_ENTRENADORES fmlPartidos = new fmlPartidos_ENTRENADORES();
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
            fmlInventario_ENTRENADORES fmlInventario = new fmlInventario_ENTRENADORES();
            fmlInventario.Show();
            this.Hide();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvJugadores.DataSource = Jugador.BuscarJugadores(txtBuscar.Text);
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void fmlJugadores_ENTRENADORES_Load(object sender, EventArgs e)
        {
            //mostrar opciones/valores en el combobox
            CargarPosicionesEnCombo();
            // Llenar dgv jugadores
            LlenarDataGridView();
            MostrarJugadores();
        }

        private void MostrarJugadores()
        {
            dgvJugadores.DataSource = Jugador.MostrarJugadores();

            // ocultar columnas de IDs
            dgvJugadores.Columns["idJugador"].Visible = false;
            dgvJugadores.Columns["idPosicion"].Visible = false;
        }

        private void CargarPosicionesEnCombo()
        {
            using (SqlConnection cn = ConexionDB.AbrirConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idPosicion, Nombre FROM Posicion", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxPosicionJugador.DataSource = dt;
                cbxPosicionJugador.DisplayMember = "Nombre";   // lo que ve el usuario
                cbxPosicionJugador.ValueMember = "idPosicion"; // lo que se guarda
            }
        }

        private void LlenarDataGridView()
        {
            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                string sql = @"SELECT j.idJugador, j.nombre, j.apellido, j.edad, j.dorsal, p.Nombre AS Posicion
                       FROM Jugador j
                       INNER JOIN Posicion p ON j.idPosicion = p.idPosicion";
                var da = new SqlDataAdapter(sql, conexionPTC);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvJugadores.DataSource = dt;
            }

        }

        private void LimpiarFormulario()
        {
            txtNombreJugadores.Clear();
            txtApellidoJugadores.Clear();
            idJugadorSeleccionado = 0; // Reiniciar el ID del jugador seleccionado}
        }
    }
}
