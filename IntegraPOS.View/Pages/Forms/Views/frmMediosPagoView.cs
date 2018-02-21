using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmMediosPagoView : IntegraPOS.MasterPage
    {
        public frmMediosPagoView()
        {
            InitializeComponent();
        }

        private void frmMediosPagoView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "Detalle";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("Descripcion", typeof(string));
                vTabla.Columns.Add("TipoMedioPago", typeof(string));
                vTabla.Columns.Add("Moneda", typeof(string));

                vTabla.Rows.Add("Efectivo Local", "Efectivo en colones", "EFEC-001", "Colón");
                vTabla.Rows.Add("Efectivo $", "Efectivo en dólares", "EFEC-002", "Dólar");
                vTabla.Rows.Add("Efectivo €", "Efectivo en euros", "EFEC-003", "Euro");

                mgvMediosPago.DataSource = vTabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos Controles

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMedioPagoMant vFrmMedioPagoMant = new frmMedioPagoMant();
                vFrmMedioPagoMant.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMedioPagoMant vFrmMedioPagoMant = new frmMedioPagoMant();
                vFrmMedioPagoMant.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Evento de Teclas



        #endregion

        private void mgvMediosPago_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmMedioPagoMant vFrmMedioPagoMant = new frmMedioPagoMant();
                        vFrmMedioPagoMant.Show();
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
