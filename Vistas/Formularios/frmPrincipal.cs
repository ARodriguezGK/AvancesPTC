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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {

        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            
            // entrelazar el formulario principal
             fmlinventario fmlinventario = new fmlinventario();
            fmlinventario.Show();

            // cerramos el formulario despues de iniciar sesión
            this.Hide();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBarraEstado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {

        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {

        }
    }
}
