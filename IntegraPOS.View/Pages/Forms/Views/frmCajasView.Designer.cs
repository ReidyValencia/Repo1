namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmCajasView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajasView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefrescarBusqueda = new MetroFramework.Controls.MetroLink();
            this.btnBuscarCaja = new MetroFramework.Controls.MetroLink();
            this.mtxtBuscarGeneral = new MetroFramework.Controls.MetroTextBox();
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
            this.txtBuscarCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.mgvCajas = new MetroFramework.Controls.MetroGrid();
            this.cajChrCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mgvCajas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescarBusqueda
            // 
            this.btnRefrescarBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefrescarBusqueda.BackgroundImage")));
            this.btnRefrescarBusqueda.Location = new System.Drawing.Point(586, 117);
            this.btnRefrescarBusqueda.Name = "btnRefrescarBusqueda";
            this.btnRefrescarBusqueda.Size = new System.Drawing.Size(48, 48);
            this.btnRefrescarBusqueda.TabIndex = 78;
            this.btnRefrescarBusqueda.UseSelectable = true;
            this.btnRefrescarBusqueda.Click += new System.EventHandler(this.btnRefrescarBusqueda_Click);
            // 
            // btnBuscarCaja
            // 
            this.btnBuscarCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCaja.BackgroundImage")));
            this.btnBuscarCaja.Location = new System.Drawing.Point(528, 117);
            this.btnBuscarCaja.Name = "btnBuscarCaja";
            this.btnBuscarCaja.Size = new System.Drawing.Size(48, 48);
            this.btnBuscarCaja.TabIndex = 77;
            this.btnBuscarCaja.UseSelectable = true;
            this.btnBuscarCaja.Click += new System.EventHandler(this.btnBuscarCaja_Click);
            // 
            // mtxtBuscarGeneral
            // 
            // 
            // 
            // 
            this.mtxtBuscarGeneral.CustomButton.Image = null;
            this.mtxtBuscarGeneral.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.mtxtBuscarGeneral.CustomButton.Name = "";
            this.mtxtBuscarGeneral.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscarGeneral.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscarGeneral.CustomButton.TabIndex = 1;
            this.mtxtBuscarGeneral.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscarGeneral.CustomButton.UseSelectable = true;
            this.mtxtBuscarGeneral.CustomButton.Visible = false;
            this.mtxtBuscarGeneral.Lines = new string[0];
            this.mtxtBuscarGeneral.Location = new System.Drawing.Point(222, 123);
            this.mtxtBuscarGeneral.MaxLength = 32767;
            this.mtxtBuscarGeneral.Name = "mtxtBuscarGeneral";
            this.mtxtBuscarGeneral.PasswordChar = '\0';
            this.mtxtBuscarGeneral.PromptText = "Buscar por Nombre, Sucursal...";
            this.mtxtBuscarGeneral.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscarGeneral.SelectedText = "";
            this.mtxtBuscarGeneral.SelectionLength = 0;
            this.mtxtBuscarGeneral.SelectionStart = 0;
            this.mtxtBuscarGeneral.ShortcutsEnabled = true;
            this.mtxtBuscarGeneral.Size = new System.Drawing.Size(300, 35);
            this.mtxtBuscarGeneral.TabIndex = 76;
            this.mtxtBuscarGeneral.UseSelectable = true;
            this.mtxtBuscarGeneral.WaterMark = "Buscar por Nombre, Sucursal...";
            this.mtxtBuscarGeneral.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscarGeneral.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.mlnkEliminar.Click += new System.EventHandler(this.mlnkEliminar_Click);
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
            this.mlblTitulo.TabIndex = 88;
            this.mlblTitulo.Text = "Cajas";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarCodigo
            // 
            // 
            // 
            // 
            this.txtBuscarCodigo.CustomButton.Image = null;
            this.txtBuscarCodigo.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtBuscarCodigo.CustomButton.Name = "";
            this.txtBuscarCodigo.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtBuscarCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarCodigo.CustomButton.TabIndex = 1;
            this.txtBuscarCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarCodigo.CustomButton.UseSelectable = true;
            this.txtBuscarCodigo.CustomButton.Visible = false;
            this.txtBuscarCodigo.Lines = new string[0];
            this.txtBuscarCodigo.Location = new System.Drawing.Point(55, 123);
            this.txtBuscarCodigo.MaxLength = 32767;
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.PasswordChar = '\0';
            this.txtBuscarCodigo.PromptText = "Buscar por código de caja";
            this.txtBuscarCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarCodigo.SelectedText = "";
            this.txtBuscarCodigo.SelectionLength = 0;
            this.txtBuscarCodigo.SelectionStart = 0;
            this.txtBuscarCodigo.ShortcutsEnabled = true;
            this.txtBuscarCodigo.Size = new System.Drawing.Size(161, 35);
            this.txtBuscarCodigo.TabIndex = 89;
            this.txtBuscarCodigo.UseSelectable = true;
            this.txtBuscarCodigo.WaterMark = "Buscar por código de caja";
            this.txtBuscarCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(739, 459);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 90;
            this.metroUserControl1.UseSelectable = true;
            // 
            // mgvCajas
            // 
            this.mgvCajas.AllowUserToAddRows = false;
            this.mgvCajas.AllowUserToDeleteRows = false;
            this.mgvCajas.AllowUserToResizeRows = false;
            this.mgvCajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvCajas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvCajas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvCajas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cajChrCodigo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvCajas.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvCajas.EnableHeadersVisualStyles = false;
            this.mgvCajas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvCajas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvCajas.Location = new System.Drawing.Point(55, 183);
            this.mgvCajas.Name = "mgvCajas";
            this.mgvCajas.ReadOnly = true;
            this.mgvCajas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvCajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvCajas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvCajas.Size = new System.Drawing.Size(1152, 312);
            this.mgvCajas.TabIndex = 91;
            // 
            // cajChrCodigo
            // 
            this.cajChrCodigo.DataPropertyName = "cajChrCodigo";
            this.cajChrCodigo.HeaderText = "Código";
            this.cajChrCodigo.Name = "cajChrCodigo";
            this.cajChrCodigo.ReadOnly = true;
            // 
            // frmCajasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mgvCajas);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.btnRefrescarBusqueda);
            this.Controls.Add(this.btnBuscarCaja);
            this.Controls.Add(this.mtxtBuscarGeneral);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlnkEliminar);
            this.Controls.Add(this.mlblEliminar);
            this.Controls.Add(this.mlblModificar);
            this.Controls.Add(this.mlnkModificar);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Controls.Add(this.mlblNuevo);
            this.Controls.Add(this.mlnkNuevo);
            this.Name = "frmCajasView";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmCajasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvCajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink btnRefrescarBusqueda;
        private MetroFramework.Controls.MetroLink btnBuscarCaja;
        private MetroFramework.Controls.MetroTextBox mtxtBuscarGeneral;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink mlnkEliminar;
        private MetroFramework.Controls.MetroLabel mlblEliminar;
        private MetroFramework.Controls.MetroLabel mlblModificar;
        private MetroFramework.Controls.MetroLink mlnkModificar;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroLabel mlblNuevo;
        private MetroFramework.Controls.MetroLink mlnkNuevo;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroTextBox txtBuscarCodigo;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroGrid mgvCajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajChrCodigo;
    }
}
