namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    partial class pnlExistenciasInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlExistenciasInventario));
            this.mlblFechaFin = new MetroFramework.Controls.MetroLabel();
            this.mlblProducto = new MetroFramework.Controls.MetroLabel();
            this.mlblBodega = new MetroFramework.Controls.MetroLabel();
            this.mlblCaracteristicas = new MetroFramework.Controls.MetroLabel();
            this.mchkFamilia = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.mbtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mbtnAceptar = new MetroFramework.Controls.MetroButton();
            this.mdateFechaFin = new MetroFramework.Controls.MetroDateTime();
            this.mcboxBodega = new MetroFramework.Controls.MetroComboBox();
            this.mtxtProducto = new MetroFramework.Controls.MetroTextBox();
            this.mlnkBuscar = new MetroFramework.Controls.MetroLink();
            this.mtxtCaracteristicas = new MetroFramework.Controls.MetroTextBox();
            this.mlblExistenciasInv = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlblFechaFin
            // 
            this.mlblFechaFin.AutoSize = true;
            this.mlblFechaFin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblFechaFin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblFechaFin.Location = new System.Drawing.Point(17, 108);
            this.mlblFechaFin.Name = "mlblFechaFin";
            this.mlblFechaFin.Size = new System.Drawing.Size(96, 25);
            this.mlblFechaFin.TabIndex = 2;
            this.mlblFechaFin.Text = "Fecha Fin:";
            // 
            // mlblProducto
            // 
            this.mlblProducto.AutoSize = true;
            this.mlblProducto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblProducto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblProducto.Location = new System.Drawing.Point(17, 150);
            this.mlblProducto.Name = "mlblProducto";
            this.mlblProducto.Size = new System.Drawing.Size(95, 25);
            this.mlblProducto.TabIndex = 3;
            this.mlblProducto.Text = "Producto:";
            // 
            // mlblBodega
            // 
            this.mlblBodega.AutoSize = true;
            this.mlblBodega.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblBodega.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblBodega.Location = new System.Drawing.Point(17, 62);
            this.mlblBodega.Name = "mlblBodega";
            this.mlblBodega.Size = new System.Drawing.Size(82, 25);
            this.mlblBodega.TabIndex = 4;
            this.mlblBodega.Text = "Bodega:";
            // 
            // mlblCaracteristicas
            // 
            this.mlblCaracteristicas.AutoSize = true;
            this.mlblCaracteristicas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblCaracteristicas.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblCaracteristicas.Location = new System.Drawing.Point(17, 206);
            this.mlblCaracteristicas.Name = "mlblCaracteristicas";
            this.mlblCaracteristicas.Size = new System.Drawing.Size(140, 25);
            this.mlblCaracteristicas.TabIndex = 5;
            this.mlblCaracteristicas.Text = "Caracteristicas:";
            // 
            // mchkFamilia
            // 
            this.mchkFamilia.AutoSize = true;
            this.mchkFamilia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mchkFamilia.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkFamilia.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.mchkFamilia.Location = new System.Drawing.Point(17, 261);
            this.mchkFamilia.Name = "mchkFamilia";
            this.mchkFamilia.Size = new System.Drawing.Size(192, 25);
            this.mchkFamilia.TabIndex = 6;
            this.mchkFamilia.Text = "No mostrar familia:";
            this.mchkFamilia.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox1.Location = new System.Drawing.Point(272, 261);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(245, 25);
            this.metroCheckBox1.TabIndex = 7;
            this.metroCheckBox1.Text = "Omitir existencia en cero:";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.mbtnCancelar.Location = new System.Drawing.Point(169, 331);
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Size = new System.Drawing.Size(120, 40);
            this.mbtnCancelar.TabIndex = 21;
            this.mbtnCancelar.Text = "&Cancelar";
            this.mbtnCancelar.UseCustomBackColor = true;
            this.mbtnCancelar.UseCustomForeColor = true;
            this.mbtnCancelar.UseSelectable = true;
            // 
            // mbtnAceptar
            // 
            this.mbtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnAceptar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnAceptar.ForeColor = System.Drawing.Color.White;
            this.mbtnAceptar.Location = new System.Drawing.Point(22, 331);
            this.mbtnAceptar.Name = "mbtnAceptar";
            this.mbtnAceptar.Size = new System.Drawing.Size(120, 40);
            this.mbtnAceptar.TabIndex = 20;
            this.mbtnAceptar.Text = "&Aceptar";
            this.mbtnAceptar.UseCustomBackColor = true;
            this.mbtnAceptar.UseCustomForeColor = true;
            this.mbtnAceptar.UseSelectable = true;
            // 
            // mdateFechaFin
            // 
            this.mdateFechaFin.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.mdateFechaFin.Location = new System.Drawing.Point(180, 103);
            this.mdateFechaFin.MinimumSize = new System.Drawing.Size(0, 35);
            this.mdateFechaFin.Name = "mdateFechaFin";
            this.mdateFechaFin.Size = new System.Drawing.Size(178, 35);
            this.mdateFechaFin.TabIndex = 22;
            this.mdateFechaFin.ValueChanged += new System.EventHandler(this.mdateFechaFin_ValueChanged);
            // 
            // mcboxBodega
            // 
            this.mcboxBodega.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.mcboxBodega.FormattingEnabled = true;
            this.mcboxBodega.ItemHeight = 29;
            this.mcboxBodega.Location = new System.Drawing.Point(180, 62);
            this.mcboxBodega.Name = "mcboxBodega";
            this.mcboxBodega.Size = new System.Drawing.Size(178, 35);
            this.mcboxBodega.TabIndex = 23;
            this.mcboxBodega.UseSelectable = true;
            // 
            // mtxtProducto
            // 
            // 
            // 
            // 
            this.mtxtProducto.CustomButton.Image = null;
            this.mtxtProducto.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.mtxtProducto.CustomButton.Name = "";
            this.mtxtProducto.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtProducto.CustomButton.TabIndex = 1;
            this.mtxtProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtProducto.CustomButton.UseSelectable = true;
            this.mtxtProducto.CustomButton.Visible = false;
            this.mtxtProducto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtProducto.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtxtProducto.Lines = new string[0];
            this.mtxtProducto.Location = new System.Drawing.Point(180, 150);
            this.mtxtProducto.MaxLength = 32767;
            this.mtxtProducto.Name = "mtxtProducto";
            this.mtxtProducto.PasswordChar = '\0';
            this.mtxtProducto.PromptText = "Buscar producto";
            this.mtxtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtProducto.SelectedText = "";
            this.mtxtProducto.SelectionLength = 0;
            this.mtxtProducto.SelectionStart = 0;
            this.mtxtProducto.ShortcutsEnabled = true;
            this.mtxtProducto.Size = new System.Drawing.Size(297, 35);
            this.mtxtProducto.TabIndex = 24;
            this.mtxtProducto.UseSelectable = true;
            this.mtxtProducto.WaterMark = "Buscar producto";
            this.mtxtProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mlnkBuscar
            // 
            this.mlnkBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkBuscar.BackgroundImage")));
            this.mlnkBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkBuscar.Location = new System.Drawing.Point(483, 150);
            this.mlnkBuscar.Name = "mlnkBuscar";
            this.mlnkBuscar.Size = new System.Drawing.Size(29, 35);
            this.mlnkBuscar.TabIndex = 83;
            this.mlnkBuscar.UseSelectable = true;
            // 
            // mtxtCaracteristicas
            // 
            // 
            // 
            // 
            this.mtxtCaracteristicas.CustomButton.Image = null;
            this.mtxtCaracteristicas.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.mtxtCaracteristicas.CustomButton.Name = "";
            this.mtxtCaracteristicas.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtCaracteristicas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtCaracteristicas.CustomButton.TabIndex = 1;
            this.mtxtCaracteristicas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtCaracteristicas.CustomButton.UseSelectable = true;
            this.mtxtCaracteristicas.CustomButton.Visible = false;
            this.mtxtCaracteristicas.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtCaracteristicas.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtxtCaracteristicas.Lines = new string[0];
            this.mtxtCaracteristicas.Location = new System.Drawing.Point(180, 206);
            this.mtxtCaracteristicas.MaxLength = 32767;
            this.mtxtCaracteristicas.Name = "mtxtCaracteristicas";
            this.mtxtCaracteristicas.PasswordChar = '\0';
            this.mtxtCaracteristicas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCaracteristicas.SelectedText = "";
            this.mtxtCaracteristicas.SelectionLength = 0;
            this.mtxtCaracteristicas.SelectionStart = 0;
            this.mtxtCaracteristicas.ShortcutsEnabled = true;
            this.mtxtCaracteristicas.Size = new System.Drawing.Size(337, 35);
            this.mtxtCaracteristicas.TabIndex = 84;
            this.mtxtCaracteristicas.UseSelectable = true;
            this.mtxtCaracteristicas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtCaracteristicas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mlblExistenciasInv
            // 
            this.mlblExistenciasInv.AutoSize = true;
            this.mlblExistenciasInv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblExistenciasInv.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblExistenciasInv.Location = new System.Drawing.Point(154, 10);
            this.mlblExistenciasInv.Name = "mlblExistenciasInv";
            this.mlblExistenciasInv.Size = new System.Drawing.Size(223, 25);
            this.mlblExistenciasInv.TabIndex = 85;
            this.mlblExistenciasInv.Text = "Existencias de inventario";
            // 
            // pnlExistenciasInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mlblExistenciasInv);
            this.Controls.Add(this.mtxtCaracteristicas);
            this.Controls.Add(this.mlnkBuscar);
            this.Controls.Add(this.mtxtProducto);
            this.Controls.Add(this.mcboxBodega);
            this.Controls.Add(this.mdateFechaFin);
            this.Controls.Add(this.mbtnCancelar);
            this.Controls.Add(this.mbtnAceptar);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.mchkFamilia);
            this.Controls.Add(this.mlblCaracteristicas);
            this.Controls.Add(this.mlblBodega);
            this.Controls.Add(this.mlblProducto);
            this.Controls.Add(this.mlblFechaFin);
            this.Name = "pnlExistenciasInventario";
            this.Size = new System.Drawing.Size(562, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mlblFechaFin;
        private MetroFramework.Controls.MetroLabel mlblProducto;
        private MetroFramework.Controls.MetroLabel mlblBodega;
        private MetroFramework.Controls.MetroLabel mlblCaracteristicas;
        private MetroFramework.Controls.MetroCheckBox mchkFamilia;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton mbtnCancelar;
        private MetroFramework.Controls.MetroButton mbtnAceptar;
        private MetroFramework.Controls.MetroDateTime mdateFechaFin;
        private MetroFramework.Controls.MetroComboBox mcboxBodega;
        private MetroFramework.Controls.MetroTextBox mtxtProducto;
        private MetroFramework.Controls.MetroLink mlnkBuscar;
        private MetroFramework.Controls.MetroTextBox mtxtCaracteristicas;
        private MetroFramework.Controls.MetroLabel mlblExistenciasInv;
    }
}
