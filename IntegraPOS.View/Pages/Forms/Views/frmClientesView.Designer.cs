namespace IntegraPOS.Pages.Forms
{
    partial class frmClientesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clienteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mlnkLimpiarCampos = new MetroFramework.Controls.MetroLink();
            this.mlnkBuscar = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.mgvClientes = new MetroFramework.Controls.MetroGrid();
            this.mtxtBuscarNombre = new MetroFramework.Controls.MetroTextBox();
            this.mtxtBuscarOtro = new MetroFramework.Controls.MetroTextBox();
            this.mtxtBuscarTelefono = new MetroFramework.Controls.MetroTextBox();
            this.mtxtBuscarCedula = new MetroFramework.Controls.MetroTextBox();
            this.mtxtBuscarCodigo = new MetroFramework.Controls.MetroTextBox();
            this.mlnkImprimirFicha = new MetroFramework.Controls.MetroLink();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlblModificar = new MetroFramework.Controls.MetroLabel();
            this.mlnkModificar = new MetroFramework.Controls.MetroLink();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.mlblNuevo = new MetroFramework.Controls.MetroLabel();
            this.mlnkNuevo = new MetroFramework.Controls.MetroLink();
            this.CodigoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteModelBindingSource
            // 
            this.clienteModelBindingSource.DataSource = typeof(IntegraPOS.Model.Entidades.Clases.ClienteModel);
            // 
            // mlnkLimpiarCampos
            // 
            this.mlnkLimpiarCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkLimpiarCampos.BackgroundImage")));
            this.mlnkLimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkLimpiarCampos.Location = new System.Drawing.Point(312, 109);
            this.mlnkLimpiarCampos.Name = "mlnkLimpiarCampos";
            this.mlnkLimpiarCampos.Size = new System.Drawing.Size(48, 48);
            this.mlnkLimpiarCampos.TabIndex = 90;
            this.mlnkLimpiarCampos.UseSelectable = true;
            // 
            // mlnkBuscar
            // 
            this.mlnkBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBuscar.BackgroundImage")));
            this.mlnkBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscar.Location = new System.Drawing.Point(254, 109);
            this.mlnkBuscar.Name = "mlnkBuscar";
            this.mlnkBuscar.Size = new System.Drawing.Size(48, 48);
            this.mlnkBuscar.TabIndex = 89;
            this.mlnkBuscar.UseSelectable = true;
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(540, 70);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(200, 44);
            this.mlblTitulo.TabIndex = 88;
            this.mlblTitulo.Text = "Clientes";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CodigoCliente,
            this.CedulaCliente,
            this.NombrePri,
            this.TelefonoCliente,
            this.FormaPago,
            this.EstadoCliente});
            this.mgvClientes.DataSource = this.clienteModelBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.mgvClientes.EnableHeadersVisualStyles = false;
            this.mgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvClientes.Location = new System.Drawing.Point(10, 180);
            this.mgvClientes.Name = "mgvClientes";
            this.mgvClientes.ReadOnly = true;
            this.mgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvClientes.Size = new System.Drawing.Size(1260, 578);
            this.mgvClientes.TabIndex = 58;
            this.mgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvClientes_CellClick);
            this.mgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvClientes_CellDoubleClick);
            this.mgvClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mgvClientes_KeyDown);
            // 
            // mtxtBuscarNombre
            // 
            // 
            // 
            // 
            this.mtxtBuscarNombre.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.mtxtBuscarNombre.CustomButton.Location = new System.Drawing.Point(333, 1);
            this.mtxtBuscarNombre.CustomButton.Name = "";
            this.mtxtBuscarNombre.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscarNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscarNombre.CustomButton.TabIndex = 1;
            this.mtxtBuscarNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscarNombre.CustomButton.UseSelectable = true;
            this.mtxtBuscarNombre.CustomButton.Visible = false;
            this.mtxtBuscarNombre.Lines = new string[0];
            this.mtxtBuscarNombre.Location = new System.Drawing.Point(587, 122);
            this.mtxtBuscarNombre.MaxLength = 32767;
            this.mtxtBuscarNombre.Name = "mtxtBuscarNombre";
            this.mtxtBuscarNombre.PasswordChar = '\0';
            this.mtxtBuscarNombre.PromptText = "Buscar nombre";
            this.mtxtBuscarNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscarNombre.SelectedText = "";
            this.mtxtBuscarNombre.SelectionLength = 0;
            this.mtxtBuscarNombre.SelectionStart = 0;
            this.mtxtBuscarNombre.ShortcutsEnabled = true;
            this.mtxtBuscarNombre.Size = new System.Drawing.Size(367, 35);
            this.mtxtBuscarNombre.TabIndex = 57;
            this.mtxtBuscarNombre.UseSelectable = true;
            this.mtxtBuscarNombre.Visible = false;
            this.mtxtBuscarNombre.WaterMark = "Buscar nombre";
            this.mtxtBuscarNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscarNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.mtxtBuscarNombre.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtxtDatoBusqueda_ButtonClick);
            // 
            // mtxtBuscarOtro
            // 
            // 
            // 
            // 
            this.mtxtBuscarOtro.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.mtxtBuscarOtro.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtxtBuscarOtro.CustomButton.Name = "";
            this.mtxtBuscarOtro.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscarOtro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscarOtro.CustomButton.TabIndex = 1;
            this.mtxtBuscarOtro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscarOtro.CustomButton.UseSelectable = true;
            this.mtxtBuscarOtro.CustomButton.Visible = false;
            this.mtxtBuscarOtro.Lines = new string[0];
            this.mtxtBuscarOtro.Location = new System.Drawing.Point(1118, 122);
            this.mtxtBuscarOtro.MaxLength = 32767;
            this.mtxtBuscarOtro.Name = "mtxtBuscarOtro";
            this.mtxtBuscarOtro.PasswordChar = '\0';
            this.mtxtBuscarOtro.PromptText = "Buscar otro";
            this.mtxtBuscarOtro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscarOtro.SelectedText = "";
            this.mtxtBuscarOtro.SelectionLength = 0;
            this.mtxtBuscarOtro.SelectionStart = 0;
            this.mtxtBuscarOtro.ShortcutsEnabled = true;
            this.mtxtBuscarOtro.Size = new System.Drawing.Size(152, 35);
            this.mtxtBuscarOtro.TabIndex = 57;
            this.mtxtBuscarOtro.UseSelectable = true;
            this.mtxtBuscarOtro.Visible = false;
            this.mtxtBuscarOtro.WaterMark = "Buscar otro";
            this.mtxtBuscarOtro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscarOtro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.mtxtBuscarOtro.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtxtDatoBusqueda_ButtonClick);
            // 
            // mtxtBuscarTelefono
            // 
            // 
            // 
            // 
            this.mtxtBuscarTelefono.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.mtxtBuscarTelefono.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtxtBuscarTelefono.CustomButton.Name = "";
            this.mtxtBuscarTelefono.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscarTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscarTelefono.CustomButton.TabIndex = 1;
            this.mtxtBuscarTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscarTelefono.CustomButton.UseSelectable = true;
            this.mtxtBuscarTelefono.CustomButton.Visible = false;
            this.mtxtBuscarTelefono.Lines = new string[0];
            this.mtxtBuscarTelefono.Location = new System.Drawing.Point(960, 122);
            this.mtxtBuscarTelefono.MaxLength = 32767;
            this.mtxtBuscarTelefono.Name = "mtxtBuscarTelefono";
            this.mtxtBuscarTelefono.PasswordChar = '\0';
            this.mtxtBuscarTelefono.PromptText = "Buscar teléfono";
            this.mtxtBuscarTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscarTelefono.SelectedText = "";
            this.mtxtBuscarTelefono.SelectionLength = 0;
            this.mtxtBuscarTelefono.SelectionStart = 0;
            this.mtxtBuscarTelefono.ShortcutsEnabled = true;
            this.mtxtBuscarTelefono.Size = new System.Drawing.Size(152, 35);
            this.mtxtBuscarTelefono.TabIndex = 57;
            this.mtxtBuscarTelefono.UseSelectable = true;
            this.mtxtBuscarTelefono.Visible = false;
            this.mtxtBuscarTelefono.WaterMark = "Buscar teléfono";
            this.mtxtBuscarTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscarTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.mtxtBuscarTelefono.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtxtDatoBusqueda_ButtonClick);
            // 
            // mtxtBuscarCedula
            // 
            // 
            // 
            // 
            this.mtxtBuscarCedula.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.mtxtBuscarCedula.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.mtxtBuscarCedula.CustomButton.Name = "";
            this.mtxtBuscarCedula.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscarCedula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscarCedula.CustomButton.TabIndex = 1;
            this.mtxtBuscarCedula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscarCedula.CustomButton.UseSelectable = true;
            this.mtxtBuscarCedula.CustomButton.Visible = false;
            this.mtxtBuscarCedula.Lines = new string[0];
            this.mtxtBuscarCedula.Location = new System.Drawing.Point(438, 122);
            this.mtxtBuscarCedula.MaxLength = 32767;
            this.mtxtBuscarCedula.Name = "mtxtBuscarCedula";
            this.mtxtBuscarCedula.PasswordChar = '\0';
            this.mtxtBuscarCedula.PromptText = "Buscar cédula";
            this.mtxtBuscarCedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscarCedula.SelectedText = "";
            this.mtxtBuscarCedula.SelectionLength = 0;
            this.mtxtBuscarCedula.SelectionStart = 0;
            this.mtxtBuscarCedula.ShortcutsEnabled = true;
            this.mtxtBuscarCedula.Size = new System.Drawing.Size(143, 35);
            this.mtxtBuscarCedula.TabIndex = 57;
            this.mtxtBuscarCedula.UseSelectable = true;
            this.mtxtBuscarCedula.Visible = false;
            this.mtxtBuscarCedula.WaterMark = "Buscar cédula";
            this.mtxtBuscarCedula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscarCedula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.mtxtBuscarCedula.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtxtDatoBusqueda_ButtonClick);
            // 
            // mtxtBuscarCodigo
            // 
            // 
            // 
            // 
            this.mtxtBuscarCodigo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.mtxtBuscarCodigo.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.mtxtBuscarCodigo.CustomButton.Name = "";
            this.mtxtBuscarCodigo.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscarCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscarCodigo.CustomButton.TabIndex = 1;
            this.mtxtBuscarCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscarCodigo.CustomButton.UseSelectable = true;
            this.mtxtBuscarCodigo.CustomButton.Visible = false;
            this.mtxtBuscarCodigo.Lines = new string[0];
            this.mtxtBuscarCodigo.Location = new System.Drawing.Point(11, 122);
            this.mtxtBuscarCodigo.MaxLength = 32767;
            this.mtxtBuscarCodigo.Name = "mtxtBuscarCodigo";
            this.mtxtBuscarCodigo.PasswordChar = '\0';
            this.mtxtBuscarCodigo.PromptText = "Buscar";
            this.mtxtBuscarCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscarCodigo.SelectedText = "";
            this.mtxtBuscarCodigo.SelectionLength = 0;
            this.mtxtBuscarCodigo.SelectionStart = 0;
            this.mtxtBuscarCodigo.ShortcutsEnabled = true;
            this.mtxtBuscarCodigo.Size = new System.Drawing.Size(237, 35);
            this.mtxtBuscarCodigo.TabIndex = 57;
            this.mtxtBuscarCodigo.UseSelectable = true;
            this.mtxtBuscarCodigo.WaterMark = "Buscar";
            this.mtxtBuscarCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscarCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.mtxtBuscarCodigo.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtxtDatoBusqueda_ButtonClick);
            this.mtxtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtBuscarCodigo_KeyPress);
            // 
            // mlnkImprimirFicha
            // 
            this.mlnkImprimirFicha.BackgroundImage = global::IntegraPOS.Properties.Resources.imprimirFichaCir48x48;
            this.mlnkImprimirFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkImprimirFicha.Location = new System.Drawing.Point(390, 9);
            this.mlnkImprimirFicha.Name = "mlnkImprimirFicha";
            this.mlnkImprimirFicha.Size = new System.Drawing.Size(48, 48);
            this.mlnkImprimirFicha.TabIndex = 53;
            this.mlnkImprimirFicha.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.metroTile1.Location = new System.Drawing.Point(10, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1260, 5);
            this.metroTile1.TabIndex = 50;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(444, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 35);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Imprimir Ficha";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlblModificar
            // 
            this.mlblModificar.Location = new System.Drawing.Point(258, 22);
            this.mlblModificar.Name = "mlblModificar";
            this.mlblModificar.Size = new System.Drawing.Size(120, 35);
            this.mlblModificar.TabIndex = 48;
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
            this.mlnkModificar.TabIndex = 49;
            this.mlnkModificar.UseSelectable = true;
            this.mlnkModificar.Click += new System.EventHandler(this.mlnkModificar_Click);
            // 
            // mlblVolver
            // 
            this.mlblVolver.Location = new System.Drawing.Point(1145, 22);
            this.mlblVolver.Name = "mlblVolver";
            this.mlblVolver.Size = new System.Drawing.Size(120, 35);
            this.mlblVolver.TabIndex = 46;
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
            this.mlnkVolver.TabIndex = 47;
            this.mlnkVolver.UseSelectable = true;
            this.mlnkVolver.Click += new System.EventHandler(this.mlnkVolver_Click);
            // 
            // mlblNuevo
            // 
            this.mlblNuevo.Location = new System.Drawing.Point(78, 22);
            this.mlblNuevo.Name = "mlblNuevo";
            this.mlblNuevo.Size = new System.Drawing.Size(120, 35);
            this.mlblNuevo.TabIndex = 42;
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
            this.mlnkNuevo.TabIndex = 43;
            this.mlnkNuevo.UseSelectable = true;
            this.mlnkNuevo.Click += new System.EventHandler(this.mlnkNuevo_Click);
            // 
            // CodigoSistema
            // 
            this.CodigoSistema.DataPropertyName = "cliIntCodigo";
            this.CodigoSistema.HeaderText = "Código Sistema";
            this.CodigoSistema.Name = "CodigoSistema";
            this.CodigoSistema.ReadOnly = true;
            this.CodigoSistema.Visible = false;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.DataPropertyName = "cliChrCodigoPri";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CodigoCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoCliente.HeaderText = "Código Cliente";
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.ReadOnly = true;
            this.CodigoCliente.Width = 240;
            // 
            // CedulaCliente
            // 
            this.CedulaCliente.DataPropertyName = "cliChrCedula";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CedulaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.CedulaCliente.HeaderText = "Cédula";
            this.CedulaCliente.Name = "CedulaCliente";
            this.CedulaCliente.ReadOnly = true;
            this.CedulaCliente.Width = 150;
            // 
            // NombrePri
            // 
            this.NombrePri.DataPropertyName = "cliChrNombrePri";
            this.NombrePri.HeaderText = "Nombre";
            this.NombrePri.Name = "NombrePri";
            this.NombrePri.ReadOnly = true;
            this.NombrePri.Width = 379;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.DataPropertyName = "cliChrTelefono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TelefonoCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.TelefonoCliente.HeaderText = "Teléfono";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            this.TelefonoCliente.Width = 150;
            // 
            // FormaPago
            // 
            this.FormaPago.DataPropertyName = "cliChrFPago";
            this.FormaPago.HeaderText = "Tipo Cliente";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            this.FormaPago.Width = 150;
            // 
            // EstadoCliente
            // 
            this.EstadoCliente.DataPropertyName = "cliChrEstado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.EstadoCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.EstadoCliente.HeaderText = "Estado";
            this.EstadoCliente.Name = "EstadoCliente";
            this.EstadoCliente.ReadOnly = true;
            this.EstadoCliente.Width = 150;
            // 
            // frmClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlnkLimpiarCampos);
            this.Controls.Add(this.mlnkBuscar);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.mgvClientes);
            this.Controls.Add(this.mtxtBuscarNombre);
            this.Controls.Add(this.mtxtBuscarOtro);
            this.Controls.Add(this.mtxtBuscarTelefono);
            this.Controls.Add(this.mtxtBuscarCedula);
            this.Controls.Add(this.mtxtBuscarCodigo);
            this.Controls.Add(this.mlnkImprimirFicha);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlblModificar);
            this.Controls.Add(this.mlnkModificar);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Controls.Add(this.mlblNuevo);
            this.Controls.Add(this.mlnkNuevo);
            this.KeyPreview = true;
            this.Name = "frmClientesView";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmClientesView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientesView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.clienteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblModificar;
        private MetroFramework.Controls.MetroLink mlnkModificar;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroLabel mlblNuevo;
        private MetroFramework.Controls.MetroLink mlnkNuevo;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink mlnkImprimirFicha;
        private MetroFramework.Controls.MetroGrid mgvClientes;
        private MetroFramework.Controls.MetroTextBox mtxtBuscarCodigo;
        private System.Windows.Forms.BindingSource clienteModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente;
        private MetroFramework.Controls.MetroTextBox mtxtBuscarCedula;
        private MetroFramework.Controls.MetroTextBox mtxtBuscarNombre;
        private MetroFramework.Controls.MetroTextBox mtxtBuscarTelefono;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtxtBuscarOtro;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroLink mlnkLimpiarCampos;
        private MetroFramework.Controls.MetroLink mlnkBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePri;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente;
    }
}
