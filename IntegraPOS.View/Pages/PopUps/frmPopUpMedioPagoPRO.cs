using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using IntegraPOS.Model.Entidades.Clases;

namespace IntegraPOS
{
    public partial class frmPopUpMedioPagoPRO : MasterPagePopUp
    {
        private int pe_FormaPago;
        private int pe_CodMoneda;
        private decimal pe_ValorTasa;
        private decimal pe_TotalPagar;

        private MedioPagoModel pe_PopUpMedioPagoModel = new MedioPagoModel();
        private List<MedioPagoModel> ps_PopUpMedioPagoModel;

        public frmPopUpMedioPagoPRO()
        {
            InitializeComponent();
        }

        public frmPopUpMedioPagoPRO(int pe_FormaPago, int pe_CodMoneda, decimal pe_ValorTasa, decimal pe_TotalPagar) : this()
        {
            try
            {
                this.pe_FormaPago = pe_FormaPago;
                this.pe_CodMoneda = pe_CodMoneda;
                this.pe_ValorTasa = pe_ValorTasa;
                this.pe_TotalPagar = pe_TotalPagar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmPopUpMedioPago_Load(object sender, EventArgs e)
        {
            try
            {
                pe_PopUpMedioPagoModel.pb_ObtenerMediosPago("CAJ-001", DateTime.Now.ToString("yyyy-dd-MM"), pe_CodMoneda, pe_ValorTasa, pe_FormaPago, ref ps_PopUpMedioPagoModel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region POR SI ACASO

        /*
        private void frmPopUpMedioPago_Load(object sender, EventArgs e)
        {
            try
            {
                int x = 10;

                for (int i = 1; i < 10; i++)
                {
                    MetroTile MTile = new MetroTile();

                    MTile.AutoSize = false;
                    MTile.Size = new Size(160, 50);
                    MTile.Location = new System.Drawing.Point(x, 10);
                    MTile.TextAlign = ContentAlignment.MiddleCenter;
                    MTile.TileTextFontSize = MetroTileTextSize.Tall;
                    MTile.TileTextFontWeight = MetroTileTextWeight.Bold;

                    MTile.Text = "MEDIO PAGO " + i.ToString();
                    MTile.Click += pv_SeleccionarTile;
                    mplTipoMedioPago.Controls.Add(MTile);

                    //MTile.Tag = i;
                    //MTile.Style = (MetroColorStyle)i;

                    x = x + 170;
                }                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_SeleccionarTile(object sender, EventArgs e)
        {
            try
            {
                if (((MetroTile)sender).Style.Equals(MetroColorStyle.Green))
                {
                    ((MetroTile)sender).Style = MetroColorStyle.Blue;
                }
                else
                {
                    ((MetroTile)sender).Style = MetroColorStyle.Green;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */


        #endregion

    }
}
