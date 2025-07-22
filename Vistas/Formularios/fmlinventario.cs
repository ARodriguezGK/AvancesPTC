using Modelo.Conexion;
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
            SqlConnection conexionPTC = ConexionDB.AbrirConexion();
             String sqlGuardarJugador = "INSERT INTO dbo.Herramienta(nombre,cantidad,estado,fechaIntegracion,idInventario)" +
                "VALUES (@nombre,@cantidad,@estado,@fechaIntegracion,@idInventario)";
            
            SqlCommand insertar = new SqlCommand(sqlGuardarJugador, conexionPTC);

            insertar.Parameters.AddWithValue("@nombre", txtHerramientaInventario.Text);
            insertar.Parameters.AddWithValue("@cantidad", txtCantidadInventario.Text);
            insertar.Parameters.AddWithValue("@estado", txtEstadoInventario.Text);
            DateTime fecha = DateTime.Parse(txtFechaInventario.Text);
            insertar.Parameters.AddWithValue("@fechaIntegracion", fecha);
            insertar.Parameters.AddWithValue("@idInventario", 1);

            try
            {
                insertar.ExecuteNonQuery();
                LimpiarFormulario();
                LlenarDataGridView();

                MessageBox.Show("Inventario guardado correctamente");
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

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evitar encabezado
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];
                idInventarioSeleccionado = Convert.ToInt32(fila.Cells["idHerramienta"].Value); 
                
            }
        }

        private void btnQuitarObje_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Está seguro de que desea eliminar este inventario?";
            String titulo = "Confirmación de eliminación";
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                SqlConnection conexionPTC = ConexionDB.AbrirConexion();
                String sqlEliminarJugador = "DELETE FROM dbo.Herramienta WHERE idHerramienta = @idHerramienta";
                SqlCommand eliminar = new SqlCommand(sqlEliminarJugador, conexionPTC);
                eliminar.Parameters.AddWithValue("@idHerramienta", idInventarioSeleccionado);
                try
                {
                    eliminar.ExecuteNonQuery();
                    LlenarDataGridView();
                    LimpiarFormulario();
                    MessageBox.Show("Inventario eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    conexionPTC.Close();
                }
            }
        }

        private void txtFechaInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstadoInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadInventario_TextChanged(object sender, EventArgs e)
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

        private void lblNombreInventario_Click(object sender, EventArgs e)
        {

        }

        private void txtHerramientaInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void LlenarDataGridView()
        {


            using (SqlConnection conexionPTC = ConexionDB.AbrirConexion())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Herramienta", conexionPTC);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvInventario.DataSource = dt;
                    dgvInventario.Columns["idInventario"].Visible = false;

                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                }
            }
        }
        private void fmlInventario_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        private void LimpiarFormulario()
        {
            txtCantidadInventario.Clear();
            txtHerramientaInventario.Clear();
            txtCantidadInventario.Clear();
            txtFechaInventario.Clear();
          
        }



    }
}
