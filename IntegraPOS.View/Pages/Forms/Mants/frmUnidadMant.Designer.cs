namespace IntegraPOS.Pages.Forms.Mants
{
    partial class frmUnidadMant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidadMant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlblCancelar = new MetroFramework.Controls.MetroLabel();
            this.mlnkCancelar = new MetroFramework.Controls.MetroLink();
            this.mlblGuardar = new MetroFramework.Controls.MetroLabel();
            this.mlnkNuevo = new MetroFramework.Controls.MetroLink();
            this.mlblRecargar = new MetroFramework.Controls.MetroLabel();
            this.mlnkRecargar = new MetroFramework.Controls.MetroLink();
            this.mlblTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.mgvUnidades = new MetroFramework.Controls.MetroGrid();
            this.EliminarUnidad = new System.Windows.Forms.DataGridViewImageColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquivalenciaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.mtxtBuscar = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgvUnidades)).BeginInit();
            this.SuspendLayout();
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
            // mlblCancelar
            // 
            this.mlblCancelar.Location = new System.Drawing.Point(1146, 22);
            this.mlblCancelar.Name = "mlblCancelar";
            this.mlblCancelar.Size = new System.Drawing.Size(120, 35);
            this.mlblCancelar.TabIndex = 83;
            this.mlblCancelar.Text = "Cancelar";
            this.mlblCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.mlblRecargar.TabIndex = 105;
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
            this.mlnkRecargar.TabIndex = 106;
            this.mlnkRecargar.UseSelectable = true;
            // 
            // mlblTitulo
            // 
            this.mlblTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblTitulo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTitulo.Location = new System.Drawing.Point(535, 68);
            this.mlblTitulo.Name = "mlblTitulo";
            this.mlblTitulo.Size = new System.Drawing.Size(211, 44);
            this.mlblTitulo.TabIndex = 86;
            this.mlblTitulo.Text = "Unidades";
            this.mlblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 29;
            this.metroComboBox1.Location = new System.Drawing.Point(718, 211);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(300, 35);
            this.metroComboBox1.TabIndex = 114;
            this.metroComboBox1.UseSelectable = true;
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
            this.mgvUnidades.Location = new System.Drawing.Point(106, 277);
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
            this.mgvUnidades.TabIndex = 113;
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
            this.metroLink2.Location = new System.Drawing.Point(466, 131);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(48, 48);
            this.metroLink2.TabIndex = 112;
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink3
            // 
            this.metroLink3.BackgroundImage = global::IntegraPOS.Properties.Resources.aprobarCir48x48;
            this.metroLink3.Location = new System.Drawing.Point(1024, 198);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(48, 48);
            this.metroLink3.TabIndex = 110;
            this.metroLink3.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.Location = new System.Drawing.Point(412, 131);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(48, 48);
            this.metroLink1.TabIndex = 111;
            this.metroLink1.UseSelectable = true;
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
            this.metroTextBox3.Location = new System.Drawing.Point(106, 211);
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
            this.metroTextBox3.TabIndex = 107;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "Unidad";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.metroTextBox1.Location = new System.Drawing.Point(412, 211);
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
            this.metroTextBox1.TabIndex = 108;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Descripción";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.mtxtBuscar.Location = new System.Drawing.Point(106, 144);
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
            this.mtxtBuscar.TabIndex = 109;
            this.mtxtBuscar.UseSelectable = true;
            this.mtxtBuscar.WaterMark = "Buscar";
            this.mtxtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmUnidadMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.mgvUnidades);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.mtxtBuscar);
            this.Controls.Add(this.mlblRecargar);
            this.Controls.Add(this.mlnkRecargar);
            this.Controls.Add(this.mlblTitulo);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mlblCancelar);
            this.Controls.Add(this.mlnkCancelar);
            this.Controls.Add(this.mlblGuardar);
            this.Controls.Add(this.mlnkNuevo);
            this.Name = "frmUnidadMant";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.mgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlblCancelar;
        private MetroFramework.Controls.MetroLink mlnkCancelar;
        private MetroFramework.Controls.MetroLabel mlblGuardar;
        private MetroFramework.Controls.MetroLink mlnkNuevo;
        private MetroFramework.Controls.MetroLabel mlblRecargar;
        private MetroFramework.Controls.MetroLink mlnkRecargar;
        private MetroFramework.Controls.MetroLabel mlblTitulo;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroGrid mgvUnidades;
        private System.Windows.Forms.DataGridViewImageColumn EliminarUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquivalenciaMH;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox mtxtBuscar;
    }
}
