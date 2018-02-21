using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmTransaccionesView : IntegraPOS.MasterPage
    {
        public frmTransaccionesView()
        {
            InitializeComponent();
        }

        #region Eventos Controles

        private void frmTransaccionesView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Identificador", typeof(string));
                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("TipoDocumento", typeof(string));
                vTabla.Columns.Add("Consecutivo", typeof(string));
                vTabla.Columns.Add("GeneraAsiento", typeof(bool));

                vTabla.Rows.Add("VEN001", "Factura contado", "FAC", "1", true);
                vTabla.Rows.Add("VEN002", "Factura crédito", "VEN", "215", true);
                vTabla.Rows.Add("VEN003", "Facturas especiales", "FA1", "14", false);

                mgvTransacciones.DataSource = vTabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmTransaccionMant vFrmTransaccionMant = new frmTransaccionMant();
                vFrmTransaccionMant.Show();
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
                frmTransaccionMant vFrmTransaccionMant = new frmTransaccionMant();
                vFrmTransaccionMant.Show();
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
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Evento de Teclas



        #endregion

        private void mgvTransacciones_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmTransaccionMant vFrmTransaccionMant = new frmTransaccionMant();
                        vFrmTransaccionMant.Show();
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
