using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmAdministracionRpts : IntegraPOS.MasterPage
    {
        private DataTable vTabla = new DataTable();

        public frmAdministracionRpts()
        {
            InitializeComponent();
        }
        private void frmAdministracionRpts_Load(object sender, EventArgs e)
        {
            try
            {
                vTabla.TableName = "Reportes";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Codigo", typeof(string));
                vTabla.Columns.Add("Reporte", typeof(string));

                vTabla.Rows.Add("01", "Proveedores Nacionales");
                vTabla.Rows.Add("02", "Dos Pinos");
                vTabla.Rows.Add("03", "Proveedores Internacionales");
                vTabla.Rows.Add("04", "Office Depot");
                vTabla.Rows.Add("05", "DELL");

                //mgvReportes.DataSource = vTabla;
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


    }
}
