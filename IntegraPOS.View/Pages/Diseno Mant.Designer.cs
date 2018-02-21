namespace IntegraPOS.Pages
{
    partial class Diseno_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diseno_Mant));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.mlblGuardar = new MetroFramework.Controls.MetroLabel();
            this.mlnkNuevo = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(535, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(211, 651);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Registro de Empresas";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(535, 68);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(211, 44);
            this.mlblTitulo.TabIndex = 79;
            this.mlblTitulo.Text = "Registro de Empresas";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.metroTile1.Location = new System.Drawing.Point(10, 61);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1260, 5);
            this.metroTile1.TabIndex = 78;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mlblVolver
            // 
            this.mlblVolver.Location = new System.Drawing.Point(1137, 19);
            this.mlblVolver.Name = "mlblVolver";
            this.mlblVolver.Size = new System.Drawing.Size(120, 35);
            this.mlblVolver.TabIndex = 76;
            this.mlblVolver.Text = "Volver";
            this.mlblVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkVolver
            // 
            this.mlnkVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkVolver.BackgroundImage")));
            this.mlnkVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkVolver.Location = new System.Drawing.Point(1082, 6);
            this.mlnkVolver.Name = "mlnkVolver";
            this.mlnkVolver.Size = new System.Drawing.Size(48, 48);
            this.mlnkVolver.TabIndex = 77;
            this.mlnkVolver.UseSelectable = true;
            // 
            // mlblGuardar
            // 
            this.mlblGuardar.Location = new System.Drawing.Point(78, 19);
            this.mlblGuardar.Name = "mlblGuardar";
            this.mlblGuardar.Size = new System.Drawing.Size(120, 35);
            this.mlblGuardar.TabIndex = 74;
            this.mlblGuardar.Text = "Guardar";
            this.mlblGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkNuevo
            // 
            this.mlnkNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkNuevo.BackgroundImage")));
            this.mlnkNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkNuevo.Location = new System.Drawing.Point(24, 6);
            this.mlnkNuevo.Name = "mlnkNuevo";
            this.mlnkNuevo.Size = new System.Drawing.Size(48, 48);
            this.mlnkNuevo.TabIndex = 75;
            this.mlnkNuevo.UseSelectable = true;
            // 
            // Diseno_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Controls.Add(this.mlblGuardar);
            this.Controls.Add(this.mlnkNuevo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Diseno_Mant";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroLabel mlblGuardar;
        private MetroFramework.Controls.MetroLink mlnkNuevo;
    }
}
