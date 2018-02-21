namespace IntegraPOS
{
    partial class frmAcceso
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
            this.mtxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.mtxtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.mlblInicioSesion = new MetroFramework.Controls.MetroLabel();
            this.mbtnAccesar = new MetroFramework.Controls.MetroButton();
            this.mlnkLogo = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mtxtUsuario
            // 
            this.mtxtUsuario.CausesValidation = false;
            // 
            // 
            // 
            this.mtxtUsuario.CustomButton.Image = null;
            this.mtxtUsuario.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.mtxtUsuario.CustomButton.Name = "";
            this.mtxtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuario.CustomButton.TabIndex = 1;
            this.mtxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuario.CustomButton.UseSelectable = true;
            this.mtxtUsuario.CustomButton.Visible = false;
            this.mtxtUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.mtxtUsuario.Lines = new string[0];
            this.mtxtUsuario.Location = new System.Drawing.Point(359, 85);
            this.mtxtUsuario.MaxLength = 32767;
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.PasswordChar = '\0';
            this.mtxtUsuario.PromptText = "Nombre de Usuario";
            this.mtxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuario.SelectedText = "";
            this.mtxtUsuario.SelectionLength = 0;
            this.mtxtUsuario.SelectionStart = 0;
            this.mtxtUsuario.ShortcutsEnabled = true;
            this.mtxtUsuario.Size = new System.Drawing.Size(198, 23);
            this.mtxtUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuario.TabIndex = 0;
            this.mtxtUsuario.UseSelectable = true;
            this.mtxtUsuario.WaterMark = "Nombre de Usuario";
            this.mtxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtUsuario_KeyPress);
            // 
            // mtxtContrasena
            // 
            // 
            // 
            // 
            this.mtxtContrasena.CustomButton.Image = null;
            this.mtxtContrasena.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.mtxtContrasena.CustomButton.Name = "";
            this.mtxtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtContrasena.CustomButton.TabIndex = 1;
            this.mtxtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtContrasena.CustomButton.UseSelectable = true;
            this.mtxtContrasena.CustomButton.Visible = false;
            this.mtxtContrasena.ForeColor = System.Drawing.Color.Transparent;
            this.mtxtContrasena.Lines = new string[0];
            this.mtxtContrasena.Location = new System.Drawing.Point(359, 133);
            this.mtxtContrasena.MaxLength = 32767;
            this.mtxtContrasena.Name = "mtxtContrasena";
            this.mtxtContrasena.PasswordChar = '*';
            this.mtxtContrasena.PromptText = "Contraseña";
            this.mtxtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtContrasena.SelectedText = "";
            this.mtxtContrasena.SelectionLength = 0;
            this.mtxtContrasena.SelectionStart = 0;
            this.mtxtContrasena.ShortcutsEnabled = true;
            this.mtxtContrasena.Size = new System.Drawing.Size(198, 23);
            this.mtxtContrasena.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtContrasena.TabIndex = 1;
            this.mtxtContrasena.UseSelectable = true;
            this.mtxtContrasena.WaterMark = "Contraseña";
            this.mtxtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtContrasena_KeyPress);
            // 
            // mlblInicioSesion
            // 
            this.mlblInicioSesion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblInicioSesion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblInicioSesion.Location = new System.Drawing.Point(359, 46);
            this.mlblInicioSesion.Name = "mlblInicioSesion";
            this.mlblInicioSesion.Size = new System.Drawing.Size(198, 25);
            this.mlblInicioSesion.TabIndex = 0;
            this.mlblInicioSesion.Text = "Inicio de Sesión";
            this.mlblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mbtnAccesar
            // 
            this.mbtnAccesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.mbtnAccesar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.mbtnAccesar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnAccesar.Location = new System.Drawing.Point(359, 177);
            this.mbtnAccesar.Name = "mbtnAccesar";
            this.mbtnAccesar.Size = new System.Drawing.Size(198, 40);
            this.mbtnAccesar.TabIndex = 7;
            this.mbtnAccesar.Text = "Accesar";
            this.mbtnAccesar.UseCustomBackColor = true;
            this.mbtnAccesar.UseCustomForeColor = true;
            this.mbtnAccesar.UseSelectable = true;
            this.mbtnAccesar.Click += new System.EventHandler(this.mbtnAccesar_Click);
            // 
            // mlnkLogo
            // 
            this.mlnkLogo.BackgroundImage = global::IntegraPOS.Properties.Resources.logoIntegraPOS420x150_v9;
            this.mlnkLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mlnkLogo.Location = new System.Drawing.Point(3, 85);
            this.mlnkLogo.Name = "mlnkLogo";
            this.mlnkLogo.Size = new System.Drawing.Size(350, 125);
            this.mlnkLogo.TabIndex = 13;
            this.mlnkLogo.UseSelectable = true;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(586, 263);
            this.Controls.Add(this.mlnkLogo);
            this.Controls.Add(this.mbtnAccesar);
            this.Controls.Add(this.mlblInicioSesion);
            this.Controls.Add(this.mtxtContrasena);
            this.Controls.Add(this.mtxtUsuario);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "frmAcceso";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox mtxtUsuario;
        private MetroFramework.Controls.MetroTextBox mtxtContrasena;
        private MetroFramework.Controls.MetroLabel mlblInicioSesion;
        private MetroFramework.Controls.MetroButton mbtnAccesar;
        private MetroFramework.Controls.MetroLink mlnkLogo;
    }
}

