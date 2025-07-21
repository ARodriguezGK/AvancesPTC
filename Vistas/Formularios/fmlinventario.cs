using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Button btn = (Button)sender;
            Rectangle rect = btn.ClientRectangle;
            int radius = 20;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitarObje_Click(object sender, EventArgs e)
        {

        }
    }
}
