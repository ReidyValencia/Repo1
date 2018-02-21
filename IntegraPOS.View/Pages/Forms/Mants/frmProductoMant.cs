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
    public partial class frmProductoMant : IntegraPOS.MasterPage
    {
        public frmProductoMant()
        {
            InitializeComponent();
        }

        private void frmProductoMant_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleCuentas";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("TipoCuenta", typeof(string));
                vTabla.Columns.Add("Cuenta", typeof(string));

                vTabla.Rows.Add("Inventario", "1-1-30-01-002");
                vTabla.Rows.Add("Costos de ventas", "5-1-10-01-001");

                mgvCuentas.DataSource = vTabla;

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
                frmProductosView vFrmProductosView = new frmProductosView();
                vFrmProductosView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
