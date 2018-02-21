namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmProcesoCajaRpts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCajaRpts));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.mpnlReportes = new MetroFramework.Controls.MetroPanel();
            this.mtileProcesosCaja = new MetroFramework.Controls.MetroTile();
            this.mtileCierresCajas = new MetroFramework.Controls.MetroTile();
            this.mtileListadoCajas = new MetroFramework.Controls.MetroTile();
            this.mtileVentasXCaja = new MetroFramework.Controls.MetroTile();
            this.mpnlReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.metroTile1.Location = new System.Drawing.Point(10, 64);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1260, 5);
            this.metroTile1.TabIndex = 88;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mlblVolver
            // 
            this.mlblVolver.Location = new System.Drawing.Point(1146, 22);
            this.mlblVolver.Name = "mlblVolver";
            this.mlblVolver.Size = new System.Drawing.Size(120, 35);
            this.mlblVolver.TabIndex = 82;
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
            this.mlnkVolver.TabIndex = 83;
            this.mlnkVolver.UseSelectable = true;
            this.mlnkVolver.Click += new System.EventHandler(this.mlnkVolver_Click);
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(535, 71);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(211, 44);
            this.mlblTitulo.TabIndex = 93;
            this.mlblTitulo.Text = "Listado de reportes";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpnlReportes
            // 
            this.mpnlReportes.Controls.Add(this.mtileProcesosCaja);
            this.mpnlReportes.Controls.Add(this.mtileCierresCajas);
            this.mpnlReportes.Controls.Add(this.mtileListadoCajas);
            this.mpnlReportes.Controls.Add(this.mtileVentasXCaja);
            this.mpnlReportes.HorizontalScrollbarBarColor = true;
            this.mpnlReportes.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlReportes.HorizontalScrollbarSize = 10;
            this.mpnlReportes.Location = new System.Drawing.Point(0, 139);
            this.mpnlReportes.Name = "mpnlReportes";
            this.mpnlReportes.Size = new System.Drawing.Size(1280, 615);
            this.mpnlReportes.TabIndex = 94;
            this.mpnlReportes.VerticalScrollbarBarColor = true;
            this.mpnlReportes.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlReportes.VerticalScrollbarSize = 10;
            // 
            // mtileProcesosCaja
            // 
            this.mtileProcesosCaja.ActiveControl = null;
            this.mtileProcesosCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileProcesosCaja.Location = new System.Drawing.Point(754, 130);
            this.mtileProcesosCaja.Name = "mtileProcesosCaja";
            this.mtileProcesosCaja.Size = new System.Drawing.Size(300, 50);
            this.mtileProcesosCaja.TabIndex = 3;
            this.mtileProcesosCaja.Text = "Procesos de caja";
            this.mtileProcesosCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileProcesosCaja.UseCustomBackColor = true;
            this.mtileProcesosCaja.UseSelectable = true;
            // 
            // mtileCierresCajas
            // 
            this.mtileCierresCajas.ActiveControl = null;
            this.mtileCierresCajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileCierresCajas.Location = new System.Drawing.Point(754, 30);
            this.mtileCierresCajas.Name = "mtileCierresCajas";
            this.mtileCierresCajas.Size = new System.Drawing.Size(300, 50);
            this.mtileCierresCajas.TabIndex = 4;
            this.mtileCierresCajas.Text = "Listado cierres de cajas";
            this.mtileCierresCajas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileCierresCajas.UseCustomBackColor = true;
            this.mtileCierresCajas.UseSelectable = true;
            // 
            // mtileListadoCajas
            // 
            this.mtileListadoCajas.ActiveControl = null;
            this.mtileListadoCajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoCajas.Location = new System.Drawing.Point(226, 30);
            this.mtileListadoCajas.Name = "mtileListadoCajas";
            this.mtileListadoCajas.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoCajas.TabIndex = 5;
            this.mtileListadoCajas.Text = "Listado de cajas";
            this.mtileListadoCajas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoCajas.UseCustomBackColor = true;
            this.mtileListadoCajas.UseSelectable = true;
            // 
            // mtileVentasXCaja
            // 
            this.mtileVentasXCaja.ActiveControl = null;
            this.mtileVentasXCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileVentasXCaja.Location = new System.Drawing.Point(226, 130);
            this.mtileVentasXCaja.Name = "mtileVentasXCaja";
            this.mtileVentasXCaja.Size = new System.Drawing.Size(300, 50);
            this.mtileVentasXCaja.TabIndex = 6;
            this.mtileVentasXCaja.Text = "Detalle ventas por caja";
            this.mtileVentasXCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileVentasXCaja.UseCustomBackColor = true;
            this.mtileVentasXCaja.UseSelectable = true;
            // 
            // frmProcesoCajaRpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mpnlReportes);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Name = "frmProcesoCajaRpts";
            this.Text = "";
            this.mpnlReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroPanel mpnlReportes;
        private MetroFramework.Controls.MetroTile mtileProcesosCaja;
        private MetroFramework.Controls.MetroTile mtileCierresCajas;
        private MetroFramework.Controls.MetroTile mtileListadoCajas;
        private MetroFramework.Controls.MetroTile mtileVentasXCaja;
    }
}
