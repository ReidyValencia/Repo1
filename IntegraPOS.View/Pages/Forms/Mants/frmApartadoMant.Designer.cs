namespace IntegraPOS.Pages.Forms.Mants
{
    partial class frmApartadoMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApartadoMant));
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblGuardar = new MetroFramework.Controls.MetroLabel();
            this.mlnkNuevo = new MetroFramework.Controls.MetroLink();
            this.mlblRecargar = new MetroFramework.Controls.MetroLabel();
            this.mlnkRecargar = new MetroFramework.Controls.MetroLink();
            this.mlnkCancelar = new MetroFramework.Controls.MetroLink();
            this.mlblCancelar = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(535, 68);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(211, 44);
            this.mlblTitulo.TabIndex = 86;
            this.mlblTitulo.Text = "Apartado";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.metroTile1.Location = new System.Drawing.Point(10, 61);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1260, 5);
            this.metroTile1.TabIndex = 85;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mlblGuardar
            // 
            this.mlblGuardar.Location = new System.Drawing.Point(78, 22);
            this.mlblGuardar.Name = "mlblGuardar";
            this.mlblGuardar.Size = new System.Drawing.Size(120, 35);
            this.mlblGuardar.TabIndex = 81;
            this.mlblGuardar.Text = "Guardar";
            this.mlblGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkNuevo
            // 
            this.mlnkNuevo.BackgroundImage = global::IntegraPOS.Properties.Resources.F1Cir48x48;
            this.mlnkNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkNuevo.Location = new System.Drawing.Point(24, 9);
            this.mlnkNuevo.Name = "mlnkNuevo";
            this.mlnkNuevo.Size = new System.Drawing.Size(48, 48);
            this.mlnkNuevo.TabIndex = 82;
            this.mlnkNuevo.UseSelectable = true;
            // 
            // mlblRecargar
            // 
            this.mlblRecargar.Location = new System.Drawing.Point(258, 22);
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
            this.mlnkRecargar.Location = new System.Drawing.Point(204, 9);
            this.mlnkRecargar.Name = "mlnkRecargar";
            this.mlnkRecargar.Size = new System.Drawing.Size(48, 48);
            this.mlnkRecargar.TabIndex = 88;
            this.mlnkRecargar.UseSelectable = true;
            // 
            // mlnkCancelar
            // 
            this.mlnkCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCancelar.BackgroundImage")));
            this.mlnkCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkCancelar.Location = new System.Drawing.Point(1091, 9);
            this.mlnkCancelar.Name = "mlnkCancelar";
            this.mlnkCancelar.Size = new System.Drawing.Size(48, 48);
            this.mlnkCancelar.TabIndex = 84;
            this.mlnkCancelar.UseSelectable = true;
            this.mlnkCancelar.Click += new System.EventHandler(this.mlnkCancelar_Click);
            // 
            // mlblCancelar
            // 
            this.mlblCancelar.Location = new System.Drawing.Point(1146, 22);
            this.mlblCancelar.Name = "mlblCancelar";
            this.mlblCancelar.Size = new System.Drawing.Size(120, 35);
            this.mlblCancelar.TabIndex = 83;
            this.mlblCancelar.Text = "Cancelar";
            this.mlblCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmApartadoMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlblRecargar);
            this.Controls.Add(this.mlnkRecargar);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblCancelar);
            this.Controls.Add(this.mlnkCancelar);
            this.Controls.Add(this.mlblGuardar);
            this.Controls.Add(this.mlnkNuevo);
            this.Name = "frmApartadoMant";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlblGuardar;
        private MetroFramework.Controls.MetroLink mlnkNuevo;
        private MetroFramework.Controls.MetroLabel mlblRecargar;
        private MetroFramework.Controls.MetroLink mlnkRecargar;
        private MetroFramework.Controls.MetroLink mlnkCancelar;
        private MetroFramework.Controls.MetroLabel mlblCancelar;
    }
}
