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
    public partial class fmlJugadores : Form
    {
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

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblJugadoresBasic_Click(object sender, EventArgs e)
        {

        }

        private void btnAñaJugador_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarJugador_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoInventario_Click(object sender, EventArgs e)
        {

        }

        private void fmlJugadores_Load(object sender, EventArgs e)
        {

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
    }
}
