using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // credenciales fijas
            string usuarioCorrecto = "admin";
            string contraseñaCorrecta = "1234";

            // valores de los txtbox
            string usuarioIngresado = txtUser.Text;
            string contraseñaIngresada = txtPass.Text;

            // validando de las credenciales
            if (usuarioIngresado == usuarioCorrecto && contraseñaIngresada == contraseñaCorrecta)
            {
                // cerramos el formulario despues de iniciar sesión
                this.Hide();

                // entrelazar el formulario principal
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
            }
            else
            {
                //mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
