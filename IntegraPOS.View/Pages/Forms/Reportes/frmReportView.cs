using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using IntegraPOS.Model.Datos;
using IntegraPOS.Model.Entidades.Reportes;
using IntegraPOS.Clases;

namespace IntegraPOS.Pages.Forms.Reportes
{
    public partial class frmReportView : IntegraPOS.MasterPage
    {
        #region {Declaración de Objetos}

        public ReportModel ps_ReportModel = new ReportModel();
        public ConnectionReport pe_ConnectionReport;
        public ReportDocument ps_ReportDocument;
        public MensajeView ps_MensajeView = new MensajeView();
        public DataTable dtTableReport;

        public bool ps_status = false;
        public string ps_mensaje = string.Empty;

        #endregion

        #region {Declaración de variables}
        public string vPathRpt = string.Empty;
        #endregion

        #region {Method.Public}
        public frmReportView( object pe_ReportModel)
        {
            InitializeComponent();
            ps_ReportModel = (ReportModel)pe_ReportModel;
            pe_ConnectionReport = new ConnectionReport();
            frmReportView_Load();
        } 
        #endregion

        #region {Method.Private}
        private bool pv_CargarRpt()
        {
            try
            {
                if (ps_ReportModel == null) return false;
                var vDespliegue = ps_ReportModel.pe_ListadoParametros.FirstOrDefault(w => w.Key.Equals("paramDespliegue")).Value;
                var vEmpresa = ps_ReportModel.pe_ConfigurationModel.codEmpresa;
                var vBaseDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\", "\\Resources\\");
                vPathRpt = Path.Combine(vBaseDirectory, "rec\\emp_" + vEmpresa + "\\rep\\");

                if (vDespliegue.ToString().ToLower().Equals("res"))
                {
                    vPathRpt = Path.Combine(vPathRpt, ps_ReportModel.pe_rptChrNameReporte);
                }
                else if (vDespliegue.ToString().ToLower().Equals("det"))
                {
                    vPathRpt = Path.Combine(vPathRpt, ps_ReportModel.pe_rptChrNamereporteDet);
                }
                else
                {
                    vPathRpt = Path.Combine(vPathRpt.Replace("emp_" + vEmpresa, "emp_0"), ps_ReportModel.pe_rptChrNameReporte);
                }

                if (!Directory.Exists(vPathRpt))
                {
                    vPathRpt = string.IsNullOrEmpty(ps_ReportModel.pe_rptChrNameReporte) ? Path.Combine(vPathRpt.Replace("emp_" + vEmpresa, "emp_0"), ps_ReportModel.pe_rptChrNameReporte) : vPathRpt.Replace("emp_" + vEmpresa, "emp_0");

                }

                ps_ReportDocument = new ReportDocument();

                try
                {
                    ps_ReportDocument.Load(vPathRpt);
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmReportView_Load()
        {
            try
            {

                if (pv_CargarRpt())
                {
                    if (pe_ConnectionReport.Conectar())
                    {
                        var tablas = ps_ReportDocument.Database.Tables;
                        if (tablas.Count == 0)
                        {
                            ps_mensaje = "Error en el reporte, no tiene ninguna fuente de datos agregada, por favor verificar.";
                            return;
                        }
                        else
                        {
                            var posTabla = 0;
                            foreach (var table in ps_ReportDocument.Database.Tables.Cast<Table>())
                            {
                                pv_CargarSqlDataReader(table, posTabla);
                                posTabla++;
                            }

                            ReportView.ReportSource = ps_ReportDocument;
                            ReportView.RefreshReport();
                            ReportView.Refresh();
                            ps_status = true;
                        }
                    }
                    else ps_mensaje = "Error al realizar la conexión con la base de datos.";
                }
                else ps_mensaje = "Archivo no encontrado.";

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                pe_ConnectionReport.Desconectar();
            }

        }

        private void pv_CargarSqlDataReader(Table tablaReport, int posicion)
        {
            try
            {
                var queryCommand = string.Empty;

                #region Llamado de funciones agregadas a reportes.
                switch (tablaReport.Name)
                {
                    case "fn_SelCLI_CLIENTE":
                        {
                            queryCommand = "SELECT * FROM ptv.fn_SelCLI_CLIENTE(" + ps_ReportModel.pe_ConfigurationModel.codEmpresa + ",'%')";
                            break;
                        }
                    case "fn_SelCLI_VENDEDOR":
                    {
                        queryCommand = "SELECT * FROM ptv.fn_SelCLI_VENDEDOR(" + ps_ReportModel.pe_ConfigurationModel.codEmpresa + ",'%')";
                        break;
                    }
                }
                #endregion

                #region Carga de comando SQL
                pe_ConnectionReport.CrearComando(queryCommand);
                #endregion

                #region Ejecuciòn SQL y carga de funcion en los reportes
                using (dtTableReport = new DataTable())
                {
                    SqlDataReader vResul = pe_ConnectionReport.CargarBD();
                    dtTableReport.Load(vResul);
                }

                try
                {
                    ps_ReportDocument.Database.Tables[posicion].SetDataSource(dtTableReport);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } 
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCerrar_Click(object sender, EventArgs e)
        {
            try{Close();}catch (Exception ex){throw ex;}
        }
        #endregion
        
    } 
  
}
