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
            this.btnGestCategoria = new System.Windows.Forms.Button();
            this.btnGestEquipos = new System.Windows.Forms.Button();
            this.btnGestEntrenadores = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblGestionEntrenadores = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnActualizarEntrenador = new System.Windows.Forms.Button();
            this.btnQuitarEntrenador = new System.Windows.Forms.Button();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.btnAñaEntrenador = new System.Windows.Forms.Button();
            this.txtContraseñaGestionEntrenadores = new System.Windows.Forms.TextBox();
            this.lblContraseñaGestionEntrenadores = new System.Windows.Forms.Label();
            this.txtCorreoGestionEntrenadores = new System.Windows.Forms.TextBox();
            this.txtNombreGestionEntrenador = new System.Windows.Forms.TextBox();
            this.lblCorreoGestionEntrenadores = new System.Windows.Forms.Label();
            this.lblEstadoGestionEntrenadores = new System.Windows.Forms.Label();
            this.lblNombreGestionEntrenador = new System.Windows.Forms.Label();
            this.cbxEstadoGestionEntrenador = new System.Windows.Forms.ComboBox();
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
            this.pnlBarraEstado.Location = new System.Drawing.Point(136, 663);
            this.pnlBarraEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(785, 46);
            this.pnlBarraEstado.TabIndex = 5;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // btnGestCategoria
            // 
            this.btnGestCategoria.BackColor = System.Drawing.Color.LightGray;
            this.btnGestCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCategoria.Location = new System.Drawing.Point(550, 2);
            this.btnGestCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestCategoria.Name = "btnGestCategoria";
            this.btnGestCategoria.Size = new System.Drawing.Size(207, 41);
            this.btnGestCategoria.TabIndex = 2;
            this.btnGestCategoria.Text = "Categorias";
            this.btnGestCategoria.UseVisualStyleBackColor = false;
            this.btnGestCategoria.Click += new System.EventHandler(this.btnGestCategoria_Click);
            // 
            // btnGestEquipos
            // 
            this.btnGestEquipos.BackColor = System.Drawing.Color.LightGray;
            this.btnGestEquipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEquipos.Location = new System.Drawing.Point(289, 2);
            this.btnGestEquipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestEquipos.Name = "btnGestEquipos";
            this.btnGestEquipos.Size = new System.Drawing.Size(207, 41);
            this.btnGestEquipos.TabIndex = 1;
            this.btnGestEquipos.Text = "Equipos";
            this.btnGestEquipos.UseVisualStyleBackColor = false;
            this.btnGestEquipos.Click += new System.EventHandler(this.btnGestEquipos_Click);
            // 
            // btnGestEntrenadores
            // 
            this.btnGestEntrenadores.BackColor = System.Drawing.Color.LightGray;
            this.btnGestEntrenadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestEntrenadores.ForeColor = System.Drawing.Color.Green;
            this.btnGestEntrenadores.Location = new System.Drawing.Point(28, 2);
            this.btnGestEntrenadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestEntrenadores.Name = "btnGestEntrenadores";
            this.btnGestEntrenadores.Size = new System.Drawing.Size(207, 41);
            this.btnGestEntrenadores.TabIndex = 0;
            this.btnGestEntrenadores.Text = "Entrenadores";
            this.btnGestEntrenadores.UseVisualStyleBackColor = false;
            this.btnGestEntrenadores.Click += new System.EventHandler(this.btnGestEntrenadores_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Controls.Add(this.lblGestionEntrenadores);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(136, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(785, 93);
            this.pnlBarraTitulo.TabIndex = 4;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(694, 37);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(69, 22);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblGestionEntrenadores
            // 
            this.lblGestionEntrenadores.AutoSize = true;
            this.lblGestionEntrenadores.BackColor = System.Drawing.Color.Green;
            this.lblGestionEntrenadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEntrenadores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGestionEntrenadores.Location = new System.Drawing.Point(24, 37);
            this.lblGestionEntrenadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionEntrenadores.Name = "lblGestionEntrenadores";
            this.lblGestionEntrenadores.Size = new System.Drawing.Size(229, 22);
            this.lblGestionEntrenadores.TabIndex = 6;
            this.lblGestionEntrenadores.Text = "Gestion de Entenadores";
            this.lblGestionEntrenadores.Click += new System.EventHandler(this.lblGestionEntrenadores_Click);
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(136, 709);
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
            this.btnPartidos.Location = new System.Drawing.Point(4, 335);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(132, 74);
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
            this.btnGestion.Location = new System.Drawing.Point(0, 256);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(136, 74);
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
            this.btnJugadores.Location = new System.Drawing.Point(4, 177);
            this.btnJugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(132, 74);
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
            this.picBoxUser.Location = new System.Drawing.Point(45, 440);
            this.picBoxUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(56, 57);
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
            this.btnInventario.Location = new System.Drawing.Point(2, 98);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(132, 74);
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
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(136, 93);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // btnActualizarEntrenador
            // 
            this.btnActualizarEntrenador.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarEntrenador.FlatAppearance.BorderSize = 0;
            this.btnActualizarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEntrenador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntrenador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarEntrenador.Location = new System.Drawing.Point(164, 586);
            this.btnActualizarEntrenador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarEntrenador.Name = "btnActualizarEntrenador";
            this.btnActualizarEntrenador.Size = new System.Drawing.Size(154, 54);
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
            this.btnQuitarEntrenador.Location = new System.Drawing.Point(730, 586);
            this.btnQuitarEntrenador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitarEntrenador.Name = "btnQuitarEntrenador";
            this.btnQuitarEntrenador.Size = new System.Drawing.Size(154, 54);
            this.btnQuitarEntrenador.TabIndex = 14;
            this.btnQuitarEntrenador.Text = "- Quitar Entrenador";
            this.btnQuitarEntrenador.UseVisualStyleBackColor = false;
            this.btnQuitarEntrenador.Click += new System.EventHandler(this.btnQuitarEntrenador_Click);
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Location = new System.Drawing.Point(164, 316);
            this.dgvEntrenadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.RowHeadersWidth = 51;
            this.dgvEntrenadores.RowTemplate.Height = 24;
            this.dgvEntrenadores.Size = new System.Drawing.Size(720, 249);
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
            this.btnAñaEntrenador.Location = new System.Drawing.Point(716, 98);
            this.btnAñaEntrenador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAñaEntrenador.Name = "btnAñaEntrenador";
            this.btnAñaEntrenador.Size = new System.Drawing.Size(154, 54);
            this.btnAñaEntrenador.TabIndex = 12;
            this.btnAñaEntrenador.Text = "+ Añadir Entrenador";
            this.btnAñaEntrenador.UseVisualStyleBackColor = false;
            this.btnAñaEntrenador.Click += new System.EventHandler(this.btnAñaEntrenador_Click);
            // 
            // txtContraseñaGestionEntrenadores
            // 
            this.txtContraseñaGestionEntrenadores.Location = new System.Drawing.Point(616, 246);
            this.txtContraseñaGestionEntrenadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseñaGestionEntrenadores.Name = "txtContraseñaGestionEntrenadores";
            this.txtContraseñaGestionEntrenadores.Size = new System.Drawing.Size(223, 20);
            this.txtContraseñaGestionEntrenadores.TabIndex = 61;
            // 
            // lblContraseñaGestionEntrenadores
            // 
            this.lblContraseñaGestionEntrenadores.AutoSize = true;
            this.lblContraseñaGestionEntrenadores.Location = new System.Drawing.Point(524, 251);
            this.lblContraseñaGestionEntrenadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseñaGestionEntrenadores.Name = "lblContraseñaGestionEntrenadores";
            this.lblContraseñaGestionEntrenadores.Size = new System.Drawing.Size(61, 13);
            this.lblContraseñaGestionEntrenadores.TabIndex = 60;
            this.lblContraseñaGestionEntrenadores.Text = "Contraseña";
            // 
            // txtCorreoGestionEntrenadores
            // 
            this.txtCorreoGestionEntrenadores.Location = new System.Drawing.Point(266, 249);
            this.txtCorreoGestionEntrenadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoGestionEntrenadores.Name = "txtCorreoGestionEntrenadores";
            this.txtCorreoGestionEntrenadores.Size = new System.Drawing.Size(223, 20);
            this.txtCorreoGestionEntrenadores.TabIndex = 58;
            // 
            // txtNombreGestionEntrenador
            // 
            this.txtNombreGestionEntrenador.Location = new System.Drawing.Point(266, 208);
            this.txtNombreGestionEntrenador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreGestionEntrenador.Name = "txtNombreGestionEntrenador";
            this.txtNombreGestionEntrenador.Size = new System.Drawing.Size(223, 20);
            this.txtNombreGestionEntrenador.TabIndex = 57;
            // 
            // lblCorreoGestionEntrenadores
            // 
            this.lblCorreoGestionEntrenadores.AutoSize = true;
            this.lblCorreoGestionEntrenadores.Location = new System.Drawing.Point(179, 249);
            this.lblCorreoGestionEntrenadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoGestionEntrenadores.Name = "lblCorreoGestionEntrenadores";
            this.lblCorreoGestionEntrenadores.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoGestionEntrenadores.TabIndex = 56;
            this.lblCorreoGestionEntrenadores.Text = "Correo";
            // 
            // lblEstadoGestionEntrenadores
            // 
            this.lblEstadoGestionEntrenadores.AutoSize = true;
            this.lblEstadoGestionEntrenadores.Location = new System.Drawing.Point(524, 213);
            this.lblEstadoGestionEntrenadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoGestionEntrenadores.Name = "lblEstadoGestionEntrenadores";
            this.lblEstadoGestionEntrenadores.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoGestionEntrenadores.TabIndex = 55;
            this.lblEstadoGestionEntrenadores.Text = "Estado";
            // 
            // lblNombreGestionEntrenador
            // 
            this.lblNombreGestionEntrenador.AutoSize = true;
            this.lblNombreGestionEntrenador.Location = new System.Drawing.Point(174, 210);
            this.lblNombreGestionEntrenador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreGestionEntrenador.Name = "lblNombreGestionEntrenador";
            this.lblNombreGestionEntrenador.Size = new System.Drawing.Size(44, 13);
            this.lblNombreGestionEntrenador.TabIndex = 54;
            this.lblNombreGestionEntrenador.Text = "Nombre";
            // 
            // cbxEstadoGestionEntrenador
            // 
            this.cbxEstadoGestionEntrenador.FormattingEnabled = true;
            this.cbxEstadoGestionEntrenador.Location = new System.Drawing.Point(616, 201);
            this.cbxEstadoGestionEntrenador.Name = "cbxEstadoGestionEntrenador";
            this.cbxEstadoGestionEntrenador.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoGestionEntrenador.TabIndex = 62;
            this.cbxEstadoGestionEntrenador.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoGestionEntrenador_SelectedIndexChanged);
            // 
            // fmlGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 709);
            this.Controls.Add(this.cbxEstadoGestionEntrenador);
            this.Controls.Add(this.txtContraseñaGestionEntrenadores);
            this.Controls.Add(this.lblContraseñaGestionEntrenadores);
            this.Controls.Add(this.txtCorreoGestionEntrenadores);
            this.Controls.Add(this.txtNombreGestionEntrenador);
            this.Controls.Add(this.lblCorreoGestionEntrenadores);
            this.Controls.Add(this.lblEstadoGestionEntrenadores);
            this.Controls.Add(this.lblNombreGestionEntrenador);
            this.Controls.Add(this.btnActualizarEntrenador);
            this.Controls.Add(this.btnQuitarEntrenador);
            this.Controls.Add(this.dgvEntrenadores);
            this.Controls.Add(this.btnAñaEntrenador);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmlGestion";
            this.Text = "fmlGestion";
            this.pnlBarraEstado.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtContraseñaGestionEntrenadores;
        private System.Windows.Forms.Label lblContraseñaGestionEntrenadores;
        private System.Windows.Forms.TextBox txtCorreoGestionEntrenadores;
        private System.Windows.Forms.TextBox txtNombreGestionEntrenador;
        private System.Windows.Forms.Label lblCorreoGestionEntrenadores;
        private System.Windows.Forms.Label lblEstadoGestionEntrenadores;
        private System.Windows.Forms.Label lblNombreGestionEntrenador;
        private System.Windows.Forms.ComboBox cbxEstadoGestionEntrenador;
    }
}