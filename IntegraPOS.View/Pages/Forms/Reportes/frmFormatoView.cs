using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using IntegraPOS.Model.Datos;
using IntegraPOS.Model.Entidades.Reportes;
using IntegraPOS.Resources.rec.emp_0.rep;

namespace IntegraPOS.Pages.Forms.Reportes
{
    public partial class frmFormatoView : MasterPage
    {
        #region Objetos & Variables
        private ConnectionReport pe_ConnectionFormat;

        private ReportDocument ps_ReportDocument;

        private readonly FormatModel ps_FormatModel;

        public bool ps_status = false;

        public string ps_mensaje = string.Empty;

        public DataTable dtTableFormat;

        private string pe_vPathFor { get; set; }
        #endregion

        #region Method.Public
        public frmFormatoView(FormatModel pe_FormatModel)
        {
            InitializeComponent();
            pe_ConnectionFormat = new ConnectionReport();
            ps_FormatModel = pe_FormatModel;
            pb_Load();
        }

        public void pb_Load()
        {
            if (pv_CargarFormat())
            {
                if (pe_ConnectionFormat.Conectar())
                {
                    if (ps_ReportDocument.Database == null)
                    {
                        ps_mensaje = "Error al cargar el reporte verificar estructura del formato.";
                        return;
                    }
                    var tablas = ps_ReportDocument.Database?.Tables;
                    if (tablas?.Count == 0)
                    {
                        ps_mensaje = "Error en el formato, no tiene ninguna fuente de datos agregada, por favor verificar.";
                        return;
                    }
                    else
                    {
                        var posTabla = 0;
                        foreach (var table in ps_ReportDocument.Database.Tables.Cast<Table>())
                        {
                            try
                            {
                                pv_CargarSqlDataReader(table, posTabla);
                                posTabla++;
                            }
                            catch (Exception)
                            {

                                ps_mensaje = "Error en el formato, error en la carga de los datos, verificar.";
                                return;
                            }

                        }

                        //Llamado de parametro para verificar si desea realizar la impresion directa.
                        if (true)
                        {
                            ps_ReportDocument.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
                        }


                        formatView.ReportSource = ps_ReportDocument;
                        formatView.RefreshReport();
                        formatView.Refresh();
                        ps_status = true;
                    }
                }
                else ps_mensaje = "Error no se logro conectar con la base de datos, verificar conexión.";

            }
        }
        #endregion

        #region Method.Private
        private void pv_CargarSqlDataReader(Table tablaReport, int posicion)
        {
            try
            {
                var queryCommand = string.Empty;

                #region Llamado de funciones agregadas a reportes.

                switch (tablaReport.Name)
                {
                    case "fn_ForRep_Encabezado_Empresa":
                        {
                            queryCommand = "SELECT * FROM [ptv].[fn_ForRep_Encabezado_Empresa](" + ps_FormatModel.pe_empIntCodigo + ")";
                            break;
                        }
                    case "fn_ForCOM_CLITransacEnc":
                        {
                            queryCommand = "SELECT * FROM [ptv].[fn_ForCOM_CLITransacEnc](" + ps_FormatModel.pe_empIntCodigo + ", '" + ps_FormatModel.pe_traChrNumero + "')";
                            break;
                        }
                    case "fn_ForCOM_CLITransacDetInv":
                        {

                            queryCommand = "SELECT * FROM [ptv].[fn_ForCOM_CLITransacDetInv](" + ps_FormatModel.pe_empIntCodigo + ", '" + ps_FormatModel.pe_traChrNumero + "')";
                            break;
                        }

                }

                #endregion

                #region Carga de comando SQL

                if (!string.IsNullOrEmpty(queryCommand))
                {
                    pe_ConnectionFormat.CrearComando(queryCommand);

                    #endregion

                #region Ejecuciòn SQL y carga de funcion en los reportes

                    using (dtTableFormat = new DataTable())
                    {
                        SqlDataReader vResul = pe_ConnectionFormat.CargarBD();
                        dtTableFormat.Load(vResul);
                    }
                }
                else
                {
                    dtTableFormat = null;
                }


                try
                {
                    ps_ReportDocument.Database.Tables[posicion].SetDataSource(dtTableFormat);
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

        private bool pv_CargarFormat()
        {
            try
            {
                if (ps_FormatModel == null) return false;
                var vEmpresa = ps_FormatModel.pe_empIntCodigo;
                var vBaseDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\", "\\Resources\\");
                var nomFormat = "For" + ps_FormatModel.pe_nomChrModulo + "_" + ps_FormatModel.pe_traChrClasificación + ps_FormatModel.pe_numChrFormato.PadLeft(3, '0') + ".rpt";
                pe_vPathFor = Path.Combine(vBaseDirectory, "rec\\emp_" + vEmpresa + "\\for\\");
                pe_vPathFor = pe_vPathFor + nomFormat;
                if (!Directory.Exists(pe_vPathFor))
                {
                    pe_vPathFor = pe_vPathFor.Replace("emp_" + vEmpresa, "emp_0");
                }

                ps_ReportDocument = new ReportDocument();

                try
                {
                    ps_ReportDocument.Load(pe_vPathFor);
                    return true;
                }
                catch (Exception)
                {
                    ps_mensaje = "No se encontro el archivo para cargar";
                    ps_status = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return ps_status;
        }

        private void mlnkImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ps_ReportDocument?.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void mlnkCerrar_Click(object sender, EventArgs e)
        {
            try { Close(); } catch (Exception ex) { throw ex; }
        } 
        #endregion
    }
}
