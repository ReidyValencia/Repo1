namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmAdministracionRpts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracionRpts));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.mpnlReportes = new MetroFramework.Controls.MetroPanel();
            this.mtileListadoMonedas = new MetroFramework.Controls.MetroTile();
            this.mtileListadoSucursales = new MetroFramework.Controls.MetroTile();
            this.mtileTransacXUsuario = new MetroFramework.Controls.MetroTile();
            this.mtileUsuariosXPerfil = new MetroFramework.Controls.MetroTile();
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
            this.metroTile1.TabIndex = 75;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // mlblVolver
            // 
            this.mlblVolver.Location = new System.Drawing.Point(1146, 22);
            this.mlblVolver.Name = "mlblVolver";
            this.mlblVolver.Size = new System.Drawing.Size(120, 35);
            this.mlblVolver.TabIndex = 69;
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
            this.mlnkVolver.TabIndex = 70;
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
            this.mlblTitulo.TabIndex = 80;
            this.mlblTitulo.Text = "Listado de reportes";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpnlReportes
            // 
            this.mpnlReportes.Controls.Add(this.mtileListadoMonedas);
            this.mpnlReportes.Controls.Add(this.mtileListadoSucursales);
            this.mpnlReportes.Controls.Add(this.mtileTransacXUsuario);
            this.mpnlReportes.Controls.Add(this.mtileUsuariosXPerfil);
            this.mpnlReportes.HorizontalScrollbarBarColor = true;
            this.mpnlReportes.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnlReportes.HorizontalScrollbarSize = 10;
            this.mpnlReportes.Location = new System.Drawing.Point(0, 139);
            this.mpnlReportes.Name = "mpnlReportes";
            this.mpnlReportes.Size = new System.Drawing.Size(1280, 615);
            this.mpnlReportes.TabIndex = 81;
            this.mpnlReportes.VerticalScrollbarBarColor = true;
            this.mpnlReportes.VerticalScrollbarHighlightOnWheel = false;
            this.mpnlReportes.VerticalScrollbarSize = 10;
            // 
            // mtileListadoMonedas
            // 
            this.mtileListadoMonedas.ActiveControl = null;
            this.mtileListadoMonedas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoMonedas.Location = new System.Drawing.Point(490, 198);
            this.mtileListadoMonedas.Name = "mtileListadoMonedas";
            this.mtileListadoMonedas.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoMonedas.TabIndex = 2;
            this.mtileListadoMonedas.Text = "Listado de monedas";
            this.mtileListadoMonedas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoMonedas.UseCustomBackColor = true;
            this.mtileListadoMonedas.UseSelectable = true;
            // 
            // mtileListadoSucursales
            // 
            this.mtileListadoSucursales.ActiveControl = null;
            this.mtileListadoSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileListadoSucursales.Location = new System.Drawing.Point(490, 142);
            this.mtileListadoSucursales.Name = "mtileListadoSucursales";
            this.mtileListadoSucursales.Size = new System.Drawing.Size(300, 50);
            this.mtileListadoSucursales.TabIndex = 2;
            this.mtileListadoSucursales.Text = "Listado de sucursales";
            this.mtileListadoSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileListadoSucursales.UseCustomBackColor = true;
            this.mtileListadoSucursales.UseSelectable = true;
            // 
            // mtileTransacXUsuario
            // 
            this.mtileTransacXUsuario.ActiveControl = null;
            this.mtileTransacXUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileTransacXUsuario.Location = new System.Drawing.Point(490, 86);
            this.mtileTransacXUsuario.Name = "mtileTransacXUsuario";
            this.mtileTransacXUsuario.Size = new System.Drawing.Size(300, 50);
            this.mtileTransacXUsuario.TabIndex = 2;
            this.mtileTransacXUsuario.Text = "Transacciones por usuario";
            this.mtileTransacXUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileTransacXUsuario.UseCustomBackColor = true;
            this.mtileTransacXUsuario.UseSelectable = true;
            // 
            // mtileUsuariosXPerfil
            // 
            this.mtileUsuariosXPerfil.ActiveControl = null;
            this.mtileUsuariosXPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mtileUsuariosXPerfil.Location = new System.Drawing.Point(490, 30);
            this.mtileUsuariosXPerfil.Name = "mtileUsuariosXPerfil";
            this.mtileUsuariosXPerfil.Size = new System.Drawing.Size(300, 50);
            this.mtileUsuariosXPerfil.TabIndex = 2;
            this.mtileUsuariosXPerfil.Text = "Usuarios por perfil";
            this.mtileUsuariosXPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtileUsuariosXPerfil.UseCustomBackColor = true;
            this.mtileUsuariosXPerfil.UseSelectable = true;
            // 
            // frmAdministracionRpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mpnlReportes);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Name = "frmAdministracionRpts";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmAdministracionRpts_Load);
            this.mpnlReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroPanel mpnlReportes;
        private MetroFramework.Controls.MetroTile mtileUsuariosXPerfil;
        private MetroFramework.Controls.MetroTile mtileTransacXUsuario;
        private MetroFramework.Controls.MetroTile mtileListadoSucursales;
        private MetroFramework.Controls.MetroTile mtileListadoMonedas;
    }
}
