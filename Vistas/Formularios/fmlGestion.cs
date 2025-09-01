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
    public partial class fmlGestion : Form
    {
        private DataTable usuariosTabla;
        private int idUsuarioSeleccionado = 0;

        public fmlGestion()
        {
            InitializeComponent();
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            fmlJugadores fmlJugadores = new fmlJugadores();
            fmlJugadores.Show();

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

        private void btnGestion_Click(object sender, EventArgs e)
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

        private void btnGestEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void btnGestEquipos_Click(object sender, EventArgs e)
        {
            fmlEquipos_Gestion fmlEquipos_Gestion = new fmlEquipos_Gestion();
            fmlEquipos_Gestion.Show();
            this.Hide();
        }

        private void btnGestCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarEntrenador_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario del listado.");
                return;
            }

            var confirmar = MessageBox.Show("¿Seguro que deseas eliminar este usuario?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes) return;

            Usuario u = new Usuario { IdUsuario = idUsuarioSeleccionado };
            u.EliminarUsuario();
            MessageBox.Show("Usuario eliminado correctamente.");
            RefrescarGridYLimpiar();
        }

        private void lblGestionEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEntrenador_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }

            Usuario u = new Usuario
            {
                IdUsuario = idUsuarioSeleccionado,
                Nombre = txtNombreGestionEntrenador.Text.Trim(),
                Correo = txtCorreoGestionEntrenadores.Text.Trim(),
                Contraseña = txtContraseñaGestionEntrenadores.Text,
                Estado = cbxEstadoGestionEntrenador.Text,
                IdRol = Convert.ToInt32(cbxRol.SelectedValue)
            };

            u.ActualizarUsuario();
            MessageBox.Show("Usuario actualizado correctamente.");
            RefrescarGridYLimpiar();
        }

        private void dgvEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEntrenadores.Rows[e.RowIndex];

                // Índices fijos: 0=idUsuario, 1=nombre, 2=correo, 3=contraseña, 4=estado, 5=idRol
                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtNombreGestionEntrenador.Text = fila.Cells[1].Value?.ToString();
                txtCorreoGestionEntrenadores.Text = fila.Cells[2].Value?.ToString();
                txtContraseñaGestionEntrenadores.Text = fila.Cells[3].Value?.ToString();

                // Estado
                string estadoTexto = fila.Cells[4].Value?.ToString();
                if (estadoTexto == "Activo")
                    cbxEstadoGestionEntrenador.SelectedValue = 1;
                else if (estadoTexto == "Inactivo")
                    cbxEstadoGestionEntrenador.SelectedValue = 2;
                else
                    cbxEstadoGestionEntrenador.SelectedIndex = -1;

                // Rol
                if (fila.Cells[5].Value != null)
                    cbxRol.SelectedValue = Convert.ToInt32(fila.Cells[5].Value);
                else
                    cbxRol.SelectedIndex = -1;
            }
        }

        private void btnAñaEntrenador_Click(object sender, EventArgs e)
        {
            if (cbxRol.SelectedValue == null || cbxEstadoGestionEntrenador.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un estado y un rol antes de agregar.");
                return;
            }

            Usuario u = new Usuario
            {
                Nombre = txtNombreGestionEntrenador.Text.Trim(),
                Correo = txtCorreoGestionEntrenadores.Text.Trim(),
                Contraseña = txtContraseñaGestionEntrenadores.Text,
                Estado = cbxEstadoGestionEntrenador.Text,
                IdRol = Convert.ToInt32(cbxRol.SelectedValue)
            };

            u.InsertarUsuario();
            MessageBox.Show("Usuario agregado correctamente.");
            RefrescarGridYLimpiar();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstadoGestionEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            string filtro = txtBuscar.Text.Trim();
            if (usuariosTabla != null)
            {
                DataView dv = usuariosTabla.DefaultView;
                if (!string.IsNullOrEmpty(filtro))
                    dv.RowFilter = $"nombre LIKE '%{filtro}%' OR correo LIKE '%{filtro}%'";
                else
                    dv.RowFilter = "";
            }
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void fmlGestion_Load(object sender, EventArgs e)
        {
            CargarRoles();

            //Cargar Estados desde la clase EstadoEntrenador
            cbxEstadoGestionEntrenador.DataSource = EstadoEntrenador.ObtenerEstados();
            cbxEstadoGestionEntrenador.DisplayMember = "NombreEstado";
            cbxEstadoGestionEntrenador.ValueMember = "IdEstado";
            cbxEstadoGestionEntrenador.SelectedIndex = -1;

            //Cargar usuarios
            RefrescarGridYLimpiar();
        }

        private void CargarRoles()
        {
            using (SqlConnection conexion = ConexionDB.AbrirConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT idRol, nombreRol FROM Rol", conexion);
                DataTable dtRoles = new DataTable();
                da.Fill(dtRoles);

                cbxRol.DataSource = dtRoles;
                cbxRol.DisplayMember = "nombreRol";
                cbxRol.ValueMember = "idRol";
                cbxRol.SelectedIndex = -1; // Sin selección por defecto
            }
        }

        private void RefrescarGridYLimpiar()
        {
            usuariosTabla = Usuario.MostrarUsuarios();
            dgvEntrenadores.DataSource = usuariosTabla;

            // Ocultar columna idUsuario si quieres
            if (dgvEntrenadores.Columns.Count > 0)
                dgvEntrenadores.Columns[0].Visible = false;

            idUsuarioSeleccionado = 0;
            txtNombreGestionEntrenador.Clear();
            txtCorreoGestionEntrenadores.Clear();
            txtContraseñaGestionEntrenadores.Clear();
            cbxEstadoGestionEntrenador.SelectedIndex = -1;
            cbxRol.SelectedIndex = -1;
        }

        private void txtCorreoGestionEntrenadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaGestionEntrenadores_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseñaGestionEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreGestionEntrenador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCorreoGestionEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoGestionEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreGestionEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }
    }
}
