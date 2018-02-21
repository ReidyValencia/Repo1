namespace IntegraPOS.Pages.Forms.Mants
{
    partial class frmPedidoMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoMant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlnkBusqProducto = new MetroFramework.Controls.MetroLink();
            this.mlnkBusqCliente = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.mcbTipoTasa = new MetroFramework.Controls.MetroComboBox();
            this.mcbMoneda = new MetroFramework.Controls.MetroComboBox();
            this.mcbMonedaError = new MetroFramework.Controls.MetroLabel();
            this.mtxtValorTasaError = new MetroFramework.Controls.MetroLabel();
            this.mcbTipoTasaError = new MetroFramework.Controls.MetroLabel();
            this.mlblTipoTasa = new MetroFramework.Controls.MetroLabel();
            this.mcbBodegaError = new MetroFramework.Controls.MetroLabel();
            this.mtxtClienteError = new MetroFramework.Controls.MetroLabel();
            this.mcbFormaPagoError = new MetroFramework.Controls.MetroLabel();
            this.mtileLinea = new MetroFramework.Controls.MetroTile();
            this.mlblLineaBusc02 = new MetroFramework.Controls.MetroLabel();
            this.mlblLineaBusc01 = new MetroFramework.Controls.MetroLabel();
            this.mtxtValorTasa = new MetroFramework.Controls.MetroTextBox();
            this.mlblValorTasa = new MetroFramework.Controls.MetroLabel();
            this.mlblCancelar = new MetroFramework.Controls.MetroLabel();
            this.mlnkCancelar = new MetroFramework.Controls.MetroLink();
            this.mlblBuscarProducto = new MetroFramework.Controls.MetroLabel();
            this.mlnkBuscarProducto = new MetroFramework.Controls.MetroLink();
            this.mlblBuscarCliente = new MetroFramework.Controls.MetroLabel();
            this.mlnkBuscarCliente = new MetroFramework.Controls.MetroLink();
            this.mcbFormaPago = new MetroFramework.Controls.MetroComboBox();
            this.mlblNuevaFact = new MetroFramework.Controls.MetroLabel();
            this.mlnkNuevaFact = new MetroFramework.Controls.MetroLink();
            this.mlblRecargar = new MetroFramework.Controls.MetroLabel();
            this.mlnkRecargar = new MetroFramework.Controls.MetroLink();
            this.mtxtProducto = new MetroFramework.Controls.MetroTextBox();
            this.mlblGuardar = new MetroFramework.Controls.MetroLabel();
            this.mlnkGuardar = new MetroFramework.Controls.MetroLink();
            this.mlblDescripNumTransaccion = new MetroFramework.Controls.MetroLabel();
            this.mcbBodega = new MetroFramework.Controls.MetroComboBox();
            this.mlblProducto = new MetroFramework.Controls.MetroLabel();
            this.mlblBodega = new MetroFramework.Controls.MetroLabel();
            this.mlblNumTransaccion = new MetroFramework.Controls.MetroLabel();
            this.mtxtAnotacion = new MetroFramework.Controls.MetroTextBox();
            this.mlblAnotacion = new MetroFramework.Controls.MetroLabel();
            this.mplTotales = new MetroFramework.Controls.MetroPanel();
            this.mlblImpuestoGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblImpuesto = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotalGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblDescuentoGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotalDescGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotalDesc = new MetroFramework.Controls.MetroLabel();
            this.mlblDescuento = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotal = new MetroFramework.Controls.MetroLabel();
            this.mtileTotalFactura = new MetroFramework.Controls.MetroTile();
            this.mgvProductos = new MetroFramework.Controls.MetroGrid();
            this.EliminarRegistro = new System.Windows.Forms.DataGridViewImageColumn();
            this.NumLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonDescuentoLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonImpuestoLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlblFormaPago = new MetroFramework.Controls.MetroLabel();
            this.mlblMoneda = new MetroFramework.Controls.MetroLabel();
            this.mtxtCliente = new MetroFramework.Controls.MetroTextBox();
            this.mlblCliente = new MetroFramework.Controls.MetroLabel();
            this.mplTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // mlnkBusqProducto
            // 
            this.mlnkBusqProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBusqProducto.BackgroundImage")));
            this.mlnkBusqProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBusqProducto.Location = new System.Drawing.Point(855, 395);
            this.mlnkBusqProducto.Name = "mlnkBusqProducto";
            this.mlnkBusqProducto.Size = new System.Drawing.Size(29, 35);
            this.mlnkBusqProducto.TabIndex = 170;
            this.mlnkBusqProducto.UseSelectable = true;
            // 
            // mlnkBusqCliente
            // 
            this.mlnkBusqCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBusqCliente.BackgroundImage")));
            this.mlnkBusqCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBusqCliente.Location = new System.Drawing.Point(855, 130);
            this.mlnkBusqCliente.Name = "mlnkBusqCliente";
            this.mlnkBusqCliente.Size = new System.Drawing.Size(29, 35);
            this.mlnkBusqCliente.TabIndex = 169;
            this.mlnkBusqCliente.UseSelectable = true;
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(540, 68);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(200, 44);
            this.mlblTitulo.TabIndex = 168;
            this.mlblTitulo.Text = "Pedido";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcbTipoTasa
            // 
            this.mcbTipoTasa.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbTipoTasa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcbTipoTasa.FormattingEnabled = true;
            this.mcbTipoTasa.ItemHeight = 29;
            this.mcbTipoTasa.Location = new System.Drawing.Point(709, 180);
            this.mcbTipoTasa.Name = "mcbTipoTasa";
            this.mcbTipoTasa.Size = new System.Drawing.Size(140, 35);
            this.mcbTipoTasa.TabIndex = 167;
            this.mcbTipoTasa.UseSelectable = true;
            // 
            // mcbMoneda
            // 
            this.mcbMoneda.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbMoneda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcbMoneda.FormattingEnabled = true;
            this.mcbMoneda.ItemHeight = 29;
            this.mcbMoneda.Location = new System.Drawing.Point(429, 180);
            this.mcbMoneda.Name = "mcbMoneda";
            this.mcbMoneda.Size = new System.Drawing.Size(140, 35);
            this.mcbMoneda.TabIndex = 166;
            this.mcbMoneda.UseSelectable = true;
            // 
            // mcbMonedaError
            // 
            this.mcbMonedaError.BackColor = System.Drawing.Color.White;
            this.mcbMonedaError.ForeColor = System.Drawing.Color.Maroon;
            this.mcbMonedaError.Location = new System.Drawing.Point(575, 180);
            this.mcbMonedaError.Name = "mcbMonedaError";
            this.mcbMonedaError.Size = new System.Drawing.Size(14, 19);
            this.mcbMonedaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mcbMonedaError.TabIndex = 165;
            this.mcbMonedaError.Text = "*";
            this.mcbMonedaError.UseCustomForeColor = true;
            this.mcbMonedaError.Visible = false;
            // 
            // mtxtValorTasaError
            // 
            this.mtxtValorTasaError.BackColor = System.Drawing.Color.White;
            this.mtxtValorTasaError.ForeColor = System.Drawing.Color.Maroon;
            this.mtxtValorTasaError.Location = new System.Drawing.Point(855, 221);
            this.mtxtValorTasaError.Name = "mtxtValorTasaError";
            this.mtxtValorTasaError.Size = new System.Drawing.Size(14, 19);
            this.mtxtValorTasaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mtxtValorTasaError.TabIndex = 164;
            this.mtxtValorTasaError.Text = "*";
            this.mtxtValorTasaError.UseCustomForeColor = true;
            this.mtxtValorTasaError.Visible = false;
            // 
            // mcbTipoTasaError
            // 
            this.mcbTipoTasaError.BackColor = System.Drawing.Color.White;
            this.mcbTipoTasaError.ForeColor = System.Drawing.Color.Maroon;
            this.mcbTipoTasaError.Location = new System.Drawing.Point(855, 180);
            this.mcbTipoTasaError.Name = "mcbTipoTasaError";
            this.mcbTipoTasaError.Size = new System.Drawing.Size(14, 19);
            this.mcbTipoTasaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mcbTipoTasaError.TabIndex = 163;
            this.mcbTipoTasaError.Text = "*";
            this.mcbTipoTasaError.UseCustomForeColor = true;
            this.mcbTipoTasaError.Visible = false;
            // 
            // mlblTipoTasa
            // 
            this.mlblTipoTasa.Location = new System.Drawing.Point(605, 180);
            this.mlblTipoTasa.Name = "mlblTipoTasa";
            this.mlblTipoTasa.Size = new System.Drawing.Size(98, 35);
            this.mlblTipoTasa.TabIndex = 162;
            this.mlblTipoTasa.Text = "Tipo Tasa";
            this.mlblTipoTasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mcbBodegaError
            // 
            this.mcbBodegaError.BackColor = System.Drawing.Color.White;
            this.mcbBodegaError.ForeColor = System.Drawing.Color.Maroon;
            this.mcbBodegaError.Location = new System.Drawing.Point(444, 395);
            this.mcbBodegaError.Name = "mcbBodegaError";
            this.mcbBodegaError.Size = new System.Drawing.Size(14, 19);
            this.mcbBodegaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mcbBodegaError.TabIndex = 161;
            this.mcbBodegaError.Text = "*";
            this.mcbBodegaError.UseCustomForeColor = true;
            this.mcbBodegaError.Visible = false;
            // 
            // mtxtClienteError
            // 
            this.mtxtClienteError.BackColor = System.Drawing.Color.White;
            this.mtxtClienteError.ForeColor = System.Drawing.Color.Maroon;
            this.mtxtClienteError.Location = new System.Drawing.Point(879, 130);
            this.mtxtClienteError.Name = "mtxtClienteError";
            this.mtxtClienteError.Size = new System.Drawing.Size(14, 19);
            this.mtxtClienteError.Style = MetroFramework.MetroColorStyle.Black;
            this.mtxtClienteError.TabIndex = 160;
            this.mtxtClienteError.Text = "*";
            this.mtxtClienteError.UseCustomForeColor = true;
            this.mtxtClienteError.Visible = false;
            // 
            // mcbFormaPagoError
            // 
            this.mcbFormaPagoError.BackColor = System.Drawing.Color.White;
            this.mcbFormaPagoError.ForeColor = System.Drawing.Color.Maroon;
            this.mcbFormaPagoError.Location = new System.Drawing.Point(295, 180);
            this.mcbFormaPagoError.Name = "mcbFormaPagoError";
            this.mcbFormaPagoError.Size = new System.Drawing.Size(14, 19);
            this.mcbFormaPagoError.Style = MetroFramework.MetroColorStyle.Black;
            this.mcbFormaPagoError.TabIndex = 159;
            this.mcbFormaPagoError.Text = "*";
            this.mcbFormaPagoError.UseCustomForeColor = true;
            this.mcbFormaPagoError.Visible = false;
            // 
            // mtileLinea
            // 
            this.mtileLinea.ActiveControl = null;
            this.mtileLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileLinea.Location = new System.Drawing.Point(10, 61);
            this.mtileLinea.Name = "mtileLinea";
            this.mtileLinea.Size = new System.Drawing.Size(1260, 5);
            this.mtileLinea.TabIndex = 158;
            this.mtileLinea.Text = "metroTile1";
            this.mtileLinea.UseSelectable = true;
            // 
            // mlblLineaBusc02
            // 
            this.mlblLineaBusc02.Location = new System.Drawing.Point(585, 352);
            this.mlblLineaBusc02.Name = "mlblLineaBusc02";
            this.mlblLineaBusc02.Size = new System.Drawing.Size(264, 35);
            this.mlblLineaBusc02.TabIndex = 157;
            this.mlblLineaBusc02.Text = "------------------------------------";
            // 
            // mlblLineaBusc01
            // 
            this.mlblLineaBusc01.Location = new System.Drawing.Point(150, 352);
            this.mlblLineaBusc01.Name = "mlblLineaBusc01";
            this.mlblLineaBusc01.Size = new System.Drawing.Size(264, 35);
            this.mlblLineaBusc01.TabIndex = 156;
            this.mlblLineaBusc01.Text = "------------------------------------";
            // 
            // mtxtValorTasa
            // 
            // 
            // 
            // 
            this.mtxtValorTasa.CustomButton.Image = null;
            this.mtxtValorTasa.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.mtxtValorTasa.CustomButton.Name = "";
            this.mtxtValorTasa.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtValorTasa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtValorTasa.CustomButton.TabIndex = 1;
            this.mtxtValorTasa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtValorTasa.CustomButton.UseSelectable = true;
            this.mtxtValorTasa.CustomButton.Visible = false;
            this.mtxtValorTasa.ForeColor = System.Drawing.Color.Maroon;
            this.mtxtValorTasa.Lines = new string[0];
            this.mtxtValorTasa.Location = new System.Drawing.Point(709, 221);
            this.mtxtValorTasa.MaxLength = 32767;
            this.mtxtValorTasa.Name = "mtxtValorTasa";
            this.mtxtValorTasa.PasswordChar = '\0';
            this.mtxtValorTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValorTasa.SelectedText = "";
            this.mtxtValorTasa.SelectionLength = 0;
            this.mtxtValorTasa.SelectionStart = 0;
            this.mtxtValorTasa.ShortcutsEnabled = true;
            this.mtxtValorTasa.Size = new System.Drawing.Size(140, 35);
            this.mtxtValorTasa.TabIndex = 150;
            this.mtxtValorTasa.UseSelectable = true;
            this.mtxtValorTasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtValorTasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblValorTasa
            // 
            this.mlblValorTasa.Location = new System.Drawing.Point(605, 221);
            this.mlblValorTasa.Name = "mlblValorTasa";
            this.mlblValorTasa.Size = new System.Drawing.Size(98, 35);
            this.mlblValorTasa.TabIndex = 155;
            this.mlblValorTasa.Text = "Valor Tasa";
            this.mlblValorTasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlblCancelar
            // 
            this.mlblCancelar.Location = new System.Drawing.Point(1150, 22);
            this.mlblCancelar.Name = "mlblCancelar";
            this.mlblCancelar.Size = new System.Drawing.Size(120, 35);
            this.mlblCancelar.TabIndex = 146;
            this.mlblCancelar.Text = "Cancelar";
            this.mlblCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkCancelar
            // 
            this.mlnkCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCancelar.BackgroundImage")));
            this.mlnkCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkCancelar.Location = new System.Drawing.Point(1096, 9);
            this.mlnkCancelar.Name = "mlnkCancelar";
            this.mlnkCancelar.Size = new System.Drawing.Size(48, 48);
            this.mlnkCancelar.TabIndex = 147;
            this.mlnkCancelar.UseSelectable = true;
            this.mlnkCancelar.Click += new System.EventHandler(this.mlnkCancelar_Click);
            // 
            // mlblBuscarProducto
            // 
            this.mlblBuscarProducto.Location = new System.Drawing.Point(444, 22);
            this.mlblBuscarProducto.Name = "mlblBuscarProducto";
            this.mlblBuscarProducto.Size = new System.Drawing.Size(168, 35);
            this.mlblBuscarProducto.TabIndex = 144;
            this.mlblBuscarProducto.Text = "Buscar Producto";
            this.mlblBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkBuscarProducto
            // 
            this.mlnkBuscarProducto.BackgroundImage = global::IntegraPOS.Properties.Resources.F3Cir48x48;
            this.mlnkBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscarProducto.Location = new System.Drawing.Point(390, 9);
            this.mlnkBuscarProducto.Name = "mlnkBuscarProducto";
            this.mlnkBuscarProducto.Size = new System.Drawing.Size(48, 48);
            this.mlnkBuscarProducto.TabIndex = 143;
            this.mlnkBuscarProducto.UseSelectable = true;
            // 
            // mlblBuscarCliente
            // 
            this.mlblBuscarCliente.Location = new System.Drawing.Point(244, 22);
            this.mlblBuscarCliente.Name = "mlblBuscarCliente";
            this.mlblBuscarCliente.Size = new System.Drawing.Size(140, 35);
            this.mlblBuscarCliente.TabIndex = 127;
            this.mlblBuscarCliente.Text = "Buscar Cliente";
            this.mlblBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkBuscarCliente
            // 
            this.mlnkBuscarCliente.BackgroundImage = global::IntegraPOS.Properties.Resources.F2Cir48x48;
            this.mlnkBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscarCliente.Location = new System.Drawing.Point(190, 9);
            this.mlnkBuscarCliente.Name = "mlnkBuscarCliente";
            this.mlnkBuscarCliente.Size = new System.Drawing.Size(48, 48);
            this.mlnkBuscarCliente.TabIndex = 128;
            this.mlnkBuscarCliente.UseSelectable = true;
            // 
            // mcbFormaPago
            // 
            this.mcbFormaPago.BackColor = System.Drawing.Color.White;
            this.mcbFormaPago.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbFormaPago.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcbFormaPago.FormattingEnabled = true;
            this.mcbFormaPago.ItemHeight = 29;
            this.mcbFormaPago.Location = new System.Drawing.Point(149, 180);
            this.mcbFormaPago.Name = "mcbFormaPago";
            this.mcbFormaPago.Size = new System.Drawing.Size(140, 35);
            this.mcbFormaPago.Style = MetroFramework.MetroColorStyle.Blue;
            this.mcbFormaPago.TabIndex = 149;
            this.mcbFormaPago.UseSelectable = true;
            // 
            // mlblNuevaFact
            // 
            this.mlblNuevaFact.Location = new System.Drawing.Point(844, 22);
            this.mlblNuevaFact.Name = "mlblNuevaFact";
            this.mlblNuevaFact.Size = new System.Drawing.Size(164, 35);
            this.mlblNuevaFact.TabIndex = 129;
            this.mlblNuevaFact.Text = "Nueva Pedido";
            this.mlblNuevaFact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkNuevaFact
            // 
            this.mlnkNuevaFact.BackgroundImage = global::IntegraPOS.Properties.Resources.F10Cir48x48;
            this.mlnkNuevaFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkNuevaFact.Location = new System.Drawing.Point(790, 9);
            this.mlnkNuevaFact.Name = "mlnkNuevaFact";
            this.mlnkNuevaFact.Size = new System.Drawing.Size(48, 48);
            this.mlnkNuevaFact.TabIndex = 130;
            this.mlnkNuevaFact.UseSelectable = true;
            // 
            // mlblRecargar
            // 
            this.mlblRecargar.Location = new System.Drawing.Point(664, 22);
            this.mlblRecargar.Name = "mlblRecargar";
            this.mlblRecargar.Size = new System.Drawing.Size(120, 35);
            this.mlblRecargar.TabIndex = 131;
            this.mlblRecargar.Text = "Recargar";
            this.mlblRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkRecargar
            // 
            this.mlnkRecargar.BackgroundImage = global::IntegraPOS.Properties.Resources.F5Cir48x48;
            this.mlnkRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkRecargar.Location = new System.Drawing.Point(610, 9);
            this.mlnkRecargar.Name = "mlnkRecargar";
            this.mlnkRecargar.Size = new System.Drawing.Size(48, 48);
            this.mlnkRecargar.TabIndex = 132;
            this.mlnkRecargar.UseSelectable = true;
            // 
            // mtxtProducto
            // 
            // 
            // 
            // 
            this.mtxtProducto.CustomButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxtProducto.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.mtxtProducto.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.mtxtProducto.CustomButton.Name = "";
            this.mtxtProducto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtProducto.CustomButton.TabIndex = 1;
            this.mtxtProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtProducto.CustomButton.UseSelectable = true;
            this.mtxtProducto.CustomButton.Visible = false;
            this.mtxtProducto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxtProducto.Lines = new string[0];
            this.mtxtProducto.Location = new System.Drawing.Point(527, 395);
            this.mtxtProducto.MaxLength = 32767;
            this.mtxtProducto.Name = "mtxtProducto";
            this.mtxtProducto.PasswordChar = '\0';
            this.mtxtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtProducto.SelectedText = "";
            this.mtxtProducto.SelectionLength = 0;
            this.mtxtProducto.SelectionStart = 0;
            this.mtxtProducto.ShortcutsEnabled = true;
            this.mtxtProducto.Size = new System.Drawing.Size(322, 35);
            this.mtxtProducto.TabIndex = 153;
            this.mtxtProducto.UseSelectable = true;
            this.mtxtProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblGuardar
            // 
            this.mlblGuardar.Location = new System.Drawing.Point(64, 22);
            this.mlblGuardar.Name = "mlblGuardar";
            this.mlblGuardar.Size = new System.Drawing.Size(120, 35);
            this.mlblGuardar.TabIndex = 133;
            this.mlblGuardar.Text = "Guardar";
            this.mlblGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkGuardar
            // 
            this.mlnkGuardar.BackgroundImage = global::IntegraPOS.Properties.Resources.F1Cir48x48;
            this.mlnkGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkGuardar.Location = new System.Drawing.Point(10, 9);
            this.mlnkGuardar.Name = "mlnkGuardar";
            this.mlnkGuardar.Size = new System.Drawing.Size(48, 48);
            this.mlnkGuardar.TabIndex = 134;
            this.mlnkGuardar.UseSelectable = true;
            // 
            // mlblDescripNumTransaccion
            // 
            this.mlblDescripNumTransaccion.ForeColor = System.Drawing.Color.Maroon;
            this.mlblDescripNumTransaccion.Location = new System.Drawing.Point(1130, 80);
            this.mlblDescripNumTransaccion.Name = "mlblDescripNumTransaccion";
            this.mlblDescripNumTransaccion.Size = new System.Drawing.Size(140, 29);
            this.mlblDescripNumTransaccion.TabIndex = 135;
            this.mlblDescripNumTransaccion.Text = "PED-00006";
            this.mlblDescripNumTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblDescripNumTransaccion.UseCustomForeColor = true;
            // 
            // mcbBodega
            // 
            this.mcbBodega.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbBodega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcbBodega.FormattingEnabled = true;
            this.mcbBodega.ItemHeight = 29;
            this.mcbBodega.Location = new System.Drawing.Point(256, 395);
            this.mcbBodega.Name = "mcbBodega";
            this.mcbBodega.Size = new System.Drawing.Size(182, 35);
            this.mcbBodega.TabIndex = 152;
            this.mcbBodega.UseSelectable = true;
            // 
            // mlblProducto
            // 
            this.mlblProducto.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblProducto.Location = new System.Drawing.Point(420, 352);
            this.mlblProducto.Name = "mlblProducto";
            this.mlblProducto.Size = new System.Drawing.Size(160, 35);
            this.mlblProducto.TabIndex = 136;
            this.mlblProducto.Text = "Buscar Producto";
            this.mlblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlblBodega
            // 
            this.mlblBodega.Location = new System.Drawing.Point(150, 395);
            this.mlblBodega.Name = "mlblBodega";
            this.mlblBodega.Size = new System.Drawing.Size(100, 35);
            this.mlblBodega.TabIndex = 137;
            this.mlblBodega.Text = "Bodega";
            this.mlblBodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlblNumTransaccion
            // 
            this.mlblNumTransaccion.ForeColor = System.Drawing.Color.Maroon;
            this.mlblNumTransaccion.Location = new System.Drawing.Point(1056, 80);
            this.mlblNumTransaccion.Name = "mlblNumTransaccion";
            this.mlblNumTransaccion.Size = new System.Drawing.Size(68, 29);
            this.mlblNumTransaccion.TabIndex = 138;
            this.mlblNumTransaccion.Text = "# DOC";
            this.mlblNumTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblNumTransaccion.UseCustomForeColor = true;
            // 
            // mtxtAnotacion
            // 
            // 
            // 
            // 
            this.mtxtAnotacion.CustomButton.Image = null;
            this.mtxtAnotacion.CustomButton.Location = new System.Drawing.Point(644, 2);
            this.mtxtAnotacion.CustomButton.Name = "";
            this.mtxtAnotacion.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.mtxtAnotacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAnotacion.CustomButton.TabIndex = 1;
            this.mtxtAnotacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAnotacion.CustomButton.UseSelectable = true;
            this.mtxtAnotacion.CustomButton.Visible = false;
            this.mtxtAnotacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxtAnotacion.Lines = new string[0];
            this.mtxtAnotacion.Location = new System.Drawing.Point(149, 271);
            this.mtxtAnotacion.MaxLength = 32767;
            this.mtxtAnotacion.Multiline = true;
            this.mtxtAnotacion.Name = "mtxtAnotacion";
            this.mtxtAnotacion.PasswordChar = '\0';
            this.mtxtAnotacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAnotacion.SelectedText = "";
            this.mtxtAnotacion.SelectionLength = 0;
            this.mtxtAnotacion.SelectionStart = 0;
            this.mtxtAnotacion.ShortcutsEnabled = true;
            this.mtxtAnotacion.Size = new System.Drawing.Size(700, 58);
            this.mtxtAnotacion.TabIndex = 151;
            this.mtxtAnotacion.UseSelectable = true;
            this.mtxtAnotacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAnotacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblAnotacion
            // 
            this.mlblAnotacion.Location = new System.Drawing.Point(23, 271);
            this.mlblAnotacion.Name = "mlblAnotacion";
            this.mlblAnotacion.Size = new System.Drawing.Size(100, 29);
            this.mlblAnotacion.TabIndex = 139;
            this.mlblAnotacion.Text = "Anotación";
            this.mlblAnotacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mplTotales
            // 
            this.mplTotales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mplTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mplTotales.Controls.Add(this.mlblImpuestoGeneral);
            this.mplTotales.Controls.Add(this.mlblImpuesto);
            this.mplTotales.Controls.Add(this.mlblSubTotalGeneral);
            this.mplTotales.Controls.Add(this.mlblDescuentoGeneral);
            this.mplTotales.Controls.Add(this.mlblSubTotalDescGeneral);
            this.mplTotales.Controls.Add(this.mlblSubTotalDesc);
            this.mplTotales.Controls.Add(this.mlblDescuento);
            this.mplTotales.Controls.Add(this.mlblSubTotal);
            this.mplTotales.Controls.Add(this.mtileTotalFactura);
            this.mplTotales.HorizontalScrollbarBarColor = true;
            this.mplTotales.HorizontalScrollbarHighlightOnWheel = false;
            this.mplTotales.HorizontalScrollbarSize = 10;
            this.mplTotales.Location = new System.Drawing.Point(910, 130);
            this.mplTotales.Name = "mplTotales";
            this.mplTotales.Size = new System.Drawing.Size(360, 300);
            this.mplTotales.TabIndex = 140;
            this.mplTotales.UseCustomBackColor = true;
            this.mplTotales.VerticalScrollbarBarColor = true;
            this.mplTotales.VerticalScrollbarHighlightOnWheel = false;
            this.mplTotales.VerticalScrollbarSize = 10;
            // 
            // mlblImpuestoGeneral
            // 
            this.mlblImpuestoGeneral.Location = new System.Drawing.Point(194, 168);
            this.mlblImpuestoGeneral.Name = "mlblImpuestoGeneral";
            this.mlblImpuestoGeneral.Size = new System.Drawing.Size(140, 29);
            this.mlblImpuestoGeneral.TabIndex = 0;
            this.mlblImpuestoGeneral.Text = "0.00";
            this.mlblImpuestoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblImpuestoGeneral.UseCustomBackColor = true;
            // 
            // mlblImpuesto
            // 
            this.mlblImpuesto.Location = new System.Drawing.Point(28, 169);
            this.mlblImpuesto.Name = "mlblImpuesto";
            this.mlblImpuesto.Size = new System.Drawing.Size(160, 29);
            this.mlblImpuesto.TabIndex = 0;
            this.mlblImpuesto.Text = "Impuesto";
            this.mlblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblImpuesto.UseCustomBackColor = true;
            // 
            // mlblSubTotalGeneral
            // 
            this.mlblSubTotalGeneral.Location = new System.Drawing.Point(194, 20);
            this.mlblSubTotalGeneral.Name = "mlblSubTotalGeneral";
            this.mlblSubTotalGeneral.Size = new System.Drawing.Size(140, 29);
            this.mlblSubTotalGeneral.TabIndex = 0;
            this.mlblSubTotalGeneral.Text = "0.00";
            this.mlblSubTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblSubTotalGeneral.UseCustomBackColor = true;
            // 
            // mlblDescuentoGeneral
            // 
            this.mlblDescuentoGeneral.Location = new System.Drawing.Point(194, 71);
            this.mlblDescuentoGeneral.Name = "mlblDescuentoGeneral";
            this.mlblDescuentoGeneral.Size = new System.Drawing.Size(140, 29);
            this.mlblDescuentoGeneral.TabIndex = 0;
            this.mlblDescuentoGeneral.Text = "0.00";
            this.mlblDescuentoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblDescuentoGeneral.UseCustomBackColor = true;
            // 
            // mlblSubTotalDescGeneral
            // 
            this.mlblSubTotalDescGeneral.Location = new System.Drawing.Point(194, 120);
            this.mlblSubTotalDescGeneral.Name = "mlblSubTotalDescGeneral";
            this.mlblSubTotalDescGeneral.Size = new System.Drawing.Size(140, 29);
            this.mlblSubTotalDescGeneral.TabIndex = 0;
            this.mlblSubTotalDescGeneral.Text = "0.00";
            this.mlblSubTotalDescGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblSubTotalDescGeneral.UseCustomBackColor = true;
            // 
            // mlblSubTotalDesc
            // 
            this.mlblSubTotalDesc.Location = new System.Drawing.Point(28, 120);
            this.mlblSubTotalDesc.Name = "mlblSubTotalDesc";
            this.mlblSubTotalDesc.Size = new System.Drawing.Size(160, 29);
            this.mlblSubTotalDesc.TabIndex = 0;
            this.mlblSubTotalDesc.Text = "Sub - Descuento:";
            this.mlblSubTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblSubTotalDesc.UseCustomBackColor = true;
            // 
            // mlblDescuento
            // 
            this.mlblDescuento.Location = new System.Drawing.Point(28, 71);
            this.mlblDescuento.Name = "mlblDescuento";
            this.mlblDescuento.Size = new System.Drawing.Size(160, 29);
            this.mlblDescuento.TabIndex = 0;
            this.mlblDescuento.Text = "Descuento:";
            this.mlblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblDescuento.UseCustomBackColor = true;
            // 
            // mlblSubTotal
            // 
            this.mlblSubTotal.Location = new System.Drawing.Point(28, 20);
            this.mlblSubTotal.Name = "mlblSubTotal";
            this.mlblSubTotal.Size = new System.Drawing.Size(160, 29);
            this.mlblSubTotal.TabIndex = 0;
            this.mlblSubTotal.Text = "Sub Total:";
            this.mlblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblSubTotal.UseCustomBackColor = true;
            // 
            // mtileTotalFactura
            // 
            this.mtileTotalFactura.ActiveControl = null;
            this.mtileTotalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileTotalFactura.Location = new System.Drawing.Point(28, 219);
            this.mtileTotalFactura.Name = "mtileTotalFactura";
            this.mtileTotalFactura.Size = new System.Drawing.Size(306, 60);
            this.mtileTotalFactura.TabIndex = 0;
            this.mtileTotalFactura.Text = "TOTAL 0.00";
            this.mtileTotalFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileTotalFactura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileTotalFactura.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtileTotalFactura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtileTotalFactura.UseSelectable = true;
            // 
            // mgvProductos
            // 
            this.mgvProductos.AllowUserToAddRows = false;
            this.mgvProductos.AllowUserToDeleteRows = false;
            this.mgvProductos.AllowUserToResizeRows = false;
            this.mgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.mgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarRegistro,
            this.NumLinea,
            this.CodBodega,
            this.Bodega,
            this.CodigoSistema,
            this.CodigoPri,
            this.Descripcion,
            this.Unidad,
            this.Cantidad,
            this.Precio,
            this.Descuento,
            this.MonDescuentoLinea,
            this.Impuesto,
            this.MonImpuestoLinea,
            this.TotalLinea});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvProductos.DefaultCellStyle = dataGridViewCellStyle26;
            this.mgvProductos.EnableHeadersVisualStyles = false;
            this.mgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvProductos.Location = new System.Drawing.Point(10, 436);
            this.mgvProductos.Name = "mgvProductos";
            this.mgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.mgvProductos.RowHeadersVisible = false;
            this.mgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvProductos.Size = new System.Drawing.Size(1260, 309);
            this.mgvProductos.Style = MetroFramework.MetroColorStyle.Blue;
            this.mgvProductos.TabIndex = 154;
            this.mgvProductos.UseCustomBackColor = true;
            // 
            // EliminarRegistro
            // 
            this.EliminarRegistro.HeaderText = "";
            this.EliminarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("EliminarRegistro.Image")));
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Width = 24;
            // 
            // NumLinea
            // 
            this.NumLinea.HeaderText = "#";
            this.NumLinea.Name = "NumLinea";
            this.NumLinea.Width = 30;
            // 
            // CodBodega
            // 
            this.CodBodega.HeaderText = "Codigo Bodega";
            this.CodBodega.Name = "CodBodega";
            this.CodBodega.Visible = false;
            this.CodBodega.Width = 20;
            // 
            // Bodega
            // 
            this.Bodega.FillWeight = 200F;
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Width = 120;
            // 
            // CodigoSistema
            // 
            this.CodigoSistema.HeaderText = "Código Sistema";
            this.CodigoSistema.Name = "CodigoSistema";
            this.CodigoSistema.Visible = false;
            // 
            // CodigoPri
            // 
            this.CodigoPri.DataPropertyName = "prdChrCodigoPri";
            this.CodigoPri.HeaderText = "Item";
            this.CodigoPri.Name = "CodigoPri";
            this.CodigoPri.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "prdChrDescripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 346;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "undChrCodigo";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Unidad.DefaultCellStyle = dataGridViewCellStyle20;
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.Width = 95;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle21;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 75;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "prdMonPrecioBase";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle22;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 120;
            // 
            // Descuento
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle23;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 90;
            // 
            // MonDescuentoLinea
            // 
            this.MonDescuentoLinea.HeaderText = "Monto Descuento";
            this.MonDescuentoLinea.Name = "MonDescuentoLinea";
            this.MonDescuentoLinea.Visible = false;
            // 
            // Impuesto
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Impuesto.DefaultCellStyle = dataGridViewCellStyle24;
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Width = 90;
            // 
            // MonImpuestoLinea
            // 
            this.MonImpuestoLinea.HeaderText = "Monto Impuesto";
            this.MonImpuestoLinea.Name = "MonImpuestoLinea";
            this.MonImpuestoLinea.Visible = false;
            // 
            // TotalLinea
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalLinea.DefaultCellStyle = dataGridViewCellStyle25;
            this.TotalLinea.HeaderText = "Total";
            this.TotalLinea.Name = "TotalLinea";
            this.TotalLinea.Width = 150;
            // 
            // mlblFormaPago
            // 
            this.mlblFormaPago.Location = new System.Drawing.Point(23, 180);
            this.mlblFormaPago.Name = "mlblFormaPago";
            this.mlblFormaPago.Size = new System.Drawing.Size(120, 35);
            this.mlblFormaPago.TabIndex = 141;
            this.mlblFormaPago.Text = "Forma Pago";
            this.mlblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlblMoneda
            // 
            this.mlblMoneda.Location = new System.Drawing.Point(328, 180);
            this.mlblMoneda.Name = "mlblMoneda";
            this.mlblMoneda.Size = new System.Drawing.Size(95, 35);
            this.mlblMoneda.TabIndex = 142;
            this.mlblMoneda.Text = "Moneda";
            this.mlblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtCliente
            // 
            this.mtxtCliente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mtxtCliente.CustomButton.BackColor = System.Drawing.Color.White;
            this.mtxtCliente.CustomButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxtCliente.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.mtxtCliente.CustomButton.Location = new System.Drawing.Point(666, 1);
            this.mtxtCliente.CustomButton.Name = "";
            this.mtxtCliente.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCliente.CustomButton.TabIndex = 1;
            this.mtxtCliente.CustomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtxtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCliente.CustomButton.UseSelectable = true;
            this.mtxtCliente.CustomButton.UseVisualStyleBackColor = false;
            this.mtxtCliente.CustomButton.Visible = false;
            this.mtxtCliente.ForeColor = System.Drawing.Color.Maroon;
            this.mtxtCliente.Lines = new string[0];
            this.mtxtCliente.Location = new System.Drawing.Point(149, 130);
            this.mtxtCliente.MaxLength = 32767;
            this.mtxtCliente.Name = "mtxtCliente";
            this.mtxtCliente.PasswordChar = '\0';
            this.mtxtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCliente.SelectedText = "";
            this.mtxtCliente.SelectionLength = 0;
            this.mtxtCliente.SelectionStart = 0;
            this.mtxtCliente.ShortcutsEnabled = true;
            this.mtxtCliente.Size = new System.Drawing.Size(700, 35);
            this.mtxtCliente.TabIndex = 148;
            this.mtxtCliente.UseSelectable = true;
            this.mtxtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblCliente
            // 
            this.mlblCliente.Location = new System.Drawing.Point(23, 130);
            this.mlblCliente.Name = "mlblCliente";
            this.mlblCliente.Size = new System.Drawing.Size(100, 35);
            this.mlblCliente.TabIndex = 145;
            this.mlblCliente.Text = "Cliente";
            this.mlblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPedidoMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlnkBusqProducto);
            this.Controls.Add(this.mlnkBusqCliente);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.mcbTipoTasa);
            this.Controls.Add(this.mcbMoneda);
            this.Controls.Add(this.mcbMonedaError);
            this.Controls.Add(this.mtxtValorTasaError);
            this.Controls.Add(this.mcbTipoTasaError);
            this.Controls.Add(this.mlblTipoTasa);
            this.Controls.Add(this.mcbBodegaError);
            this.Controls.Add(this.mtxtClienteError);
            this.Controls.Add(this.mcbFormaPagoError);
            this.Controls.Add(this.mtileLinea);
            this.Controls.Add(this.mlblLineaBusc02);
            this.Controls.Add(this.mlblLineaBusc01);
            this.Controls.Add(this.mtxtValorTasa);
            this.Controls.Add(this.mlblValorTasa);
            this.Controls.Add(this.mlblCancelar);
            this.Controls.Add(this.mlnkCancelar);
            this.Controls.Add(this.mlblBuscarProducto);
            this.Controls.Add(this.mlnkBuscarProducto);
            this.Controls.Add(this.mlblBuscarCliente);
            this.Controls.Add(this.mlnkBuscarCliente);
            this.Controls.Add(this.mcbFormaPago);
            this.Controls.Add(this.mlblNuevaFact);
            this.Controls.Add(this.mlnkNuevaFact);
            this.Controls.Add(this.mlblRecargar);
            this.Controls.Add(this.mlnkRecargar);
            this.Controls.Add(this.mtxtProducto);
            this.Controls.Add(this.mlblGuardar);
            this.Controls.Add(this.mlnkGuardar);
            this.Controls.Add(this.mlblDescripNumTransaccion);
            this.Controls.Add(this.mcbBodega);
            this.Controls.Add(this.mlblProducto);
            this.Controls.Add(this.mlblBodega);
            this.Controls.Add(this.mlblNumTransaccion);
            this.Controls.Add(this.mtxtAnotacion);
            this.Controls.Add(this.mlblAnotacion);
            this.Controls.Add(this.mplTotales);
            this.Controls.Add(this.mgvProductos);
            this.Controls.Add(this.mlblFormaPago);
            this.Controls.Add(this.mlblMoneda);
            this.Controls.Add(this.mtxtCliente);
            this.Controls.Add(this.mlblCliente);
            this.Name = "frmPedidoMant";
            this.Text = "";
            this.mplTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlnkBusqProducto;
        private MetroFramework.Controls.MetroLink mlnkBusqCliente;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroComboBox mcbTipoTasa;
        private MetroFramework.Controls.MetroComboBox mcbMoneda;
        private MetroFramework.Controls.MetroLabel mcbMonedaError;
        private MetroFramework.Controls.MetroLabel mtxtValorTasaError;
        private MetroFramework.Controls.MetroLabel mcbTipoTasaError;
        private MetroFramework.Controls.MetroLabel mlblTipoTasa;
        private MetroFramework.Controls.MetroLabel mcbBodegaError;
        private MetroFramework.Controls.MetroLabel mtxtClienteError;
        private MetroFramework.Controls.MetroLabel mcbFormaPagoError;
        private MetroFramework.Controls.MetroTile mtileLinea;
        private MetroFramework.Controls.MetroLabel mlblLineaBusc02;
        private MetroFramework.Controls.MetroLabel mlblLineaBusc01;
        private MetroFramework.Controls.MetroTextBox mtxtValorTasa;
        private MetroFramework.Controls.MetroLabel mlblValorTasa;
        private MetroFramework.Controls.MetroLabel mlblCancelar;
        private MetroFramework.Controls.MetroLink mlnkCancelar;
        private MetroFramework.Controls.MetroLabel mlblBuscarProducto;
        private MetroFramework.Controls.MetroLink mlnkBuscarProducto;
        private MetroFramework.Controls.MetroLabel mlblBuscarCliente;
        private MetroFramework.Controls.MetroLink mlnkBuscarCliente;
        private MetroFramework.Controls.MetroComboBox mcbFormaPago;
        private MetroFramework.Controls.MetroLabel mlblNuevaFact;
        private MetroFramework.Controls.MetroLink mlnkNuevaFact;
        private MetroFramework.Controls.MetroLabel mlblRecargar;
        private MetroFramework.Controls.MetroLink mlnkRecargar;
        private MetroFramework.Controls.MetroTextBox mtxtProducto;
        private MetroFramework.Controls.MetroLabel mlblGuardar;
        private MetroFramework.Controls.MetroLink mlnkGuardar;
        private MetroFramework.Controls.MetroLabel mlblDescripNumTransaccion;
        private MetroFramework.Controls.MetroComboBox mcbBodega;
        private MetroFramework.Controls.MetroLabel mlblProducto;
        private MetroFramework.Controls.MetroLabel mlblBodega;
        private MetroFramework.Controls.MetroLabel mlblNumTransaccion;
        private MetroFramework.Controls.MetroTextBox mtxtAnotacion;
        private MetroFramework.Controls.MetroLabel mlblAnotacion;
        private MetroFramework.Controls.MetroPanel mplTotales;
        private MetroFramework.Controls.MetroLabel mlblImpuestoGeneral;
        private MetroFramework.Controls.MetroLabel mlblImpuesto;
        private MetroFramework.Controls.MetroLabel mlblSubTotalGeneral;
        private MetroFramework.Controls.MetroLabel mlblDescuentoGeneral;
        private MetroFramework.Controls.MetroLabel mlblSubTotalDescGeneral;
        private MetroFramework.Controls.MetroLabel mlblSubTotalDesc;
        private MetroFramework.Controls.MetroLabel mlblDescuento;
        private MetroFramework.Controls.MetroLabel mlblSubTotal;
        private MetroFramework.Controls.MetroTile mtileTotalFactura;
        private MetroFramework.Controls.MetroGrid mgvProductos;
        private System.Windows.Forms.DataGridViewImageColumn EliminarRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonDescuentoLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonImpuestoLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLinea;
        private MetroFramework.Controls.MetroLabel mlblFormaPago;
        private MetroFramework.Controls.MetroLabel mlblMoneda;
        private MetroFramework.Controls.MetroTextBox mtxtCliente;
        private MetroFramework.Controls.MetroLabel mlblCliente;
    }
}
