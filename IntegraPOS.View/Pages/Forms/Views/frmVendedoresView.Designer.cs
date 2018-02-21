namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmVendedoresView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedoresView));
            this.mgvVendedores = new MetroFramework.Controls.MetroGrid();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // mgvVendedores
            // 
            this.mgvVendedores.AllowUserToAddRows = false;
            this.mgvVendedores.AllowUserToDeleteRows = false;
            this.mgvVendedores.AllowUserToResizeRows = false;
            this.mgvVendedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvVendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Correo,
            this.TipoVendedor,
            this.Estado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvVendedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.mgvVendedores.EnableHeadersVisualStyles = false;
            this.mgvVendedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvVendedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvVendedores.Location = new System.Drawing.Point(10, 181);
            this.mgvVendedores.Name = "mgvVendedores";
            this.mgvVendedores.ReadOnly = true;
            this.mgvVendedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mgvVendedores.RowHeadersVisible = false;
            this.mgvVendedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvVendedores.Size = new System.Drawing.Size(1260, 578);
            this.mgvVendedores.TabIndex = 79;
            this.mgvVendedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mgvVendedores_KeyDown);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 430;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo Electrónico";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 430;
            // 
            // TipoVendedor
            // 
            this.TipoVendedor.DataPropertyName = "TipoVendedor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoVendedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.TipoVendedor.HeaderText = "Tipo Vendedor";
            this.TipoVendedor.Name = "TipoVendedor";
            this.TipoVendedor.ReadOnly = true;
            this.TipoVendedor.Width = 200;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 200;
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
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(540, 70);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(200, 44);
            this.mlblTitulo.TabIndex = 89;
            this.mlblTitulo.Text = "Vendedores";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVendedoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.mgvVendedores);
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
            this.Name = "frmVendedoresView";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmVendedoresView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgvVendedores;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
    }
}
