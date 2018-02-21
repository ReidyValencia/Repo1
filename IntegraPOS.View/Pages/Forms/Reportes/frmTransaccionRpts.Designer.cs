namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmTransaccionRpts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaccionRpts));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.mpnlReportes = new MetroFramework.Controls.MetroPanel();
            this.mtileListadoApartados = new MetroFramework.Controls.MetroTile();
            this.mtileListadoEntradas = new MetroFramework.Controls.MetroTile();
            this.mtileListadoCotizaciones = new MetroFramework.Controls.MetroTile();
            this.mtileListadoFacturas = new MetroFramework.Controls.MetroTile();
            this.mtileListadoRecibos = new MetroFramework.Controls.MetroTile();
            this.mtileListadoPedidos = new MetroFramework.Controls.MetroTile();
            this.mtileVentasXProducto = new MetroFramework.Controls.MetroTile();
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
            this.mlblVolver.Location = new System.Drawing.Point(1146, 23);
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
            this.mlnkVolver.Location = new System.Drawing.Point(1091, 10);
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
            this.mpnlReportes.Controls.Add(this.mtileListadoApartados);
            this.mpnlReportes.Controls.Add(this.mtileListadoEntradas);
            this.mpnlReportes.Controls.Add(this.mtileListadoCotizaciones);
            this.mpnlReportes.Controls.Add(this.mtileListadoFacturas);
            this.mpnlReportes.Controls.Add(this.mtileListadoRecibos);
            this.mpnlReportes.Controls.Add(this.mtileListadoPedidos);
            this.mpnlReportes.Controls.Add(this.mtileVentasXProducto);
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
            // mtileListadoApartados
            // 
            this.mtileListadoApartados.ActiveControl = null;
            this.mtileListadoApartados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoApartados.Location = new System.Drawing.Point(754, 230);
            this.mtileListadoApartados.Name = "mtileListadoApartados";
            this.mtileListadoApartados.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoApartados.TabIndex = 2;
            this.mtileListadoApartados.Text = "Listado de apartados";
            this.mtileListadoApartados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoApartados.UseCustomBackColor = true;
            this.mtileListadoApartados.UseSelectable = true;
            // 
            // mtileListadoEntradas
            // 
            this.mtileListadoEntradas.ActiveControl = null;
            this.mtileListadoEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoEntradas.Location = new System.Drawing.Point(754, 130);
            this.mtileListadoEntradas.Name = "mtileListadoEntradas";
            this.mtileListadoEntradas.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoEntradas.TabIndex = 2;
            this.mtileListadoEntradas.Text = "Listado de entradas";
            this.mtileListadoEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoEntradas.UseCustomBackColor = true;
            this.mtileListadoEntradas.UseSelectable = true;
            // 
            // mtileListadoCotizaciones
            // 
            this.mtileListadoCotizaciones.ActiveControl = null;
            this.mtileListadoCotizaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoCotizaciones.Location = new System.Drawing.Point(754, 30);
            this.mtileListadoCotizaciones.Name = "mtileListadoCotizaciones";
            this.mtileListadoCotizaciones.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoCotizaciones.TabIndex = 2;
            this.mtileListadoCotizaciones.Text = "Listado de cotizaciones";
            this.mtileListadoCotizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoCotizaciones.UseCustomBackColor = true;
            this.mtileListadoCotizaciones.UseSelectable = true;
            // 
            // mtileListadoFacturas
            // 
            this.mtileListadoFacturas.ActiveControl = null;
            this.mtileListadoFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoFacturas.Location = new System.Drawing.Point(226, 330);
            this.mtileListadoFacturas.Name = "mtileListadoFacturas";
            this.mtileListadoFacturas.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoFacturas.TabIndex = 2;
            this.mtileListadoFacturas.Text = "Listado de facturas";
            this.mtileListadoFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoFacturas.UseCustomBackColor = true;
            this.mtileListadoFacturas.UseSelectable = true;
            // 
            // mtileListadoRecibos
            // 
            this.mtileListadoRecibos.ActiveControl = null;
            this.mtileListadoRecibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoRecibos.Location = new System.Drawing.Point(226, 230);
            this.mtileListadoRecibos.Name = "mtileListadoRecibos";
            this.mtileListadoRecibos.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoRecibos.TabIndex = 2;
            this.mtileListadoRecibos.Text = "Listado de recibos";
            this.mtileListadoRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoRecibos.UseCustomBackColor = true;
            this.mtileListadoRecibos.UseSelectable = true;
            // 
            // mtileListadoPedidos
            // 
            this.mtileListadoPedidos.ActiveControl = null;
            this.mtileListadoPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoPedidos.Location = new System.Drawing.Point(226, 130);
            this.mtileListadoPedidos.Name = "mtileListadoPedidos";
            this.mtileListadoPedidos.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoPedidos.TabIndex = 2;
            this.mtileListadoPedidos.Text = "Listado de pedidos";
            this.mtileListadoPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoPedidos.UseCustomBackColor = true;
            this.mtileListadoPedidos.UseSelectable = true;
            // 
            // mtileVentasXProducto
            // 
            this.mtileVentasXProducto.ActiveControl = null;
            this.mtileVentasXProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileVentasXProducto.Location = new System.Drawing.Point(226, 30);
            this.mtileVentasXProducto.Name = "mtileVentasXProducto";
            this.mtileVentasXProducto.Size = new System.Drawing.Size(300, 50);
            this.mtileVentasXProducto.TabIndex = 2;
            this.mtileVentasXProducto.Text = "Ventas por producto";
            this.mtileVentasXProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileVentasXProducto.UseCustomBackColor = true;
            this.mtileVentasXProducto.UseSelectable = true;
            // 
            // frmTransaccionRpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mpnlReportes);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Name = "frmTransaccionRpts";
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
        private MetroFramework.Controls.MetroTile mtileListadoPedidos;
        private MetroFramework.Controls.MetroTile mtileVentasXProducto;
        private MetroFramework.Controls.MetroTile mtileListadoFacturas;
        private MetroFramework.Controls.MetroTile mtileListadoRecibos;
        private MetroFramework.Controls.MetroTile mtileListadoCotizaciones;
        private MetroFramework.Controls.MetroTile mtileListadoEntradas;
        private MetroFramework.Controls.MetroTile mtileListadoApartados;
    }
}
