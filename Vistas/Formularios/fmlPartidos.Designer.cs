namespace Vistas.Formularios
{
    partial class fmlPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlPartidos));
            this.pnlBarraEstado = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnActualizarPartido = new System.Windows.Forms.Button();
            this.btnQuitarPartido = new System.Windows.Forms.Button();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.btnAñaPartido = new System.Windows.Forms.Button();
            this.btnPartEncuentros = new System.Windows.Forms.Button();
            this.btnPartEstadisticas = new System.Windows.Forms.Button();
            this.btnPartResultados = new System.Windows.Forms.Button();
            this.lblProximosEncuentros = new System.Windows.Forms.Label();
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
            this.pnlBarraEstado.Controls.Add(this.btnPartResultados);
            this.pnlBarraEstado.Controls.Add(this.btnPartEncuentros);
            this.pnlBarraEstado.Controls.Add(this.btnPartEstadisticas);
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(182, 606);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(1056, 64);
            this.pnlBarraEstado.TabIndex = 5;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblProximosEncuentros);
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(182, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1056, 115);
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
            this.pnlMenu.Size = new System.Drawing.Size(182, 670);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnPartidos
            // 
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.Green;
            this.btnPartidos.Location = new System.Drawing.Point(0, 412);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(182, 91);
            this.btnPartidos.TabIndex = 8;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestion.Location = new System.Drawing.Point(6, 315);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(176, 91);
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
            this.picBoxUser.Location = new System.Drawing.Point(57, 509);
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
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(944, 44);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 27);
            this.lblAdmin.TabIndex = 13;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // btnActualizarPartido
            // 
            this.btnActualizarPartido.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarPartido.FlatAppearance.BorderSize = 0;
            this.btnActualizarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPartido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarPartido.Location = new System.Drawing.Point(233, 534);
            this.btnActualizarPartido.Name = "btnActualizarPartido";
            this.btnActualizarPartido.Size = new System.Drawing.Size(206, 66);
            this.btnActualizarPartido.TabIndex = 20;
            this.btnActualizarPartido.Text = "Actualizar Partido";
            this.btnActualizarPartido.UseVisualStyleBackColor = false;
            this.btnActualizarPartido.Click += new System.EventHandler(this.btnActualizarPartido_Click);
            // 
            // btnQuitarPartido
            // 
            this.btnQuitarPartido.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarPartido.FlatAppearance.BorderSize = 0;
            this.btnQuitarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPartido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitarPartido.Location = new System.Drawing.Point(1003, 534);
            this.btnQuitarPartido.Name = "btnQuitarPartido";
            this.btnQuitarPartido.Size = new System.Drawing.Size(206, 66);
            this.btnQuitarPartido.TabIndex = 19;
            this.btnQuitarPartido.Text = "- Quitar Partido";
            this.btnQuitarPartido.UseVisualStyleBackColor = false;
            this.btnQuitarPartido.Click += new System.EventHandler(this.btnQuitarPartido_Click);
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Location = new System.Drawing.Point(233, 203);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.RowHeadersWidth = 51;
            this.dgvEntrenadores.RowTemplate.Height = 24;
            this.dgvEntrenadores.Size = new System.Drawing.Size(976, 322);
            this.dgvEntrenadores.TabIndex = 18;
            this.dgvEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrenadores_CellContentClick);
            // 
            // btnAñaPartido
            // 
            this.btnAñaPartido.BackColor = System.Drawing.Color.Green;
            this.btnAñaPartido.FlatAppearance.BorderSize = 0;
            this.btnAñaPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñaPartido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñaPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñaPartido.Location = new System.Drawing.Point(1003, 121);
            this.btnAñaPartido.Name = "btnAñaPartido";
            this.btnAñaPartido.Size = new System.Drawing.Size(206, 66);
            this.btnAñaPartido.TabIndex = 17;
            this.btnAñaPartido.Text = "+ Añadir Partido";
            this.btnAñaPartido.UseVisualStyleBackColor = false;
            this.btnAñaPartido.Click += new System.EventHandler(this.btnAñaPartido_Click);
            // 
            // btnPartEncuentros
            // 
            this.btnPartEncuentros.BackColor = System.Drawing.Color.LightGray;
            this.btnPartEncuentros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartEncuentros.ForeColor = System.Drawing.Color.Green;
            this.btnPartEncuentros.Location = new System.Drawing.Point(31, 6);
            this.btnPartEncuentros.Name = "btnPartEncuentros";
            this.btnPartEncuentros.Size = new System.Drawing.Size(276, 51);
            this.btnPartEncuentros.TabIndex = 0;
            this.btnPartEncuentros.Text = "Proximo encuentro";
            this.btnPartEncuentros.UseVisualStyleBackColor = false;
            this.btnPartEncuentros.Click += new System.EventHandler(this.btnPartEncuentros_Click);
            // 
            // btnPartEstadisticas
            // 
            this.btnPartEstadisticas.BackColor = System.Drawing.Color.LightGray;
            this.btnPartEstadisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartEstadisticas.Location = new System.Drawing.Point(397, 6);
            this.btnPartEstadisticas.Name = "btnPartEstadisticas";
            this.btnPartEstadisticas.Size = new System.Drawing.Size(276, 51);
            this.btnPartEstadisticas.TabIndex = 1;
            this.btnPartEstadisticas.Text = "Estadisticas de partidos";
            this.btnPartEstadisticas.UseVisualStyleBackColor = false;
            this.btnPartEstadisticas.Click += new System.EventHandler(this.btnPartEstadisticas_Click);
            // 
            // btnPartResultados
            // 
            this.btnPartResultados.BackColor = System.Drawing.Color.LightGray;
            this.btnPartResultados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartResultados.Location = new System.Drawing.Point(751, 6);
            this.btnPartResultados.Name = "btnPartResultados";
            this.btnPartResultados.Size = new System.Drawing.Size(276, 51);
            this.btnPartResultados.TabIndex = 2;
            this.btnPartResultados.Text = "Resultados ";
            this.btnPartResultados.UseVisualStyleBackColor = false;
            this.btnPartResultados.Click += new System.EventHandler(this.btnPartResultados_Click);
            // 
            // lblProximosEncuentros
            // 
            this.lblProximosEncuentros.AutoSize = true;
            this.lblProximosEncuentros.BackColor = System.Drawing.Color.Green;
            this.lblProximosEncuentros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximosEncuentros.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProximosEncuentros.Location = new System.Drawing.Point(46, 44);
            this.lblProximosEncuentros.Name = "lblProximosEncuentros";
            this.lblProximosEncuentros.Size = new System.Drawing.Size(214, 27);
            this.lblProximosEncuentros.TabIndex = 14;
            this.lblProximosEncuentros.Text = "Proximos Partidos";
            this.lblProximosEncuentros.Click += new System.EventHandler(this.lblProximosEncuentros_Click);
            // 
            // fmlPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 670);
            this.Controls.Add(this.btnActualizarPartido);
            this.Controls.Add(this.btnQuitarPartido);
            this.Controls.Add(this.dgvEntrenadores);
            this.Controls.Add(this.btnAñaPartido);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmlPartidos";
            this.Text = "fmlPartidos";
            this.pnlBarraEstado.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Panel pnlBarraEstado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnActualizarPartido;
        private System.Windows.Forms.Button btnQuitarPartido;
        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.Button btnAñaPartido;
        private System.Windows.Forms.Button btnPartEncuentros;
        private System.Windows.Forms.Button btnPartEstadisticas;
        private System.Windows.Forms.Button btnPartResultados;
        private System.Windows.Forms.Label lblProximosEncuentros;
    }
}