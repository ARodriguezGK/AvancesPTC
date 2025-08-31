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
    public partial class fmlJugadores : Form
    {
        int idJugadorSeleccionado = 0; // Variable para almacenar el ID del jugador seleccionado

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

        private void dgvJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void lblJugadoresBasic_Click(object sender, EventArgs e)
        {

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

        private void lblEstadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void fmlJugadores_Load(object sender, EventArgs e)
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

        private void numericUpDownDorsalJugador_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownEdadJugador_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxPosicionJugador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            var fila = dgvJugadores.Rows[e.RowIndex];

            idJugadorSeleccionado = Convert.ToInt32(fila.Cells["idJugador"].Value);
            txtNombreJugadores.Text = fila.Cells["nombre"].Value?.ToString();
            txtApellidoJugadores.Text = fila.Cells["apellido"].Value?.ToString();
            numericUpDownEdadJugador.Value = Convert.ToDecimal(fila.Cells["edad"].Value);
            numericUpDownDorsalJugador.Value = Convert.ToDecimal(fila.Cells["dorsal"].Value);

            // Seleccionar posición por texto si el combo está poblado
            string pos = fila.Cells["Posicion"].Value?.ToString();
            int idx = cbxPosicionJugador.FindStringExact(pos);
            if (idx >= 0) cbxPosicionJugador.SelectedIndex = idx;
        }

        private void btnQuitarJugador_Click(object sender, EventArgs e)
        {
            if (idJugadorSeleccionado > 0)
            {
                Jugador.EliminarJugador(idJugadorSeleccionado);
                MostrarJugadores();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvJugadores.DataSource = Jugador.BuscarJugadores(txtBuscar.Text);
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}

