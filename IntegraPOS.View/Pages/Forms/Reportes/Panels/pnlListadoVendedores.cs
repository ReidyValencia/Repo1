using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;
using IntegraPOS.Model.Entidades.Reportes;
using MetroFramework.Controls;

namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    public partial class pnlListadoVendedores : pnlDeslizarMenuReportes
    {
        /// <summary>
        ///  Instancia de MiscelaneosModel para obtener datos de consulta.
        /// </summary>
        readonly MiscelaneosModel vMiscelaneosModel = new MiscelaneosModel();

        /// <summary>
        /// Instancia de ClienteModel para obtener datos de consulta.
        /// </summary>
        /// 
        private VendedorModel pe_VendedorModel = new VendedorModel();

        private ReportModel pe_ReportModel = new ReportModel();

        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        /// <param name="owner"></param>
        /// 
        public pnlListadoVendedores(Form owner, ReportModel model) : base(owner)
        {
            InitializeComponent();

            #region {Carga de combo box}
            var listadoComboBoxs = new List<ComboBox>
                {
                    mcmbDespliegue,
                    mcmbEstado
                };

            foreach (var combo in listadoComboBoxs)
            {
                MetroComboBox mcomBox = (MetroComboBox)combo;
                vMiscelaneosModel.pb_CargaComboBox(ref mcomBox);
            }

            #endregion
        }
        
        private void mbtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            var vFrmReportView = new frmReportView(pe_ReportModel);
            vFrmReportView.Show();
        }
    }
}
