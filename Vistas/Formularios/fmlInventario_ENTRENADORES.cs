using Modelo.Conexion;
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
using Modelo.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas.Formularios
{
    public partial class fmlInventario_ENTRENADORES : Form
    {
        int idInventarioSeleccionado = 0; // Variable para almacenar el ID del jugador seleccionado

        public fmlInventario_ENTRENADORES()
        {
            InitializeComponent();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvInventario.Rows[e.RowIndex];

            string nombre = fila.Cells[0].Value.ToString(); // columna 0 = Nombre_del_articulo

            idInventarioSeleccionado = ObtenerIdPorNombre(nombre);

            txtHerramientaInventario.Text = nombre;
            numericUpDownCantidadObjeto.Value = Convert.ToInt32(fila.Cells[1].Value); // Cantidad
            monthCalendarObjeto.SetDate(Convert.ToDateTime(fila.Cells[2].Value)); // Fecha_de_Integracion

            string estadoNombre = fila.Cells[3].Value.ToString(); // Tipo_de_Estado
            int idx = cbxEstadoObjeto.FindStringExact(estadoNombre);
            if (idx >= 0) cbxEstadoObjeto.SelectedIndex = idx;
        }

        private void pnlLogo_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActObjeto_Click(object sender, EventArgs e)
        {

            if (idInventarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un artículo primero");
                return;
            }

            Articulos_Deportivos articulo = new Articulos_Deportivos
            {
                IdHerramienta = idInventarioSeleccionado,
                Nombre = txtHerramientaInventario.Text,
                Cantidad = (int)numericUpDownCantidadObjeto.Value,
                IdEstado = Convert.ToInt32(cbxEstadoObjeto.SelectedValue),
                FechaIntegracion = monthCalendarObjeto.SelectionStart,
                IdInventario = 1
            };

            Articulos_Deportivos.ActualizarArticuloDeportivo(articulo);
            LlenarDataGridView(); // refrescar dgv
        }

        private void numericUpDownCantidadObjeto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendarObjeto_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cbxEstadoObjeto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaInventario_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadInventario_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreObjeto_Click(object sender, EventArgs e)
        {

        }

        private void txtHerramientaInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitarObje_Click(object sender, EventArgs e)
        {

        }

        private void btnAñaObjeto_Click(object sender, EventArgs e)
        {

        }

        private void pnlBarraTitulo_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblinventario_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPartidos_inventario_Click(object sender, EventArgs e)
        {
            fmlPartidos_ENTRENADORES fmlPartidos = new fmlPartidos_ENTRENADORES();
            fmlPartidos.Show();
            this.Hide();
        }

        private void btnJugadores_inventario_Click(object sender, EventArgs e)
        {
            fmlJugadores_ENTRENADORES fmlJugadores = new fmlJugadores_ENTRENADORES();
            fmlJugadores.Show();

            this.Hide();
        }

        private void picBoxUser_inventario_Click(object sender, EventArgs e)
        {

            Form fmlLogin = new fmlLogin();
        }

        private void btnInventario_inventario_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fmlInventario_ENTRENADORES_Load(object sender, EventArgs e)
        {
            CargarEstadosEnCombo();
            LlenarDataGridView();
        }

        private void CargarEstadosEnCombo()
        {
            using (var cn = ConexionDB.AbrirConexion())
            {
                var da = new SqlDataAdapter("SELECT idEstado, nombre FROM Estado", cn);
                var dt = new DataTable();
                da.Fill(dt);
                cbxEstadoObjeto.DataSource = dt;
                cbxEstadoObjeto.DisplayMember = "nombre";
                cbxEstadoObjeto.ValueMember = "idEstado";
            }
        }

        private void LimpiarFormulario()
        {

            txtHerramientaInventario.Clear();
            numericUpDownCantidadObjeto.Value = 0;
            cbxEstadoObjeto.SelectedIndex = -1;
            monthCalendarObjeto.SetDate(DateTime.Today);
            idInventarioSeleccionado = 0;


        }

        private void LlenarDataGridView()
        {
            using (var cn = ConexionDB.AbrirConexion())
            {
                var da = new SqlDataAdapter("SELECT * FROM ArticulosInventario", cn);
                var dt = new DataTable();
                da.Fill(dt);
                dgvInventario.DataSource = dt;
            }
        }

        private int ObtenerIdPorNombre(string nombre)
        {
            using (var cn = ConexionDB.AbrirConexion())
            {
                var cmd = new SqlCommand("SELECT TOP 1 idHerramienta FROM Articulos_Deportivos WHERE nombre = @nombre", cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                object result = cmd.ExecuteScalar();
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return 0;
            }
        }
    }
}