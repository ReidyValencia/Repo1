namespace IntegraPOS.Pages.PopUps
{
    partial class frmPopUpMedioPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopUpMedioPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpnlMedioPago = new MetroFramework.Controls.MetroPanel();
            this.mbtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mtileTotalPagar = new MetroFramework.Controls.MetroTile();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.mbtnGuardar = new MetroFramework.Controls.MetroButton();
            this.mtileCambio = new MetroFramework.Controls.MetroTile();
            this.mtileTotalMedPago = new MetroFramework.Controls.MetroTile();
            this.lblTotalMedPago = new System.Windows.Forms.Label();
            this.mtileDiferencia = new MetroFramework.Controls.MetroTile();
            this.mlnkCerrar = new MetroFramework.Controls.MetroLink();
            this.mgvMediosPago = new MetroFramework.Controls.MetroGrid();
            this.CodSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMedPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimboloMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonMedPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonMndTransac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BndPINPAD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BndDocumentos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BndDenominacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Totalizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.medioPagoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.mpnlMedioPago.SuspendLayout();
            this.mtileTotalPagar.SuspendLayout();
            this.mtileCambio.SuspendLayout();
            this.mtileTotalMedPago.SuspendLayout();
            this.mtileDiferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgvMediosPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioPagoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnlMedioPago
            // 
            this.mpnlMedioPago.BackColor = System.Drawing.Color.Gainsboro;
            this.mpnlMedioPago.Controls.Add(this.mbtnCancelar);
            this.mpnlMedioPago.Controls.Add(this.mtileTotalPagar);
            this.mpnlMedioPago.Controls.Add(this.mbtnGuardar);
            this.mpnlMedioPago.Controls.Add(this.mtileCambio);
            this.mpnlMedioPago.Controls.Add(this.mtileTotalMedPago);
            this.mpnlMedioPago.Controls.Add(this.mtileDiferencia);
            this.mpnlMedioPago.Controls.Add(this.mlnkCerrar);
            this.mpnlMedioPago.Controls.Add(this.mgvMediosPago);
            this.mpnlMedioPago.HorizontalScrollbarBarColor = true;
            this.mpnlMedioPago.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlMedioPago.HorizontalScrollbarSize = 10;
            this.mpnlMedioPago.Location = new System.Drawing.Point(0, 0);
            this.mpnlMedioPago.Name = "mpnlMedioPago";
            this.mpnlMedioPago.Size = new System.Drawing.Size(1000, 500);
            this.mpnlMedioPago.TabIndex = 0;
            this.mpnlMedioPago.UseCustomBackColor = true;
            this.mpnlMedioPago.VerticalScrollbarBarColor = true;
            this.mpnlMedioPago.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlMedioPago.VerticalScrollbarSize = 10;
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mbtnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.mbtnCancelar.Location = new System.Drawing.Point(863, 87);
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Size = new System.Drawing.Size(120, 40);
            this.mbtnCancelar.TabIndex = 18;
            this.mbtnCancelar.Text = "Cancelar";
            this.mbtnCancelar.UseCustomBackColor = true;
            this.mbtnCancelar.UseCustomForeColor = true;
            this.mbtnCancelar.UseSelectable = true;
            // 
            // mtileTotalPagar
            // 
            this.mtileTotalPagar.ActiveControl = null;
            this.mtileTotalPagar.Controls.Add(this.lblTotalPagar);
            this.mtileTotalPagar.Location = new System.Drawing.Point(20, 37);
            this.mtileTotalPagar.Name = "mtileTotalPagar";
            this.mtileTotalPagar.Size = new System.Drawing.Size(160, 90);
            this.mtileTotalPagar.TabIndex = 13;
            this.mtileTotalPagar.Text = "TOTAL";
            this.mtileTotalPagar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtileTotalPagar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtileTotalPagar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtileTotalPagar.UseSelectable = true;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalPagar.Location = new System.Drawing.Point(3, 50);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(154, 35);
            this.lblTotalPagar.TabIndex = 0;
            this.lblTotalPagar.Text = "0.00";
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mbtnGuardar
            // 
            this.mbtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mbtnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnGuardar.ForeColor = System.Drawing.Color.White;
            this.mbtnGuardar.Location = new System.Drawing.Point(737, 87);
            this.mbtnGuardar.Name = "mbtnGuardar";
            this.mbtnGuardar.Size = new System.Drawing.Size(120, 40);
            this.mbtnGuardar.TabIndex = 17;
            this.mbtnGuardar.Text = "Guardar";
            this.mbtnGuardar.UseCustomBackColor = true;
            this.mbtnGuardar.UseCustomForeColor = true;
            this.mbtnGuardar.UseSelectable = true;
            this.mbtnGuardar.Click += new System.EventHandler(this.mbtnGuardar_Click);
            // 
            // mtileCambio
            // 
            this.mtileCambio.ActiveControl = null;
            this.mtileCambio.Controls.Add(this.lblCambio);
            this.mtileCambio.Location = new System.Drawing.Point(533, 37);
            this.mtileCambio.Name = "mtileCambio";
            this.mtileCambio.Size = new System.Drawing.Size(160, 90);
            this.mtileCambio.TabIndex = 14;
            this.mtileCambio.Text = "Cambio";
            this.mtileCambio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtileCambio.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtileCambio.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtileCambio.UseSelectable = true;
            // 
            // mtileTotalMedPago
            // 
            this.mtileTotalMedPago.ActiveControl = null;
            this.mtileTotalMedPago.Controls.Add(this.lblTotalMedPago);
            this.mtileTotalMedPago.Location = new System.Drawing.Point(193, 37);
            this.mtileTotalMedPago.Name = "mtileTotalMedPago";
            this.mtileTotalMedPago.Size = new System.Drawing.Size(160, 90);
            this.mtileTotalMedPago.TabIndex = 15;
            this.mtileTotalMedPago.Text = "T. Medio Pago";
            this.mtileTotalMedPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtileTotalMedPago.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtileTotalMedPago.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtileTotalMedPago.UseSelectable = true;
            // 
            // lblTotalMedPago
            // 
            this.lblTotalMedPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.lblTotalMedPago.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalMedPago.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalMedPago.Location = new System.Drawing.Point(3, 50);
            this.lblTotalMedPago.Name = "lblTotalMedPago";
            this.lblTotalMedPago.Size = new System.Drawing.Size(154, 35);
            this.lblTotalMedPago.TabIndex = 0;
            this.lblTotalMedPago.Text = "0.00";
            this.lblTotalMedPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtileDiferencia
            // 
            this.mtileDiferencia.ActiveControl = null;
            this.mtileDiferencia.Controls.Add(this.lblDiferencia);
            this.mtileDiferencia.Location = new System.Drawing.Point(363, 37);
            this.mtileDiferencia.Name = "mtileDiferencia";
            this.mtileDiferencia.Size = new System.Drawing.Size(160, 90);
            this.mtileDiferencia.TabIndex = 16;
            this.mtileDiferencia.Text = "Diferencia";
            this.mtileDiferencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtileDiferencia.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtileDiferencia.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtileDiferencia.UseSelectable = true;
            // 
            // mlnkCerrar
            // 
            this.mlnkCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCerrar.BackgroundImage")));
            this.mlnkCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkCerrar.Location = new System.Drawing.Point(967, 3);
            this.mlnkCerrar.Name = "mlnkCerrar";
            this.mlnkCerrar.Size = new System.Drawing.Size(30, 30);
            this.mlnkCerrar.TabIndex = 12;
            this.mlnkCerrar.UseSelectable = true;
            this.mlnkCerrar.Click += new System.EventHandler(this.mlnkCerrar_Click);
            // 
            // mgvMediosPago
            // 
            this.mgvMediosPago.AllowUserToAddRows = false;
            this.mgvMediosPago.AllowUserToDeleteRows = false;
            this.mgvMediosPago.AllowUserToResizeRows = false;
            this.mgvMediosPago.AutoGenerateColumns = false;
            this.mgvMediosPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvMediosPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvMediosPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvMediosPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvMediosPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.mgvMediosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvMediosPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodSistema,
            this.TipoMedPago,
            this.NombreMedPago,
            this.Documento,
            this.Banco,
            this.FechaDoc,
            this.CodigoMoneda,
            this.SimboloMoneda,
            this.MonMedPago,
            this.MonFactor,
            this.MonMndTransac,
            this.BndPINPAD,
            this.BndDocumentos,
            this.BndDenominacion,
            this.Totalizar});
            this.mgvMediosPago.DataSource = this.medioPagoModelBindingSource;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 20F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvMediosPago.DefaultCellStyle = dataGridViewCellStyle26;
            this.mgvMediosPago.EnableHeadersVisualStyles = false;
            this.mgvMediosPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvMediosPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvMediosPago.Location = new System.Drawing.Point(10, 161);
            this.mgvMediosPago.Name = "mgvMediosPago";
            this.mgvMediosPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvMediosPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.mgvMediosPago.RowHeadersVisible = false;
            this.mgvMediosPago.RowHeadersWidth = 100;
            this.mgvMediosPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvMediosPago.RowTemplate.Height = 50;
            this.mgvMediosPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvMediosPago.ShowCellErrors = false;
            this.mgvMediosPago.Size = new System.Drawing.Size(980, 330);
            this.mgvMediosPago.TabIndex = 2;
            this.mgvMediosPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvMediosPago_CellClick);
            this.mgvMediosPago.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgvMediosPago_CellValueChanged);
            this.mgvMediosPago.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.mgvMediosPago_EditingControlShowing);
            this.mgvMediosPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mgvMediosPago_KeyPress);
            // 
            // CodSistema
            // 
            this.CodSistema.DataPropertyName = "mpgChrCodigo";
            this.CodSistema.Frozen = true;
            this.CodSistema.HeaderText = "Codigo Sistema";
            this.CodSistema.Name = "CodSistema";
            this.CodSistema.Visible = false;
            // 
            // TipoMedPago
            // 
            this.TipoMedPago.DataPropertyName = "tpgChrCodigo";
            this.TipoMedPago.Frozen = true;
            this.TipoMedPago.HeaderText = "Tipo";
            this.TipoMedPago.Name = "TipoMedPago";
            this.TipoMedPago.Visible = false;
            // 
            // NombreMedPago
            // 
            this.NombreMedPago.DataPropertyName = "mpgChrNombre";
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Gainsboro;
            this.NombreMedPago.DefaultCellStyle = dataGridViewCellStyle20;
            this.NombreMedPago.Frozen = true;
            this.NombreMedPago.HeaderText = "Nombre";
            this.NombreMedPago.Name = "NombreMedPago";
            this.NombreMedPago.Width = 250;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "dmpChrDocumento";
            this.Documento.Frozen = true;
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.Width = 110;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "dmpChrBancoEmisor";
            this.Banco.Frozen = true;
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            this.Banco.Width = 130;
            // 
            // FechaDoc
            // 
            this.FechaDoc.DataPropertyName = "dmpFecFechaDoc";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.NullValue = null;
            this.FechaDoc.DefaultCellStyle = dataGridViewCellStyle21;
            this.FechaDoc.Frozen = true;
            this.FechaDoc.HeaderText = "Fec. Doc.";
            this.FechaDoc.Name = "FechaDoc";
            this.FechaDoc.Width = 120;
            // 
            // CodigoMoneda
            // 
            this.CodigoMoneda.DataPropertyName = "mndIntCodigo";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodigoMoneda.DefaultCellStyle = dataGridViewCellStyle22;
            this.CodigoMoneda.Frozen = true;
            this.CodigoMoneda.HeaderText = "Codigo Moneda";
            this.CodigoMoneda.Name = "CodigoMoneda";
            this.CodigoMoneda.Visible = false;
            this.CodigoMoneda.Width = 70;
            // 
            // SimboloMoneda
            // 
            this.SimboloMoneda.DataPropertyName = "mndChrSimbolo";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SimboloMoneda.DefaultCellStyle = dataGridViewCellStyle23;
            this.SimboloMoneda.Frozen = true;
            this.SimboloMoneda.HeaderText = "Mnd.";
            this.SimboloMoneda.Name = "SimboloMoneda";
            this.SimboloMoneda.Width = 60;
            // 
            // MonMedPago
            // 
            this.MonMedPago.DataPropertyName = "mpgMonMontoMPago";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.MonMedPago.DefaultCellStyle = dataGridViewCellStyle24;
            this.MonMedPago.Frozen = true;
            this.MonMedPago.HeaderText = "Monto";
            this.MonMedPago.Name = "MonMedPago";
            this.MonMedPago.Width = 140;
            // 
            // MonFactor
            // 
            this.MonFactor.DataPropertyName = "mpgMonMontoFactor";
            this.MonFactor.Frozen = true;
            this.MonFactor.HeaderText = "Factor";
            this.MonFactor.Name = "MonFactor";
            this.MonFactor.Visible = false;
            // 
            // MonMndTransac
            // 
            this.MonMndTransac.DataPropertyName = "mpgMonMontoTransac";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MonMndTransac.DefaultCellStyle = dataGridViewCellStyle25;
            this.MonMndTransac.Frozen = true;
            this.MonMndTransac.HeaderText = "Mon. Mnd. Transac.";
            this.MonMndTransac.Name = "MonMndTransac";
            this.MonMndTransac.Width = 140;
            // 
            // BndPINPAD
            // 
            this.BndPINPAD.DataPropertyName = "mpgBndUtilPINPAD";
            this.BndPINPAD.Frozen = true;
            this.BndPINPAD.HeaderText = "Util. PINPAD";
            this.BndPINPAD.Name = "BndPINPAD";
            this.BndPINPAD.Visible = false;
            // 
            // BndDocumentos
            // 
            this.BndDocumentos.DataPropertyName = "tpgBndUtilDoc";
            this.BndDocumentos.Frozen = true;
            this.BndDocumentos.HeaderText = "Util. Documentos";
            this.BndDocumentos.Name = "BndDocumentos";
            this.BndDocumentos.Visible = false;
            // 
            // BndDenominacion
            // 
            this.BndDenominacion.DataPropertyName = "mpgBndUtilDenominacion";
            this.BndDenominacion.Frozen = true;
            this.BndDenominacion.HeaderText = "Util. Denominacion";
            this.BndDenominacion.Name = "BndDenominacion";
            this.BndDenominacion.Visible = false;
            // 
            // Totalizar
            // 
            this.Totalizar.Frozen = true;
            this.Totalizar.HeaderText = "T";
            this.Totalizar.Image = ((System.Drawing.Image)(resources.GetObject("Totalizar.Image")));
            this.Totalizar.Name = "Totalizar";
            this.Totalizar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Totalizar.Width = 30;
            // 
            // medioPagoModelBindingSource
            // 
            this.medioPagoModelBindingSource.DataSource = typeof(IntegraPOS.Model.Entidades.Clases.MedioPagoModel);
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.lblDiferencia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDiferencia.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDiferencia.Location = new System.Drawing.Point(3, 50);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(154, 35);
            this.lblDiferencia.TabIndex = 0;
            this.lblDiferencia.Text = "0.00";
            this.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCambio
            // 
            this.lblCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCambio.Location = new System.Drawing.Point(3, 50);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(154, 35);
            this.lblCambio.TabIndex = 0;
            this.lblCambio.Text = "0.00";
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPopUpMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.mpnlMedioPago);
            this.MinimizeBox = false;
            this.Name = "frmPopUpMedioPago";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.frmPopUpMedioPago_Load);
            this.mpnlMedioPago.ResumeLayout(false);
            this.mtileTotalPagar.ResumeLayout(false);
            this.mtileCambio.ResumeLayout(false);
            this.mtileTotalMedPago.ResumeLayout(false);
            this.mtileDiferencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgvMediosPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medioPagoModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mpnlMedioPago;
        private MetroFramework.Controls.MetroGrid mgvMediosPago;
        private MetroFramework.Controls.MetroLink mlnkCerrar;
        private MetroFramework.Controls.MetroButton mbtnCancelar;
        private MetroFramework.Controls.MetroTile mtileTotalPagar;
        private MetroFramework.Controls.MetroButton mbtnGuardar;
        private MetroFramework.Controls.MetroTile mtileCambio;
        private MetroFramework.Controls.MetroTile mtileTotalMedPago;
        private MetroFramework.Controls.MetroTile mtileDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMedioPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTransac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UtilPINPAD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UtilDoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UtilDenominacion;
        private System.Windows.Forms.BindingSource medioPagoModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMedPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoMonedaTransac;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMedPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn SimboloMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonMedPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonMndTransac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BndPINPAD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BndDocumentos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BndDenominacion;
        private System.Windows.Forms.DataGridViewImageColumn Totalizar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTotalMedPago;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label lblCambio;
    }
}
