namespace IntegraPOS.Pages.PopUps
{
    partial class frmPopUpDirecciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopUpDirecciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.direccionModelMiscBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mpnlDireccionesPopUp = new MetroFramework.Controls.MetroPanel();
            this.mlnkBusqDireccion = new MetroFramework.Controls.MetroLink();
            this.mlblDirecciones = new MetroFramework.Controls.MetroLabel();
            this.mlnkCerrar = new MetroFramework.Controls.MetroLink();
            this.mlblCriterioBusqueda = new MetroFramework.Controls.MetroLabel();
            this.mgvDirecciones = new MetroFramework.Controls.MetroGrid();
            this.CodigoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtDatoBusqueda = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.direccionModelMiscBindingSource)).BeginInit();
            this.mpnlDireccionesPopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionModelMiscBindingSource
            // 
            this.direccionModelMiscBindingSource.DataSource = typeof(IntegraPOS.Model.Entidades.Miscelaneos.DireccionModelMisc);
            // 
            // mpnlDireccionesPopUp
            // 
            this.mpnlDireccionesPopUp.BackColor = System.Drawing.Color.Gainsboro;
            this.mpnlDireccionesPopUp.Controls.Add(this.mlnkBusqDireccion);
            this.mpnlDireccionesPopUp.Controls.Add(this.mlblDirecciones);
            this.mpnlDireccionesPopUp.Controls.Add(this.mlnkCerrar);
            this.mpnlDireccionesPopUp.Controls.Add(this.mlblCriterioBusqueda);
            this.mpnlDireccionesPopUp.Controls.Add(this.mgvDirecciones);
            this.mpnlDireccionesPopUp.Controls.Add(this.mtxtDatoBusqueda);
            this.mpnlDireccionesPopUp.HorizontalScrollbarBarColor = true;
            this.mpnlDireccionesPopUp.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlDireccionesPopUp.HorizontalScrollbarSize = 10;
            this.mpnlDireccionesPopUp.Location = new System.Drawing.Point(0, 0);
            this.mpnlDireccionesPopUp.Name = "mpnlDireccionesPopUp";
            this.mpnlDireccionesPopUp.Size = new System.Drawing.Size(1000, 500);
            this.mpnlDireccionesPopUp.TabIndex = 0;
            this.mpnlDireccionesPopUp.UseCustomBackColor = true;
            this.mpnlDireccionesPopUp.VerticalScrollbarBarColor = true;
            this.mpnlDireccionesPopUp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlDireccionesPopUp.VerticalScrollbarSize = 10;
            // 
            // mlnkBusqDireccion
            // 
            this.mlnkBusqDireccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBusqDireccion.BackgroundImage")));
            this.mlnkBusqDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBusqDireccion.Location = new System.Drawing.Point(635, 69);
            this.mlnkBusqDireccion.Name = "mlnkBusqDireccion";
            this.mlnkBusqDireccion.Size = new System.Drawing.Size(35, 35);
            this.mlnkBusqDireccion.TabIndex = 13;
            this.mlnkBusqDireccion.UseSelectable = true;
            this.mlnkBusqDireccion.Click += new System.EventHandler(this.mlnkBusqDireccion_Click);
            // 
            // mlblDirecciones
            // 
            this.mlblDirecciones.Location = new System.Drawing.Point(393, 12);
            this.mlblDirecciones.Name = "mlblDirecciones";
            this.mlblDirecciones.Size = new System.Drawing.Size(211, 44);
            this.mlblDirecciones.TabIndex = 12;
            this.mlblDirecciones.Text = "Direcciones";
            this.mlblDirecciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlnkCerrar
            // 
            this.mlnkCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCerrar.BackgroundImage")));
            this.mlnkCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkCerrar.Location = new System.Drawing.Point(967, 3);
            this.mlnkCerrar.Name = "mlnkCerrar";
            this.mlnkCerrar.Size = new System.Drawing.Size(30, 30);
            this.mlnkCerrar.TabIndex = 11;
            this.mlnkCerrar.UseSelectable = true;
            this.mlnkCerrar.Click += new System.EventHandler(this.mlnkCerrar_Click);
            // 
            // mlblCriterioBusqueda
            // 
            this.mlblCriterioBusqueda.Location = new System.Drawing.Point(23, 69);
            this.mlblCriterioBusqueda.Name = "mlblCriterioBusqueda";
            this.mlblCriterioBusqueda.Size = new System.Drawing.Size(200, 35);
            this.mlblCriterioBusqueda.TabIndex = 8;
            this.mlblCriterioBusqueda.Text = "Criterio de búsqueda";
            this.mlblCriterioBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mgvDirecciones
            // 
            this.mgvDirecciones.AllowUserToAddRows = false;
            this.mgvDirecciones.AllowUserToDeleteRows = false;
            this.mgvDirecciones.AllowUserToResizeRows = false;
            this.mgvDirecciones.AutoGenerateColumns = false;
            this.mgvDirecciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDirecciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvDirecciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvDirecciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDirecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvDirecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoSistema,
            this.Descripcion});
            this.mgvDirecciones.DataSource = this.direccionModelMiscBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvDirecciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvDirecciones.EnableHeadersVisualStyles = false;
            this.mgvDirecciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvDirecciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDirecciones.Location = new System.Drawing.Point(10, 126);
            this.mgvDirecciones.Name = "mgvDirecciones";
            this.mgvDirecciones.ReadOnly = true;
            this.mgvDirecciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDirecciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvDirecciones.RowHeadersVisible = false;
            this.mgvDirecciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvDirecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvDirecciones.Size = new System.Drawing.Size(980, 351);
            this.mgvDirecciones.TabIndex = 10;
            this.mgvDirecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvDirecciones_CellDoubleClick);
            this.mgvDirecciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mgvDirecciones_KeyDown);
            // 
            // CodigoSistema
            // 
            this.CodigoSistema.DataPropertyName = "dirChrCodDireccion";
            this.CodigoSistema.HeaderText = "Código Dirección";
            this.CodigoSistema.Name = "CodigoSistema";
            this.CodigoSistema.ReadOnly = true;
            this.CodigoSistema.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "dirChrNomDireccion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 780;
            // 
            // mtxtDatoBusqueda
            // 
            // 
            // 
            // 
            this.mtxtDatoBusqueda.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.mtxtDatoBusqueda.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.mtxtDatoBusqueda.CustomButton.Name = "";
            this.mtxtDatoBusqueda.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtDatoBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtDatoBusqueda.CustomButton.TabIndex = 1;
            this.mtxtDatoBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtDatoBusqueda.CustomButton.UseSelectable = true;
            this.mtxtDatoBusqueda.CustomButton.Visible = false;
            this.mtxtDatoBusqueda.Lines = new string[0];
            this.mtxtDatoBusqueda.Location = new System.Drawing.Point(229, 69);
            this.mtxtDatoBusqueda.MaxLength = 32767;
            this.mtxtDatoBusqueda.Name = "mtxtDatoBusqueda";
            this.mtxtDatoBusqueda.PasswordChar = '\0';
            this.mtxtDatoBusqueda.PromptText = "Buscar";
            this.mtxtDatoBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtDatoBusqueda.SelectedText = "";
            this.mtxtDatoBusqueda.SelectionLength = 0;
            this.mtxtDatoBusqueda.SelectionStart = 0;
            this.mtxtDatoBusqueda.ShortcutsEnabled = true;
            this.mtxtDatoBusqueda.Size = new System.Drawing.Size(400, 35);
            this.mtxtDatoBusqueda.TabIndex = 9;
            this.mtxtDatoBusqueda.UseSelectable = true;
            this.mtxtDatoBusqueda.WaterMark = "Buscar";
            this.mtxtDatoBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDatoBusqueda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            // 
            // frmPopUpDirecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.mpnlDireccionesPopUp);
            this.MinimizeBox = false;
            this.Name = "frmPopUpDirecciones";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmPopUpDirecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.direccionModelMiscBindingSource)).EndInit();
            this.mpnlDireccionesPopUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvDirecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource direccionModelMiscBindingSource;
        private MetroFramework.Controls.MetroPanel mpnlDireccionesPopUp;
        private MetroFramework.Controls.MetroLink mlnkCerrar;
        private MetroFramework.Controls.MetroLabel mlblCriterioBusqueda;
        private MetroFramework.Controls.MetroGrid mgvDirecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private MetroFramework.Controls.MetroTextBox mtxtDatoBusqueda;
        private MetroFramework.Controls.MetroLabel mlblDirecciones;
        private MetroFramework.Controls.MetroLink mlnkBusqDireccion;
    }
}
