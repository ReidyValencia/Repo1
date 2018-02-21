namespace IntegraPOS.Pages.Forms.Mants
{
    partial class frmReciboMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReciboMant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mlnkBusqCliente = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.mcbTipoTasa = new MetroFramework.Controls.MetroComboBox();
            this.mcbMoneda = new MetroFramework.Controls.MetroComboBox();
            this.mcbMonedaError = new MetroFramework.Controls.MetroLabel();
            this.mtxtValorTasaError = new MetroFramework.Controls.MetroLabel();
            this.mcbTipoTasaError = new MetroFramework.Controls.MetroLabel();
            this.mlblTipoTasa = new MetroFramework.Controls.MetroLabel();
            this.mtxtClienteError = new MetroFramework.Controls.MetroLabel();
            this.mtileLinea = new MetroFramework.Controls.MetroTile();
            this.mtxtValorTasa = new MetroFramework.Controls.MetroTextBox();
            this.mlblValorTasa = new MetroFramework.Controls.MetroLabel();
            this.mlblCancelar = new MetroFramework.Controls.MetroLabel();
            this.mlnkCancelar = new MetroFramework.Controls.MetroLink();
            this.mlblBuscarCliente = new MetroFramework.Controls.MetroLabel();
            this.mlnkBuscarCliente = new MetroFramework.Controls.MetroLink();
            this.mlblRecargar = new MetroFramework.Controls.MetroLabel();
            this.mlnkRecargar = new MetroFramework.Controls.MetroLink();
            this.mlblGuardar = new MetroFramework.Controls.MetroLabel();
            this.mlnkGuardar = new MetroFramework.Controls.MetroLink();
            this.mlblDescripNumTransaccion = new MetroFramework.Controls.MetroLabel();
            this.mlblNumTransaccion = new MetroFramework.Controls.MetroLabel();
            this.mplTotales = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mlblImpuestoGeneral = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlblImpuesto = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotalGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblDescuentoGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotalDescGeneral = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotalDesc = new MetroFramework.Controls.MetroLabel();
            this.mlblDescuento = new MetroFramework.Controls.MetroLabel();
            this.mlblSubTotal = new MetroFramework.Controls.MetroLabel();
            this.mtileTotalFactura = new MetroFramework.Controls.MetroTile();
            this.mgvDocumentos = new MetroFramework.Controls.MetroGrid();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.mlblMoneda = new MetroFramework.Controls.MetroLabel();
            this.mtxtCliente = new MetroFramework.Controls.MetroTextBox();
            this.mlblCliente = new MetroFramework.Controls.MetroLabel();
            this.mtxtAnotacion = new MetroFramework.Controls.MetroTextBox();
            this.mlblAnotacion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.mplTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // mlnkBusqCliente
            // 
            this.mlnkBusqCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBusqCliente.BackgroundImage")));
            this.mlnkBusqCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBusqCliente.Location = new System.Drawing.Point(855, 137);
            this.mlnkBusqCliente.Name = "mlnkBusqCliente";
            this.mlnkBusqCliente.Size = new System.Drawing.Size(29, 35);
            this.mlnkBusqCliente.TabIndex = 125;
            this.mlnkBusqCliente.UseSelectable = true;
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(540, 75);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(200, 44);
            this.mlblTitulo.TabIndex = 124;
            this.mlblTitulo.Text = "Recibo";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcbTipoTasa
            // 
            this.mcbTipoTasa.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbTipoTasa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcbTipoTasa.FormattingEnabled = true;
            this.mcbTipoTasa.ItemHeight = 29;
            this.mcbTipoTasa.Location = new System.Drawing.Point(149, 372);
            this.mcbTipoTasa.Name = "mcbTipoTasa";
            this.mcbTipoTasa.Size = new System.Drawing.Size(140, 35);
            this.mcbTipoTasa.TabIndex = 123;
            this.mcbTipoTasa.UseSelectable = true;
            // 
            // mcbMoneda
            // 
            this.mcbMoneda.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcbMoneda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcbMoneda.FormattingEnabled = true;
            this.mcbMoneda.ItemHeight = 29;
            this.mcbMoneda.Location = new System.Drawing.Point(149, 322);
            this.mcbMoneda.Name = "mcbMoneda";
            this.mcbMoneda.Size = new System.Drawing.Size(140, 35);
            this.mcbMoneda.TabIndex = 122;
            this.mcbMoneda.UseSelectable = true;
            // 
            // mcbMonedaError
            // 
            this.mcbMonedaError.BackColor = System.Drawing.Color.White;
            this.mcbMonedaError.ForeColor = System.Drawing.Color.Maroon;
            this.mcbMonedaError.Location = new System.Drawing.Point(295, 322);
            this.mcbMonedaError.Name = "mcbMonedaError";
            this.mcbMonedaError.Size = new System.Drawing.Size(14, 19);
            this.mcbMonedaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mcbMonedaError.TabIndex = 121;
            this.mcbMonedaError.Text = "*";
            this.mcbMonedaError.UseCustomForeColor = true;
            this.mcbMonedaError.Visible = false;
            // 
            // mtxtValorTasaError
            // 
            this.mtxtValorTasaError.BackColor = System.Drawing.Color.White;
            this.mtxtValorTasaError.ForeColor = System.Drawing.Color.Maroon;
            this.mtxtValorTasaError.Location = new System.Drawing.Point(590, 372);
            this.mtxtValorTasaError.Name = "mtxtValorTasaError";
            this.mtxtValorTasaError.Size = new System.Drawing.Size(14, 19);
            this.mtxtValorTasaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mtxtValorTasaError.TabIndex = 120;
            this.mtxtValorTasaError.Text = "*";
            this.mtxtValorTasaError.UseCustomForeColor = true;
            this.mtxtValorTasaError.Visible = false;
            // 
            // mcbTipoTasaError
            // 
            this.mcbTipoTasaError.BackColor = System.Drawing.Color.White;
            this.mcbTipoTasaError.ForeColor = System.Drawing.Color.Maroon;
            this.mcbTipoTasaError.Location = new System.Drawing.Point(295, 372);
            this.mcbTipoTasaError.Name = "mcbTipoTasaError";
            this.mcbTipoTasaError.Size = new System.Drawing.Size(14, 19);
            this.mcbTipoTasaError.Style = MetroFramework.MetroColorStyle.Black;
            this.mcbTipoTasaError.TabIndex = 119;
            this.mcbTipoTasaError.Text = "*";
            this.mcbTipoTasaError.UseCustomForeColor = true;
            this.mcbTipoTasaError.Visible = false;
            // 
            // mlblTipoTasa
            // 
            this.mlblTipoTasa.Location = new System.Drawing.Point(23, 372);
            this.mlblTipoTasa.Name = "mlblTipoTasa";
            this.mlblTipoTasa.Size = new System.Drawing.Size(100, 35);
            this.mlblTipoTasa.TabIndex = 118;
            this.mlblTipoTasa.Text = "Tipo Tasa";
            this.mlblTipoTasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtClienteError
            // 
            this.mtxtClienteError.BackColor = System.Drawing.Color.White;
            this.mtxtClienteError.ForeColor = System.Drawing.Color.Maroon;
            this.mtxtClienteError.Location = new System.Drawing.Point(879, 137);
            this.mtxtClienteError.Name = "mtxtClienteError";
            this.mtxtClienteError.Size = new System.Drawing.Size(14, 19);
            this.mtxtClienteError.Style = MetroFramework.MetroColorStyle.Black;
            this.mtxtClienteError.TabIndex = 116;
            this.mtxtClienteError.Text = "*";
            this.mtxtClienteError.UseCustomForeColor = true;
            this.mtxtClienteError.Visible = false;
            // 
            // mtileLinea
            // 
            this.mtileLinea.ActiveControl = null;
            this.mtileLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileLinea.Location = new System.Drawing.Point(10, 68);
            this.mtileLinea.Name = "mtileLinea";
            this.mtileLinea.Size = new System.Drawing.Size(1260, 5);
            this.mtileLinea.TabIndex = 114;
            this.mtileLinea.Text = "metroTile1";
            this.mtileLinea.UseSelectable = true;
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
            this.mtxtValorTasa.Location = new System.Drawing.Point(444, 372);
            this.mtxtValorTasa.MaxLength = 32767;
            this.mtxtValorTasa.Name = "mtxtValorTasa";
            this.mtxtValorTasa.PasswordChar = '\0';
            this.mtxtValorTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValorTasa.SelectedText = "";
            this.mtxtValorTasa.SelectionLength = 0;
            this.mtxtValorTasa.SelectionStart = 0;
            this.mtxtValorTasa.ShortcutsEnabled = true;
            this.mtxtValorTasa.Size = new System.Drawing.Size(140, 35);
            this.mtxtValorTasa.TabIndex = 106;
            this.mtxtValorTasa.UseSelectable = true;
            this.mtxtValorTasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtValorTasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblValorTasa
            // 
            this.mlblValorTasa.Location = new System.Drawing.Point(338, 372);
            this.mlblValorTasa.Name = "mlblValorTasa";
            this.mlblValorTasa.Size = new System.Drawing.Size(98, 35);
            this.mlblValorTasa.TabIndex = 111;
            this.mlblValorTasa.Text = "Valor Tasa";
            this.mlblValorTasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlblCancelar
            // 
            this.mlblCancelar.Location = new System.Drawing.Point(1150, 29);
            this.mlblCancelar.Name = "mlblCancelar";
            this.mlblCancelar.Size = new System.Drawing.Size(120, 35);
            this.mlblCancelar.TabIndex = 102;
            this.mlblCancelar.Text = "Cancelar";
            this.mlblCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkCancelar
            // 
            this.mlnkCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCancelar.BackgroundImage")));
            this.mlnkCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkCancelar.Location = new System.Drawing.Point(1096, 16);
            this.mlnkCancelar.Name = "mlnkCancelar";
            this.mlnkCancelar.Size = new System.Drawing.Size(48, 48);
            this.mlnkCancelar.TabIndex = 103;
            this.mlnkCancelar.UseSelectable = true;
            this.mlnkCancelar.Click += new System.EventHandler(this.mlnkCancelar_Click);
            // 
            // mlblBuscarCliente
            // 
            this.mlblBuscarCliente.Location = new System.Drawing.Point(244, 29);
            this.mlblBuscarCliente.Name = "mlblBuscarCliente";
            this.mlblBuscarCliente.Size = new System.Drawing.Size(140, 35);
            this.mlblBuscarCliente.TabIndex = 83;
            this.mlblBuscarCliente.Text = "Buscar Cliente";
            this.mlblBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkBuscarCliente
            // 
            this.mlnkBuscarCliente.BackgroundImage = global::IntegraPOS.Properties.Resources.F2Cir48x48;
            this.mlnkBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscarCliente.Location = new System.Drawing.Point(190, 16);
            this.mlnkBuscarCliente.Name = "mlnkBuscarCliente";
            this.mlnkBuscarCliente.Size = new System.Drawing.Size(48, 48);
            this.mlnkBuscarCliente.TabIndex = 84;
            this.mlnkBuscarCliente.UseSelectable = true;
            // 
            // mlblRecargar
            // 
            this.mlblRecargar.Location = new System.Drawing.Point(444, 29);
            this.mlblRecargar.Name = "mlblRecargar";
            this.mlblRecargar.Size = new System.Drawing.Size(120, 35);
            this.mlblRecargar.TabIndex = 87;
            this.mlblRecargar.Text = "Recargar";
            this.mlblRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkRecargar
            // 
            this.mlnkRecargar.BackgroundImage = global::IntegraPOS.Properties.Resources.F5Cir48x48;
            this.mlnkRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkRecargar.Location = new System.Drawing.Point(390, 16);
            this.mlnkRecargar.Name = "mlnkRecargar";
            this.mlnkRecargar.Size = new System.Drawing.Size(48, 48);
            this.mlnkRecargar.TabIndex = 88;
            this.mlnkRecargar.UseSelectable = true;
            // 
            // mlblGuardar
            // 
            this.mlblGuardar.Location = new System.Drawing.Point(64, 29);
            this.mlblGuardar.Name = "mlblGuardar";
            this.mlblGuardar.Size = new System.Drawing.Size(120, 35);
            this.mlblGuardar.TabIndex = 89;
            this.mlblGuardar.Text = "Guardar";
            this.mlblGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkGuardar
            // 
            this.mlnkGuardar.BackgroundImage = global::IntegraPOS.Properties.Resources.F1Cir48x48;
            this.mlnkGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkGuardar.Location = new System.Drawing.Point(10, 16);
            this.mlnkGuardar.Name = "mlnkGuardar";
            this.mlnkGuardar.Size = new System.Drawing.Size(48, 48);
            this.mlnkGuardar.TabIndex = 90;
            this.mlnkGuardar.UseSelectable = true;
            // 
            // mlblDescripNumTransaccion
            // 
            this.mlblDescripNumTransaccion.ForeColor = System.Drawing.Color.Maroon;
            this.mlblDescripNumTransaccion.Location = new System.Drawing.Point(1130, 87);
            this.mlblDescripNumTransaccion.Name = "mlblDescripNumTransaccion";
            this.mlblDescripNumTransaccion.Size = new System.Drawing.Size(140, 29);
            this.mlblDescripNumTransaccion.TabIndex = 91;
            this.mlblDescripNumTransaccion.Text = "FAC-00006";
            this.mlblDescripNumTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblDescripNumTransaccion.UseCustomForeColor = true;
            // 
            // mlblNumTransaccion
            // 
            this.mlblNumTransaccion.ForeColor = System.Drawing.Color.Maroon;
            this.mlblNumTransaccion.Location = new System.Drawing.Point(1056, 87);
            this.mlblNumTransaccion.Name = "mlblNumTransaccion";
            this.mlblNumTransaccion.Size = new System.Drawing.Size(68, 29);
            this.mlblNumTransaccion.TabIndex = 94;
            this.mlblNumTransaccion.Text = "# DOC";
            this.mlblNumTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblNumTransaccion.UseCustomForeColor = true;
            // 
            // mplTotales
            // 
            this.mplTotales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mplTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mplTotales.Controls.Add(this.metroLabel4);
            this.mplTotales.Controls.Add(this.mlblImpuestoGeneral);
            this.mplTotales.Controls.Add(this.metroLabel3);
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
            this.mplTotales.Location = new System.Drawing.Point(910, 137);
            this.mplTotales.Name = "mplTotales";
            this.mplTotales.Size = new System.Drawing.Size(360, 300);
            this.mplTotales.TabIndex = 96;
            this.mplTotales.UseCustomBackColor = true;
            this.mplTotales.VerticalScrollbarBarColor = true;
            this.mplTotales.VerticalScrollbarHighlightOnWheel = false;
            this.mplTotales.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(197, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(140, 35);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "0.00";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // mlblImpuestoGeneral
            // 
            this.mlblImpuestoGeneral.Location = new System.Drawing.Point(197, 145);
            this.mlblImpuestoGeneral.Name = "mlblImpuestoGeneral";
            this.mlblImpuestoGeneral.Size = new System.Drawing.Size(140, 35);
            this.mlblImpuestoGeneral.TabIndex = 0;
            this.mlblImpuestoGeneral.Text = "0.00";
            this.mlblImpuestoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblImpuestoGeneral.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(23, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(200, 35);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Total recibo:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // mlblImpuesto
            // 
            this.mlblImpuesto.Location = new System.Drawing.Point(23, 145);
            this.mlblImpuesto.Name = "mlblImpuesto";
            this.mlblImpuesto.Size = new System.Drawing.Size(200, 35);
            this.mlblImpuesto.TabIndex = 0;
            this.mlblImpuesto.Text = "Apl. saldo a favor:";
            this.mlblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblImpuesto.UseCustomBackColor = true;
            // 
            // mlblSubTotalGeneral
            // 
            this.mlblSubTotalGeneral.Location = new System.Drawing.Point(197, 10);
            this.mlblSubTotalGeneral.Name = "mlblSubTotalGeneral";
            this.mlblSubTotalGeneral.Size = new System.Drawing.Size(140, 35);
            this.mlblSubTotalGeneral.TabIndex = 0;
            this.mlblSubTotalGeneral.Text = "0.00";
            this.mlblSubTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblSubTotalGeneral.UseCustomBackColor = true;
            // 
            // mlblDescuentoGeneral
            // 
            this.mlblDescuentoGeneral.Location = new System.Drawing.Point(197, 55);
            this.mlblDescuentoGeneral.Name = "mlblDescuentoGeneral";
            this.mlblDescuentoGeneral.Size = new System.Drawing.Size(140, 35);
            this.mlblDescuentoGeneral.TabIndex = 0;
            this.mlblDescuentoGeneral.Text = "0.00";
            this.mlblDescuentoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblDescuentoGeneral.UseCustomBackColor = true;
            // 
            // mlblSubTotalDescGeneral
            // 
            this.mlblSubTotalDescGeneral.Location = new System.Drawing.Point(197, 100);
            this.mlblSubTotalDescGeneral.Name = "mlblSubTotalDescGeneral";
            this.mlblSubTotalDescGeneral.Size = new System.Drawing.Size(140, 35);
            this.mlblSubTotalDescGeneral.TabIndex = 0;
            this.mlblSubTotalDescGeneral.Text = "0.00";
            this.mlblSubTotalDescGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlblSubTotalDescGeneral.UseCustomBackColor = true;
            // 
            // mlblSubTotalDesc
            // 
            this.mlblSubTotalDesc.Location = new System.Drawing.Point(23, 100);
            this.mlblSubTotalDesc.Name = "mlblSubTotalDesc";
            this.mlblSubTotalDesc.Size = new System.Drawing.Size(200, 35);
            this.mlblSubTotalDesc.TabIndex = 0;
            this.mlblSubTotalDesc.Text = "Saldo actual:";
            this.mlblSubTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblSubTotalDesc.UseCustomBackColor = true;
            // 
            // mlblDescuento
            // 
            this.mlblDescuento.Location = new System.Drawing.Point(23, 55);
            this.mlblDescuento.Name = "mlblDescuento";
            this.mlblDescuento.Size = new System.Drawing.Size(200, 35);
            this.mlblDescuento.TabIndex = 0;
            this.mlblDescuento.Text = "Sub total recibo:";
            this.mlblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblDescuento.UseCustomBackColor = true;
            // 
            // mlblSubTotal
            // 
            this.mlblSubTotal.Location = new System.Drawing.Point(23, 10);
            this.mlblSubTotal.Name = "mlblSubTotal";
            this.mlblSubTotal.Size = new System.Drawing.Size(200, 35);
            this.mlblSubTotal.TabIndex = 0;
            this.mlblSubTotal.Text = "Total deuda:";
            this.mlblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlblSubTotal.UseCustomBackColor = true;
            // 
            // mtileTotalFactura
            // 
            this.mtileTotalFactura.ActiveControl = null;
            this.mtileTotalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileTotalFactura.Location = new System.Drawing.Point(23, 228);
            this.mtileTotalFactura.Name = "mtileTotalFactura";
            this.mtileTotalFactura.Size = new System.Drawing.Size(314, 60);
            this.mtileTotalFactura.TabIndex = 0;
            this.mtileTotalFactura.Text = "TOTAL 0.00";
            this.mtileTotalFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileTotalFactura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileTotalFactura.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtileTotalFactura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtileTotalFactura.UseSelectable = true;
            // 
            // mgvDocumentos
            // 
            this.mgvDocumentos.AllowUserToAddRows = false;
            this.mgvDocumentos.AllowUserToDeleteRows = false;
            this.mgvDocumentos.AllowUserToResizeRows = false;
            this.mgvDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linea,
            this.NumDocumento,
            this.Fecha,
            this.FechaVencimiento,
            this.DiasMora,
            this.Cliente,
            this.Saldo,
            this.Abono,
            this.Totalizar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvDocumentos.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgvDocumentos.EnableHeadersVisualStyles = false;
            this.mgvDocumentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvDocumentos.Location = new System.Drawing.Point(10, 443);
            this.mgvDocumentos.Name = "mgvDocumentos";
            this.mgvDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgvDocumentos.RowHeadersVisible = false;
            this.mgvDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvDocumentos.Size = new System.Drawing.Size(1260, 309);
            this.mgvDocumentos.Style = MetroFramework.MetroColorStyle.Blue;
            this.mgvDocumentos.TabIndex = 110;
            this.mgvDocumentos.UseCustomBackColor = true;
            // 
            // Linea
            // 
            this.Linea.DataPropertyName = "Linea";
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 60;
            // 
            // NumDocumento
            // 
            this.NumDocumento.DataPropertyName = "NumDocumento";
            this.NumDocumento.HeaderText = "# Doc.";
            this.NumDocumento.Name = "NumDocumento";
            this.NumDocumento.ReadOnly = true;
            this.NumDocumento.Width = 140;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.DataPropertyName = "FechaVenc";
            this.FechaVencimiento.HeaderText = "Fec. Venc.";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Width = 120;
            // 
            // DiasMora
            // 
            this.DiasMora.DataPropertyName = "DiasMora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiasMora.DefaultCellStyle = dataGridViewCellStyle2;
            this.DiasMora.HeaderText = "Días Mora";
            this.DiasMora.Name = "DiasMora";
            this.DiasMora.ReadOnly = true;
            this.DiasMora.Width = 120;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 283;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 160;
            // 
            // Abono
            // 
            this.Abono.DataPropertyName = "Abono";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Abono.DefaultCellStyle = dataGridViewCellStyle4;
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            this.Abono.Width = 160;
            // 
            // Totalizar
            // 
            this.Totalizar.DataPropertyName = "Totalizar";
            this.Totalizar.HeaderText = "T";
            this.Totalizar.Image = ((System.Drawing.Image)(resources.GetObject("Totalizar.Image")));
            this.Totalizar.Name = "Totalizar";
            this.Totalizar.Width = 80;
            // 
            // mlblMoneda
            // 
            this.mlblMoneda.Location = new System.Drawing.Point(23, 322);
            this.mlblMoneda.Name = "mlblMoneda";
            this.mlblMoneda.Size = new System.Drawing.Size(100, 35);
            this.mlblMoneda.TabIndex = 98;
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
            this.mtxtCliente.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.mtxtCliente.Location = new System.Drawing.Point(149, 137);
            this.mtxtCliente.MaxLength = 32767;
            this.mtxtCliente.Name = "mtxtCliente";
            this.mtxtCliente.PasswordChar = '\0';
            this.mtxtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCliente.SelectedText = "";
            this.mtxtCliente.SelectionLength = 0;
            this.mtxtCliente.SelectionStart = 0;
            this.mtxtCliente.ShortcutsEnabled = true;
            this.mtxtCliente.Size = new System.Drawing.Size(700, 35);
            this.mtxtCliente.TabIndex = 104;
            this.mtxtCliente.UseSelectable = true;
            this.mtxtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblCliente
            // 
            this.mlblCliente.Location = new System.Drawing.Point(23, 137);
            this.mlblCliente.Name = "mlblCliente";
            this.mlblCliente.Size = new System.Drawing.Size(100, 35);
            this.mlblCliente.TabIndex = 101;
            this.mlblCliente.Text = "Cliente";
            this.mlblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtAnotacion
            // 
            // 
            // 
            // 
            this.mtxtAnotacion.CustomButton.Image = null;
            this.mtxtAnotacion.CustomButton.Location = new System.Drawing.Point(632, 2);
            this.mtxtAnotacion.CustomButton.Name = "";
            this.mtxtAnotacion.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.mtxtAnotacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtAnotacion.CustomButton.TabIndex = 1;
            this.mtxtAnotacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtAnotacion.CustomButton.UseSelectable = true;
            this.mtxtAnotacion.CustomButton.Visible = false;
            this.mtxtAnotacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtxtAnotacion.Lines = new string[0];
            this.mtxtAnotacion.Location = new System.Drawing.Point(149, 237);
            this.mtxtAnotacion.MaxLength = 32767;
            this.mtxtAnotacion.Multiline = true;
            this.mtxtAnotacion.Name = "mtxtAnotacion";
            this.mtxtAnotacion.PasswordChar = '\0';
            this.mtxtAnotacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtAnotacion.SelectedText = "";
            this.mtxtAnotacion.SelectionLength = 0;
            this.mtxtAnotacion.SelectionStart = 0;
            this.mtxtAnotacion.ShortcutsEnabled = true;
            this.mtxtAnotacion.Size = new System.Drawing.Size(700, 70);
            this.mtxtAnotacion.TabIndex = 107;
            this.mtxtAnotacion.UseSelectable = true;
            this.mtxtAnotacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtAnotacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlblAnotacion
            // 
            this.mlblAnotacion.Location = new System.Drawing.Point(23, 237);
            this.mlblAnotacion.Name = "mlblAnotacion";
            this.mlblAnotacion.Size = new System.Drawing.Size(100, 29);
            this.mlblAnotacion.TabIndex = 95;
            this.mlblAnotacion.Text = "Anotación";
            this.mlblAnotacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 187);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 35);
            this.metroLabel1.TabIndex = 101;
            this.metroLabel1.Text = "Cobrador";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.BackColor = System.Drawing.Color.White;
            this.metroTextBox1.CustomButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.metroTextBox1.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(666, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(149, 187);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(700, 35);
            this.metroTextBox1.TabIndex = 104;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(338, 322);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 35);
            this.metroLabel2.TabIndex = 101;
            this.metroLabel2.Text = "Caja";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.BackColor = System.Drawing.Color.White;
            this.metroTextBox2.CustomButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.metroTextBox2.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.ForeColor = System.Drawing.Color.Maroon;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(444, 322);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(405, 35);
            this.metroTextBox2.TabIndex = 104;
            this.metroTextBox2.UseCustomBackColor = true;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmReciboMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlnkBusqCliente);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.mcbTipoTasa);
            this.Controls.Add(this.mcbMoneda);
            this.Controls.Add(this.mcbMonedaError);
            this.Controls.Add(this.mtxtValorTasaError);
            this.Controls.Add(this.mcbTipoTasaError);
            this.Controls.Add(this.mlblTipoTasa);
            this.Controls.Add(this.mtxtClienteError);
            this.Controls.Add(this.mtileLinea);
            this.Controls.Add(this.mtxtValorTasa);
            this.Controls.Add(this.mlblValorTasa);
            this.Controls.Add(this.mlblCancelar);
            this.Controls.Add(this.mlnkCancelar);
            this.Controls.Add(this.mlblBuscarCliente);
            this.Controls.Add(this.mlnkBuscarCliente);
            this.Controls.Add(this.mlblRecargar);
            this.Controls.Add(this.mlnkRecargar);
            this.Controls.Add(this.mlblGuardar);
            this.Controls.Add(this.mlnkGuardar);
            this.Controls.Add(this.mlblDescripNumTransaccion);
            this.Controls.Add(this.mlblNumTransaccion);
            this.Controls.Add(this.mtxtAnotacion);
            this.Controls.Add(this.mlblAnotacion);
            this.Controls.Add(this.mplTotales);
            this.Controls.Add(this.mgvDocumentos);
            this.Controls.Add(this.mlblMoneda);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.mtxtCliente);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mlblCliente);
            this.Name = "frmReciboMant";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmReciboMant_Load);
            this.mplTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlnkBusqCliente;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroComboBox mcbTipoTasa;
        private MetroFramework.Controls.MetroComboBox mcbMoneda;
        private MetroFramework.Controls.MetroLabel mcbMonedaError;
        private MetroFramework.Controls.MetroLabel mtxtValorTasaError;
        private MetroFramework.Controls.MetroLabel mcbTipoTasaError;
        private MetroFramework.Controls.MetroLabel mlblTipoTasa;
        private MetroFramework.Controls.MetroLabel mtxtClienteError;
        private MetroFramework.Controls.MetroTile mtileLinea;
        private MetroFramework.Controls.MetroTextBox mtxtValorTasa;
        private MetroFramework.Controls.MetroLabel mlblValorTasa;
        private MetroFramework.Controls.MetroLabel mlblCancelar;
        private MetroFramework.Controls.MetroLink mlnkCancelar;
        private MetroFramework.Controls.MetroLabel mlblBuscarCliente;
        private MetroFramework.Controls.MetroLink mlnkBuscarCliente;
        private MetroFramework.Controls.MetroLabel mlblRecargar;
        private MetroFramework.Controls.MetroLink mlnkRecargar;
        private MetroFramework.Controls.MetroLabel mlblGuardar;
        private MetroFramework.Controls.MetroLink mlnkGuardar;
        private MetroFramework.Controls.MetroLabel mlblDescripNumTransaccion;
        private MetroFramework.Controls.MetroLabel mlblNumTransaccion;
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
        private MetroFramework.Controls.MetroGrid mgvDocumentos;
        private MetroFramework.Controls.MetroLabel mlblMoneda;
        private MetroFramework.Controls.MetroTextBox mtxtCliente;
        private MetroFramework.Controls.MetroLabel mlblCliente;
        private MetroFramework.Controls.MetroTextBox mtxtAnotacion;
        private MetroFramework.Controls.MetroLabel mlblAnotacion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasMora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.DataGridViewImageColumn Totalizar;
    }
}
