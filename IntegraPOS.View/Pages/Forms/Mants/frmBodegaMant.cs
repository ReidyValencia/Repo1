using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmBodegaMant : IntegraPOS.MasterPage
    {
        public frmBodegaMant()
        {
            InitializeComponent();
        }

        private void frmBodegaMant_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleBodegasReserva";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Codigo", typeof(string));
                vTabla.Columns.Add("Descripcion", typeof(string));
                vTabla.Columns.Add("Asignar", typeof(bool));

                vTabla.Rows.Add("BOD03", "Bodega reserva 01", false);
                vTabla.Rows.Add("BOD04", "Bodega reserva 02", true);

                mgvBodReserva.DataSource = vTabla;

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
                frmBodegasView vFrmBodegasView = new frmBodegasView();
                vFrmBodegasView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
