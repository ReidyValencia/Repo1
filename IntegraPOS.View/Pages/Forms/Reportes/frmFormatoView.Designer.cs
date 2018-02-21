namespace IntegraPOS.Pages.Forms.Reportes
{
    partial class frmFormatoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormatoView));
            this.formatView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.mlnkImprimir = new MetroFramework.Controls.MetroLink();
            this.mlnkCerrar = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // formatView
            // 
            this.formatView.ActiveViewIndex = -1;
            this.formatView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formatView.Cursor = System.Windows.Forms.Cursors.Default;
            this.formatView.DisplayStatusBar = false;
            this.formatView.DisplayToolbar = false;
            this.formatView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formatView.Location = new System.Drawing.Point(20, 60);
            this.formatView.Name = "formatView";
            this.formatView.Size = new System.Drawing.Size(1240, 688);
            this.formatView.TabIndex = 0;
            this.formatView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // mlnkImprimir
            // 
            this.mlnkImprimir.BackgroundImage = global::IntegraPOS.Properties.Resources.imprimirFichaCir48x48;
            this.mlnkImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkImprimir.Location = new System.Drawing.Point(1180, 24);
            this.mlnkImprimir.Name = "mlnkImprimir";
            this.mlnkImprimir.Size = new System.Drawing.Size(31, 30);
            this.mlnkImprimir.TabIndex = 10;
            this.mlnkImprimir.UseSelectable = true;
            this.mlnkImprimir.Click += new System.EventHandler(this.mlnkImprimir_Click);
            // 
            // mlnkCerrar
            // 
            this.mlnkCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCerrar.BackgroundImage")));
            this.mlnkCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkCerrar.Location = new System.Drawing.Point(1217, 24);
            this.mlnkCerrar.Name = "mlnkCerrar";
            this.mlnkCerrar.Size = new System.Drawing.Size(31, 30);
            this.mlnkCerrar.TabIndex = 9;
            this.mlnkCerrar.UseSelectable = true;
            this.mlnkCerrar.Click += new System.EventHandler(this.mlnkCerrar_Click);
            // 
            // frmFormatoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlnkImprimir);
            this.Controls.Add(this.mlnkCerrar);
            this.Controls.Add(this.formatView);
            this.Name = "frmFormatoView";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer formatView;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private MetroFramework.Controls.MetroLink mlnkImprimir;
        private MetroFramework.Controls.MetroLink mlnkCerrar;
    }
}