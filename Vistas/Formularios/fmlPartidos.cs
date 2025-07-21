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
    public partial class fmlPartidos : Form
    {
        public fmlPartidos()
        {
            InitializeComponent();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            fmlGestion fmlGestion = new fmlGestion();
            fmlGestion.Show();

            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            fmlinventario fmlinventario = new fmlinventario();
            fmlinventario.Show();

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
            fmlJugadores fmlJugadores = new fmlJugadores();
            fmlJugadores.Show();

            this.Hide();
        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizarPartido_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarPartido_Click(object sender, EventArgs e)
        {

        }

        private void dgvEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñaPartido_Click(object sender, EventArgs e)
        {

        }

        private void btnPartEncuentros_Click(object sender, EventArgs e)
        {

        }

        private void btnPartEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void btnPartResultados_Click(object sender, EventArgs e)
        {

        }

        private void lblProximosEncuentros_Click(object sender, EventArgs e)
        {

        }
    }
}
