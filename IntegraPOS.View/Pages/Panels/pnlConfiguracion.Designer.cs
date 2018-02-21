namespace IntegraPOS.Pages.Panels
{
    partial class pnlConfiguracion
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
            this.mlnkTransacciones = new MetroFramework.Controls.MetroLink();
            this.mlblTransacciones = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlnkLogo = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mlnkTransacciones
            // 
            this.mlnkTransacciones.BackColor = System.Drawing.Color.White;
            this.mlnkTransacciones.BackgroundImage = global::IntegraPOS.Properties.Resources.transaccionesCir128x128;
            this.mlnkTransacciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mlnkTransacciones.Location = new System.Drawing.Point(297, 266);
            this.mlnkTransacciones.Name = "mlnkTransacciones";
            this.mlnkTransacciones.Size = new System.Drawing.Size(128, 128);
            this.mlnkTransacciones.TabIndex = 50;
            this.mlnkTransacciones.UseSelectable = true;
            this.mlnkTransacciones.Click += new System.EventHandler(this.mlnkTransacciones_Click);
            // 
            // mlblTransacciones
            // 
            this.mlblTransacciones.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTransacciones.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTransacciones.Location = new System.Drawing.Point(292, 397);
            this.mlblTransacciones.Name = "mlblTransacciones";
            this.mlblTransacciones.Size = new System.Drawing.Size(138, 29);
            this.mlblTransacciones.TabIndex = 49;
            this.mlblTransacciones.Text = "Transacciones ";
            this.mlblTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.White;
            this.metroLink1.BackgroundImage = global::IntegraPOS.Properties.Resources.sincronizarCir128x128;
            this.metroLink1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLink1.Location = new System.Drawing.Point(525, 266);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(128, 128);
            this.metroLink1.TabIndex = 52;
            this.metroLink1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(499, 397);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 29);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Sincronización ERP";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlnkLogo
            // 
            this.mlnkLogo.BackColor = System.Drawing.Color.White;
            this.mlnkLogo.BackgroundImage = global::IntegraPOS.Properties.Resources.logoIntegraPOS420x150_v9;
            this.mlnkLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkLogo.Location = new System.Drawing.Point(754, 0);
            this.mlnkLogo.Name = "mlnkLogo";
            this.mlnkLogo.Size = new System.Drawing.Size(196, 70);
            this.mlnkLogo.TabIndex = 53;
            this.mlnkLogo.UseSelectable = true;
            // 
            // pnlConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.mlnkLogo);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mlnkTransacciones);
            this.Controls.Add(this.mlblTransacciones);
            this.Name = "pnlConfiguracion";
            this.Size = new System.Drawing.Size(950, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlnkTransacciones;
        private MetroFramework.Controls.MetroLabel mlblTransacciones;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink mlnkLogo;
    }
}
