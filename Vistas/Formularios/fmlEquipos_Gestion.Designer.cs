namespace Vistas.Formularios
{
    partial class fmlEquipos_Gestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarEquipo = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.cbxCategoriaEquipo = new System.Windows.Forms.ComboBox();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.lblGestionEquipos = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblCtegoriaEquipo = new System.Windows.Forms.Label();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnActualizarEquipo = new System.Windows.Forms.Button();
            this.btnQuitarEquipo = new System.Windows.Forms.Button();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btnAñaEquipo = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnGestCategoria = new System.Windows.Forms.Button();
            this.btnGestEquipos = new System.Windows.Forms.Button();
            this.btnGestEntrenadores = new System.Windows.Forms.Button();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.pnlBarraEstado = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlBarraEstado.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(352, 136);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 16);
            this.lblBuscar.TabIndex = 83;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // txtBuscarEquipo
            // 
            this.txtBuscarEquipo.Location = new System.Drawing.Point(427, 136);
            this.txtBuscarEquipo.Name = "txtBuscarEquipo";
            this.txtBuscarEquipo.Size = new System.Drawing.Size(568, 22);
            this.txtBuscarEquipo.TabIndex = 82;
            this.txtBuscarEquipo.TextChanged += new System.EventHandler(this.txtBuscarEquipo_TextChanged);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(971, 46);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 27);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // cbxCategoriaEquipo
            // 
            this.cbxCategoriaEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaEquipo.FormattingEnabled = true;
            this.cbxCategoriaEquipo.Location = new System.Drawing.Point(821, 242);
            this.cbxCategoriaEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoriaEquipo.Name = "cbxCategoriaEquipo";
            this.cbxCategoriaEquipo.Size = new System.Drawing.Size(160, 24);
            this.cbxCategoriaEquipo.TabIndex = 81;
            this.cbxCategoriaEquipo.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriaEquipo_SelectedIndexChanged);
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPartidos.Location = new System.Drawing.Point(5, 412);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(176, 91);
            this.btnPartidos.TabIndex = 8;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.Green;
            this.btnGestion.Location = new System.Drawing.Point(0, 315);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(181, 91);
            this.btnGestion.TabIndex = 7;
            this.btnGestion.Text = "Gestion";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJugadores.Location = new System.Drawing.Point(5, 218);
            this.btnJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(176, 91);
            this.btnJugadores.TabIndex = 6;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = true;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(355, 251);
            this.txtNombreEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(296, 22);
            this.txtNombreEquipo.TabIndex = 77;
            this.txtNombreEquipo.TextChanged += new System.EventHandler(this.txtNombreEquipo_TextChanged);
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.picBoxUser.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.picBoxUser.Image = global::Vistas.Properties.Resources.user;
            this.picBoxUser.Location = new System.Drawing.Point(60, 542);
            this.picBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(75, 70);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 5;
            this.picBoxUser.TabStop = false;
            this.picBoxUser.Click += new System.EventHandler(this.picBoxUser_Click);
            // 
            // lblGestionEquipos
            // 
            this.lblGestionEquipos.AutoSize = true;
            this.lblGestionEquipos.BackColor = System.Drawing.Color.Green;
            this.lblGestionEquipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEquipos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGestionEquipos.Location = new System.Drawing.Point(32, 46);
            this.lblGestionEquipos.Name = "lblGestionEquipos";
            this.lblGestionEquipos.Size = new System.Drawing.Size(227, 27);
            this.lblGestionEquipos.TabIndex = 6;
            this.lblGestionEquipos.Text = "Gestion de Equipos";
            this.lblGestionEquipos.Click += new System.EventHandler(this.lblGestionEquipos_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Vistas.Properties.Resources.logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(181, 114);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // lblCtegoriaEquipo
            // 
            this.lblCtegoriaEquipo.AutoSize = true;
            this.lblCtegoriaEquipo.Location = new System.Drawing.Point(699, 257);
            this.lblCtegoriaEquipo.Name = "lblCtegoriaEquipo";
            this.lblCtegoriaEquipo.Size = new System.Drawing.Size(66, 16);
            this.lblCtegoriaEquipo.TabIndex = 75;
            this.lblCtegoriaEquipo.Text = "Categoria";
            this.lblCtegoriaEquipo.Click += new System.EventHandler(this.lblCtegoriaEquipo_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventario.Location = new System.Drawing.Point(3, 121);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(176, 91);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnActualizarEquipo
            // 
            this.btnActualizarEquipo.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarEquipo.FlatAppearance.BorderSize = 0;
            this.btnActualizarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEquipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarEquipo.Location = new System.Drawing.Point(219, 716);
            this.btnActualizarEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarEquipo.Name = "btnActualizarEquipo";
            this.btnActualizarEquipo.Size = new System.Drawing.Size(205, 66);
            this.btnActualizarEquipo.TabIndex = 73;
            this.btnActualizarEquipo.Text = "Actualizar Equipo";
            this.btnActualizarEquipo.UseVisualStyleBackColor = false;
            this.btnActualizarEquipo.Click += new System.EventHandler(this.btnActualizarEquipo_Click);
            // 
            // btnQuitarEquipo
            // 
            this.btnQuitarEquipo.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarEquipo.FlatAppearance.BorderSize = 0;
            this.btnQuitarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEquipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitarEquipo.Location = new System.Drawing.Point(973, 716);
            this.btnQuitarEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarEquipo.Name = "btnQuitarEquipo";
            this.btnQuitarEquipo.Size = new System.Drawing.Size(205, 66);
            this.btnQuitarEquipo.TabIndex = 72;
            this.btnQuitarEquipo.Text = "- Quitar Equipo";
            this.btnQuitarEquipo.UseVisualStyleBackColor = false;
            this.btnQuitarEquipo.Click += new System.EventHandler(this.btnQuitarEquipo_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(219, 384);
            this.dgvEquipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.RowHeadersWidth = 51;
            this.dgvEquipos.RowTemplate.Height = 24;
            this.dgvEquipos.Size = new System.Drawing.Size(960, 306);
            this.dgvEquipos.TabIndex = 71;
            this.dgvEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellContentClick);
            // 
            // btnAñaEquipo
            // 
            this.btnAñaEquipo.BackColor = System.Drawing.Color.Green;
            this.btnAñaEquipo.FlatAppearance.BorderSize = 0;
            this.btnAñaEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñaEquipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñaEquipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñaEquipo.Location = new System.Drawing.Point(1054, 121);
            this.btnAñaEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñaEquipo.Name = "btnAñaEquipo";
            this.btnAñaEquipo.Size = new System.Drawing.Size(205, 66);
            this.btnAñaEquipo.TabIndex = 70;
            this.btnAñaEquipo.Text = "+ Añadir Equipo";
            this.btnAñaEquipo.UseVisualStyleBackColor = false;
            this.btnAñaEquipo.Click += new System.EventHandler(this.btnAñaEquipo_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Controls.Add(this.lblGestionEquipos);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(181, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1090, 114);
            this.pnlBarraTitulo.TabIndex = 68;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // btnGestCategoria
            // 
            this.btnGestCategoria.BackColor = System.Drawing.Color.LightGray;
            this.btnGestCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCategoria.Location = new System.Drawing.Point(733, 2);
            this.btnGestCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestCategoria.Name = "btnGestCategoria";
            this.btnGestCategoria.Size = new System.Drawing.Size(276, 50);
            this.btnGestCategoria.TabIndex = 2;
            this.btnGestCategoria.Text = "Categorias";
            this.btnGestCategoria.UseVisualStyleBackColor = false;
            this.btnGestCategoria.Click += new System.EventHandler(this.btnGestCategoria_Click);
            // 
            // btnGestEquipos
            // 
            this.btnGestEquipos.BackColor = System.Drawing.Color.LightGray;
            this.btnGestEquipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEquipos.ForeColor = System.Drawing.Color.Green;
            this.btnGestEquipos.Location = new System.Drawing.Point(385, 2);
            this.btnGestEquipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestEquipos.Name = "btnGestEquipos";
            this.btnGestEquipos.Size = new System.Drawing.Size(276, 50);
            this.btnGestEquipos.TabIndex = 1;
            this.btnGestEquipos.Text = "Equipos";
            this.btnGestEquipos.UseVisualStyleBackColor = false;
            this.btnGestEquipos.Click += new System.EventHandler(this.btnGestEquipos_Click);
            // 
            // btnGestEntrenadores
            // 
            this.btnGestEntrenadores.BackColor = System.Drawing.Color.LightGray;
            this.btnGestEntrenadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEntrenadores.ForeColor = System.Drawing.Color.Black;
            this.btnGestEntrenadores.Location = new System.Drawing.Point(37, 2);
            this.btnGestEntrenadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestEntrenadores.Name = "btnGestEntrenadores";
            this.btnGestEntrenadores.Size = new System.Drawing.Size(276, 50);
            this.btnGestEntrenadores.TabIndex = 0;
            this.btnGestEntrenadores.Text = "Entrenadores";
            this.btnGestEntrenadores.UseVisualStyleBackColor = false;
            this.btnGestEntrenadores.Click += new System.EventHandler(this.btnGestEntrenadores_Click);
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Location = new System.Drawing.Point(232, 253);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(56, 16);
            this.lblNombreEquipo.TabIndex = 74;
            this.lblNombreEquipo.Text = "Nombre";
            this.lblNombreEquipo.Click += new System.EventHandler(this.lblNombreEquipo_Click);
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Silver;
            this.pnlBarraEstado.Controls.Add(this.btnGestCategoria);
            this.pnlBarraEstado.Controls.Add(this.btnGestEquipos);
            this.pnlBarraEstado.Controls.Add(this.btnGestEntrenadores);
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(181, 794);
            this.pnlBarraEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(1090, 57);
            this.pnlBarraEstado.TabIndex = 69;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlMenu.Controls.Add(this.btnPartidos);
            this.pnlMenu.Controls.Add(this.btnGestion);
            this.pnlMenu.Controls.Add(this.btnJugadores);
            this.pnlMenu.Controls.Add(this.picBoxUser);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(181, 851);
            this.pnlMenu.TabIndex = 67;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // Equipos_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 851);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscarEquipo);
            this.Controls.Add(this.cbxCategoriaEquipo);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblCtegoriaEquipo);
            this.Controls.Add(this.btnActualizarEquipo);
            this.Controls.Add(this.btnQuitarEquipo);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.btnAñaEquipo);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.lblNombreEquipo);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Equipos_Gestion";
            this.Text = "Equipos_Gestion";
            this.Load += new System.EventHandler(this.Equipos_Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlBarraEstado.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarEquipo;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ComboBox cbxCategoriaEquipo;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Label lblGestionEquipos;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblCtegoriaEquipo;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnActualizarEquipo;
        private System.Windows.Forms.Button btnQuitarEquipo;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Button btnAñaEquipo;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Button btnGestCategoria;
        private System.Windows.Forms.Button btnGestEquipos;
        private System.Windows.Forms.Button btnGestEntrenadores;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Panel pnlBarraEstado;
        private System.Windows.Forms.Panel pnlMenu;
    }
}