namespace IntegraPOS
{
    partial class frmPopUpClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopUpClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mpnlClientesPopUp = new MetroFramework.Controls.MetroPanel();
            this.mlnkBusqCliente = new MetroFramework.Controls.MetroLink();
            this.mlblClientes = new MetroFramework.Controls.MetroLabel();
            this.mlnkCerrar = new MetroFramework.Controls.MetroLink();
            this.mlblCriterioBusqueda = new MetroFramework.Controls.MetroLabel();
            this.mgvClientes = new MetroFramework.Controls.MetroGrid();
            this.mtxtDatoBusqueda = new MetroFramework.Controls.MetroTextBox();
            this.frmPopUpClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CodigoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteModelBindingSource)).BeginInit();
            this.mpnlClientesPopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPopUpClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteModelBindingSource
            // 
            this.ClienteModelBindingSource.DataSource = typeof(IntegraPOS.Model.Entidades.Clases.ClienteModel);
            // 
            // mpnlClientesPopUp
            // 
            this.mpnlClientesPopUp.BackColor = System.Drawing.Color.Gainsboro;
            this.mpnlClientesPopUp.Controls.Add(this.mlnkBusqCliente);
            this.mpnlClientesPopUp.Controls.Add(this.mlblClientes);
            this.mpnlClientesPopUp.Controls.Add(this.mlnkCerrar);
            this.mpnlClientesPopUp.Controls.Add(this.mlblCriterioBusqueda);
            this.mpnlClientesPopUp.Controls.Add(this.mgvClientes);
            this.mpnlClientesPopUp.Controls.Add(this.mtxtDatoBusqueda);
            this.mpnlClientesPopUp.HorizontalScrollbarBarColor = true;
            this.mpnlClientesPopUp.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlClientesPopUp.HorizontalScrollbarSize = 10;
            this.mpnlClientesPopUp.Location = new System.Drawing.Point(0, 0);
            this.mpnlClientesPopUp.Margin = new System.Windows.Forms.Padding(0);
            this.mpnlClientesPopUp.Name = "mpnlClientesPopUp";
            this.mpnlClientesPopUp.Size = new System.Drawing.Size(1000, 500);
            this.mpnlClientesPopUp.TabIndex = 3;
            this.mpnlClientesPopUp.UseCustomBackColor = true;
            this.mpnlClientesPopUp.VerticalScrollbarBarColor = true;
            this.mpnlClientesPopUp.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlClientesPopUp.VerticalScrollbarSize = 10;
            // 
            // mlnkBusqCliente
            // 
            this.mlnkBusqCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBusqCliente.BackgroundImage")));
            this.mlnkBusqCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBusqCliente.Location = new System.Drawing.Point(635, 69);
            this.mlnkBusqCliente.Name = "mlnkBusqCliente";
            this.mlnkBusqCliente.Size = new System.Drawing.Size(35, 35);
            this.mlnkBusqCliente.TabIndex = 9;
            this.mlnkBusqCliente.UseSelectable = true;
            this.mlnkBusqCliente.Click += new System.EventHandler(this.mlnkBusqCliente_Click);
            // 
            // mlblClientes
            // 
            this.mlblClientes.Location = new System.Drawing.Point(393, 12);
            this.mlblClientes.Name = "mlblClientes";
            this.mlblClientes.Size = new System.Drawing.Size(211, 44);
            this.mlblClientes.TabIndex = 7;
            this.mlblClientes.Text = "Clientes";
            this.mlblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlnkCerrar
            // 
            this.mlnkCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCerrar.BackgroundImage")));
            this.mlnkCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkCerrar.Location = new System.Drawing.Point(967, 3);
            this.mlnkCerrar.Name = "mlnkCerrar";
            this.mlnkCerrar.Size = new System.Drawing.Size(30, 30);
            this.mlnkCerrar.TabIndex = 6;
            this.mlnkCerrar.UseSelectable = true;
            this.mlnkCerrar.Click += new System.EventHandler(this.mlnkCerrar_Click);
            // 
            // mlblCriterioBusqueda
            // 
            this.mlblCriterioBusqueda.Location = new System.Drawing.Point(23, 69);
            this.mlblCriterioBusqueda.Name = "mlblCriterioBusqueda";
            this.mlblCriterioBusqueda.Size = new System.Drawing.Size(200, 35);
            this.mlblCriterioBusqueda.TabIndex = 3;
            this.mlblCriterioBusqueda.Text = "Criterio de búsqueda";
            this.mlblCriterioBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mgvClientes
            // 
            this.mgvClientes.AllowUserToAddRows = false;
            this.mgvClientes.AllowUserToDeleteRows = false;
            this.mgvClientes.AllowUserToResizeRows = false;
            this.mgvClientes.AutoGenerateColumns = false;
            this.mgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoSistema,
            this.CodigoPri,
            this.Cedula,
            this.NombrePri,
            this.Telefono,
            this.FormaPago,
            this.Email,
            this.Estado});
            this.mgvClientes.DataSource = this.ClienteModelBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.mgvClientes.EnableHeadersVisualStyles = false;
            this.mgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvClientes.Location = new System.Drawing.Point(10, 126);
            this.mgvClientes.Name = "mgvClientes";
            this.mgvClientes.ReadOnly = true;
            this.mgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.mgvClientes.RowHeadersVisible = false;
            this.mgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvClientes.Size = new System.Drawing.Size(980, 351);
            this.mgvClientes.TabIndex = 5;
            this.mgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridClientes_CellDoubleClick);
            this.mgvClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mgvClientes_KeyDown);
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
            this.mtxtDatoBusqueda.TabIndex = 4;
            this.mtxtDatoBusqueda.UseSelectable = true;
            this.mtxtDatoBusqueda.WaterMark = "Buscar";
            this.mtxtDatoBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtDatoBusqueda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            // 
            // frmPopUpClientesBindingSource
            // 
            this.frmPopUpClientesBindingSource.DataSource = typeof(IntegraPOS.frmPopUpClientes);
            // 
            // CodigoSistema
            // 
            this.CodigoSistema.DataPropertyName = "cliIntCodigo";
            this.CodigoSistema.HeaderText = "Código Sistema";
            this.CodigoSistema.Name = "CodigoSistema";
            this.CodigoSistema.ReadOnly = true;
            this.CodigoSistema.Visible = false;
            // 
            // CodigoPri
            // 
            this.CodigoPri.DataPropertyName = "cliChrCodigoPri";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodigoPri.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoPri.HeaderText = "Código";
            this.CodigoPri.Name = "CodigoPri";
            this.CodigoPri.ReadOnly = true;
            this.CodigoPri.ToolTipText = "Código del Cliente";
            this.CodigoPri.Width = 120;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "cliChrCedula";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Cedula.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.ToolTipText = "Cedula del Cliente";
            this.Cedula.Width = 150;
            // 
            // NombrePri
            // 
            this.NombrePri.DataPropertyName = "cliChrNombrePri";
            this.NombrePri.HeaderText = "Nombre";
            this.NombrePri.Name = "NombrePri";
            this.NombrePri.ReadOnly = true;
            this.NombrePri.Width = 242;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "cliChrTelefono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle4;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.ToolTipText = "Teléfono";
            // 
            // FormaPago
            // 
            this.FormaPago.DataPropertyName = "cliIntFPago";
            this.FormaPago.HeaderText = "Tipo";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            this.FormaPago.Width = 88;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "cliChrEmail";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Email.DefaultCellStyle = dataGridViewCellStyle5;
            this.Email.HeaderText = "Correo";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.ToolTipText = "Correo Electronico";
            this.Email.Width = 200;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "cliChrEstado";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.ToolTipText = "Estado del cliente";
            this.Estado.Width = 80;
            // 
            // frmPopUpClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.mpnlClientesPopUp);
            this.MinimizeBox = false;
            this.Name = "frmPopUpClientes";
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmPopUpClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteModelBindingSource)).EndInit();
            this.mpnlClientesPopUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPopUpClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource frmPopUpClientesBindingSource;
        private System.Windows.Forms.BindingSource ClienteModelBindingSource;
        private MetroFramework.Controls.MetroPanel mpnlClientesPopUp;
        private MetroFramework.Controls.MetroLabel mlblCriterioBusqueda;
        private MetroFramework.Controls.MetroGrid mgvClientes;
        private MetroFramework.Controls.MetroTextBox mtxtDatoBusqueda;
        private MetroFramework.Controls.MetroLink mlnkCerrar;
        private MetroFramework.Controls.MetroLabel mlblClientes;
        private MetroFramework.Controls.MetroLink mlnkBusqCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
