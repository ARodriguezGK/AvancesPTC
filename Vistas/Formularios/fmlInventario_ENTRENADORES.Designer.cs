namespace Vistas.Formularios
{
    partial class fmlInventario_ENTRENADORES
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
            this.btnActObjeto = new System.Windows.Forms.Button();
            this.numericUpDownCantidadObjeto = new System.Windows.Forms.NumericUpDown();
            this.monthCalendarObjeto = new System.Windows.Forms.MonthCalendar();
            this.cbxEstadoObjeto = new System.Windows.Forms.ComboBox();
            this.lblEstadoInventario = new System.Windows.Forms.Label();
            this.lblFechaInventario = new System.Windows.Forms.Label();
            this.lblCantidadInventario = new System.Windows.Forms.Label();
            this.lblNombreObjeto = new System.Windows.Forms.Label();
            this.txtHerramientaInventario = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.pnlBarraTitulo_inventario = new System.Windows.Forms.Panel();
            this.lblinventario = new System.Windows.Forms.Label();
            this.pnlMenu_inventario = new System.Windows.Forms.Panel();
            this.btnPartidos_inventario = new System.Windows.Forms.Button();
            this.btnJugadores_inventario = new System.Windows.Forms.Button();
            this.picBoxUser_inventario = new System.Windows.Forms.PictureBox();
            this.btnInventario_inventario = new System.Windows.Forms.Button();
            this.pnlLogo_inventario = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadObjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pnlBarraTitulo_inventario.SuspendLayout();
            this.pnlMenu_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActObjeto
            // 
            this.btnActObjeto.BackColor = System.Drawing.Color.Teal;
            this.btnActObjeto.FlatAppearance.BorderSize = 0;
            this.btnActObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActObjeto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActObjeto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActObjeto.Location = new System.Drawing.Point(679, 106);
            this.btnActObjeto.Margin = new System.Windows.Forms.Padding(2);
            this.btnActObjeto.Name = "btnActObjeto";
            this.btnActObjeto.Size = new System.Drawing.Size(154, 54);
            this.btnActObjeto.TabIndex = 58;
            this.btnActObjeto.Text = "Actualizar Objeto";
            this.btnActObjeto.UseVisualStyleBackColor = false;
            this.btnActObjeto.Click += new System.EventHandler(this.btnActObjeto_Click);
            // 
            // numericUpDownCantidadObjeto
            // 
            this.numericUpDownCantidadObjeto.Location = new System.Drawing.Point(247, 225);
            this.numericUpDownCantidadObjeto.Name = "numericUpDownCantidadObjeto";
            this.numericUpDownCantidadObjeto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidadObjeto.TabIndex = 57;
            this.numericUpDownCantidadObjeto.ValueChanged += new System.EventHandler(this.numericUpDownCantidadObjeto_ValueChanged);
            // 
            // monthCalendarObjeto
            // 
            this.monthCalendarObjeto.Location = new System.Drawing.Point(606, 171);
            this.monthCalendarObjeto.Name = "monthCalendarObjeto";
            this.monthCalendarObjeto.TabIndex = 56;
            this.monthCalendarObjeto.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarObjeto_DateChanged);
            // 
            // cbxEstadoObjeto
            // 
            this.cbxEstadoObjeto.FormattingEnabled = true;
            this.cbxEstadoObjeto.Location = new System.Drawing.Point(247, 265);
            this.cbxEstadoObjeto.Name = "cbxEstadoObjeto";
            this.cbxEstadoObjeto.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoObjeto.TabIndex = 55;
            this.cbxEstadoObjeto.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoObjeto_SelectedIndexChanged);
            // 
            // lblEstadoInventario
            // 
            this.lblEstadoInventario.AutoSize = true;
            this.lblEstadoInventario.Location = new System.Drawing.Point(160, 261);
            this.lblEstadoInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoInventario.Name = "lblEstadoInventario";
            this.lblEstadoInventario.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoInventario.TabIndex = 54;
            this.lblEstadoInventario.Text = "Estado";
            this.lblEstadoInventario.Click += new System.EventHandler(this.lblEstadoInventario_Click);
            // 
            // lblFechaInventario
            // 
            this.lblFechaInventario.AutoSize = true;
            this.lblFechaInventario.Location = new System.Drawing.Point(506, 189);
            this.lblFechaInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaInventario.Name = "lblFechaInventario";
            this.lblFechaInventario.Size = new System.Drawing.Size(89, 13);
            this.lblFechaInventario.TabIndex = 53;
            this.lblFechaInventario.Text = "Fecha de registro";
            this.lblFechaInventario.Click += new System.EventHandler(this.lblFechaInventario_Click);
            // 
            // lblCantidadInventario
            // 
            this.lblCantidadInventario.AutoSize = true;
            this.lblCantidadInventario.Location = new System.Drawing.Point(160, 223);
            this.lblCantidadInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadInventario.Name = "lblCantidadInventario";
            this.lblCantidadInventario.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadInventario.TabIndex = 52;
            this.lblCantidadInventario.Text = "Cantidad";
            this.lblCantidadInventario.Click += new System.EventHandler(this.lblCantidadInventario_Click);
            // 
            // lblNombreObjeto
            // 
            this.lblNombreObjeto.AutoSize = true;
            this.lblNombreObjeto.Location = new System.Drawing.Point(162, 185);
            this.lblNombreObjeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreObjeto.Name = "lblNombreObjeto";
            this.lblNombreObjeto.Size = new System.Drawing.Size(38, 13);
            this.lblNombreObjeto.TabIndex = 51;
            this.lblNombreObjeto.Text = "Objeto";
            this.lblNombreObjeto.Click += new System.EventHandler(this.lblNombreObjeto_Click);
            // 
            // txtHerramientaInventario
            // 
            this.txtHerramientaInventario.Location = new System.Drawing.Point(247, 182);
            this.txtHerramientaInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHerramientaInventario.Name = "txtHerramientaInventario";
            this.txtHerramientaInventario.Size = new System.Drawing.Size(223, 20);
            this.txtHerramientaInventario.TabIndex = 50;
            this.txtHerramientaInventario.TextChanged += new System.EventHandler(this.txtHerramientaInventario_TextChanged);
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(168, 340);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(673, 237);
            this.dgvInventario.TabIndex = 48;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // pnlBarraTitulo_inventario
            // 
            this.pnlBarraTitulo_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo_inventario.Controls.Add(this.lblinventario);
            this.pnlBarraTitulo_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo_inventario.Location = new System.Drawing.Point(136, 0);
            this.pnlBarraTitulo_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo_inventario.Name = "pnlBarraTitulo_inventario";
            this.pnlBarraTitulo_inventario.Size = new System.Drawing.Size(734, 93);
            this.pnlBarraTitulo_inventario.TabIndex = 46;
            this.pnlBarraTitulo_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_inventario_Paint);
            // 
            // lblinventario
            // 
            this.lblinventario.AutoSize = true;
            this.lblinventario.BackColor = System.Drawing.Color.Green;
            this.lblinventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinventario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblinventario.Location = new System.Drawing.Point(28, 35);
            this.lblinventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinventario.Name = "lblinventario";
            this.lblinventario.Size = new System.Drawing.Size(203, 22);
            this.lblinventario.TabIndex = 0;
            this.lblinventario.Text = "Gestion de inventario";
            this.lblinventario.Click += new System.EventHandler(this.lblinventario_Click);
            // 
            // pnlMenu_inventario
            // 
            this.pnlMenu_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlMenu_inventario.Controls.Add(this.btnPartidos_inventario);
            this.pnlMenu_inventario.Controls.Add(this.btnJugadores_inventario);
            this.pnlMenu_inventario.Controls.Add(this.picBoxUser_inventario);
            this.pnlMenu_inventario.Controls.Add(this.btnInventario_inventario);
            this.pnlMenu_inventario.Controls.Add(this.pnlLogo_inventario);
            this.pnlMenu_inventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu_inventario.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu_inventario.Name = "pnlMenu_inventario";
            this.pnlMenu_inventario.Size = new System.Drawing.Size(136, 639);
            this.pnlMenu_inventario.TabIndex = 45;
            this.pnlMenu_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_inventario_Paint);
            // 
            // btnPartidos_inventario
            // 
            this.btnPartidos_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnPartidos_inventario.FlatAppearance.BorderSize = 0;
            this.btnPartidos_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPartidos_inventario.Location = new System.Drawing.Point(4, 326);
            this.btnPartidos_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartidos_inventario.Name = "btnPartidos_inventario";
            this.btnPartidos_inventario.Size = new System.Drawing.Size(132, 92);
            this.btnPartidos_inventario.TabIndex = 8;
            this.btnPartidos_inventario.Text = "Partidos";
            this.btnPartidos_inventario.UseVisualStyleBackColor = true;
            this.btnPartidos_inventario.Click += new System.EventHandler(this.btnPartidos_inventario_Click);
            // 
            // btnJugadores_inventario
            // 
            this.btnJugadores_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.btnJugadores_inventario.FlatAppearance.BorderSize = 0;
            this.btnJugadores_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores_inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores_inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJugadores_inventario.Location = new System.Drawing.Point(4, 213);
            this.btnJugadores_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnJugadores_inventario.Name = "btnJugadores_inventario";
            this.btnJugadores_inventario.Size = new System.Drawing.Size(132, 99);
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
            this.picBoxUser_inventario.Location = new System.Drawing.Point(42, 431);
            this.picBoxUser_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxUser_inventario.Name = "picBoxUser_inventario";
            this.picBoxUser_inventario.Size = new System.Drawing.Size(56, 57);
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
            this.btnInventario_inventario.Location = new System.Drawing.Point(0, 92);
            this.btnInventario_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventario_inventario.Name = "btnInventario_inventario";
            this.btnInventario_inventario.Size = new System.Drawing.Size(142, 117);
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
            this.pnlLogo_inventario.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo_inventario.Name = "pnlLogo_inventario";
            this.pnlLogo_inventario.Size = new System.Drawing.Size(136, 93);
            this.pnlLogo_inventario.TabIndex = 0;
            this.pnlLogo_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_inventario_Paint);
            // 
            // fmlInventario_ENTRENADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 639);
            this.Controls.Add(this.btnActObjeto);
            this.Controls.Add(this.numericUpDownCantidadObjeto);
            this.Controls.Add(this.monthCalendarObjeto);
            this.Controls.Add(this.cbxEstadoObjeto);
            this.Controls.Add(this.lblEstadoInventario);
            this.Controls.Add(this.lblFechaInventario);
            this.Controls.Add(this.lblCantidadInventario);
            this.Controls.Add(this.lblNombreObjeto);
            this.Controls.Add(this.txtHerramientaInventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pnlBarraTitulo_inventario);
            this.Controls.Add(this.pnlMenu_inventario);
            this.Name = "fmlInventario_ENTRENADORES";
            this.Text = "fmlInventario_ENTRENADORES";
            this.Load += new System.EventHandler(this.fmlInventario_ENTRENADORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadObjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlBarraTitulo_inventario.ResumeLayout(false);
            this.pnlBarraTitulo_inventario.PerformLayout();
            this.pnlMenu_inventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidos_inventario;
        private System.Windows.Forms.Button btnJugadores_inventario;
        private System.Windows.Forms.PictureBox picBoxUser_inventario;
        private System.Windows.Forms.Panel pnlLogo_inventario;
        private System.Windows.Forms.Label lblinventario;
        private System.Windows.Forms.Button btnInventario_inventario;
        private System.Windows.Forms.Button btnActObjeto;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidadObjeto;
        private System.Windows.Forms.MonthCalendar monthCalendarObjeto;
        private System.Windows.Forms.ComboBox cbxEstadoObjeto;
        private System.Windows.Forms.Label lblEstadoInventario;
        private System.Windows.Forms.Label lblFechaInventario;
        private System.Windows.Forms.Label lblCantidadInventario;
        private System.Windows.Forms.Label lblNombreObjeto;
        private System.Windows.Forms.TextBox txtHerramientaInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel pnlBarraTitulo_inventario;
        private System.Windows.Forms.Panel pnlMenu_inventario;
    }
}