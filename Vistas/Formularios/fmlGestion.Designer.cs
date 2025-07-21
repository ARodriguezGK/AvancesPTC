namespace Vistas.Formularios
{
    partial class fmlGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlGestion));
            this.pnlBarraEstado = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblGestionEntrenadores = new System.Windows.Forms.Label();
            this.btnActualizarEntrenador = new System.Windows.Forms.Button();
            this.btnQuitarEntrenador = new System.Windows.Forms.Button();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.btnAñaEntrenador = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnGestEntrenadores = new System.Windows.Forms.Button();
            this.btnGestEquipos = new System.Windows.Forms.Button();
            this.btnGestCategoria = new System.Windows.Forms.Button();
            this.pnlBarraEstado.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Silver;
            this.pnlBarraEstado.Controls.Add(this.btnGestCategoria);
            this.pnlBarraEstado.Controls.Add(this.btnGestEquipos);
            this.pnlBarraEstado.Controls.Add(this.btnGestEntrenadores);
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(182, 644);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(1046, 57);
            this.pnlBarraEstado.TabIndex = 5;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Controls.Add(this.lblGestionEntrenadores);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(182, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1046, 115);
            this.pnlBarraTitulo.TabIndex = 4;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
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
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 701);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPartidos.Location = new System.Drawing.Point(6, 412);
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
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(182, 91);
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
            this.btnJugadores.Location = new System.Drawing.Point(6, 218);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(176, 91);
            this.btnJugadores.TabIndex = 6;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = true;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.picBoxUser.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.picBoxUser.Image = global::Vistas.Properties.Resources.user;
            this.picBoxUser.Location = new System.Drawing.Point(60, 541);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(74, 70);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 5;
            this.picBoxUser.TabStop = false;
            this.picBoxUser.Click += new System.EventHandler(this.picBoxUser_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventario.Location = new System.Drawing.Point(3, 121);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(176, 91);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Vistas.Properties.Resources.logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(182, 115);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // lblGestionEntrenadores
            // 
            this.lblGestionEntrenadores.AutoSize = true;
            this.lblGestionEntrenadores.BackColor = System.Drawing.Color.Green;
            this.lblGestionEntrenadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEntrenadores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGestionEntrenadores.Location = new System.Drawing.Point(32, 45);
            this.lblGestionEntrenadores.Name = "lblGestionEntrenadores";
            this.lblGestionEntrenadores.Size = new System.Drawing.Size(281, 27);
            this.lblGestionEntrenadores.TabIndex = 6;
            this.lblGestionEntrenadores.Text = "Gestion de Entenadores";
            this.lblGestionEntrenadores.Click += new System.EventHandler(this.lblGestionEntrenadores_Click);
            // 
            // btnActualizarEntrenador
            // 
            this.btnActualizarEntrenador.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnActualizarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEntrenador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntrenador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarEntrenador.Location = new System.Drawing.Point(219, 563);
            this.btnActualizarEntrenador.Name = "btnActualizarEntrenador";
            this.btnActualizarEntrenador.Size = new System.Drawing.Size(206, 66);
            this.btnActualizarEntrenador.TabIndex = 15;
            this.btnActualizarEntrenador.Text = "Actualizar Entrenador";
            this.btnActualizarEntrenador.UseVisualStyleBackColor = false;
            this.btnActualizarEntrenador.Click += new System.EventHandler(this.btnActualizarEntrenador_Click);
            // 
            // btnQuitarEntrenador
            // 
            this.btnQuitarEntrenador.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnQuitarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarEntrenador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarEntrenador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitarEntrenador.Location = new System.Drawing.Point(973, 563);
            this.btnQuitarEntrenador.Name = "btnQuitarEntrenador";
            this.btnQuitarEntrenador.Size = new System.Drawing.Size(206, 66);
            this.btnQuitarEntrenador.TabIndex = 14;
            this.btnQuitarEntrenador.Text = "- Quitar Entrenador";
            this.btnQuitarEntrenador.UseVisualStyleBackColor = false;
            this.btnQuitarEntrenador.Click += new System.EventHandler(this.btnQuitarEntrenador_Click);
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Location = new System.Drawing.Point(219, 218);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.RowHeadersWidth = 51;
            this.dgvEntrenadores.RowTemplate.Height = 24;
            this.dgvEntrenadores.Size = new System.Drawing.Size(960, 307);
            this.dgvEntrenadores.TabIndex = 13;
            this.dgvEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrenadores_CellContentClick);
            // 
            // btnAñaEntrenador
            // 
            this.btnAñaEntrenador.BackColor = System.Drawing.Color.Green;
            this.btnAñaEntrenador.FlatAppearance.BorderSize = 0;
            this.btnAñaEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñaEntrenador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñaEntrenador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñaEntrenador.Location = new System.Drawing.Point(955, 121);
            this.btnAñaEntrenador.Name = "btnAñaEntrenador";
            this.btnAñaEntrenador.Size = new System.Drawing.Size(206, 66);
            this.btnAñaEntrenador.TabIndex = 12;
            this.btnAñaEntrenador.Text = "+ Añadir Entrenador";
            this.btnAñaEntrenador.UseVisualStyleBackColor = false;
            this.btnAñaEntrenador.Click += new System.EventHandler(this.btnAñaEntrenador_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(926, 45);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 27);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // btnGestEntrenadores
            // 
            this.btnGestEntrenadores.BackColor = System.Drawing.Color.LightGray;
            this.btnGestEntrenadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEntrenadores.ForeColor = System.Drawing.Color.Green;
            this.btnGestEntrenadores.Location = new System.Drawing.Point(37, 3);
            this.btnGestEntrenadores.Name = "btnGestEntrenadores";
            this.btnGestEntrenadores.Size = new System.Drawing.Size(276, 51);
            this.btnGestEntrenadores.TabIndex = 0;
            this.btnGestEntrenadores.Text = "Entrenadores";
            this.btnGestEntrenadores.UseVisualStyleBackColor = false;
            this.btnGestEntrenadores.Click += new System.EventHandler(this.btnGestEntrenadores_Click);
            // 
            // btnGestEquipos
            // 
            this.btnGestEquipos.BackColor = System.Drawing.Color.LightGray;
            this.btnGestEquipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEquipos.Location = new System.Drawing.Point(385, 3);
            this.btnGestEquipos.Name = "btnGestEquipos";
            this.btnGestEquipos.Size = new System.Drawing.Size(276, 51);
            this.btnGestEquipos.TabIndex = 1;
            this.btnGestEquipos.Text = "Equipos";
            this.btnGestEquipos.UseVisualStyleBackColor = false;
            this.btnGestEquipos.Click += new System.EventHandler(this.btnGestEquipos_Click);
            // 
            // btnGestCategoria
            // 
            this.btnGestCategoria.BackColor = System.Drawing.Color.LightGray;
            this.btnGestCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCategoria.Location = new System.Drawing.Point(733, 3);
            this.btnGestCategoria.Name = "btnGestCategoria";
            this.btnGestCategoria.Size = new System.Drawing.Size(276, 51);
            this.btnGestCategoria.TabIndex = 2;
            this.btnGestCategoria.Text = "Categorias";
            this.btnGestCategoria.UseVisualStyleBackColor = false;
            this.btnGestCategoria.Click += new System.EventHandler(this.btnGestCategoria_Click);
            // 
            // fmlGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 701);
            this.Controls.Add(this.btnActualizarEntrenador);
            this.Controls.Add(this.btnQuitarEntrenador);
            this.Controls.Add(this.dgvEntrenadores);
            this.Controls.Add(this.btnAñaEntrenador);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmlGestion";
            this.Text = "fmlGestion";
            this.pnlBarraEstado.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlBarraEstado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblGestionEntrenadores;
        private System.Windows.Forms.Button btnActualizarEntrenador;
        private System.Windows.Forms.Button btnQuitarEntrenador;
        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.Button btnAñaEntrenador;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnGestEntrenadores;
        private System.Windows.Forms.Button btnGestCategoria;
        private System.Windows.Forms.Button btnGestEquipos;
    }
}