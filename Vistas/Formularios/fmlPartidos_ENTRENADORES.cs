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
    public partial class fmlPartidos_ENTRENADORES: Form
    {
        public fmlPartidos_ENTRENADORES()
        {
            InitializeComponent();
        }

        private void btnActualizarPartido_Click(object sender, EventArgs e)
        {

        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {

        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            fmlJugadores_ENTRENADORES frmJugadores = new fmlJugadores_ENTRENADORES();
            frmJugadores.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            fmlInventario_ENTRENADORES frmInventario = new fmlInventario_ENTRENADORES();
            frmInventario.Show();
            this.Hide();
        }

        private void lblProximosEncuentros_Click(object sender, EventArgs e)
        {

        }

        private void dtpHorarioPartido_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoPartido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCategoriaPartido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLugarPart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipoVisitantePart_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipoLocalPartidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultadoPart_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLugar_Click(object sender, EventArgs e)
        {

        }

        private void btnPartResultados_Click(object sender, EventArgs e)
        {

        }

        private void btnPartEncuentros_Click(object sender, EventArgs e)
        {

        }

        private void btnPartEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void lblEquipVisitantePartidos_Click(object sender, EventArgs e)
        {

        }

        private void lblEquipLocalPartidos_Click(object sender, EventArgs e)
        {

        }

        private void lblHorarioPartido_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoriaPartido_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoPartido_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoPartido_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEntrenadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void fmlPartidos_ENTRENADORES_Load(object sender, EventArgs e)
        {

        }
    }
}
