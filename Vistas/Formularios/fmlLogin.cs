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

namespace Vistas.Formularios
{
    public partial class fmlLogin : Form
    {
        public fmlLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSailr_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // valores de los txtbox
            string usuarioIngresado = txtUser.Text;
            string contraseñaIngresada = txtPass.Text;
            SqlConnection conexionPTC = ConexionDB.AbrirConexion();
            String consulta = "SELECT COUNT(*) FROM dbo.Usuario WHERE correo = @correo AND contraseña = @contraseña";
            String mensajeError = "Error al iniciar sesión. Por favor, verifique sus credenciales.";
            // Crear el comando SQL con la consulta y la conexión
            SqlCommand comando = new SqlCommand(consulta, conexionPTC);
            // Agregar los parámetros a la consulta
            comando.Parameters.AddWithValue("@correo", usuarioIngresado);
            comando.Parameters.AddWithValue("@contraseña", contraseñaIngresada);
            try
            {
                int count = (int)comando.ExecuteScalar();
                if (count > 0)
                {
                    // cerramos el formulario despues de iniciar sesión
                    this.Hide();
                    // entrelazar el formulario principal
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                }
                else
                {
                    // mensaje de error si las credenciales son incorrectas
                    MessageBox.Show(mensajeError, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionPTC.Close();
            }


        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            //UseSistemPasswordChar = true; // Esto oculta el texto ingresado en el TextBox
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Iniciar_Click(object sender, EventArgs e)
        {

        }

        private void lblCredencial_Click(object sender, EventArgs e)
        {

        }

        private void lbliniciasecion_Click(object sender, EventArgs e)
        {

        }

        private void lblbienvenido_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
