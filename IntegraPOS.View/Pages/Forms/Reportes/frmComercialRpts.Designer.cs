namespace IntegraPOS.Pages.Forms.Reportes
{
    partial class frmComercialRpts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComercialRpts));
            this.mgridListReportes = new MetroFramework.Controls.MetroGrid();
            this.pe_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pe_PDF = new System.Windows.Forms.DataGridViewImageColumn();
            this.pe_XLS = new System.Windows.Forms.DataGridViewImageColumn();
            this.pe_posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sYSWFIntegraPOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSWF_IntegraPOSDataSet = new IntegraPOS.SYSWF_IntegraPOSDataSet();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgridListReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSWFIntegraPOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSWF_IntegraPOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mgridListReportes
            // 
            this.mgridListReportes.AllowUserToAddRows = false;
            this.mgridListReportes.AllowUserToDeleteRows = false;
            this.mgridListReportes.AllowUserToResizeRows = false;
            this.mgridListReportes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgridListReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgridListReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgridListReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgridListReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pe_Titulo,
            this.pe_PDF,
            this.pe_XLS,
            this.pe_posicion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgridListReportes.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgridListReportes.EnableHeadersVisualStyles = false;
            this.mgridListReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgridListReportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgridListReportes.Location = new System.Drawing.Point(23, 104);
            this.mgridListReportes.MultiSelect = false;
            this.mgridListReportes.Name = "mgridListReportes";
            this.mgridListReportes.ReadOnly = true;
            this.mgridListReportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgridListReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgridListReportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgridListReportes.RowTemplate.Height = 35;
            this.mgridListReportes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mgridListReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgridListReportes.Size = new System.Drawing.Size(628, 489);
            this.mgridListReportes.TabIndex = 77;
            this.mgridListReportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgridListReportes_CellClick);
            // 
            // pe_Titulo
            // 
            this.pe_Titulo.DataPropertyName = "pe_Titulo";
            this.pe_Titulo.HeaderText = "Titulo del reporte";
            this.pe_Titulo.Name = "pe_Titulo";
            this.pe_Titulo.ReadOnly = true;
            this.pe_Titulo.Width = 450;
            // 
            // pe_PDF
            // 
            this.pe_PDF.DataPropertyName = "pe_pdf";
            this.pe_PDF.HeaderText = "PDF";
            this.pe_PDF.Image = ((System.Drawing.Image)(resources.GetObject("pe_PDF.Image")));
            this.pe_PDF.Name = "pe_PDF";
            this.pe_PDF.ReadOnly = true;
            this.pe_PDF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pe_PDF.Width = 50;
            // 
            // pe_XLS
            // 
            this.pe_XLS.DataPropertyName = "pe_xls";
            this.pe_XLS.HeaderText = "XLS";
            this.pe_XLS.Image = ((System.Drawing.Image)(resources.GetObject("pe_XLS.Image")));
            this.pe_XLS.Name = "pe_XLS";
            this.pe_XLS.ReadOnly = true;
            this.pe_XLS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pe_XLS.Width = 50;
            // 
            // pe_posicion
            // 
            this.pe_posicion.DataPropertyName = "pe_posicion";
            this.pe_posicion.HeaderText = "Posicion";
            this.pe_posicion.Name = "pe_posicion";
            this.pe_posicion.ReadOnly = true;
            this.pe_posicion.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "pe_pdf";
            this.dataGridViewImageColumn1.HeaderText = "PDF";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "pe_xls";
            this.dataGridViewImageColumn2.HeaderText = "XLS";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // sYSWFIntegraPOSDataSetBindingSource
            // 
            this.sYSWFIntegraPOSDataSetBindingSource.DataSource = this.sYSWF_IntegraPOSDataSet;
            this.sYSWFIntegraPOSDataSetBindingSource.Position = 0;
            // 
            // sYSWF_IntegraPOSDataSet
            // 
            this.sYSWF_IntegraPOSDataSet.DataSetName = "SYSWF_IntegraPOSDataSet";
            this.sYSWF_IntegraPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mlblVolver
            // 
            this.mlblVolver.Location = new System.Drawing.Point(1148, 20);
            this.mlblVolver.Name = "mlblVolver";
            this.mlblVolver.Size = new System.Drawing.Size(120, 35);
            this.mlblVolver.TabIndex = 78;
            this.mlblVolver.Text = "Volver";
            this.mlblVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlnkVolver
            // 
            this.mlnkVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mlnkVolver.BackgroundImage")));
            this.mlnkVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mlnkVolver.Location = new System.Drawing.Point(1093, 7);
            this.mlnkVolver.Name = "mlnkVolver";
            this.mlnkVolver.Size = new System.Drawing.Size(48, 48);
            this.mlnkVolver.TabIndex = 79;
            this.mlnkVolver.UseSelectable = true;
            this.mlnkVolver.Click += new System.EventHandler(this.mlnkVolver_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.metroTile1.Location = new System.Drawing.Point(10, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1260, 5);
            this.metroTile1.TabIndex = 83;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // frmComercialRpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Controls.Add(this.mgridListReportes);
            this.Name = "frmComercialRpts";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.mgridListReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSWFIntegraPOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSWF_IntegraPOSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgridListReportes;
        private System.Windows.Forms.BindingSource sYSWFIntegraPOSDataSetBindingSource;
        private SYSWF_IntegraPOSDataSet sYSWF_IntegraPOSDataSet;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe_Titulo;
        private System.Windows.Forms.DataGridViewImageColumn pe_PDF;
        private System.Windows.Forms.DataGridViewImageColumn pe_XLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn pe_posicion;
    }
}
