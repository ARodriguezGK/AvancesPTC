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
    public partial class fmlEquipos_Gestion : Form
    {
        private int idEquipoSeleccionado = 0;

        public fmlEquipos_Gestion()
        {
            InitializeComponent();
        }


        private void Equipos_Gestion_Load(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarCategorias();
        }

        private void LimpiarCampos()
        {
            idEquipoSeleccionado = 0;
            txtNombreEquipo.Clear();
            cbxCategoriaEquipo.SelectedIndex = -1;
        }

        private void CargarEquipos()
        {
            dgvEquipos.DataSource = Equipo.MostrarEquipos();

            
            if (dgvEquipos.Columns["idUsuario"] != null)
                dgvEquipos.Columns["idUsuario"].Visible = false;

            if (dgvEquipos.Columns["nombreUsuario"] != null)
                dgvEquipos.Columns["nombreUsuario"].Visible = false;
        }

        private void CargarCategorias()
        {
            cbxCategoriaEquipo.DataSource = CategoriaEquipo.MostrarCategorias();
            cbxCategoriaEquipo.DisplayMember = "nombreCategoria";
            cbxCategoriaEquipo.ValueMember = "idCategoria";
        }


        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEquipos.Rows[e.RowIndex];
                idEquipoSeleccionado = Convert.ToInt32(fila.Cells["idEquipo"].Value);
                txtNombreEquipo.Text = fila.Cells["nombre"].Value.ToString();
                cbxCategoriaEquipo.Text = fila.Cells["nombreCategoria"].Value.ToString();
            }
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarEquipo.Text.Trim();
            DataTable dt = Equipo.MostrarEquipos();

            if (!string.IsNullOrEmpty(filtro))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"nombre LIKE '%{filtro}%'";
                dgvEquipos.DataSource = dv;
            }
            else
            {
                dgvEquipos.DataSource = dt;
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void cbxCategoriaEquipo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            fmlJugadores fmlJugadores = new fmlJugadores();
            fmlJugadores.Show();
            this.Hide();
        }

        private void txtNombreEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void lblGestionEquipos_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCtegoriaEquipo_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            fmlinventario fmlinventario = new fmlinventario();
            fmlinventario.Show();
            this.Hide();
        }

        private void btnActualizarEquipo_Click(object sender, EventArgs e)
        {
            if (idEquipoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un equipo de la tabla primero.");
                return;
            }

            Equipo actualizado = new Equipo()
            {
                IdEquipo = idEquipoSeleccionado,
                NombreEquipo = txtNombreEquipo.Text,
                IdCategoria = Convert.ToInt32(cbxCategoriaEquipo.SelectedValue),
                IdUsuario = 1 // 👈 oculto
            };

            Equipo.Actualizar(actualizado);
            MessageBox.Show("Equipo actualizado correctamente.");
            CargarEquipos();
            LimpiarCampos();
        }

        private void btnQuitarEquipo_Click(object sender, EventArgs e)
        {
            if (idEquipoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un equipo a eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este equipo?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Equipo.Eliminar(idEquipoSeleccionado);
                MessageBox.Show("Equipo eliminado correctamente.");
                CargarEquipos();
                LimpiarCampos();
            }   
        }

        private void btnAñaEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEquipo.Text) || cbxCategoriaEquipo.SelectedValue == null)
            {
                MessageBox.Show("Complete todos los campos antes de agregar.");
                return;
            }

            Equipo nuevo = new Equipo()
            {
                NombreEquipo = txtNombreEquipo.Text,
                IdCategoria = Convert.ToInt32(cbxCategoriaEquipo.SelectedValue),
                IdUsuario = 1 // 👈 lo dejamos fijo/oculto
            };

            Equipo.Insertar(nuevo);
            MessageBox.Show("Equipo agregado correctamente.");
            CargarEquipos();
            LimpiarCampos();
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnGestEquipos_Click(object sender, EventArgs e)
        {

        }

        private void btnGestEntrenadores_Click(object sender, EventArgs e)
        {
            fmlGestion fmlGestion = new fmlGestion();
            fmlGestion.Show();
            this.Hide();
        }

        private void lblNombreEquipo_Click(object sender, EventArgs e)
        {

        }

        private void pnlBarraEstado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
