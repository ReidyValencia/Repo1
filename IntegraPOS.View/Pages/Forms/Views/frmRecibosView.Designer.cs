namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmRecibosView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibosView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mtxtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlnkEliminar = new MetroFramework.Controls.MetroLink();
            this.mlblEliminar = new MetroFramework.Controls.MetroLabel();
            this.mlblModificar = new MetroFramework.Controls.MetroLabel();
            this.mlnkModificar = new MetroFramework.Controls.MetroLink();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.mlblNuevo = new MetroFramework.Controls.MetroLabel();
            this.mlnkNuevo = new MetroFramework.Controls.MetroLink();
            this.mgvRecibos = new MetroFramework.Controls.MetroGrid();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoMndLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink2.BackgroundImage")));
            this.metroLink2.Location = new System.Drawing.Point(448, 110);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(48, 48);
            this.metroLink2.TabIndex = 78;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.Location = new System.Drawing.Point(390, 110);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(48, 48);
            this.metroLink1.TabIndex = 77;
            this.metroLink1.UseSelectable = true;
            // 
            // mtxtBuscar
            // 
            // 
            // 
            // 
            this.mtxtBuscar.CustomButton.Image = null;
            this.mtxtBuscar.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.mtxtBuscar.CustomButton.Name = "";
            this.mtxtBuscar.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscar.CustomButton.TabIndex = 1;
            this.mtxtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscar.CustomButton.UseSelectable = true;
            this.mtxtBuscar.CustomButton.Visible = false;
            this.mtxtBuscar.Lines = new string[0];
            this.mtxtBuscar.Location = new System.Drawing.Point(52, 123);
            this.mtxtBuscar.MaxLength = 32767;
            this.mtxtBuscar.Name = "mtxtBuscar";
            this.mtxtBuscar.PasswordChar = '\0';
            this.mtxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscar.SelectedText = "";
            this.mtxtBuscar.SelectionLength = 0;
            this.mtxtBuscar.SelectionStart = 0;
            this.mtxtBuscar.ShortcutsEnabled = true;
            this.mtxtBuscar.Size = new System.Drawing.Size(300, 35);
            this.mtxtBuscar.TabIndex = 76;
            this.mtxtBuscar.UseSelectable = true;
            this.mtxtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.metroTile1.Location = new System.Drawing.Point(10, 64);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1260, 5);
            this.metroTile1.TabIndex = 75;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mlnkEliminar
            // 
            this.mlnkEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkEliminar.BackgroundImage")));
            this.mlnkEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkEliminar.Location = new System.Drawing.Point(390, 9);
            this.mlnkEliminar.Name = "mlnkEliminar";
            this.mlnkEliminar.Size = new System.Drawing.Size(48, 48);
            this.mlnkEliminar.TabIndex = 74;
            this.mlnkEliminar.UseSelectable = true;
            // 
            // mlblEliminar
            // 
            this.mlblEliminar.Location = new System.Drawing.Point(444, 22);
            this.mlblEliminar.Name = "mlblEliminar";
            this.mlblEliminar.Size = new System.Drawing.Size(158, 35);
            this.mlblEliminar.TabIndex = 71;
            this.mlblEliminar.Text = "Eliminar";
            this.mlblEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlblModificar
            // 
            this.mlblModificar.Location = new System.Drawing.Point(258, 22);
            this.mlblModificar.Name = "mlblModificar";
            this.mlblModificar.Size = new System.Drawing.Size(120, 35);
            this.mlblModificar.TabIndex = 72;
            this.mlblModificar.Text = "Modificar";
            this.mlblModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkModificar
            // 
            this.mlnkModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkModificar.BackgroundImage")));
            this.mlnkModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkModificar.Location = new System.Drawing.Point(204, 9);
            this.mlnkModificar.Name = "mlnkModificar";
            this.mlnkModificar.Size = new System.Drawing.Size(48, 48);
            this.mlnkModificar.TabIndex = 73;
            this.mlnkModificar.UseSelectable = true;
            this.mlnkModificar.Click += new System.EventHandler(this.mlnkModificar_Click);
            // 
            // mlblVolver
            // 
            this.mlblVolver.Location = new System.Drawing.Point(1146, 22);
            this.mlblVolver.Name = "mlblVolver";
            this.mlblVolver.Size = new System.Drawing.Size(120, 35);
            this.mlblVolver.TabIndex = 69;
            this.mlblVolver.Text = "Volver";
            this.mlblVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkVolver
            // 
            this.mlnkVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkVolver.BackgroundImage")));
            this.mlnkVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkVolver.Location = new System.Drawing.Point(1091, 9);
            this.mlnkVolver.Name = "mlnkVolver";
            this.mlnkVolver.Size = new System.Drawing.Size(48, 48);
            this.mlnkVolver.TabIndex = 70;
            this.mlnkVolver.UseSelectable = true;
            this.mlnkVolver.Click += new System.EventHandler(this.mlnkVolver_Click);
            // 
            // mlblNuevo
            // 
            this.mlblNuevo.Location = new System.Drawing.Point(78, 22);
            this.mlblNuevo.Name = "mlblNuevo";
            this.mlblNuevo.Size = new System.Drawing.Size(120, 35);
            this.mlblNuevo.TabIndex = 67;
            this.mlblNuevo.Text = "Nuevo";
            this.mlblNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkNuevo
            // 
            this.mlnkNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkNuevo.BackgroundImage")));
            this.mlnkNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkNuevo.Location = new System.Drawing.Point(24, 9);
            this.mlnkNuevo.Name = "mlnkNuevo";
            this.mlnkNuevo.Size = new System.Drawing.Size(48, 48);
            this.mlnkNuevo.TabIndex = 68;
            this.mlnkNuevo.UseSelectable = true;
            this.mlnkNuevo.Click += new System.EventHandler(this.mlnkNuevo_Click);
            // 
            // mgvRecibos
            // 
            this.mgvRecibos.AllowUserToAddRows = false;
            this.mgvRecibos.AllowUserToResizeRows = false;
            this.mgvRecibos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvRecibos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvRecibos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvRecibos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sucursal,
            this.Documento,
            this.FechaDocumento,
            this.Cliente,
            this.Moneda,
            this.Tasa,
            this.MontoMndLocal,
            this.Estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvRecibos.DefaultCellStyle = dataGridViewCellStyle6;
            this.mgvRecibos.EnableHeadersVisualStyles = false;
            this.mgvRecibos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvRecibos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvRecibos.Location = new System.Drawing.Point(10, 180);
            this.mgvRecibos.Name = "mgvRecibos";
            this.mgvRecibos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvRecibos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgvRecibos.RowHeadersVisible = false;
            this.mgvRecibos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvRecibos.Size = new System.Drawing.Size(1260, 578);
            this.mgvRecibos.TabIndex = 81;
            this.mgvRecibos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mgvRecibos_KeyDown);
            // 
            // Sucursal
            // 
            this.Sucursal.DataPropertyName = "Sucursal";
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 200;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "# Doc.";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 160;
            // 
            // FechaDocumento
            // 
            this.FechaDocumento.DataPropertyName = "FechaDocumento";
            this.FechaDocumento.HeaderText = "Fec. Doc.";
            this.FechaDocumento.Name = "FechaDocumento";
            this.FechaDocumento.ReadOnly = true;
            this.FechaDocumento.Width = 140;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 260;
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "Moneda";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Moneda.DefaultCellStyle = dataGridViewCellStyle2;
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Tasa
            // 
            this.Tasa.DataPropertyName = "Tasa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Tasa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tasa.HeaderText = "Tasa";
            this.Tasa.Name = "Tasa";
            this.Tasa.ReadOnly = true;
            this.Tasa.Width = 83;
            // 
            // MontoMndLocal
            // 
            this.MontoMndLocal.DataPropertyName = "MontoMndLocal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MontoMndLocal.DefaultCellStyle = dataGridViewCellStyle4;
            this.MontoMndLocal.HeaderText = "Monto Mnd Local";
            this.MontoMndLocal.Name = "MontoMndLocal";
            this.MontoMndLocal.ReadOnly = true;
            this.MontoMndLocal.Width = 200;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(540, 70);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(200, 44);
            this.mlblTitulo.TabIndex = 87;
            this.mlblTitulo.Text = "Recibos";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRecibosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.mgvRecibos);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.mtxtBuscar);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlnkEliminar);
            this.Controls.Add(this.mlblEliminar);
            this.Controls.Add(this.mlblModificar);
            this.Controls.Add(this.mlnkModificar);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Controls.Add(this.mlblNuevo);
            this.Controls.Add(this.mlnkNuevo);
            this.Name = "frmRecibosView";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmRecibosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvRecibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox mtxtBuscar;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink mlnkEliminar;
        private MetroFramework.Controls.MetroLabel mlblEliminar;
        private MetroFramework.Controls.MetroLabel mlblModificar;
        private MetroFramework.Controls.MetroLink mlnkModificar;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroLabel mlblNuevo;
        private MetroFramework.Controls.MetroLink mlnkNuevo;
        private MetroFramework.Controls.MetroGrid mgvRecibos;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMndLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
