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
    public partial class frmReciboMant : IntegraPOS.MasterPage
    {
        public frmReciboMant()
        {
            InitializeComponent();
        }

        private void frmReciboMant_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleDocumentos";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Linea", typeof(string));
                vTabla.Columns.Add("NumDocumento", typeof(string));
                vTabla.Columns.Add("Fecha", typeof(string));
                vTabla.Columns.Add("FechaVenc", typeof(string));
                vTabla.Columns.Add("DiasMora", typeof(string));
                vTabla.Columns.Add("Cliente", typeof(string));
                vTabla.Columns.Add("Saldo", typeof(string));
                vTabla.Columns.Add("Abono", typeof(string));
                vTabla.Columns.Add("Totalizar", typeof(string));

                vTabla.Rows.Add("001", "FAC-00001", "12-01-2018", "12-01-2018", "24", "Fernando Araya", "163,800.00", "0.00");
                vTabla.Rows.Add("002", "FAC-00002", "15-01-2018", "15-01-2018", "21", "Denia Hernández", "79,300.00", "0.00");
                vTabla.Rows.Add("003", "FAC-00005", "06-02-2018", "06-02-2018", "0", "Luisana Ortega", "700,862.00", "0.00");

                mgvDocumentos.DataSource = vTabla;
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
                frmRecibosView vFrmRecibosView = new frmRecibosView();
                vFrmRecibosView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
