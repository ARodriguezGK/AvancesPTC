namespace Vistas.Formularios
{
    partial class fmlPartidos_ENTRENADORES
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
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.lblProximosEncuentros = new System.Windows.Forms.Label();
            this.dtpHorarioPartido = new System.Windows.Forms.DateTimePicker();
            this.cbxTipoPartido = new System.Windows.Forms.ComboBox();
            this.cbxCategoriaPartido = new System.Windows.Forms.ComboBox();
            this.txtLugarPart = new System.Windows.Forms.TextBox();
            this.txtEquipoVisitantePart = new System.Windows.Forms.TextBox();
            this.txtEquipoLocalPartidos = new System.Windows.Forms.TextBox();
            this.txtResultadoPart = new System.Windows.Forms.TextBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnPartResultados = new System.Windows.Forms.Button();
            this.btnPartEncuentros = new System.Windows.Forms.Button();
            this.btnPartEstadisticas = new System.Windows.Forms.Button();
            this.lblEquipVisitantePartidos = new System.Windows.Forms.Label();
            this.lblEquipLocalPartidos = new System.Windows.Forms.Label();
            this.lblHorarioPartido = new System.Windows.Forms.Label();
            this.lblCategoriaPartido = new System.Windows.Forms.Label();
            this.lblResultadoPartido = new System.Windows.Forms.Label();
            this.lblTipoPartido = new System.Windows.Forms.Label();
            this.btnActualizarPartido = new System.Windows.Forms.Button();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.pnlBarraEstado = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.pnlBarraEstado.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPartidos
            // 
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.Green;
            this.btnPartidos.Location = new System.Drawing.Point(0, 366);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(181, 124);
            this.btnPartidos.TabIndex = 8;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJugadores.Location = new System.Drawing.Point(5, 240);
            this.btnJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(176, 121);
            this.btnJugadores.TabIndex = 6;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = true;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInventario.Location = new System.Drawing.Point(5, 140);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(176, 91);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // lblProximosEncuentros
            // 
            this.lblProximosEncuentros.AutoSize = true;
            this.lblProximosEncuentros.BackColor = System.Drawing.Color.Green;
            this.lblProximosEncuentros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximosEncuentros.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProximosEncuentros.Location = new System.Drawing.Point(45, 44);
            this.lblProximosEncuentros.Name = "lblProximosEncuentros";
            this.lblProximosEncuentros.Size = new System.Drawing.Size(214, 27);
            this.lblProximosEncuentros.TabIndex = 14;
            this.lblProximosEncuentros.Text = "Proximos Partidos";
            this.lblProximosEncuentros.Click += new System.EventHandler(this.lblProximosEncuentros_Click);
            // 
            // dtpHorarioPartido
            // 
            this.dtpHorarioPartido.Location = new System.Drawing.Point(832, 260);
            this.dtpHorarioPartido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHorarioPartido.Name = "dtpHorarioPartido";
            this.dtpHorarioPartido.Size = new System.Drawing.Size(265, 22);
            this.dtpHorarioPartido.TabIndex = 58;
            this.dtpHorarioPartido.ValueChanged += new System.EventHandler(this.dtpHorarioPartido_ValueChanged);
            // 
            // cbxTipoPartido
            // 
            this.cbxTipoPartido.FormattingEnabled = true;
            this.cbxTipoPartido.Location = new System.Drawing.Point(356, 218);
            this.cbxTipoPartido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTipoPartido.Name = "cbxTipoPartido";
            this.cbxTipoPartido.Size = new System.Drawing.Size(160, 24);
            this.cbxTipoPartido.TabIndex = 57;
            this.cbxTipoPartido.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPartido_SelectedIndexChanged);
            // 
            // cbxCategoriaPartido
            // 
            this.cbxCategoriaPartido.FormattingEnabled = true;
            this.cbxCategoriaPartido.Location = new System.Drawing.Point(832, 215);
            this.cbxCategoriaPartido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCategoriaPartido.Name = "cbxCategoriaPartido";
            this.cbxCategoriaPartido.Size = new System.Drawing.Size(160, 24);
            this.cbxCategoriaPartido.TabIndex = 56;
            this.cbxCategoriaPartido.SelectedIndexChanged += new System.EventHandler(this.cbxCategoriaPartido_SelectedIndexChanged);
            // 
            // txtLugarPart
            // 
            this.txtLugarPart.Location = new System.Drawing.Point(832, 338);
            this.txtLugarPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLugarPart.Name = "txtLugarPart";
            this.txtLugarPart.Size = new System.Drawing.Size(296, 22);
            this.txtLugarPart.TabIndex = 55;
            this.txtLugarPart.TextChanged += new System.EventHandler(this.txtLugarPart_TextChanged);
            // 
            // txtEquipoVisitantePart
            // 
            this.txtEquipoVisitantePart.Location = new System.Drawing.Point(832, 294);
            this.txtEquipoVisitantePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEquipoVisitantePart.Name = "txtEquipoVisitantePart";
            this.txtEquipoVisitantePart.Size = new System.Drawing.Size(296, 22);
            this.txtEquipoVisitantePart.TabIndex = 54;
            this.txtEquipoVisitantePart.TextChanged += new System.EventHandler(this.txtEquipoVisitantePart_TextChanged);
            // 
            // txtEquipoLocalPartidos
            // 
            this.txtEquipoLocalPartidos.Location = new System.Drawing.Point(356, 315);
            this.txtEquipoLocalPartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEquipoLocalPartidos.Name = "txtEquipoLocalPartidos";
            this.txtEquipoLocalPartidos.Size = new System.Drawing.Size(296, 22);
            this.txtEquipoLocalPartidos.TabIndex = 53;
            this.txtEquipoLocalPartidos.TextChanged += new System.EventHandler(this.txtEquipoLocalPartidos_TextChanged);
            // 
            // txtResultadoPart
            // 
            this.txtResultadoPart.Location = new System.Drawing.Point(356, 265);
            this.txtResultadoPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultadoPart.Name = "txtResultadoPart";
            this.txtResultadoPart.Size = new System.Drawing.Size(296, 22);
            this.txtResultadoPart.TabIndex = 52;
            this.txtResultadoPart.TextChanged += new System.EventHandler(this.txtResultadoPart_TextChanged);
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.picBoxUser.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.picBoxUser.Image = global::Vistas.Properties.Resources.user;
            this.picBoxUser.Location = new System.Drawing.Point(57, 532);
            this.picBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(75, 70);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 5;
            this.picBoxUser.TabStop = false;
            this.picBoxUser.Click += new System.EventHandler(this.picBoxUser_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(707, 345);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(41, 16);
            this.lblLugar.TabIndex = 51;
            this.lblLugar.Text = "Lugar";
            this.lblLugar.Click += new System.EventHandler(this.lblLugar_Click);
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
            // btnPartResultados
            // 
            this.btnPartResultados.BackColor = System.Drawing.Color.LightGray;
            this.btnPartResultados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartResultados.Location = new System.Drawing.Point(751, 6);
            this.btnPartResultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartResultados.Name = "btnPartResultados";
            this.btnPartResultados.Size = new System.Drawing.Size(276, 50);
            this.btnPartResultados.TabIndex = 2;
            this.btnPartResultados.Text = "Resultados ";
            this.btnPartResultados.UseVisualStyleBackColor = false;
            this.btnPartResultados.Click += new System.EventHandler(this.btnPartResultados_Click);
            // 
            // btnPartEncuentros
            // 
            this.btnPartEncuentros.BackColor = System.Drawing.Color.LightGray;
            this.btnPartEncuentros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartEncuentros.ForeColor = System.Drawing.Color.Green;
            this.btnPartEncuentros.Location = new System.Drawing.Point(31, 6);
            this.btnPartEncuentros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartEncuentros.Name = "btnPartEncuentros";
            this.btnPartEncuentros.Size = new System.Drawing.Size(276, 50);
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
            this.btnPartEstadisticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartEstadisticas.Name = "btnPartEstadisticas";
            this.btnPartEstadisticas.Size = new System.Drawing.Size(276, 50);
            this.btnPartEstadisticas.TabIndex = 1;
            this.btnPartEstadisticas.Text = "Estadisticas de partidos";
            this.btnPartEstadisticas.UseVisualStyleBackColor = false;
            this.btnPartEstadisticas.Click += new System.EventHandler(this.btnPartEstadisticas_Click);
            // 
            // lblEquipVisitantePartidos
            // 
            this.lblEquipVisitantePartidos.AutoSize = true;
            this.lblEquipVisitantePartidos.Location = new System.Drawing.Point(707, 300);
            this.lblEquipVisitantePartidos.Name = "lblEquipVisitantePartidos";
            this.lblEquipVisitantePartidos.Size = new System.Drawing.Size(102, 16);
            this.lblEquipVisitantePartidos.TabIndex = 50;
            this.lblEquipVisitantePartidos.Text = "Equipo visitante";
            this.lblEquipVisitantePartidos.Click += new System.EventHandler(this.lblEquipVisitantePartidos_Click);
            // 
            // lblEquipLocalPartidos
            // 
            this.lblEquipLocalPartidos.AutoSize = true;
            this.lblEquipLocalPartidos.Location = new System.Drawing.Point(241, 315);
            this.lblEquipLocalPartidos.Name = "lblEquipLocalPartidos";
            this.lblEquipLocalPartidos.Size = new System.Drawing.Size(82, 16);
            this.lblEquipLocalPartidos.TabIndex = 49;
            this.lblEquipLocalPartidos.Text = "Equipo local";
            this.lblEquipLocalPartidos.Click += new System.EventHandler(this.lblEquipLocalPartidos_Click);
            // 
            // lblHorarioPartido
            // 
            this.lblHorarioPartido.AutoSize = true;
            this.lblHorarioPartido.Location = new System.Drawing.Point(707, 256);
            this.lblHorarioPartido.Name = "lblHorarioPartido";
            this.lblHorarioPartido.Size = new System.Drawing.Size(52, 16);
            this.lblHorarioPartido.TabIndex = 48;
            this.lblHorarioPartido.Text = "Horario";
            this.lblHorarioPartido.Click += new System.EventHandler(this.lblHorarioPartido_Click);
            // 
            // lblCategoriaPartido
            // 
            this.lblCategoriaPartido.AutoSize = true;
            this.lblCategoriaPartido.Location = new System.Drawing.Point(707, 215);
            this.lblCategoriaPartido.Name = "lblCategoriaPartido";
            this.lblCategoriaPartido.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriaPartido.TabIndex = 47;
            this.lblCategoriaPartido.Text = "Categoria";
            this.lblCategoriaPartido.Click += new System.EventHandler(this.lblCategoriaPartido_Click);
            // 
            // lblResultadoPartido
            // 
            this.lblResultadoPartido.AutoSize = true;
            this.lblResultadoPartido.Location = new System.Drawing.Point(241, 268);
            this.lblResultadoPartido.Name = "lblResultadoPartido";
            this.lblResultadoPartido.Size = new System.Drawing.Size(72, 16);
            this.lblResultadoPartido.TabIndex = 46;
            this.lblResultadoPartido.Text = "Resultado ";
            this.lblResultadoPartido.Click += new System.EventHandler(this.lblResultadoPartido_Click);
            // 
            // lblTipoPartido
            // 
            this.lblTipoPartido.AutoSize = true;
            this.lblTipoPartido.Location = new System.Drawing.Point(235, 222);
            this.lblTipoPartido.Name = "lblTipoPartido";
            this.lblTipoPartido.Size = new System.Drawing.Size(99, 16);
            this.lblTipoPartido.TabIndex = 45;
            this.lblTipoPartido.Text = "Tipo de partido";
            this.lblTipoPartido.Click += new System.EventHandler(this.lblTipoPartido_Click);
            // 
            // btnActualizarPartido
            // 
            this.btnActualizarPartido.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarPartido.FlatAppearance.BorderSize = 0;
            this.btnActualizarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPartido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarPartido.Location = new System.Drawing.Point(1008, 135);
            this.btnActualizarPartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarPartido.Name = "btnActualizarPartido";
            this.btnActualizarPartido.Size = new System.Drawing.Size(205, 66);
            this.btnActualizarPartido.TabIndex = 44;
            this.btnActualizarPartido.Text = "Actualizar Partido";
            this.btnActualizarPartido.UseVisualStyleBackColor = false;
            this.btnActualizarPartido.Click += new System.EventHandler(this.btnActualizarPartido_Click);
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Location = new System.Drawing.Point(237, 377);
            this.dgvEntrenadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.RowHeadersWidth = 51;
            this.dgvEntrenadores.RowTemplate.Height = 24;
            this.dgvEntrenadores.Size = new System.Drawing.Size(976, 322);
            this.dgvEntrenadores.TabIndex = 42;
            this.dgvEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrenadores_CellContentClick);
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Silver;
            this.pnlBarraEstado.Controls.Add(this.btnPartResultados);
            this.pnlBarraEstado.Controls.Add(this.btnPartEncuentros);
            this.pnlBarraEstado.Controls.Add(this.btnPartEstadisticas);
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(181, 754);
            this.pnlBarraEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(1091, 64);
            this.pnlBarraEstado.TabIndex = 40;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblProximosEncuentros);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(181, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1091, 114);
            this.pnlBarraTitulo.TabIndex = 39;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlMenu.Controls.Add(this.btnPartidos);
            this.pnlMenu.Controls.Add(this.btnJugadores);
            this.pnlMenu.Controls.Add(this.picBoxUser);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(181, 818);
            this.pnlMenu.TabIndex = 38;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // fmlPartidos_ENTRENADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 818);
            this.Controls.Add(this.dtpHorarioPartido);
            this.Controls.Add(this.cbxTipoPartido);
            this.Controls.Add(this.cbxCategoriaPartido);
            this.Controls.Add(this.txtLugarPart);
            this.Controls.Add(this.txtEquipoVisitantePart);
            this.Controls.Add(this.txtEquipoLocalPartidos);
            this.Controls.Add(this.txtResultadoPart);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblEquipVisitantePartidos);
            this.Controls.Add(this.lblEquipLocalPartidos);
            this.Controls.Add(this.lblHorarioPartido);
            this.Controls.Add(this.lblCategoriaPartido);
            this.Controls.Add(this.lblResultadoPartido);
            this.Controls.Add(this.lblTipoPartido);
            this.Controls.Add(this.btnActualizarPartido);
            this.Controls.Add(this.dgvEntrenadores);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmlPartidos_ENTRENADORES";
            this.Text = "fmlPartidos_ENTRENADORES";
            this.Load += new System.EventHandler(this.fmlPartidos_ENTRENADORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.pnlBarraEstado.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Label lblProximosEncuentros;
        private System.Windows.Forms.DateTimePicker dtpHorarioPartido;
        private System.Windows.Forms.ComboBox cbxTipoPartido;
        private System.Windows.Forms.ComboBox cbxCategoriaPartido;
        private System.Windows.Forms.TextBox txtLugarPart;
        private System.Windows.Forms.TextBox txtEquipoVisitantePart;
        private System.Windows.Forms.TextBox txtEquipoLocalPartidos;
        private System.Windows.Forms.TextBox txtResultadoPart;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnPartResultados;
        private System.Windows.Forms.Button btnPartEncuentros;
        private System.Windows.Forms.Button btnPartEstadisticas;
        private System.Windows.Forms.Label lblEquipVisitantePartidos;
        private System.Windows.Forms.Label lblEquipLocalPartidos;
        private System.Windows.Forms.Label lblHorarioPartido;
        private System.Windows.Forms.Label lblCategoriaPartido;
        private System.Windows.Forms.Label lblResultadoPartido;
        private System.Windows.Forms.Label lblTipoPartido;
        private System.Windows.Forms.Button btnActualizarPartido;
        private System.Windows.Forms.DataGridView dgvEntrenadores;
        private System.Windows.Forms.Panel pnlBarraEstado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenu;
    }
}