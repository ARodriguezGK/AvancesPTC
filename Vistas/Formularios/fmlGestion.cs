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
    public partial class fmlGestion : Form
    {
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

        }

        private void btnGestCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void lblGestionEntrenadores_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void dgvEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñaEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstadoGestionEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
