using IntegraPOS.Pages.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmCierreCajaMant : IntegraPOS.MasterPage
    {
        public frmCierreCajaMant()
        {
            InitializeComponent();
        }

        private void frmCierreCajaMant_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTablaMPago = new DataTable();

                vTablaMPago.TableName = "DetalleMedioPago";
                vTablaMPago.Rows.Clear();

                vTablaMPago.Columns.Add("TipoMedioPago", typeof(string));
                vTablaMPago.Columns.Add("Nombre", typeof(string));
                vTablaMPago.Columns.Add("TasaCambio", typeof(string));
                vTablaMPago.Columns.Add("ValoresReportados", typeof(string));
                vTablaMPago.Columns.Add("ValReportadosL", typeof(string));

                vTablaMPago.Rows.Add("Efectivo", "Efectivo Local", "1.00", "0.00", "0.00");
                vTablaMPago.Rows.Add("Efectivo", "Efectivo $", "1.00", "0.00", "0.00");
                vTablaMPago.Rows.Add("Efectivo", "Efectivo €", "1.00", "0.00", "0.00");

                mgvMediosPago.DataSource = vTablaMPago;

                //-- //  ---------------------------------  //--//
                DataTable vTablaDes = new DataTable();
                vTablaDes.TableName = "DetalleDesglose";
                vTablaDes.Rows.Clear();

                vTablaDes.Columns.Add("Denominacion", typeof(string));
                vTablaDes.Columns.Add("Cantidad", typeof(string));
                vTablaDes.Columns.Add("Simbolo", typeof(string));
                vTablaDes.Columns.Add("Total", typeof(string));

                vTablaDes.Rows.Add("Billetas de 1000", "0.00", "₡", "0.00");
                vTablaDes.Rows.Add("Billetas de 2000", "0.00", "₡", "0.00");
                vTablaDes.Rows.Add("Billetas de 5000", "0.00", "₡", "0.00");
                vTablaDes.Rows.Add("Billetas de 10000", "0.00", "₡", "0.00");
                vTablaDes.Rows.Add("Billetas de 20000", "0.00", "₡", "0.00");
                vTablaDes.Rows.Add("Billetas de 50000", "0.00", "₡", "0.00");

                mgvDesgloseEfectivo.DataSource = vTablaDes;




            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCierreCajasView vFrmCierreCajasView = new frmCierreCajasView();
                vFrmCierreCajasView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
