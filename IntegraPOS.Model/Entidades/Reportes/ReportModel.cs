using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace IntegraPOS.Model.Entidades.Reportes
{
    public class ReportModel
    {
        public int pe_empIntCodigo { get; set; }
        public int pe_rptIntCodigo { get; set; }
        public int pe_perIntCodigo { get; set; }
        public int pe_accIntCodigo { get; set; }
        public string pe_rptChrNombreInterno { get; set; }
        public string pe_rptChrTitulo { get; set; }
        public string pe_rptChrModulo { get; set; }
        public string pe_rptChrNameReporte { get; set; }
        public string pe_rptChrNamereporteDet { get; set; }
        public int pe_rptIntPrioridad { get; set; }
        public ConfigurationModel pe_ConfigurationModel { get; set; }
        public Dictionary<string,object> pe_ListadoParametros { get; set; }

        public ReportModel()
        {
            pe_empIntCodigo = 0;
            pe_rptIntCodigo = 0;
            pe_accIntCodigo = 0;
            pe_rptChrNombreInterno = string.Empty;
            pe_rptIntPrioridad = 0;
            pe_rptChrTitulo = string.Empty;
            pe_rptChrModulo = string.Empty;
            pe_rptChrNameReporte = string.Empty;
            pe_rptChrNamereporteDet = string.Empty;
            pe_ListadoParametros = new Dictionary<string, object>();
        }

    }
}
