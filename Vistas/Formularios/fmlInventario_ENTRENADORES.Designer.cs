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
            this.components = new System.ComponentModel.Container();
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
            this.administracion_deportivaDataSet4 = new Vistas.Administracion_deportivaDataSet4();
            this.articulosInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulosInventarioTableAdapter = new Vistas.Administracion_deportivaDataSet4TableAdapters.ArticulosInventarioTableAdapter();
            this.nombredelarticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeIntegracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodeEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadObjeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pnlBarraTitulo_inventario.SuspendLayout();
            this.pnlMenu_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracion_deportivaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActObjeto
            // 
            this.btnActObjeto.BackColor = System.Drawing.Color.Teal;
            this.btnActObjeto.FlatAppearance.BorderSize = 0;
            this.btnActObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActObjeto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActObjeto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActObjeto.Location = new System.Drawing.Point(905, 130);
            this.btnActObjeto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActObjeto.Name = "btnActObjeto";
            this.btnActObjeto.Size = new System.Drawing.Size(205, 66);
            this.btnActObjeto.TabIndex = 58;
            this.btnActObjeto.Text = "Actualizar Objeto";
            this.btnActObjeto.UseVisualStyleBackColor = false;
            this.btnActObjeto.Click += new System.EventHandler(this.btnActObjeto_Click);
            // 
            // numericUpDownCantidadObjeto
            // 
            this.numericUpDownCantidadObjeto.Location = new System.Drawing.Point(329, 277);
            this.numericUpDownCantidadObjeto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCantidadObjeto.Name = "numericUpDownCantidadObjeto";
            this.numericUpDownCantidadObjeto.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownCantidadObjeto.TabIndex = 57;
            this.numericUpDownCantidadObjeto.ValueChanged += new System.EventHandler(this.numericUpDownCantidadObjeto_ValueChanged);
            // 
            // monthCalendarObjeto
            // 
            this.monthCalendarObjeto.Location = new System.Drawing.Point(808, 210);
            this.monthCalendarObjeto.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarObjeto.Name = "monthCalendarObjeto";
            this.monthCalendarObjeto.TabIndex = 56;
            this.monthCalendarObjeto.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarObjeto_DateChanged);
            // 
            // cbxEstadoObjeto
            // 
            this.cbxEstadoObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoObjeto.FormattingEnabled = true;
            this.cbxEstadoObjeto.Location = new System.Drawing.Point(329, 326);
            this.cbxEstadoObjeto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstadoObjeto.Name = "cbxEstadoObjeto";
            this.cbxEstadoObjeto.Size = new System.Drawing.Size(160, 24);
            this.cbxEstadoObjeto.TabIndex = 55;
            this.cbxEstadoObjeto.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoObjeto_SelectedIndexChanged);
            // 
            // lblEstadoInventario
            // 
            this.lblEstadoInventario.AutoSize = true;
            this.lblEstadoInventario.Location = new System.Drawing.Point(213, 321);
            this.lblEstadoInventario.Name = "lblEstadoInventario";
            this.lblEstadoInventario.Size = new System.Drawing.Size(50, 16);
            this.lblEstadoInventario.TabIndex = 54;
            this.lblEstadoInventario.Text = "Estado";
            this.lblEstadoInventario.Click += new System.EventHandler(this.lblEstadoInventario_Click);
            // 
            // lblFechaInventario
            // 
            this.lblFechaInventario.AutoSize = true;
            this.lblFechaInventario.Location = new System.Drawing.Point(675, 233);
            this.lblFechaInventario.Name = "lblFechaInventario";
            this.lblFechaInventario.Size = new System.Drawing.Size(112, 16);
            this.lblFechaInventario.TabIndex = 53;
            this.lblFechaInventario.Text = "Fecha de registro";
            this.lblFechaInventario.Click += new System.EventHandler(this.lblFechaInventario_Click);
            // 
            // lblCantidadInventario
            // 
            this.lblCantidadInventario.AutoSize = true;
            this.lblCantidadInventario.Location = new System.Drawing.Point(213, 274);
            this.lblCantidadInventario.Name = "lblCantidadInventario";
            this.lblCantidadInventario.Size = new System.Drawing.Size(61, 16);
            this.lblCantidadInventario.TabIndex = 52;
            this.lblCantidadInventario.Text = "Cantidad";
            this.lblCantidadInventario.Click += new System.EventHandler(this.lblCantidadInventario_Click);
            // 
            // lblNombreObjeto
            // 
            this.lblNombreObjeto.AutoSize = true;
            this.lblNombreObjeto.Location = new System.Drawing.Point(216, 228);
            this.lblNombreObjeto.Name = "lblNombreObjeto";
            this.lblNombreObjeto.Size = new System.Drawing.Size(47, 16);
            this.lblNombreObjeto.TabIndex = 51;
            this.lblNombreObjeto.Text = "Objeto";
            this.lblNombreObjeto.Click += new System.EventHandler(this.lblNombreObjeto_Click);
            // 
            // txtHerramientaInventario
            // 
            this.txtHerramientaInventario.Location = new System.Drawing.Point(329, 224);
            this.txtHerramientaInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHerramientaInventario.Name = "txtHerramientaInventario";
            this.txtHerramientaInventario.Size = new System.Drawing.Size(296, 22);
            this.txtHerramientaInventario.TabIndex = 50;
            this.txtHerramientaInventario.TextChanged += new System.EventHandler(this.txtHerramientaInventario_TextChanged);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoGenerateColumns = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombredelarticuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechadeIntegracionDataGridViewTextBoxColumn,
            this.tipodeEstadoDataGridViewTextBoxColumn});
            this.dgvInventario.DataSource = this.articulosInventarioBindingSource;
            this.dgvInventario.Location = new System.Drawing.Point(216, 430);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(897, 292);
            this.dgvInventario.TabIndex = 48;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // pnlBarraTitulo_inventario
            // 
            this.pnlBarraTitulo_inventario.BackgroundImage = global::Vistas.Properties.Resources.green;
            this.pnlBarraTitulo_inventario.Controls.Add(this.lblinventario);
            this.pnlBarraTitulo_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo_inventario.Location = new System.Drawing.Point(181, 0);
            this.pnlBarraTitulo_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo_inventario.Name = "pnlBarraTitulo_inventario";
            this.pnlBarraTitulo_inventario.Size = new System.Drawing.Size(979, 114);
            this.pnlBarraTitulo_inventario.TabIndex = 46;
            this.pnlBarraTitulo_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_inventario_Paint);
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
            this.pnlMenu_inventario.Controls.Add(this.btnJugadores_inventario);
            this.pnlMenu_inventario.Controls.Add(this.picBoxUser_inventario);
            this.pnlMenu_inventario.Controls.Add(this.btnInventario_inventario);
            this.pnlMenu_inventario.Controls.Add(this.pnlLogo_inventario);
            this.pnlMenu_inventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu_inventario.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu_inventario.Name = "pnlMenu_inventario";
            this.pnlMenu_inventario.Size = new System.Drawing.Size(181, 786);
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
            this.btnPartidos_inventario.Location = new System.Drawing.Point(5, 401);
            this.btnPartidos_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartidos_inventario.Name = "btnPartidos_inventario";
            this.btnPartidos_inventario.Size = new System.Drawing.Size(176, 113);
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
            this.btnJugadores_inventario.Location = new System.Drawing.Point(5, 262);
            this.btnJugadores_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJugadores_inventario.Name = "btnJugadores_inventario";
            this.btnJugadores_inventario.Size = new System.Drawing.Size(176, 122);
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
            this.picBoxUser_inventario.Location = new System.Drawing.Point(56, 530);
            this.picBoxUser_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxUser_inventario.Name = "picBoxUser_inventario";
            this.picBoxUser_inventario.Size = new System.Drawing.Size(75, 70);
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
            this.btnInventario_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario_inventario.Name = "btnInventario_inventario";
            this.btnInventario_inventario.Size = new System.Drawing.Size(189, 144);
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
            this.pnlLogo_inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo_inventario.Name = "pnlLogo_inventario";
            this.pnlLogo_inventario.Size = new System.Drawing.Size(181, 114);
            this.pnlLogo_inventario.TabIndex = 0;
            this.pnlLogo_inventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogo_inventario_Paint);
            // 
            // administracion_deportivaDataSet4
            // 
            this.administracion_deportivaDataSet4.DataSetName = "Administracion_deportivaDataSet4";
            this.administracion_deportivaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulosInventarioBindingSource
            // 
            this.articulosInventarioBindingSource.DataMember = "ArticulosInventario";
            this.articulosInventarioBindingSource.DataSource = this.administracion_deportivaDataSet4;
            // 
            // articulosInventarioTableAdapter
            // 
            this.articulosInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // nombredelarticuloDataGridViewTextBoxColumn
            // 
            this.nombredelarticuloDataGridViewTextBoxColumn.DataPropertyName = "Nombre_del_articulo";
            this.nombredelarticuloDataGridViewTextBoxColumn.HeaderText = "Nombre_del_articulo";
            this.nombredelarticuloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombredelarticuloDataGridViewTextBoxColumn.Name = "nombredelarticuloDataGridViewTextBoxColumn";
            this.nombredelarticuloDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechadeIntegracionDataGridViewTextBoxColumn
            // 
            this.fechadeIntegracionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_de_Integracion";
            this.fechadeIntegracionDataGridViewTextBoxColumn.HeaderText = "Fecha_de_Integracion";
            this.fechadeIntegracionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechadeIntegracionDataGridViewTextBoxColumn.Name = "fechadeIntegracionDataGridViewTextBoxColumn";
            this.fechadeIntegracionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipodeEstadoDataGridViewTextBoxColumn
            // 
            this.tipodeEstadoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_de_Estado";
            this.tipodeEstadoDataGridViewTextBoxColumn.HeaderText = "Tipo_de_Estado";
            this.tipodeEstadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipodeEstadoDataGridViewTextBoxColumn.Name = "tipodeEstadoDataGridViewTextBoxColumn";
            this.tipodeEstadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fmlInventario_ENTRENADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 786);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmlInventario_ENTRENADORES";
            this.Text = "fmlInventario_ENTRENADORES";
            this.Load += new System.EventHandler(this.fmlInventario_ENTRENADORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadObjeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlBarraTitulo_inventario.ResumeLayout(false);
            this.pnlBarraTitulo_inventario.PerformLayout();
            this.pnlMenu_inventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administracion_deportivaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosInventarioBindingSource)).EndInit();
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
        private Administracion_deportivaDataSet4 administracion_deportivaDataSet4;
        private System.Windows.Forms.BindingSource articulosInventarioBindingSource;
        private Administracion_deportivaDataSet4TableAdapters.ArticulosInventarioTableAdapter articulosInventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelarticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeIntegracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodeEstadoDataGridViewTextBoxColumn;
    }
}