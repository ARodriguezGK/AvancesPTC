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
            this.txtEdadJugadores = new System.Windows.Forms.TextBox();
            this.txtDorsalJugadores = new System.Windows.Forms.TextBox();
            this.txtApellidoJugadores = new System.Windows.Forms.TextBox();
            this.lblDorsalJugadores = new System.Windows.Forms.Label();
            this.lblEdadJugadores = new System.Windows.Forms.Label();
            this.lblApellidoJugadores = new System.Windows.Forms.Label();
            this.lblNombreJugadores = new System.Windows.Forms.Label();
            this.txtNombreJugadores = new System.Windows.Forms.TextBox();
            this.lblPosicionJugadores = new System.Windows.Forms.Label();
            this.txtPosicionJugadores = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraEstado
            // 
            this.pnlBarraEstado.BackColor = System.Drawing.Color.Silver;
            this.pnlBarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBarraEstado.Location = new System.Drawing.Point(182, 870);
            this.pnlBarraEstado.Name = "pnlBarraEstado";
            this.pnlBarraEstado.Size = new System.Drawing.Size(1094, 57);
            this.pnlBarraEstado.TabIndex = 5;
            this.pnlBarraEstado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraEstado_Paint);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo.Controls.Add(this.lblJugadoresBasic);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(182, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1094, 115);
            this.pnlBarraTitulo.TabIndex = 4;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(934, 46);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 27);
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
            this.lblJugadoresBasic.Location = new System.Drawing.Point(28, 46);
            this.lblJugadoresBasic.Name = "lblJugadoresBasic";
            this.lblJugadoresBasic.Size = new System.Drawing.Size(337, 34);
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
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 927);
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
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.ForeColor = System.Drawing.Color.Green;
            this.btnJugadores.Location = new System.Drawing.Point(0, 218);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(182, 91);
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
            // btnQuitarJugador
            // 
            this.btnQuitarJugador.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarJugador.FlatAppearance.BorderSize = 0;
            this.btnQuitarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitarJugador.Location = new System.Drawing.Point(993, 700);
            this.btnQuitarJugador.Name = "btnQuitarJugador";
            this.btnQuitarJugador.Size = new System.Drawing.Size(206, 66);
            this.btnQuitarJugador.TabIndex = 10;
            this.btnQuitarJugador.Text = "- Quitar Jugador";
            this.btnQuitarJugador.UseVisualStyleBackColor = false;
            this.btnQuitarJugador.Click += new System.EventHandler(this.btnQuitarJugador_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(239, 362);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.RowTemplate.Height = 24;
            this.dgvJugadores.Size = new System.Drawing.Size(960, 307);
            this.dgvJugadores.TabIndex = 9;
            this.dgvJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellClick);
            // 
            // btnAñaJugador
            // 
            this.btnAñaJugador.BackColor = System.Drawing.Color.Green;
            this.btnAñaJugador.FlatAppearance.BorderSize = 0;
            this.btnAñaJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñaJugador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñaJugador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñaJugador.Location = new System.Drawing.Point(993, 135);
            this.btnAñaJugador.Name = "btnAñaJugador";
            this.btnAñaJugador.Size = new System.Drawing.Size(206, 66);
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
            this.btnActualizarJugador.Location = new System.Drawing.Point(239, 700);
            this.btnActualizarJugador.Name = "btnActualizarJugador";
            this.btnActualizarJugador.Size = new System.Drawing.Size(206, 66);
            this.btnActualizarJugador.TabIndex = 11;
            this.btnActualizarJugador.Text = "Actualizar Jugadores";
            this.btnActualizarJugador.UseVisualStyleBackColor = false;
            this.btnActualizarJugador.Click += new System.EventHandler(this.btnActualizarJugador_Click);
            // 
            // txtEdadJugadores
            // 
            this.txtEdadJugadores.Location = new System.Drawing.Point(854, 265);
            this.txtEdadJugadores.Name = "txtEdadJugadores";
            this.txtEdadJugadores.Size = new System.Drawing.Size(296, 22);
            this.txtEdadJugadores.TabIndex = 51;
            this.txtEdadJugadores.TextChanged += new System.EventHandler(this.txtEdadJugadores_TextChanged);
            // 
            // txtDorsalJugadores
            // 
            this.txtDorsalJugadores.Location = new System.Drawing.Point(387, 315);
            this.txtDorsalJugadores.Name = "txtDorsalJugadores";
            this.txtDorsalJugadores.Size = new System.Drawing.Size(296, 22);
            this.txtDorsalJugadores.TabIndex = 50;
            this.txtDorsalJugadores.TextChanged += new System.EventHandler(this.txtDorsalJugadores_TextChanged);
            // 
            // txtApellidoJugadores
            // 
            this.txtApellidoJugadores.Location = new System.Drawing.Point(387, 265);
            this.txtApellidoJugadores.Name = "txtApellidoJugadores";
            this.txtApellidoJugadores.Size = new System.Drawing.Size(296, 22);
            this.txtApellidoJugadores.TabIndex = 49;
            this.txtApellidoJugadores.TextChanged += new System.EventHandler(this.txtApellidoJugadores_TextChanged);
            // 
            // lblDorsalJugadores
            // 
            this.lblDorsalJugadores.AutoSize = true;
            this.lblDorsalJugadores.Location = new System.Drawing.Point(272, 315);
            this.lblDorsalJugadores.Name = "lblDorsalJugadores";
            this.lblDorsalJugadores.Size = new System.Drawing.Size(47, 16);
            this.lblDorsalJugadores.TabIndex = 48;
            this.lblDorsalJugadores.Text = "Dorsal";
            this.lblDorsalJugadores.Click += new System.EventHandler(this.lblDorsalJugadores_Click);
            // 
            // lblEdadJugadores
            // 
            this.lblEdadJugadores.AutoSize = true;
            this.lblEdadJugadores.Location = new System.Drawing.Point(732, 271);
            this.lblEdadJugadores.Name = "lblEdadJugadores";
            this.lblEdadJugadores.Size = new System.Drawing.Size(40, 16);
            this.lblEdadJugadores.TabIndex = 47;
            this.lblEdadJugadores.Text = "Edad";
            this.lblEdadJugadores.Click += new System.EventHandler(this.lblEdadJugadores_Click);
            // 
            // lblApellidoJugadores
            // 
            this.lblApellidoJugadores.AutoSize = true;
            this.lblApellidoJugadores.Location = new System.Drawing.Point(265, 268);
            this.lblApellidoJugadores.Name = "lblApellidoJugadores";
            this.lblApellidoJugadores.Size = new System.Drawing.Size(57, 16);
            this.lblApellidoJugadores.TabIndex = 46;
            this.lblApellidoJugadores.Text = "Apellido";
            this.lblApellidoJugadores.Click += new System.EventHandler(this.lblApellidoJugadores_Click);
            // 
            // lblNombreJugadores
            // 
            this.lblNombreJugadores.AutoSize = true;
            this.lblNombreJugadores.Location = new System.Drawing.Point(266, 221);
            this.lblNombreJugadores.Name = "lblNombreJugadores";
            this.lblNombreJugadores.Size = new System.Drawing.Size(56, 16);
            this.lblNombreJugadores.TabIndex = 45;
            this.lblNombreJugadores.Text = "Nombre";
            this.lblNombreJugadores.Click += new System.EventHandler(this.lblNombreJugadores_Click);
            // 
            // txtNombreJugadores
            // 
            this.txtNombreJugadores.Location = new System.Drawing.Point(387, 218);
            this.txtNombreJugadores.Name = "txtNombreJugadores";
            this.txtNombreJugadores.Size = new System.Drawing.Size(296, 22);
            this.txtNombreJugadores.TabIndex = 44;
            this.txtNombreJugadores.TextChanged += new System.EventHandler(this.txtNombreJugadores_TextChanged);
            // 
            // lblPosicionJugadores
            // 
            this.lblPosicionJugadores.AutoSize = true;
            this.lblPosicionJugadores.Location = new System.Drawing.Point(732, 318);
            this.lblPosicionJugadores.Name = "lblPosicionJugadores";
            this.lblPosicionJugadores.Size = new System.Drawing.Size(59, 16);
            this.lblPosicionJugadores.TabIndex = 52;
            this.lblPosicionJugadores.Text = "Posicion";
            this.lblPosicionJugadores.Click += new System.EventHandler(this.lblPosicionJugadores_Click);
            // 
            // txtPosicionJugadores
            // 
            this.txtPosicionJugadores.Location = new System.Drawing.Point(854, 312);
            this.txtPosicionJugadores.Name = "txtPosicionJugadores";
            this.txtPosicionJugadores.Size = new System.Drawing.Size(296, 22);
            this.txtPosicionJugadores.TabIndex = 53;
            this.txtPosicionJugadores.TextChanged += new System.EventHandler(this.txtPosicionJugadores_TextChanged);
            // 
            // fmlJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 927);
            this.Controls.Add(this.txtPosicionJugadores);
            this.Controls.Add(this.lblPosicionJugadores);
            this.Controls.Add(this.txtEdadJugadores);
            this.Controls.Add(this.txtDorsalJugadores);
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
            this.Name = "fmlJugadores";
            this.Text = "fmlJugadores";
            this.Load += new System.EventHandler(this.fmlJugadores_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
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
        private System.Windows.Forms.TextBox txtEdadJugadores;
        private System.Windows.Forms.TextBox txtDorsalJugadores;
        private System.Windows.Forms.TextBox txtApellidoJugadores;
        private System.Windows.Forms.Label lblDorsalJugadores;
        private System.Windows.Forms.Label lblEdadJugadores;
        private System.Windows.Forms.Label lblApellidoJugadores;
        private System.Windows.Forms.Label lblNombreJugadores;
        private System.Windows.Forms.TextBox txtNombreJugadores;
        private System.Windows.Forms.Label lblPosicionJugadores;
        private System.Windows.Forms.TextBox txtPosicionJugadores;
    }
}