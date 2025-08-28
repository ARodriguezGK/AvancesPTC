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
            if (e.RowIndex >= 0) // evitar encabezado
            {
                DataGridViewRow fila = dgvJugadores.Rows[e.RowIndex];

                // Asignar valores a los TextBox, numericUpdown y ComboBox
                txtNombreJugadores.Text = fila.Cells["nombre"].Value.ToString();
                txtApellidoJugadores.Text = fila.Cells["apellido"].Value.ToString();
                // Reemplaza la línea problemática en el método dgvJugadores_CellClick:
                numericUpDownEdadJugador.Value = Convert.ToByte(fila.Cells["edad"].Value);
                numericUpDownDorsalJugador.Value = Convert.ToByte(fila.Cells["dorsal"].Value);
                cbxPosicionJugador.ValueMember = fila.Cells["posicion"].Value.ToString();
                idJugadorSeleccionado = Convert.ToInt32(fila.Cells["idJugador"].Value); // Asignar el ID del jugador seleccionado

            }

        }

        private void lblJugadoresBasic_Click(object sender, EventArgs e)
        {

        }

        private void btnAñaJugador_Click(object sender, EventArgs e)
        {
            //SqlConnection conexionPTC = ConexionDB.AbrirConexion();

            //String sqlGuardarJugador = "Insert into dbo.Jugador( nombre , apellido , edad , dorsal , posicion , idUsuario )" +
            //    " values ( @nombre , @apellido, @edad , @dorsal , @posicion , @idUsuario )";

            //SqlCommand insertar = new SqlCommand(sqlGuardarJugador, conexionPTC);

            //insertar.Parameters.AddWithValue("@nombre", txtNombreJugadores.Text);
            //insertar.Parameters.AddWithValue("@apellido", txtApellidoJugadores.Text);
            //insertar.Parameters.AddWithValue("@edad", txtEdadJugadores.Text);
            //insertar.Parameters.AddWithValue("@dorsal", txtDorsalJugadores.Text);
            //insertar.Parameters.AddWithValue("@posicion", txtPosicionJugadores.Text);
            //insertar.Parameters.AddWithValue("@idUsuario", 1); // rsto es temporal



            //try
            //{
            //    insertar.ExecuteNonQuery();
            //    LimpiarFormulario();
            //    LlenarDataGridView();

            //    MessageBox.Show("Jugador guardado correctamente");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al guardar: " + ex.Message);
            //}
            //finally
            //{
            //    conexionPTC.Close();
            //}

        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {
        //    SqlConnection conexionPTC = ConexionDB.AbrirConexion();

        //    String sqlGuardarJugador = "UPDATE dbo.Jugador " +
        //        "   SET " +
        //        "       nombre = @nombre " +
        //        "      , apellido = @apellido " +
        //        "      , edad = @edad " +
        //        "      , dorsal = @dorsal " +
        //        "      , posicion = @posicion " +
        //        " WHERE idJugador = @idJugador";


        //    SqlCommand actualizar = new SqlCommand(sqlGuardarJugador, conexionPTC);

        //    actualizar.Parameters.AddWithValue("@idJugador", idJugadorSeleccionado);
        //    actualizar.Parameters.AddWithValue("@nombre", txtNombreJugadores.Text);
        //    actualizar.Parameters.AddWithValue("@apellido", txtApellidoJugadores.Text);
        //    actualizar.Parameters.AddWithValue("@edad", txtEdadJugadores.Text);
        //    actualizar.Parameters.AddWithValue("@dorsal", txtDorsalJugadores.Text);
        //    actualizar.Parameters.AddWithValue("@posicion", txtPosicionJugadores.Text);

        //    try
        //    {
        //        actualizar.ExecuteNonQuery();
        //        LlenarDataGridView();
        //        LimpiarFormulario();
        //        MessageBox.Show("Jugador ha sido editado correctamente");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al guardar: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conexionPTC.Close();
        //    }
        //}

        //private void btnQuitarJugador_Click(object sender, EventArgs e)
        //{
        //    String mensaje = "¿Está seguro de que desea eliminar este jugador?"; 
        //    String titulo = "Confirmación de eliminación";
        //    DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (resultado == DialogResult.Yes)
        //    {
        //        SqlConnection conexionPTC = ConexionDB.AbrirConexion();
        //        String sqlEliminarJugador = "DELETE FROM dbo.Jugador WHERE idJugador = @idJugador";
        //        SqlCommand eliminar = new SqlCommand(sqlEliminarJugador, conexionPTC);
        //        eliminar.Parameters.AddWithValue("@idJugador", idJugadorSeleccionado);
        //        try
        //        {
        //            eliminar.ExecuteNonQuery();
        //            LlenarDataGridView();
        //            LimpiarFormulario();
        //            MessageBox.Show("Jugador eliminado correctamente");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al eliminar: " + ex.Message);
        //        }
        //        finally
        //        {
        //            conexionPTC.Close();
        //        }
            ///  }
        }

        private void lblEstadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void fmlJugadores_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
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
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Jugador", conexionPTC);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvJugadores.DataSource = dt;
                    dgvJugadores.Columns["idUsuario"].Visible = false;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                }
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

        }
    }
}

