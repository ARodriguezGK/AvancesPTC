namespace Vistas.Formularios
{
    partial class fmlinventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlinventario));
            this.pnlBarraTitulo_inventario = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblinventario = new System.Windows.Forms.Label();
            this.pnlMenu_inventario = new System.Windows.Forms.Panel();
            this.btnPartidos_inventario = new System.Windows.Forms.Button();
            this.btnGestion_inventario = new System.Windows.Forms.Button();
            this.btnJugadores_inventario = new System.Windows.Forms.Button();
            this.picBoxUser_inventario = new System.Windows.Forms.PictureBox();
            this.btnInventario_inventario = new System.Windows.Forms.Button();
            this.pnlLogo_inventario = new System.Windows.Forms.Panel();
            this.btnAñaObjeto = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnQuitarObje = new System.Windows.Forms.Button();
            this.txtFechaInventario = new System.Windows.Forms.TextBox();
            this.txtEstadoInventario = new System.Windows.Forms.TextBox();
            this.txtCantidadInventario = new System.Windows.Forms.TextBox();
            this.lblEstadoInventario = new System.Windows.Forms.Label();
            this.lblFechaInventario = new System.Windows.Forms.Label();
            this.lblCantidadInventario = new System.Windows.Forms.Label();
            this.lblNombreInventario = new System.Windows.Forms.Label();
            this.txtHerramientaInventario = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo_inventario.SuspendLayout();
            this.pnlMenu_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo_inventario
            // 
            this.pnlBarraTitulo_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo_inventario.Controls.Add(this.lblAdmin);
            this.pnlBarraTitulo_inventario.Controls.Add(this.lblinventario);
            this.pnlBarraTitulo_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo_inventario.Location = new System.Drawing.Point(182, 0);
            this.pnlBarraTitulo_inventario.Name = "pnlBarraTitulo_inventario";
            this.pnlBarraTitulo_inventario.Size = new System.Drawing.Size(975, 115);
            this.pnlBarraTitulo_inventario.TabIndex = 4;
            this.pnlBarraTitulo_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_inventario_Paint);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Green;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdmin.Location = new System.Drawing.Point(871, 43);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 27);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin";
            // 
            // lblinventario
            // 
            this.lblinventario.AutoSize = true;
            this.lblinventario.BackColor = System.Drawing.Color.Green;
            this.lblinventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinventario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblinventario.Location = new System.Drawing.Point(37, 43);
            this.lblinventario.Name = "lblinventario";
            this.lblinventario.Size = new System.Drawing.Size(250, 27);
            this.lblinventario.TabIndex = 0;
            this.lblinventario.Text = "Gestion de inventario";
            this.lblinventario.Click += new System.EventHandler(this.lblinventario_Click);
            // 
            // pnlMenu_inventario
            // 
            this.pnlMenu_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlMenu_inventario.Controls.Add(this.btnPartidos_inventario);
            this.pnlMenu_inventario.Controls.Add(this.btnGestion_inventario);
            this.pnlMenu_inventario.Controls.Add(this.btnJugadores_inventario);
            this.pnlMenu_inventario.Controls.Add(this.picBoxUser_inventario);
            this.pnlMenu_inventario.Controls.Add(this.btnInventario_inventario);
            this.pnlMenu_inventario.Controls.Add(this.pnlLogo_inventario);
            this.pnlMenu_inventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu_inventario.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu_inventario.Name = "pnlMenu_inventario";
            this.pnlMenu_inventario.Size = new System.Drawing.Size(182, 793);
            this.pnlMenu_inventario.TabIndex = 3;
            this.pnlMenu_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_inventario_Paint);
            // 
            // btnPartidos_inventario
            // 
            this.btnPartidos_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnPartidos_inventario.FlatAppearance.BorderSize = 0;
            this.btnPartidos_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPartidos_inventario.Location = new System.Drawing.Point(6, 423);
            this.btnPartidos_inventario.Name = "btnPartidos_inventario";
            this.btnPartidos_inventario.Size = new System.Drawing.Size(176, 91);
            this.btnPartidos_inventario.TabIndex = 8;
            this.btnPartidos_inventario.Text = "Partidos";
            this.btnPartidos_inventario.UseVisualStyleBackColor = true;
            this.btnPartidos_inventario.Click += new System.EventHandler(this.btnPartidos_inventario_Click);
            // 
            // btnGestion_inventario
            // 
            this.btnGestion_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnGestion_inventario.FlatAppearance.BorderSize = 0;
            this.btnGestion_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGestion_inventario.Location = new System.Drawing.Point(6, 326);
            this.btnGestion_inventario.Name = "btnGestion_inventario";
            this.btnGestion_inventario.Size = new System.Drawing.Size(176, 91);
            this.btnGestion_inventario.TabIndex = 7;
            this.btnGestion_inventario.Text = "Gestion";
            this.btnGestion_inventario.UseVisualStyleBackColor = true;
            this.btnGestion_inventario.Click += new System.EventHandler(this.btnGestion_inventario_Click);
            // 
            // btnJugadores_inventario
            // 
            this.btnJugadores_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnJugadores_inventario.FlatAppearance.BorderSize = 0;
            this.btnJugadores_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJugadores_inventario.Location = new System.Drawing.Point(6, 218);
            this.btnJugadores_inventario.Name = "btnJugadores_inventario";
            this.btnJugadores_inventario.Size = new System.Drawing.Size(176, 91);
            this.btnJugadores_inventario.TabIndex = 6;
            this.btnJugadores_inventario.Text = "Jugadores";
            this.btnJugadores_inventario.UseVisualStyleBackColor = true;
            this.btnJugadores_inventario.Click += new System.EventHandler(this.btnJugadores_inventario_Click);
            // 
            // picBoxUser_inventario
            // 
            this.picBoxUser_inventario.BackColor = System.Drawing.SystemColors.MenuText;
            this.picBoxUser_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.picBoxUser_inventario.Image = global::Vistas.Properties.Resources.user;
            this.picBoxUser_inventario.Location = new System.Drawing.Point(57, 533);
            this.picBoxUser_inventario.Name = "picBoxUser_inventario";
            this.picBoxUser_inventario.Size = new System.Drawing.Size(74, 70);
            this.picBoxUser_inventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser_inventario.TabIndex = 5;
            this.picBoxUser_inventario.TabStop = false;
            this.picBoxUser_inventario.Click += new System.EventHandler(this.picBoxUser_inventario_Click);
            // 
            // btnInventario_inventario
            // 
            this.btnInventario_inventario.FlatAppearance.BorderSize = 0;
            this.btnInventario_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario_inventario.ForeColor = System.Drawing.Color.Green;
            this.btnInventario_inventario.Location = new System.Drawing.Point(0, 113);
            this.btnInventario_inventario.Name = "btnInventario_inventario";
            this.btnInventario_inventario.Size = new System.Drawing.Size(182, 99);
            this.btnInventario_inventario.TabIndex = 1;
            this.btnInventario_inventario.Text = "Inventario";
            this.btnInventario_inventario.UseVisualStyleBackColor = true;
            this.btnInventario_inventario.Click += new System.EventHandler(this.btnInventario_inventario_Click);
            // 
            // pnlLogo_inventario
            // 
            this.pnlLogo_inventario.BackgroundImage = global::Vistas.Properties.Resources.logo;
            this.pnlLogo_inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo_inventario.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo_inventario.Name = "pnlLogo_inventario";
            this.pnlLogo_inventario.Size = new System.Drawing.Size(182, 115);
            this.pnlLogo_inventario.TabIndex = 0;
            this.pnlLogo_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_inventario_Paint);
            // 
            // btnAñaObjeto
            // 
            this.btnAñaObjeto.BackColor = System.Drawing.Color.Green;
            this.btnAñaObjeto.FlatAppearance.BorderSize = 0;
            this.btnAñaObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñaObjeto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñaObjeto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñaObjeto.Location = new System.Drawing.Point(930, 131);
            this.btnAñaObjeto.Name = "btnAñaObjeto";
            this.btnAñaObjeto.Size = new System.Drawing.Size(206, 66);
            this.btnAñaObjeto.TabIndex = 5;
            this.btnAñaObjeto.Text = "+ Añadir Objeto";
            this.btnAñaObjeto.UseVisualStyleBackColor = false;
            this.btnAñaObjeto.Click += new System.EventHandler(this.btnAñaObjeto_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(224, 388);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(879, 292);
            this.dgvInventario.TabIndex = 6;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnQuitarObje
            // 
            this.btnQuitarObje.BackColor = System.Drawing.Color.Crimson;
            this.btnQuitarObje.FlatAppearance.BorderSize = 0;
            this.btnQuitarObje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarObje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarObje.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitarObje.Location = new System.Drawing.Point(939, 715);
            this.btnQuitarObje.Name = "btnQuitarObje";
            this.btnQuitarObje.Size = new System.Drawing.Size(206, 66);
            this.btnQuitarObje.TabIndex = 7;
            this.btnQuitarObje.Text = "- Quitar Objeto";
            this.btnQuitarObje.UseVisualStyleBackColor = false;
            this.btnQuitarObje.Click += new System.EventHandler(this.btnQuitarObje_Click);
            // 
            // txtFechaInventario
            // 
            this.txtFechaInventario.Location = new System.Drawing.Point(792, 277);
            this.txtFechaInventario.Name = "txtFechaInventario";
            this.txtFechaInventario.Size = new System.Drawing.Size(296, 22);
            this.txtFechaInventario.TabIndex = 43;
            this.txtFechaInventario.TextChanged += new System.EventHandler(this.txtFechaInventario_TextChanged);
            // 
            // txtEstadoInventario
            // 
            this.txtEstadoInventario.Location = new System.Drawing.Point(329, 321);
            this.txtEstadoInventario.Name = "txtEstadoInventario";
            this.txtEstadoInventario.Size = new System.Drawing.Size(296, 22);
            this.txtEstadoInventario.TabIndex = 42;
            this.txtEstadoInventario.TextChanged += new System.EventHandler(this.txtEstadoInventario_TextChanged);
            // 
            // txtCantidadInventario
            // 
            this.txtCantidadInventario.Location = new System.Drawing.Point(329, 271);
            this.txtCantidadInventario.Name = "txtCantidadInventario";
            this.txtCantidadInventario.Size = new System.Drawing.Size(296, 22);
            this.txtCantidadInventario.TabIndex = 41;
            this.txtCantidadInventario.TextChanged += new System.EventHandler(this.txtCantidadInventario_TextChanged);
            // 
            // lblEstadoInventario
            // 
            this.lblEstadoInventario.AutoSize = true;
            this.lblEstadoInventario.Location = new System.Drawing.Point(214, 321);
            this.lblEstadoInventario.Name = "lblEstadoInventario";
            this.lblEstadoInventario.Size = new System.Drawing.Size(50, 16);
            this.lblEstadoInventario.TabIndex = 39;
            this.lblEstadoInventario.Text = "Estado";
            this.lblEstadoInventario.Click += new System.EventHandler(this.lblEstadoInventario_Click);
            // 
            // lblFechaInventario
            // 
            this.lblFechaInventario.AutoSize = true;
            this.lblFechaInventario.Location = new System.Drawing.Point(674, 277);
            this.lblFechaInventario.Name = "lblFechaInventario";
            this.lblFechaInventario.Size = new System.Drawing.Size(112, 16);
            this.lblFechaInventario.TabIndex = 37;
            this.lblFechaInventario.Text = "Fecha de registro";
            this.lblFechaInventario.Click += new System.EventHandler(this.lblFechaInventario_Click);
            // 
            // lblCantidadInventario
            // 
            this.lblCantidadInventario.AutoSize = true;
            this.lblCantidadInventario.Location = new System.Drawing.Point(214, 274);
            this.lblCantidadInventario.Name = "lblCantidadInventario";
            this.lblCantidadInventario.Size = new System.Drawing.Size(61, 16);
            this.lblCantidadInventario.TabIndex = 36;
            this.lblCantidadInventario.Text = "Cantidad";
            this.lblCantidadInventario.Click += new System.EventHandler(this.lblCantidadInventario_Click);
            // 
            // lblNombreInventario
            // 
            this.lblNombreInventario.AutoSize = true;
            this.lblNombreInventario.Location = new System.Drawing.Point(208, 227);
            this.lblNombreInventario.Name = "lblNombreInventario";
            this.lblNombreInventario.Size = new System.Drawing.Size(81, 16);
            this.lblNombreInventario.TabIndex = 35;
            this.lblNombreInventario.Text = "Herramienta";
            this.lblNombreInventario.Click += new System.EventHandler(this.lblNombreInventario_Click);
            // 
            // txtHerramientaInventario
            // 
            this.txtHerramientaInventario.Location = new System.Drawing.Point(329, 224);
            this.txtHerramientaInventario.Name = "txtHerramientaInventario";
            this.txtHerramientaInventario.Size = new System.Drawing.Size(296, 22);
            this.txtHerramientaInventario.TabIndex = 34;
            this.txtHerramientaInventario.TextChanged += new System.EventHandler(this.txtHerramientaInventario_TextChanged);
            // 
            // fmlinventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 793);
            this.Controls.Add(this.txtFechaInventario);
            this.Controls.Add(this.txtEstadoInventario);
            this.Controls.Add(this.txtCantidadInventario);
            this.Controls.Add(this.lblEstadoInventario);
            this.Controls.Add(this.lblFechaInventario);
            this.Controls.Add(this.lblCantidadInventario);
            this.Controls.Add(this.lblNombreInventario);
            this.Controls.Add(this.txtHerramientaInventario);
            this.Controls.Add(this.btnQuitarObje);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnAñaObjeto);
            this.Controls.Add(this.pnlBarraTitulo_inventario);
            this.Controls.Add(this.pnlMenu_inventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmlinventario";
            this.Text = "fmlinventario";
            this.Load += new System.EventHandler(this.fmlInventario_Load);

            this.pnlBarraTitulo_inventario.ResumeLayout(false);
            this.pnlBarraTitulo_inventario.PerformLayout();
            this.pnlMenu_inventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugadores_inventario;
        private System.Windows.Forms.Panel pnlBarraTitulo_inventario;
        private System.Windows.Forms.Panel pnlMenu_inventario;
        private System.Windows.Forms.Button btnPartidos_inventario;
        private System.Windows.Forms.Button btnGestion_inventario;
        private System.Windows.Forms.PictureBox picBoxUser_inventario;
        private System.Windows.Forms.Button btnInventario_inventario;
        private System.Windows.Forms.Panel pnlLogo_inventario;
        private System.Windows.Forms.Label lblinventario;
        private System.Windows.Forms.Button btnAñaObjeto;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnQuitarObje;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtFechaInventario;
        private System.Windows.Forms.TextBox txtEstadoInventario;
        private System.Windows.Forms.TextBox txtCantidadInventario;
        private System.Windows.Forms.Label lblEstadoInventario;
        private System.Windows.Forms.Label lblFechaInventario;
        private System.Windows.Forms.Label lblCantidadInventario;
        private System.Windows.Forms.Label lblNombreInventario;
        private System.Windows.Forms.TextBox txtHerramientaInventario;
    }
}