namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    partial class pnlListadoVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlListadoVendedores));
            this.mbtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mbtnAceptar = new MetroFramework.Controls.MetroButton();
            this.mtxtCliente = new MetroFramework.Controls.MetroTextBox();
            this.mlblCliente = new MetroFramework.Controls.MetroLabel();
            this.mcmbDespliegue = new MetroFramework.Controls.MetroComboBox();
            this.mlblDespliegue = new MetroFramework.Controls.MetroLabel();
            this.mcmbEstado = new MetroFramework.Controls.MetroComboBox();
            this.mlblEstado = new MetroFramework.Controls.MetroLabel();
            this.mlblTituloListadoCliente = new MetroFramework.Controls.MetroLabel();
            this.mlnkBuscar = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.mbtnCancelar.Location = new System.Drawing.Point(188, 257);
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Size = new System.Drawing.Size(120, 40);
            this.mbtnCancelar.TabIndex = 91;
            this.mbtnCancelar.Text = "&Cancelar";
            this.mbtnCancelar.UseCustomBackColor = true;
            this.mbtnCancelar.UseCustomForeColor = true;
            this.mbtnCancelar.UseSelectable = true;
            this.mbtnCancelar.Click += new System.EventHandler(this.mbtnCancelar_Click_1);
            // 
            // mbtnAceptar
            // 
            this.mbtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnAceptar.ForeColor = System.Drawing.Color.White;
            this.mbtnAceptar.Location = new System.Drawing.Point(53, 257);
            this.mbtnAceptar.Name = "mbtnAceptar";
            this.mbtnAceptar.Size = new System.Drawing.Size(120, 40);
            this.mbtnAceptar.TabIndex = 90;
            this.mbtnAceptar.Text = "&Aceptar";
            this.mbtnAceptar.UseCustomBackColor = true;
            this.mbtnAceptar.UseCustomForeColor = true;
            this.mbtnAceptar.UseSelectable = true;
            this.mbtnAceptar.Click += new System.EventHandler(this.mbtnAceptar_Click);
            // 
            // mtxtCliente
            // 
            // 
            // 
            // 
            this.mtxtCliente.CustomButton.Image = null;
            this.mtxtCliente.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.mtxtCliente.CustomButton.Name = "";
            this.mtxtCliente.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCliente.CustomButton.TabIndex = 1;
            this.mtxtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCliente.CustomButton.UseSelectable = true;
            this.mtxtCliente.CustomButton.Visible = false;
            this.mtxtCliente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtCliente.Lines = new string[0];
            this.mtxtCliente.Location = new System.Drawing.Point(181, 185);
            this.mtxtCliente.MaxLength = 32767;
            this.mtxtCliente.Name = "mtxtCliente";
            this.mtxtCliente.PasswordChar = '\0';
            this.mtxtCliente.PromptText = "Buscar vendedor";
            this.mtxtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCliente.SelectedText = "";
            this.mtxtCliente.SelectionLength = 0;
            this.mtxtCliente.SelectionStart = 0;
            this.mtxtCliente.ShortcutsEnabled = true;
            this.mtxtCliente.Size = new System.Drawing.Size(271, 35);
            this.mtxtCliente.TabIndex = 89;
            this.mtxtCliente.UseSelectable = true;
            this.mtxtCliente.WaterMark = "Buscar vendedor";
            this.mtxtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mlblCliente
            // 
            this.mlblCliente.AutoSize = true;
            this.mlblCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblCliente.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblCliente.Location = new System.Drawing.Point(53, 190);
            this.mlblCliente.Name = "mlblCliente";
            this.mlblCliente.Size = new System.Drawing.Size(100, 25);
            this.mlblCliente.TabIndex = 88;
            this.mlblCliente.Text = "Vendedor:";
            // 
            // mcmbDespliegue
            // 
            this.mcmbDespliegue.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcmbDespliegue.FormattingEnabled = true;
            this.mcmbDespliegue.ItemHeight = 29;
            this.mcmbDespliegue.Location = new System.Drawing.Point(181, 125);
            this.mcmbDespliegue.Name = "mcmbDespliegue";
            this.mcmbDespliegue.Size = new System.Drawing.Size(160, 35);
            this.mcmbDespliegue.TabIndex = 87;
            this.mcmbDespliegue.UseSelectable = true;
            // 
            // mlblDespliegue
            // 
            this.mlblDespliegue.AutoSize = true;
            this.mlblDespliegue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblDespliegue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblDespliegue.Location = new System.Drawing.Point(53, 135);
            this.mlblDespliegue.Name = "mlblDespliegue";
            this.mlblDespliegue.Size = new System.Drawing.Size(111, 25);
            this.mlblDespliegue.TabIndex = 86;
            this.mlblDespliegue.Text = "Despliegue:";
            // 
            // mcmbEstado
            // 
            this.mcmbEstado.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcmbEstado.FormattingEnabled = true;
            this.mcmbEstado.ItemHeight = 29;
            this.mcmbEstado.Location = new System.Drawing.Point(181, 71);
            this.mcmbEstado.Name = "mcmbEstado";
            this.mcmbEstado.Size = new System.Drawing.Size(160, 35);
            this.mcmbEstado.TabIndex = 85;
            this.mcmbEstado.UseSelectable = true;
            // 
            // mlblEstado
            // 
            this.mlblEstado.AutoSize = true;
            this.mlblEstado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblEstado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblEstado.Location = new System.Drawing.Point(53, 81);
            this.mlblEstado.Name = "mlblEstado";
            this.mlblEstado.Size = new System.Drawing.Size(74, 25);
            this.mlblEstado.TabIndex = 84;
            this.mlblEstado.Text = "Estado:";
            // 
            // mlblTituloListadoCliente
            // 
            this.mlblTituloListadoCliente.AutoSize = true;
            this.mlblTituloListadoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTituloListadoCliente.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTituloListadoCliente.Location = new System.Drawing.Point(151, 14);
            this.mlblTituloListadoCliente.Name = "mlblTituloListadoCliente";
            this.mlblTituloListadoCliente.Size = new System.Drawing.Size(208, 25);
            this.mlblTituloListadoCliente.TabIndex = 81;
            this.mlblTituloListadoCliente.Text = "Listado de  vendedores";
            // 
            // mlnkBuscar
            // 
            this.mlnkBuscar.BackColor = System.Drawing.Color.White;
            this.mlnkBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBuscar.BackgroundImage")));
            this.mlnkBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscar.Location = new System.Drawing.Point(458, 185);
            this.mlnkBuscar.Name = "mlnkBuscar";
            this.mlnkBuscar.Size = new System.Drawing.Size(29, 35);
            this.mlnkBuscar.TabIndex = 94;
            this.mlnkBuscar.UseSelectable = true;
            // 
            // pnlListadoVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.mlnkBuscar);
            this.Controls.Add(this.mbtnCancelar);
            this.Controls.Add(this.mbtnAceptar);
            this.Controls.Add(this.mtxtCliente);
            this.Controls.Add(this.mlblCliente);
            this.Controls.Add(this.mcmbDespliegue);
            this.Controls.Add(this.mlblDespliegue);
            this.Controls.Add(this.mcmbEstado);
            this.Controls.Add(this.mlblEstado);
            this.Controls.Add(this.mlblTituloListadoCliente);
            this.Name = "pnlListadoVendedores";
            this.Size = new System.Drawing.Size(510, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton mbtnCancelar;
        private MetroFramework.Controls.MetroButton mbtnAceptar;
        private MetroFramework.Controls.MetroTextBox mtxtCliente;
        private MetroFramework.Controls.MetroLabel mlblCliente;
        private MetroFramework.Controls.MetroComboBox mcmbDespliegue;
        private MetroFramework.Controls.MetroLabel mlblDespliegue;
        private MetroFramework.Controls.MetroComboBox mcmbEstado;
        private MetroFramework.Controls.MetroLabel mlblEstado;
        private MetroFramework.Controls.MetroLabel mlblTituloListadoCliente;
        private MetroFramework.Controls.MetroLink mlnkBuscar;
    }
}
