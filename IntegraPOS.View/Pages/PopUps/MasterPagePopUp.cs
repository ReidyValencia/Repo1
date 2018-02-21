using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace IntegraPOS
{
    public partial class MasterPagePopUp : MetroFramework.Forms.MetroForm
    {
        public MasterPagePopUp()
        {
            InitializeComponent();
        }

        private void MasterPagePopUp_Load(object sender, EventArgs e)
        {
            pv_FormatoGeneral();
        }

        private void pv_FormatoGeneral()
        {
            #region WindowsForms - MetroTile

            foreach (MetroTile MTile in Controls.OfType<MetroTile>())
            {
                MTile.AutoSize = false;
                MTile.ForeColor = Color.White;
                MTile.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                MTile.UseCustomForeColor = true;
                MTile.UseCustomBackColor = true;
                MTile.TileTextFontSize = MetroTileTextSize.Tall;
                MTile.TileTextFontWeight = MetroTileTextWeight.Bold;

                #region MetroTile Contiene MetroLabel

                foreach (MetroLabel MTileLabel in MTile.Controls.OfType<MetroLabel>())
                {
                    MTileLabel.AutoSize = false;
                    MTileLabel.FontSize = MetroLabelSize.Tall;
                    MTileLabel.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                    MTileLabel.UseCustomBackColor = true;
                    MTileLabel.FontWeight = MetroLabelWeight.Bold;
                }

                #endregion                
            }

            #endregion

            #region WindowsForms - MetroLabel

            foreach (MetroLabel MLabel in Controls.OfType<MetroLabel>())
            {
                MLabel.AutoSize = false;
                MLabel.FontSize = MetroLabelSize.Tall;
                MLabel.FontWeight = MetroLabelWeight.Bold;
            }

            #endregion

            #region WindowsForms - MetroTextBox

            foreach (MetroTextBox MTextBox in Controls.OfType<MetroTextBox>())
            {
                MTextBox.Text = "";
                MTextBox.MaxLength = 500;
                MTextBox.Style = MetroColorStyle.Blue;
                MTextBox.FontSize = MetroTextBoxSize.Tall;
            }

            #endregion

            #region WindowsForm - MetroButton

            foreach (MetroButton MButton in Controls.OfType<MetroButton>())
            {
                MButton.AutoSize = false;
                MButton.Size = new Size(120, 40);
                MButton.FontSize = MetroButtonSize.Tall;
                MButton.ForeColor = Color.White;
                MButton.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                MButton.UseCustomForeColor = true;
                MButton.UseCustomBackColor = true;
                MButton.UseSelectable = true;
            }


            #endregion

            #region WindowsForm - MetroComboBox

            foreach (MetroComboBox MComboBox in Controls.OfType<MetroComboBox>())
            {
                MComboBox.FontSize = MetroComboBoxSize.Tall;
                MComboBox.FormattingEnabled = true;
                MComboBox.UseSelectable = true;
            }

            #endregion

            #region  WindowsForm - MetroPanel

            foreach (MetroPanel MPanel in Controls.OfType<MetroPanel>())
            {
                MPanel.HorizontalScrollbarBarColor = true;
                MPanel.HorizontalScrollbarHighlightOnWheel = false;
                MPanel.HorizontalScrollbarSize = 10;
                MPanel.VerticalScrollbarSize = 10;

                #region MetroPanel Contiene MetroTile

                foreach (MetroTile MPanelTile in MPanel.Controls.OfType<MetroTile>())
                {
                    MPanelTile.AutoSize = false;
                    MPanelTile.ForeColor = Color.White;
                    MPanelTile.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                    MPanelTile.UseCustomForeColor = true;
                    MPanelTile.UseCustomBackColor = true;
                    MPanelTile.TileTextFontSize = MetroTileTextSize.Tall;
                    MPanelTile.TileTextFontWeight = MetroTileTextWeight.Bold;

                    #region MetroTile Contiene MetroLabel

                    foreach (MetroLabel MPanelTileLabel in MPanelTile.Controls.OfType<MetroLabel>())
                    {
                        MPanelTileLabel.AutoSize = false;
                        MPanelTileLabel.FontSize = MetroLabelSize.Tall;
                        MPanelTileLabel.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                        MPanelTileLabel.UseCustomBackColor = true;
                        MPanelTileLabel.FontWeight = MetroLabelWeight.Bold;
                    }

                    #endregion
                }

                #endregion

                #region MetroPanel Contiene MetroLabel

                foreach (MetroLabel MPanelLabel in MPanel.Controls.OfType<MetroLabel>())
                {
                    MPanelLabel.AutoSize = false;
                    MPanelLabel.FontSize = MetroLabelSize.Tall;
                    MPanelLabel.FontWeight = MetroLabelWeight.Bold;
                    MPanelLabel.UseCustomBackColor = true;
                }

                #endregion

                #region MetroPanel Contiene MetroTextBox

                foreach (MetroTextBox MPanelTextBox in MPanel.Controls.OfType<MetroTextBox>())
                {
                    MPanelTextBox.Text = "";
                    MPanelTextBox.MaxLength = 500;
                    MPanelTextBox.Style = MetroColorStyle.Blue;
                    MPanelTextBox.FontSize = MetroTextBoxSize.Tall;
                }

                #endregion

                #region MetroPanel Contiene MetroButton

                foreach (MetroButton MPanelButton in MPanel.Controls.OfType<MetroButton>())
                {
                    MPanelButton.AutoSize = false;
                    MPanelButton.Size = new Size(120, 40);
                    MPanelButton.FontSize = MetroButtonSize.Tall;
                    MPanelButton.ForeColor = Color.White;
                    MPanelButton.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                    MPanelButton.UseCustomForeColor = true;
                    MPanelButton.UseCustomBackColor = true;
                    MPanelButton.UseSelectable = true;
                }

                #endregion

                #region MetroPanel Contiene MetroComboBox

                foreach (MetroComboBox MPanelComboBox in Controls.OfType<MetroComboBox>())
                {
                    MPanelComboBox.FontSize = MetroComboBoxSize.Tall;
                    MPanelComboBox.FormattingEnabled = true;
                    MPanelComboBox.UseSelectable = true;
                }

                #endregion

                #region MetroPanel Contiene MetroGridView

                foreach (MetroGrid MPanelGrid in MPanel.Controls.OfType<MetroGrid>())
                {
                    if (this.Name.Equals("frmPopUpMedioPago"))
                    {
                        DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle();
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                        MPanelGrid.AutoSize = false;
                        MPanelGrid.BackgroundColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        MPanelGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        MPanelGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        MPanelGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        headerCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        headerCellStyle.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                        headerCellStyle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        headerCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        headerCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                        headerCellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                        headerCellStyle.WrapMode = DataGridViewTriState.True;
                        MPanelGrid.ColumnHeadersDefaultCellStyle = headerCellStyle;
                        MPanelGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        cellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        cellStyle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        cellStyle.ForeColor = Color.Black;
                        cellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(170)))), ((int)(((byte)(228)))));
                        cellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                        cellStyle.WrapMode = DataGridViewTriState.False;
                        MPanelGrid.DefaultCellStyle = cellStyle;
                        MPanelGrid.EnableHeadersVisualStyles = false;
                        MPanelGrid.RowHeadersVisible = false;
                        MPanelGrid.RowTemplate.Height = 50;
                        MPanelGrid.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        MPanelGrid.GridColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        MPanelGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        MPanelGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        MPanelGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                    else
                    {
                        DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle();
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                        MPanelGrid.AutoSize = false;
                        MPanelGrid.BackgroundColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        MPanelGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        MPanelGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        MPanelGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        headerCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        headerCellStyle.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                        headerCellStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        headerCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        headerCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                        headerCellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                        headerCellStyle.WrapMode = DataGridViewTriState.True;
                        MPanelGrid.ColumnHeadersDefaultCellStyle = headerCellStyle;
                        MPanelGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        cellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        cellStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
                        cellStyle.ForeColor = Color.Black;
                        cellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(170)))), ((int)(((byte)(228)))));
                        cellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                        cellStyle.WrapMode = DataGridViewTriState.False;
                        MPanelGrid.DefaultCellStyle = cellStyle;
                        MPanelGrid.EnableHeadersVisualStyles = false;
                        MPanelGrid.RowHeadersVisible = false;
                        MPanelGrid.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                        MPanelGrid.GridColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        MPanelGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        MPanelGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        MPanelGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }

                #endregion
            }

            #endregion

            #region WindowsForm - MetroGridView

            foreach (MetroGrid MGrid in Controls.OfType<MetroGrid>())
            {
                DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle();
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                MGrid.AutoSize = false;
                MGrid.BackgroundColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                MGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
                MGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
                MGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                headerCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                headerCellStyle.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                headerCellStyle.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                headerCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                headerCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                headerCellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                headerCellStyle.WrapMode = DataGridViewTriState.True;
                MGrid.ColumnHeadersDefaultCellStyle = headerCellStyle;
                MGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                cellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                cellStyle.Font = new Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                cellStyle.ForeColor = Color.Black;
                cellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(170)))), ((int)(((byte)(228)))));
                cellStyle.SelectionForeColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                cellStyle.WrapMode = DataGridViewTriState.False;
                MGrid.DefaultCellStyle = cellStyle;
                MGrid.EnableHeadersVisualStyles = false;
                MGrid.RowHeadersVisible = false;
                MGrid.Font = new Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                MGrid.GridColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                MGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                MGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                MGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            #endregion

        }
    }
}
