namespace Vistas.Formularios
{
    partial class fmlJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlJugadores));
            this.pnlBarraEstado = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblJugadoresBasic = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnQuitarJugador = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.btnAñaJugador = new System.Windows.Forms.Button();
            this.btnActualizarJugador = new System.Windows.Forms.Button();
            this.txtApellidoJugadores = new System.Windows.Forms.TextBox();
            this.lblDorsalJugadores = new System.Windows.Forms.Label();
            this.lblEdadJugadores = new System.Windows.Forms.Label();
            this.lblApellidoJugadores = new System.Windows.Forms.Label();
            this.lblNombreJugadores = new System.Windows.Forms.Label();
            this.txtNombreJugadores = new System.Windows.Forms.TextBox();
            this.lblPosicionJugadores = new System.Windows.Forms.Label();
            this.numericUpDownEdadJugador = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDorsalJugador = new System.Windows.Forms.NumericUpDown();
            this.cbxPosicionJugador = new System.Windows.Forms.ComboBox();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdadJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDorsalJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Silver;
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(136, 632);
            this.pnlBarraEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(787, 46);
            this.pnlBarraEstado.TabIndex = 5;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Controls.Add(this.lblJugadoresBasic);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(136, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(787, 93);
            this.pnlBarraTitulo.TabIndex = 4;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(700, 37);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(69, 22);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "Admin";
            // 
            // lblJugadoresBasic
            // 
            this.lblJugadoresBasic.AutoSize = true;
            this.lblJugadoresBasic.BackColor = System.Drawing.Color.Green;
            this.lblJugadoresBasic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadoresBasic.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJugadoresBasic.Image = global::Vistas.Properties.Resources.green;
            this.lblJugadoresBasic.Location = new System.Drawing.Point(21, 37);
            this.lblJugadoresBasic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugadoresBasic.Name = "lblJugadoresBasic";
            this.lblJugadoresBasic.Size = new System.Drawing.Size(266, 28);
            this.lblJugadoresBasic.TabIndex = 0;
            this.lblJugadoresBasic.Text = "Gestion de Jugadores";
            this.lblJugadoresBasic.Click += new System.EventHandler(this.lblJugadoresBasic_Click);
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
            this.pnlMenu.Size = new System.Drawing.Size(136, 678);
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
            this.btnGestion.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestion.Location = new System.Drawing.Point(4, 256);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(132, 74);
            this.btnGestion.TabIndex = 7;
            this.btnGestion.Text = "Gestion";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.Color.Green;
            this.btnJugadores.Location = new System.Drawing.Point(0, 177);
            this.btnJugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(136, 74);
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
            // btnQuitarJugador
            // 
            this.btnQuitarJugador.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarJugador.FlatAppearance.BorderSize = 0;
            this.btnQuitarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitarJugador.Location = new System.Drawing.Point(745, 569);
            this.btnQuitarJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitarJugador.Name = "btnQuitarJugador";
            this.btnQuitarJugador.Size = new System.Drawing.Size(154, 54);
            this.btnQuitarJugador.TabIndex = 10;
            this.btnQuitarJugador.Text = "- Quitar Jugador";
            this.btnQuitarJugador.UseVisualStyleBackColor = false;
            this.btnQuitarJugador.Click += new System.EventHandler(this.btnQuitarJugador_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(179, 294);
            this.dgvJugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.RowTemplate.Height = 24;
            this.dgvJugadores.Size = new System.Drawing.Size(720, 249);
            this.dgvJugadores.TabIndex = 9;
            this.dgvJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellClick);
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellContentClick);
            // 
            // btnAñaJugador
            // 
            this.btnAñaJugador.BackColor = System.Drawing.Color.Green;
            this.btnAñaJugador.FlatAppearance.BorderSize = 0;
            this.btnAñaJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñaJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñaJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñaJugador.Location = new System.Drawing.Point(745, 110);
            this.btnAñaJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAñaJugador.Name = "btnAñaJugador";
            this.btnAñaJugador.Size = new System.Drawing.Size(154, 54);
            this.btnAñaJugador.TabIndex = 8;
            this.btnAñaJugador.Text = "+ Añadir Jugador";
            this.btnAñaJugador.UseVisualStyleBackColor = false;
            this.btnAñaJugador.Click += new System.EventHandler(this.btnAñaJugador_Click);
            // 
            // btnActualizarJugador
            // 
            this.btnActualizarJugador.BackColor = System.Drawing.Color.Teal;
            this.btnActualizarJugador.FlatAppearance.BorderSize = 0;
            this.btnActualizarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarJugador.Location = new System.Drawing.Point(179, 569);
            this.btnActualizarJugador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarJugador.Name = "btnActualizarJugador";
            this.btnActualizarJugador.Size = new System.Drawing.Size(154, 54);
            this.btnActualizarJugador.TabIndex = 11;
            this.btnActualizarJugador.Text = "Actualizar Jugadores";
            this.btnActualizarJugador.UseVisualStyleBackColor = false;
            this.btnActualizarJugador.Click += new System.EventHandler(this.btnActualizarJugador_Click);
            // 
            // txtApellidoJugadores
            // 
            this.txtApellidoJugadores.Location = new System.Drawing.Point(290, 215);
            this.txtApellidoJugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidoJugadores.Name = "txtApellidoJugadores";
            this.txtApellidoJugadores.Size = new System.Drawing.Size(223, 20);
            this.txtApellidoJugadores.TabIndex = 49;
            this.txtApellidoJugadores.TextChanged += new System.EventHandler(this.txtApellidoJugadores_TextChanged);
            // 
            // lblDorsalJugadores
            // 
            this.lblDorsalJugadores.AutoSize = true;
            this.lblDorsalJugadores.Location = new System.Drawing.Point(204, 256);
            this.lblDorsalJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDorsalJugadores.Name = "lblDorsalJugadores";
            this.lblDorsalJugadores.Size = new System.Drawing.Size(37, 13);
            this.lblDorsalJugadores.TabIndex = 48;
            this.lblDorsalJugadores.Text = "Dorsal";
            this.lblDorsalJugadores.Click += new System.EventHandler(this.lblDorsalJugadores_Click);
            // 
            // lblEdadJugadores
            // 
            this.lblEdadJugadores.AutoSize = true;
            this.lblEdadJugadores.Location = new System.Drawing.Point(549, 220);
            this.lblEdadJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdadJugadores.Name = "lblEdadJugadores";
            this.lblEdadJugadores.Size = new System.Drawing.Size(32, 13);
            this.lblEdadJugadores.TabIndex = 47;
            this.lblEdadJugadores.Text = "Edad";
            this.lblEdadJugadores.Click += new System.EventHandler(this.lblEdadJugadores_Click);
            // 
            // lblApellidoJugadores
            // 
            this.lblApellidoJugadores.AutoSize = true;
            this.lblApellidoJugadores.Location = new System.Drawing.Point(199, 218);
            this.lblApellidoJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoJugadores.Name = "lblApellidoJugadores";
            this.lblApellidoJugadores.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoJugadores.TabIndex = 46;
            this.lblApellidoJugadores.Text = "Apellido";
            this.lblApellidoJugadores.Click += new System.EventHandler(this.lblApellidoJugadores_Click);
            // 
            // lblNombreJugadores
            // 
            this.lblNombreJugadores.AutoSize = true;
            this.lblNombreJugadores.Location = new System.Drawing.Point(200, 180);
            this.lblNombreJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreJugadores.Name = "lblNombreJugadores";
            this.lblNombreJugadores.Size = new System.Drawing.Size(44, 13);
            this.lblNombreJugadores.TabIndex = 45;
            this.lblNombreJugadores.Text = "Nombre";
            this.lblNombreJugadores.Click += new System.EventHandler(this.lblNombreJugadores_Click);
            // 
            // txtNombreJugadores
            // 
            this.txtNombreJugadores.Location = new System.Drawing.Point(290, 177);
            this.txtNombreJugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreJugadores.Name = "txtNombreJugadores";
            this.txtNombreJugadores.Size = new System.Drawing.Size(223, 20);
            this.txtNombreJugadores.TabIndex = 44;
            this.txtNombreJugadores.TextChanged += new System.EventHandler(this.txtNombreJugadores_TextChanged);
            // 
            // lblPosicionJugadores
            // 
            this.lblPosicionJugadores.AutoSize = true;
            this.lblPosicionJugadores.Location = new System.Drawing.Point(549, 258);
            this.lblPosicionJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosicionJugadores.Name = "lblPosicionJugadores";
            this.lblPosicionJugadores.Size = new System.Drawing.Size(47, 13);
            this.lblPosicionJugadores.TabIndex = 52;
            this.lblPosicionJugadores.Text = "Posicion";
            this.lblPosicionJugadores.Click += new System.EventHandler(this.lblPosicionJugadores_Click);
            // 
            // numericUpDownEdadJugador
            // 
            this.numericUpDownEdadJugador.Location = new System.Drawing.Point(623, 214);
            this.numericUpDownEdadJugador.Name = "numericUpDownEdadJugador";
            this.numericUpDownEdadJugador.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEdadJugador.TabIndex = 53;
            this.numericUpDownEdadJugador.ValueChanged += new System.EventHandler(this.numericUpDownEdadJugador_ValueChanged);
            // 
            // numericUpDownDorsalJugador
            // 
            this.numericUpDownDorsalJugador.Location = new System.Drawing.Point(290, 258);
            this.numericUpDownDorsalJugador.Name = "numericUpDownDorsalJugador";
            this.numericUpDownDorsalJugador.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDorsalJugador.TabIndex = 54;
            this.numericUpDownDorsalJugador.ValueChanged += new System.EventHandler(this.numericUpDownDorsalJugador_ValueChanged);
            // 
            // cbxPosicionJugador
            // 
            this.cbxPosicionJugador.FormattingEnabled = true;
            this.cbxPosicionJugador.Location = new System.Drawing.Point(623, 256);
            this.cbxPosicionJugador.Name = "cbxPosicionJugador";
            this.cbxPosicionJugador.Size = new System.Drawing.Size(121, 21);
            this.cbxPosicionJugador.TabIndex = 55;
            this.cbxPosicionJugador.SelectedIndexChanged += new System.EventHandler(this.cbxPosicionJugador_SelectedIndexChanged);
            // 
            // fmlJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 678);
            this.Controls.Add(this.cbxPosicionJugador);
            this.Controls.Add(this.numericUpDownDorsalJugador);
            this.Controls.Add(this.numericUpDownEdadJugador);
            this.Controls.Add(this.lblPosicionJugadores);
            this.Controls.Add(this.txtApellidoJugadores);
            this.Controls.Add(this.lblDorsalJugadores);
            this.Controls.Add(this.lblEdadJugadores);
            this.Controls.Add(this.lblApellidoJugadores);
            this.Controls.Add(this.lblNombreJugadores);
            this.Controls.Add(this.txtNombreJugadores);
            this.Controls.Add(this.btnActualizarJugador);
            this.Controls.Add(this.btnQuitarJugador);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnAñaJugador);
            this.Controls.Add(this.pnlBarraEstado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmlJugadores";
            this.Text = "fmlJugadores";
            this.Load += new System.EventHandler(this.fmlJugadores_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdadJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDorsalJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraEstado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblJugadoresBasic;
        private System.Windows.Forms.Button btnQuitarJugador;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button btnAñaJugador;
        private System.Windows.Forms.Button btnActualizarJugador;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtApellidoJugadores;
        private System.Windows.Forms.Label lblDorsalJugadores;
        private System.Windows.Forms.Label lblEdadJugadores;
        private System.Windows.Forms.Label lblApellidoJugadores;
        private System.Windows.Forms.Label lblNombreJugadores;
        private System.Windows.Forms.TextBox txtNombreJugadores;
        private System.Windows.Forms.Label lblPosicionJugadores;
        private System.Windows.Forms.NumericUpDown numericUpDownEdadJugador;
        private System.Windows.Forms.NumericUpDown numericUpDownDorsalJugador;
        private System.Windows.Forms.ComboBox cbxPosicionJugador;
    }
}