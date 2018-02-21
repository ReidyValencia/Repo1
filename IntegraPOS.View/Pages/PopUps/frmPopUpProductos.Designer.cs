namespace IntegraPOS.Pages.PopUps
{
    partial class frmPopUpProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopUpProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpnlProductos = new MetroFramework.Controls.MetroPanel();
            this.mlnkCerrar = new MetroFramework.Controls.MetroLink();
            this.mlblProductos = new MetroFramework.Controls.MetroLabel();
            this.mlnkBusqProducto = new MetroFramework.Controls.MetroLink();
            this.mgvProductos = new MetroFramework.Controls.MetroGrid();
            this.mtxtDatoBusqueda = new MetroFramework.Controls.MetroTextBox();
            this.mlblCriterioBusqueda = new MetroFramework.Controls.MetroLabel();
            this.popUpProductoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CodigoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpProductoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnlProductos
            // 
            this.mpnlProductos.BackColor = System.Drawing.Color.Gainsboro;
            this.mpnlProductos.Controls.Add(this.mlnkCerrar);
            this.mpnlProductos.Controls.Add(this.mlblProductos);
            this.mpnlProductos.Controls.Add(this.mlnkBusqProducto);
            this.mpnlProductos.Controls.Add(this.mgvProductos);
            this.mpnlProductos.Controls.Add(this.mtxtDatoBusqueda);
            this.mpnlProductos.Controls.Add(this.mlblCriterioBusqueda);
            this.mpnlProductos.HorizontalScrollbarBarColor = true;
            this.mpnlProductos.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlProductos.HorizontalScrollbarSize = 10;
            this.mpnlProductos.Location = new System.Drawing.Point(0, 0);
            this.mpnlProductos.Name = "mpnlProductos";
            this.mpnlProductos.Size = new System.Drawing.Size(1000, 500);
            this.mpnlProductos.TabIndex = 0;
            this.mpnlProductos.UseCustomBackColor = true;
            this.mpnlProductos.VerticalScrollbarBarColor = true;
            this.mpnlProductos.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlProductos.VerticalScrollbarSize = 10;
            // 
            // mlnkCerrar
            // 
            this.mlnkCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCerrar.BackgroundImage")));
            this.mlnkCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkCerrar.Location = new System.Drawing.Point(967, 3);
            this.mlnkCerrar.Name = "mlnkCerrar";
            this.mlnkCerrar.Size = new System.Drawing.Size(30, 30);
            this.mlnkCerrar.TabIndex = 9;
            this.mlnkCerrar.UseSelectable = true;
            this.mlnkCerrar.Click += new System.EventHandler(this.mlnkCerrar_Click);
            // 
            // mlblProductos
            // 
            this.mlblProductos.Location = new System.Drawing.Point(393, 12);
            this.mlblProductos.Name = "mlblProductos";
            this.mlblProductos.Size = new System.Drawing.Size(211, 44);
            this.mlblProductos.TabIndex = 0;
            this.mlblProductos.Text = "Productos";
            this.mlblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlnkBusqProducto
            // 
            this.mlnkBusqProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBusqProducto.BackgroundImage")));
            this.mlnkBusqProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBusqProducto.Location = new System.Drawing.Point(635, 69);
            this.mlnkBusqProducto.Name = "mlnkBusqProducto";
            this.mlnkBusqProducto.Size = new System.Drawing.Size(35, 35);
            this.mlnkBusqProducto.TabIndex = 8;
            this.mlnkBusqProducto.UseSelectable = true;
            this.mlnkBusqProducto.Click += new System.EventHandler(this.mlnkBusqProducto_Click);
            // 
            // mgvProductos
            // 
            this.mgvProductos.AllowUserToAddRows = false;
            this.mgvProductos.AllowUserToDeleteRows = false;
            this.mgvProductos.AllowUserToResizeRows = false;
            this.mgvProductos.AutoGenerateColumns = false;
            this.mgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoSistema,
            this.CodigoPri,
            this.NombreProducto,
            this.Existencia,
            this.Producto,
            this.Precio,
            this.Estado});
            this.mgvProductos.DataSource = this.popUpProductoModelBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvProductos.DefaultCellStyle = dataGridViewCellStyle9;
            this.mgvProductos.EnableHeadersVisualStyles = false;
            this.mgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvProductos.Location = new System.Drawing.Point(10, 126);
            this.mgvProductos.Name = "mgvProductos";
            this.mgvProductos.ReadOnly = true;
            this.mgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgvProductos.RowHeadersVisible = false;
            this.mgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvProductos.Size = new System.Drawing.Size(980, 351);
            this.mgvProductos.TabIndex = 7;
            this.mgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridProductos_CellDoubleClick);
            this.mgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mgvProductos_KeyDown);
            // 
            // mtxtDatoBusqueda
            // 
            // 
            // 
            // 
            this.mtxtDatoBusqueda.CustomButton.Image = null;
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
            this.mtxtDatoBusqueda.TabIndex = 6;
            this.mtxtDatoBusqueda.UseSelectable = true;
            this.mtxtDatoBusqueda.WaterMark = "Buscar";
            this.mtxtDatoBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDatoBusqueda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            // 
            // mlblCriterioBusqueda
            // 
            this.mlblCriterioBusqueda.Location = new System.Drawing.Point(23, 69);
            this.mlblCriterioBusqueda.Name = "mlblCriterioBusqueda";
            this.mlblCriterioBusqueda.Size = new System.Drawing.Size(200, 35);
            this.mlblCriterioBusqueda.TabIndex = 5;
            this.mlblCriterioBusqueda.Text = "Criterio de búsqueda";
            this.mlblCriterioBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popUpProductoModelBindingSource
            // 
            this.popUpProductoModelBindingSource.DataSource = typeof(IntegraPOS.Model.Entidades.PopUps.PopUpProductoModel);
            // 
            // CodigoSistema
            // 
            this.CodigoSistema.DataPropertyName = "prdIntCodigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodigoSistema.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoSistema.HeaderText = "Código Sistema";
            this.CodigoSistema.Name = "CodigoSistema";
            this.CodigoSistema.ReadOnly = true;
            this.CodigoSistema.Visible = false;
            // 
            // CodigoPri
            // 
            this.CodigoPri.DataPropertyName = "prdChrCodigoPri";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodigoPri.DefaultCellStyle = dataGridViewCellStyle3;
            this.CodigoPri.HeaderText = "Código";
            this.CodigoPri.Name = "CodigoPri";
            this.CodigoPri.ReadOnly = true;
            this.CodigoPri.Width = 150;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "prdChrNombrePri";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NombreProducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 373;
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "prdMonExistencia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Existencia.DefaultCellStyle = dataGridViewCellStyle5;
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.Width = 160;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "prdChrTipoItem";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Producto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Visible = false;
            this.Producto.Width = 120;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "prdMonPrecioBase";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle7;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 140;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "prdChrEstado";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle8;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 140;
            // 
            // frmPopUpProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.mpnlProductos);
            this.MinimizeBox = false;
            this.Name = "frmPopUpProductos";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmPopUpProductos_Load);
            this.mpnlProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popUpProductoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mpnlProductos;
        private MetroFramework.Controls.MetroLink mlnkBusqProducto;
        private MetroFramework.Controls.MetroGrid mgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private MetroFramework.Controls.MetroTextBox mtxtDatoBusqueda;
        private MetroFramework.Controls.MetroLabel mlblCriterioBusqueda;
        private MetroFramework.Controls.MetroLabel mlblProductos;
        private MetroFramework.Controls.MetroLink mlnkCerrar;
        private System.Windows.Forms.BindingSource popUpProductoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
