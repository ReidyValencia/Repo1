namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    partial class pnlListadoClientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlListadoClientes));
            this.mlblTituloListadoCliente = new MetroFramework.Controls.MetroLabel();
            this.mlblEstadoCliente = new MetroFramework.Controls.MetroLabel();
            this.mcmbEstado = new MetroFramework.Controls.MetroComboBox();
            this.mlblDespliegue = new MetroFramework.Controls.MetroLabel();
            this.mcmbDespliegue = new MetroFramework.Controls.MetroComboBox();
            this.mlblCliente = new MetroFramework.Controls.MetroLabel();
            this.mtxtCliente = new MetroFramework.Controls.MetroTextBox();
            this.mbtnAceptar = new MetroFramework.Controls.MetroButton();
            this.mbtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mlnkBuscar = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mlblTituloListadoCliente
            // 
            this.mlblTituloListadoCliente.AutoSize = true;
            this.mlblTituloListadoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTituloListadoCliente.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTituloListadoCliente.Location = new System.Drawing.Point(148, 10);
            this.mlblTituloListadoCliente.Name = "mlblTituloListadoCliente";
            this.mlblTituloListadoCliente.Size = new System.Drawing.Size(174, 25);
            this.mlblTituloListadoCliente.TabIndex = 0;
            this.mlblTituloListadoCliente.Text = "Listado de  clientes";
            this.mlblTituloListadoCliente.WrapToLine = true;
            // 
            // mlblEstadoCliente
            // 
            this.mlblEstadoCliente.AutoSize = true;
            this.mlblEstadoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblEstadoCliente.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblEstadoCliente.Location = new System.Drawing.Point(34, 67);
            this.mlblEstadoCliente.Name = "mlblEstadoCliente";
            this.mlblEstadoCliente.Size = new System.Drawing.Size(74, 25);
            this.mlblEstadoCliente.TabIndex = 3;
            this.mlblEstadoCliente.Text = "Estado:";
            // 
            // mcmbEstado
            // 
            this.mcmbEstado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcmbEstado.FormattingEnabled = true;
            this.mcmbEstado.ItemHeight = 29;
            this.mcmbEstado.Location = new System.Drawing.Point(162, 67);
            this.mcmbEstado.Name = "mcmbEstado";
            this.mcmbEstado.Size = new System.Drawing.Size(160, 35);
            this.mcmbEstado.TabIndex = 4;
            this.mcmbEstado.UseSelectable = true;
            // 
            // mlblDespliegue
            // 
            this.mlblDespliegue.AutoSize = true;
            this.mlblDespliegue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblDespliegue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblDespliegue.Location = new System.Drawing.Point(34, 121);
            this.mlblDespliegue.Name = "mlblDespliegue";
            this.mlblDespliegue.Size = new System.Drawing.Size(111, 25);
            this.mlblDespliegue.TabIndex = 5;
            this.mlblDespliegue.Text = "Despliegue:";
            // 
            // mcmbDespliegue
            // 
            this.mcmbDespliegue.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcmbDespliegue.FormattingEnabled = true;
            this.mcmbDespliegue.ItemHeight = 29;
            this.mcmbDespliegue.Location = new System.Drawing.Point(162, 117);
            this.mcmbDespliegue.Name = "mcmbDespliegue";
            this.mcmbDespliegue.Size = new System.Drawing.Size(160, 35);
            this.mcmbDespliegue.TabIndex = 6;
            this.mcmbDespliegue.UseSelectable = true;
            // 
            // mlblCliente
            // 
            this.mlblCliente.AutoSize = true;
            this.mlblCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblCliente.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblCliente.Location = new System.Drawing.Point(34, 171);
            this.mlblCliente.Name = "mlblCliente";
            this.mlblCliente.Size = new System.Drawing.Size(76, 25);
            this.mlblCliente.TabIndex = 7;
            this.mlblCliente.Text = "Cliente:";
            // 
            // mtxtCliente
            // 
            // 
            // 
            // 
            this.mtxtCliente.CustomButton.Image = null;
            this.mtxtCliente.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.mtxtCliente.CustomButton.Name = "";
            this.mtxtCliente.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCliente.CustomButton.TabIndex = 1;
            this.mtxtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCliente.CustomButton.UseSelectable = true;
            this.mtxtCliente.CustomButton.Visible = false;
            this.mtxtCliente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtCliente.Lines = new string[0];
            this.mtxtCliente.Location = new System.Drawing.Point(162, 171);
            this.mtxtCliente.MaxLength = 32767;
            this.mtxtCliente.Name = "mtxtCliente";
            this.mtxtCliente.PasswordChar = '\0';
            this.mtxtCliente.PromptText = "Buscar cliente";
            this.mtxtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCliente.SelectedText = "";
            this.mtxtCliente.SelectionLength = 0;
            this.mtxtCliente.SelectionStart = 0;
            this.mtxtCliente.ShortcutsEnabled = true;
            this.mtxtCliente.Size = new System.Drawing.Size(294, 35);
            this.mtxtCliente.TabIndex = 8;
            this.mtxtCliente.UseSelectable = true;
            this.mtxtCliente.WaterMark = "Buscar cliente";
            this.mtxtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mbtnAceptar
            // 
            this.mbtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnAceptar.ForeColor = System.Drawing.Color.White;
            this.mbtnAceptar.Location = new System.Drawing.Point(34, 253);
            this.mbtnAceptar.Name = "mbtnAceptar";
            this.mbtnAceptar.Size = new System.Drawing.Size(120, 40);
            this.mbtnAceptar.TabIndex = 18;
            this.mbtnAceptar.Text = "&Aceptar";
            this.mbtnAceptar.UseCustomBackColor = true;
            this.mbtnAceptar.UseCustomForeColor = true;
            this.mbtnAceptar.UseSelectable = true;
            this.mbtnAceptar.Click += new System.EventHandler(this.mbtnAceptar_Click);
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.mbtnCancelar.Location = new System.Drawing.Point(169, 253);
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Size = new System.Drawing.Size(120, 40);
            this.mbtnCancelar.TabIndex = 19;
            this.mbtnCancelar.Text = "&Cancelar";
            this.mbtnCancelar.UseCustomBackColor = true;
            this.mbtnCancelar.UseCustomForeColor = true;
            this.mbtnCancelar.UseSelectable = true;
            this.mbtnCancelar.Click += new System.EventHandler(this.mbtnCancelar_Click);
            // 
            // mlnkBuscar
            // 
            this.mlnkBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBuscar.BackgroundImage")));
            this.mlnkBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscar.Location = new System.Drawing.Point(462, 171);
            this.mlnkBuscar.Name = "mlnkBuscar";
            this.mlnkBuscar.Size = new System.Drawing.Size(29, 35);
            this.mlnkBuscar.TabIndex = 82;
            this.mlnkBuscar.UseSelectable = true;
            this.mlnkBuscar.Click += new System.EventHandler(this.pv_BuscarClientes);
            // 
            // pnlListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mlnkBuscar);
            this.Controls.Add(this.mbtnCancelar);
            this.Controls.Add(this.mbtnAceptar);
            this.Controls.Add(this.mtxtCliente);
            this.Controls.Add(this.mlblCliente);
            this.Controls.Add(this.mcmbDespliegue);
            this.Controls.Add(this.mlblDespliegue);
            this.Controls.Add(this.mcmbEstado);
            this.Controls.Add(this.mlblEstadoCliente);
            this.Controls.Add(this.mlblTituloListadoCliente);
            this.Name = "pnlListadoClientes";
            this.Size = new System.Drawing.Size(1280, 720);
            this.UseCustomBackColor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblTituloListadoCliente;
        private MetroFramework.Controls.MetroLabel mlblEstadoCliente;
        private MetroFramework.Controls.MetroComboBox mcmbEstado;
        private MetroFramework.Controls.MetroLabel mlblDespliegue;
        private MetroFramework.Controls.MetroComboBox mcmbDespliegue;
        private MetroFramework.Controls.MetroLabel mlblCliente;
        private MetroFramework.Controls.MetroTextBox mtxtCliente;
        private MetroFramework.Controls.MetroButton mbtnAceptar;
        private MetroFramework.Controls.MetroButton mbtnCancelar;
        private MetroFramework.Controls.MetroLink mlnkBuscar;
    }
}
