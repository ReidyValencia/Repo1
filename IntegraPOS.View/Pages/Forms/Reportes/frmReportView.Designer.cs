namespace IntegraPOS.Pages.Forms.Reportes
{
    partial class frmReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportView));
            this.ReportView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.mlnkCerrar = new MetroFramework.Controls.MetroLink();
            this.mlnkImprimir = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // ReportView
            // 
            this.ReportView.ActiveViewIndex = -1;
            this.ReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportView.DisplayStatusBar = false;
            this.ReportView.DisplayToolbar = false;
            this.ReportView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportView.EnableToolTips = false;
            this.ReportView.Location = new System.Drawing.Point(20, 60);
            this.ReportView.Name = "ReportView";
            this.ReportView.Size = new System.Drawing.Size(1240, 688);
            this.ReportView.TabIndex = 0;
            this.ReportView.TabStop = false;
            this.ReportView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // mlnkCerrar
            // 
            this.mlnkCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkCerrar.BackgroundImage")));
            this.mlnkCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkCerrar.Location = new System.Drawing.Point(1227, 11);
            this.mlnkCerrar.Name = "mlnkCerrar";
            this.mlnkCerrar.Size = new System.Drawing.Size(30, 30);
            this.mlnkCerrar.TabIndex = 7;
            this.mlnkCerrar.UseSelectable = true;
            this.mlnkCerrar.Click += new System.EventHandler(this.mlnkCerrar_Click);
            // 
            // mlnkImprimir
            // 
            this.mlnkImprimir.BackgroundImage = global::IntegraPOS.Properties.Resources.imprimirFichaCir48x48;
            this.mlnkImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkImprimir.Location = new System.Drawing.Point(1182, 11);
            this.mlnkImprimir.Name = "mlnkImprimir";
            this.mlnkImprimir.Size = new System.Drawing.Size(30, 30);
            this.mlnkImprimir.TabIndex = 8;
            this.mlnkImprimir.UseSelectable = true;
            // 
            // frmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.mlnkImprimir);
            this.Controls.Add(this.mlnkCerrar);
            this.Controls.Add(this.ReportView);
            this.Name = "frmReportView";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportView;
        private MetroFramework.Controls.MetroLink mlnkCerrar;
        private MetroFramework.Controls.MetroLink mlnkImprimir;
    }
}