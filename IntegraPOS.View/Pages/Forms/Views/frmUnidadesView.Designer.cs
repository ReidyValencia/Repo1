namespace IntegraPOS.Pages.Forms.Views
{
    partial class frmUnidadesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidadesView));
            this.mgvUnidades = new MetroFramework.Controls.MetroGrid();
            this.EliminarUnidad = new System.Windows.Forms.DataGridViewImageColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquivalenciaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mtxtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblVolver = new MetroFramework.Controls.MetroLabel();
            this.mlnkVolver = new MetroFramework.Controls.MetroLink();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mgvUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // mgvUnidades
            // 
            this.mgvUnidades.AllowUserToAddRows = false;
            this.mgvUnidades.AllowUserToResizeRows = false;
            this.mgvUnidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgvUnidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgvUnidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EliminarUnidad,
            this.Unidad,
            this.Descripcion,
            this.EquivalenciaMH});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgvUnidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgvUnidades.EnableHeadersVisualStyles = false;
            this.mgvUnidades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgvUnidades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgvUnidades.Location = new System.Drawing.Point(100, 278);
            this.mgvUnidades.Name = "mgvUnidades";
            this.mgvUnidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgvUnidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgvUnidades.RowHeadersVisible = false;
            this.mgvUnidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgvUnidades.Size = new System.Drawing.Size(1080, 467);
            this.mgvUnidades.TabIndex = 79;
            // 
            // EliminarUnidad
            // 
            this.EliminarUnidad.DataPropertyName = "EliminarUnidad";
            this.EliminarUnidad.HeaderText = "";
            this.EliminarUnidad.Image = ((System.Drawing.Image)(resources.GetObject("EliminarUnidad.Image")));
            this.EliminarUnidad.Name = "EliminarUnidad";
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "Unidad";
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.Width = 190;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 600;
            // 
            // EquivalenciaMH
            // 
            this.EquivalenciaMH.DataPropertyName = "EquivalenciaMH";
            this.EquivalenciaMH.HeaderText = "Equivalencia MH";
            this.EquivalenciaMH.Name = "EquivalenciaMH";
            this.EquivalenciaMH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EquivalenciaMH.Width = 190;
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink2.BackgroundImage")));
            this.metroLink2.Location = new System.Drawing.Point(460, 132);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(48, 48);
            this.metroLink2.TabIndex = 78;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.Location = new System.Drawing.Point(406, 132);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(48, 48);
            this.metroLink1.TabIndex = 77;
            this.metroLink1.UseSelectable = true;
            // 
            // mtxtBuscar
            // 
            // 
            // 
            // 
            this.mtxtBuscar.CustomButton.Image = null;
            this.mtxtBuscar.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.mtxtBuscar.CustomButton.Name = "";
            this.mtxtBuscar.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtBuscar.CustomButton.TabIndex = 1;
            this.mtxtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtBuscar.CustomButton.UseSelectable = true;
            this.mtxtBuscar.CustomButton.Visible = false;
            this.mtxtBuscar.Lines = new string[0];
            this.mtxtBuscar.Location = new System.Drawing.Point(100, 145);
            this.mtxtBuscar.MaxLength = 32767;
            this.mtxtBuscar.Name = "mtxtBuscar";
            this.mtxtBuscar.PasswordChar = '\0';
            this.mtxtBuscar.PromptText = "Buscar";
            this.mtxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtBuscar.SelectedText = "";
            this.mtxtBuscar.SelectionLength = 0;
            this.mtxtBuscar.SelectionStart = 0;
            this.mtxtBuscar.ShortcutsEnabled = true;
            this.mtxtBuscar.Size = new System.Drawing.Size(300, 35);
            this.mtxtBuscar.TabIndex = 76;
            this.mtxtBuscar.UseSelectable = true;
            this.mtxtBuscar.WaterMark = "Buscar";
            this.mtxtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(406, 212);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Descripción";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(300, 35);
            this.metroTextBox1.TabIndex = 76;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Descripción";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(100, 212);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "Unidad";
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(300, 35);
            this.metroTextBox3.TabIndex = 76;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "Unidad";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(712, 212);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(300, 35);
            this.metroComboBox1.TabIndex = 80;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLink3
            // 
            this.metroLink3.BackgroundImage = global::IntegraPOS.Properties.Resources.aprobarCir48x48;
            this.metroLink3.Location = new System.Drawing.Point(1018, 199);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(48, 48);
            this.metroLink3.TabIndex = 77;
            this.metroLink3.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(540, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(200, 44);
            this.metroLabel1.TabIndex = 89;
            this.metroLabel1.Text = "Unidades";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUnidadesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.mgvUnidades);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.mtxtBuscar);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblVolver);
            this.Controls.Add(this.mlnkVolver);
            this.Name = "frmUnidadesView";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmUnidadesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgvUnidades;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox mtxtBuscar;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlblVolver;
        private MetroFramework.Controls.MetroLink mlnkVolver;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLink metroLink3;
        private System.Windows.Forms.DataGridViewImageColumn EliminarUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquivalenciaMH;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
