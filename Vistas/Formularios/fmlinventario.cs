using Modelo.Conexion;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class fmlinventario : Form
    {
        int idInventarioSeleccionado = 0; // Variable para almacenar el ID del jugador seleccionado



        public fmlinventario()
        {
            InitializeComponent();
        }



        private void btnJugadores_inventario_Click(object sender, EventArgs e)
        {
            fmlJugadores fmlJugadores = new fmlJugadores();
            fmlJugadores.Show();

            this.Hide();
        }

        private void pnlMenu_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPartidos_inventario_Click(object sender, EventArgs e)
        {
            fmlPartidos fmlPartidos = new fmlPartidos();
            fmlPartidos.Show();

            this.Hide();
        }

        private void btnGestion_inventario_Click(object sender, EventArgs e)
        {
            fmlGestion fmlGestion = new fmlGestion();
            fmlGestion.Show();

            this.Hide();
        }

        private void pnlBarraTitulo_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxUser_inventario_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_inventario_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogo_inventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblinventario_Click(object sender, EventArgs e)
        {

        }

        private void btnAñaObjeto_Click(object sender, EventArgs e)
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
            LlenarDataGridView();


        }


        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
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

        //private void btnQuitarObje_Click(object sender, EventArgs e)
        //{
        //    String mensaje = "¿Está seguro de que desea eliminar este inventario?";
        //    String titulo = "Confirmación de eliminación";
        //    DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (resultado == DialogResult.Yes)
        //    {
        //        SqlConnection conexionPTC = ConexionDB.AbrirConexion();
        //        String sqlEliminarJugador = "DELETE FROM dbo.Herramienta WHERE idHerramienta = @idHerramienta";
        //        SqlCommand eliminar = new SqlCommand(sqlEliminarJugador, conexionPTC);
        //        eliminar.Parameters.AddWithValue("@idHerramienta", idInventarioSeleccionado);
        //        try
        //        {
        //            eliminar.ExecuteNonQuery();
        //            LlenarDataGridView();
        //            LimpiarFormulario();
        //            MessageBox.Show("Inventario eliminado correctamente");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al eliminar: " + ex.Message);
        //        }
        //        finally
        //        {
        //            conexionPTC.Close();
        //        }
        //  }
        //}

        private void lblEstadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaInventario_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadInventario_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreInventario_Click(object sender, EventArgs e)
        {

        }

        private void txtHerramientaInventario_TextChanged(object sender, EventArgs e)
        {

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
        private void fmlInventario_Load(object sender, EventArgs e)
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

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitarObje_Click(object sender, EventArgs e)
        {
            if (idInventarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un artículo primero");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este artículo?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Articulos_Deportivos.EliminarArticuloDeportivo(idInventarioSeleccionado);
                LlenarDataGridView();
            }
        }
    }
}
