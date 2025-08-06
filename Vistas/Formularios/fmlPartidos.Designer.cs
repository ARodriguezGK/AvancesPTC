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
            this.btnPartResultados = new System.Windows.Forms.Button();
            this.btnPartEncuentros = new System.Windows.Forms.Button();
            this.btnPartEstadisticas = new System.Windows.Forms.Button();
            this.btnActualizarPartido = new System.Windows.Forms.Button();
            this.btnQuitarPartido = new System.Windows.Forms.Button();
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            this.btnAñaPartido = new System.Windows.Forms.Button();
            this.lblTipoPartido = new System.Windows.Forms.Label();
            this.lblCategoriaPartido = new System.Windows.Forms.Label();
            this.lblHorarioPartido = new System.Windows.Forms.Label();
            this.lblEquipLocalPartidos = new System.Windows.Forms.Label();
            this.lblEquipVisitantePartidos = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtEquipoLocalPartidos = new System.Windows.Forms.TextBox();
            this.txtEquipoVisitantePart = new System.Windows.Forms.TextBox();
            this.txtLugarPart = new System.Windows.Forms.TextBox();
            this.cbxCategoriaPartido = new System.Windows.Forms.ComboBox();
            this.cbxTipoPartido = new System.Windows.Forms.ComboBox();
            this.dtpHorarioPartido = new System.Windows.Forms.DateTimePicker();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblProximosEncuentros = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlBarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Silver;
            this.pnlBarraEstado.Controls.Add(this.btnPartResultados);
            this.pnlBarraEstado.Controls.Add(this.btnPartEncuentros);
            this.pnlBarraEstado.Controls.Add(this.btnPartEstadisticas);
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(136, 670);
            this.pnlBarraEstado.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(792, 52);
            this.pnlBarraEstado.TabIndex = 5;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // btnPartResultados
            // 
            this.btnPartResultados.BackColor = System.Drawing.Color.LightGray;
            this.btnPartResultados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartResultados.Location = new System.Drawing.Point(563, 5);
            this.btnPartResultados.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartResultados.Name = "btnPartResultados";
            this.btnPartResultados.Size = new System.Drawing.Size(207, 41);
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
            this.btnPartEncuentros.Location = new System.Drawing.Point(23, 5);
            this.btnPartEncuentros.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartEncuentros.Name = "btnPartEncuentros";
            this.btnPartEncuentros.Size = new System.Drawing.Size(207, 41);
            this.btnPartEncuentros.TabIndex = 0;
            this.btnPartEncuentros.Text = "Proximo encuentro";
            this.btnPartEncuentros.UseVisualStyleBackColor = false;
            this.btnPartEncuentros.Click += new System.EventHandler(this.btnPartEncuentros_Click);
            // 
            // btnPartEstadisticas
            // 
            this.btnPartEstadisticas.BackColor = System.Drawing.Color.LightGray;
            this.btnPartEstadisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartEstadisticas.Location = new System.Drawing.Point(298, 5);
            this.btnPartEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartEstadisticas.Name = "btnPartEstadisticas";
            this.btnPartEstadisticas.Size = new System.Drawing.Size(207, 41);
            this.btnPartEstadisticas.TabIndex = 1;
            this.btnPartEstadisticas.Text = "Estadisticas de partidos";
            this.btnPartEstadisticas.UseVisualStyleBackColor = false;
            this.btnPartEstadisticas.Click += new System.EventHandler(this.btnPartEstadisticas_Click);
            // 
            // btnActualizarPartido
            // 
            this.btnActualizarPartido.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarPartido.FlatAppearance.BorderSize = 0;
            this.btnActualizarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPartido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarPartido.Location = new System.Drawing.Point(175, 593);
            this.btnActualizarPartido.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPartido.Name = "btnActualizarPartido";
            this.btnActualizarPartido.Size = new System.Drawing.Size(154, 54);
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
            this.btnQuitarPartido.Location = new System.Drawing.Point(752, 593);
            this.btnQuitarPartido.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarPartido.Name = "btnQuitarPartido";
            this.btnQuitarPartido.Size = new System.Drawing.Size(154, 54);
            this.btnQuitarPartido.TabIndex = 19;
            this.btnQuitarPartido.Text = "- Quitar Partido";
            this.btnQuitarPartido.UseVisualStyleBackColor = false;
            this.btnQuitarPartido.Click += new System.EventHandler(this.btnQuitarPartido_Click);
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Location = new System.Drawing.Point(178, 306);
            this.dgvEntrenadores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.RowHeadersWidth = 51;
            this.dgvEntrenadores.RowTemplate.Height = 24;
            this.dgvEntrenadores.Size = new System.Drawing.Size(732, 262);
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
            this.btnAñaPartido.Location = new System.Drawing.Point(752, 98);
            this.btnAñaPartido.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñaPartido.Name = "btnAñaPartido";
            this.btnAñaPartido.Size = new System.Drawing.Size(154, 54);
            this.btnAñaPartido.TabIndex = 17;
            this.btnAñaPartido.Text = "+ Añadir Partido";
            this.btnAñaPartido.UseVisualStyleBackColor = false;
            this.btnAñaPartido.Click += new System.EventHandler(this.btnAñaPartido_Click);
            // 
            // lblTipoPartido
            // 
            this.lblTipoPartido.AutoSize = true;
            this.lblTipoPartido.Location = new System.Drawing.Point(176, 180);
            this.lblTipoPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPartido.Name = "lblTipoPartido";
            this.lblTipoPartido.Size = new System.Drawing.Size(78, 13);
            this.lblTipoPartido.TabIndex = 22;
            this.lblTipoPartido.Text = "Tipo de partido";
            this.lblTipoPartido.Click += new System.EventHandler(this.lblTipoPartido_Click);
            // 
            // lblCategoriaPartido
            // 
            this.lblCategoriaPartido.AutoSize = true;
            this.lblCategoriaPartido.Location = new System.Drawing.Point(520, 175);
            this.lblCategoriaPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaPartido.Name = "lblCategoriaPartido";
            this.lblCategoriaPartido.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaPartido.TabIndex = 24;
            this.lblCategoriaPartido.Text = "Categoria";
            this.lblCategoriaPartido.Click += new System.EventHandler(this.lblCategoriaPartido_Click);
            // 
            // lblHorarioPartido
            // 
            this.lblHorarioPartido.AutoSize = true;
            this.lblHorarioPartido.Location = new System.Drawing.Point(181, 218);
            this.lblHorarioPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorarioPartido.Name = "lblHorarioPartido";
            this.lblHorarioPartido.Size = new System.Drawing.Size(41, 13);
            this.lblHorarioPartido.TabIndex = 25;
            this.lblHorarioPartido.Text = "Horario";
            this.lblHorarioPartido.Click += new System.EventHandler(this.lblHorarioPartido_Click);
            // 
            // lblEquipLocalPartidos
            // 
            this.lblEquipLocalPartidos.AutoSize = true;
            this.lblEquipLocalPartidos.Location = new System.Drawing.Point(181, 256);
            this.lblEquipLocalPartidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipLocalPartidos.Name = "lblEquipLocalPartidos";
            this.lblEquipLocalPartidos.Size = new System.Drawing.Size(65, 13);
            this.lblEquipLocalPartidos.TabIndex = 26;
            this.lblEquipLocalPartidos.Text = "Equipo local";
            this.lblEquipLocalPartidos.Click += new System.EventHandler(this.lblEquipLocalPartidos_Click);
            // 
            // lblEquipVisitantePartidos
            // 
            this.lblEquipVisitantePartidos.AutoSize = true;
            this.lblEquipVisitantePartidos.Location = new System.Drawing.Point(520, 218);
            this.lblEquipVisitantePartidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipVisitantePartidos.Name = "lblEquipVisitantePartidos";
            this.lblEquipVisitantePartidos.Size = new System.Drawing.Size(82, 13);
            this.lblEquipVisitantePartidos.TabIndex = 27;
            this.lblEquipVisitantePartidos.Text = "Equipo visitante";
            this.lblEquipVisitantePartidos.Click += new System.EventHandler(this.lblEquipVisitantePartidos_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(530, 260);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 28;
            this.lblLugar.Text = "Lugar";
            this.lblLugar.Click += new System.EventHandler(this.lblLugar_Click);
            // 
            // txtEquipoLocalPartidos
            // 
            this.txtEquipoLocalPartidos.Location = new System.Drawing.Point(267, 256);
            this.txtEquipoLocalPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipoLocalPartidos.Name = "txtEquipoLocalPartidos";
            this.txtEquipoLocalPartidos.Size = new System.Drawing.Size(223, 20);
            this.txtEquipoLocalPartidos.TabIndex = 30;
            this.txtEquipoLocalPartidos.TextChanged += new System.EventHandler(this.txtEquipoLocalPartidos_TextChanged);
            // 
            // txtEquipoVisitantePart
            // 
            this.txtEquipoVisitantePart.Location = new System.Drawing.Point(624, 215);
            this.txtEquipoVisitantePart.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipoVisitantePart.Name = "txtEquipoVisitantePart";
            this.txtEquipoVisitantePart.Size = new System.Drawing.Size(223, 20);
            this.txtEquipoVisitantePart.TabIndex = 33;
            this.txtEquipoVisitantePart.TextChanged += new System.EventHandler(this.txtEquipoVisitantePart_TextChanged);
            // 
            // txtLugarPart
            // 
            this.txtLugarPart.Location = new System.Drawing.Point(624, 253);
            this.txtLugarPart.Margin = new System.Windows.Forms.Padding(2);
            this.txtLugarPart.Name = "txtLugarPart";
            this.txtLugarPart.Size = new System.Drawing.Size(223, 20);
            this.txtLugarPart.TabIndex = 34;
            this.txtLugarPart.TextChanged += new System.EventHandler(this.txtLugarPart_TextChanged);
            // 
            // cbxCategoriaPartido
            // 
            this.cbxCategoriaPartido.FormattingEnabled = true;
            this.cbxCategoriaPartido.Location = new System.Drawing.Point(624, 175);
            this.cbxCategoriaPartido.Name = "cbxCategoriaPartido";
            this.cbxCategoriaPartido.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoriaPartido.TabIndex = 35;
            // 
            // cbxTipoPartido
            // 
            this.cbxTipoPartido.FormattingEnabled = true;
            this.cbxTipoPartido.Location = new System.Drawing.Point(267, 177);
            this.cbxTipoPartido.Name = "cbxTipoPartido";
            this.cbxTipoPartido.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoPartido.TabIndex = 36;
            // 
            // dtpHorarioPartido
            // 
            this.dtpHorarioPartido.Location = new System.Drawing.Point(267, 218);
            this.dtpHorarioPartido.Name = "dtpHorarioPartido";
            this.dtpHorarioPartido.Size = new System.Drawing.Size(200, 20);
            this.dtpHorarioPartido.TabIndex = 37;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblProximosEncuentros);
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(136, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(792, 93);
            this.pnlBarraTitulo.TabIndex = 4;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // lblProximosEncuentros
            // 
            this.lblProximosEncuentros.AutoSize = true;
            this.lblProximosEncuentros.BackColor = System.Drawing.Color.Green;
            this.lblProximosEncuentros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximosEncuentros.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProximosEncuentros.Location = new System.Drawing.Point(34, 36);
            this.lblProximosEncuentros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProximosEncuentros.Name = "lblProximosEncuentros";
            this.lblProximosEncuentros.Size = new System.Drawing.Size(177, 22);
            this.lblProximosEncuentros.TabIndex = 14;
            this.lblProximosEncuentros.Text = "Proximos Partidos";
            this.lblProximosEncuentros.Click += new System.EventHandler(this.lblProximosEncuentros_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(708, 36);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(69, 22);
            this.lblAdmin.TabIndex = 13;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(136, 722);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnPartidos
            // 
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.Green;
            this.btnPartidos.Location = new System.Drawing.Point(0, 335);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(136, 74);
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
            this.btnGestion.Location = new System.Drawing.Point(4, 256);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(132, 74);
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
            this.btnJugadores.Margin = new System.Windows.Forms.Padding(2);
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
            this.picBoxUser.Location = new System.Drawing.Point(43, 414);
            this.picBoxUser.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnInventario.Margin = new System.Windows.Forms.Padding(2);
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
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(136, 93);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_Paint);
            // 
            // fmlPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 722);
            this.Controls.Add(this.dtpHorarioPartido);
            this.Controls.Add(this.cbxTipoPartido);
            this.Controls.Add(this.cbxCategoriaPartido);
            this.Controls.Add(this.txtLugarPart);
            this.Controls.Add(this.txtEquipoVisitantePart);
            this.Controls.Add(this.txtEquipoLocalPartidos);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblEquipVisitantePartidos);
            this.Controls.Add(this.lblEquipLocalPartidos);
            this.Controls.Add(this.lblHorarioPartido);
            this.Controls.Add(this.lblCategoriaPartido);
            this.Controls.Add(this.lblTipoPartido);
            this.Controls.Add(this.btnActualizarPartido);
            this.Controls.Add(this.btnQuitarPartido);
            this.Controls.Add(this.dgvEntrenadores);
            this.Controls.Add(this.btnAñaPartido);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmlPartidos";
            this.Text = "fmlPartidos";
            this.pnlBarraEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblTipoPartido;
        private System.Windows.Forms.Label lblCategoriaPartido;
        private System.Windows.Forms.Label lblHorarioPartido;
        private System.Windows.Forms.Label lblEquipLocalPartidos;
        private System.Windows.Forms.Label lblEquipVisitantePartidos;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtEquipoLocalPartidos;
        private System.Windows.Forms.TextBox txtEquipoVisitantePart;
        private System.Windows.Forms.TextBox txtLugarPart;
        private System.Windows.Forms.ComboBox cbxCategoriaPartido;
        private System.Windows.Forms.ComboBox cbxTipoPartido;
        private System.Windows.Forms.DateTimePicker dtpHorarioPartido;
    }
}