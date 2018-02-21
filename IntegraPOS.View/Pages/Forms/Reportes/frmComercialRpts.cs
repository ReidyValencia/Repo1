using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Model;
using IntegraPOS.Model.Entidades.Reportes;
using IntegraPOS.Pages.Forms.Reportes.Panels;
using MetroFramework.Controls;

namespace IntegraPOS.Pages.Forms.Reportes
{
    public partial class frmComercialRpts : IntegraPOS.MasterPage
    {

        #region Objetos
        public readonly string TipoRpt = "REP";
        public string panel = string.Empty;
        public int posicion = 0;
        public List<ReportModel> vListadoReportes;
        #endregion

        #region Constructor
        public frmComercialRpts()
        {
            InitializeComponent();

            pv_CrearMenuReport();
        } 
        #endregion

        #region Utilidades

        private void pv_CrearMenuReport()
        {
            try
            {
                var vConnectionModel = new ConnectionModel();
                vListadoReportes = new List<ReportModel>();
                vListadoReportes = vConnectionModel.pb_ListadoReportes(1, "COM", "%");
                if (vListadoReportes.Count > 0)
                {
                    var temp = new DataTable("ListadoReportes");
                    temp.Columns.Add("pe_Titulo", typeof (string));
                    temp.Columns.Add("pe_posicion", typeof(string));

                    for (var i = 0; i <= vListadoReportes.Count -1; i++)
                    {
                        var row = temp.NewRow();
                        row["pe_Titulo"] = vListadoReportes[i].pe_rptChrTitulo;
                        row["pe_posicion"] = i;
                        temp.Rows.Add(row);
                    }
                    
                    mgridListReportes.DataSource = temp;
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_CargarFormat(object sender, EventArgs e)
        {
            foreach (var ctrl in this.Controls.Cast<Control>().Where(w => w.ProductName.Equals("IntegraPOS"))){ctrl.Hide();}
            var model = vListadoReportes[posicion];
            pv_PosicionarPanel(model);
        }


        /// <summary>
        /// Posiciona el panel con el format de cada opcione que selecciono de reporte.
        /// </summary>
        /// <param name="pe_report"></param>
        private void pv_PosicionarPanel(ReportModel pe_report)
        {
            var vpnpnlGeneral = new pnlGeneral(this, pe_report);
            vpnpnlGeneral.AutoScroll = true;
            vpnpnlGeneral.swipe(true);
        }


        #endregion

        #region Events
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

        private void mgridListReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(2)) return;
                posicion = int.Parse(mgridListReportes.Rows[e.RowIndex].Cells["pe_posicion"].Value.ToString());
                vListadoReportes[posicion].pe_ListadoParametros = new Dictionary<string, object>();
                vListadoReportes[posicion].pe_ListadoParametros = new Dictionary<string, object>
                {
                    {"paramFormato", e.ColumnIndex.Equals(0) ? "PDF" : "XLS"}
                };
                pv_CargarFormat(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

    }
}
