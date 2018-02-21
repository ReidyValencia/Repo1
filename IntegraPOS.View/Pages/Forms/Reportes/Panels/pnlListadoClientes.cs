using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Miscelaneos;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Reportes;
using MetroFramework.Controls;
using IntegraPOS.Clases;

namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    public partial class pnlListadoClientes : pnlDeslizarMenuReportes
    {
        /// <summary>
        ///  Instancia de MiscelaneosModel para obtener datos de consulta.
        /// </summary>
        readonly MiscelaneosModel vMiscelaneosModel = new MiscelaneosModel();

        /// <summary>
        /// 
        /// </summary>
        private frmComercialRpts vComercialRpts;

        /// <summary>
        /// 
        /// </summary>
        private MensajeView ps_msView = new MensajeView();

        /// <summary>
        /// Instancia de ClienteModel para obtener datos de consulta.
        /// </summary>
        /// 
        private ClienteModel pe_ClienteModel = new ClienteModel();

        /// <summary>
        /// 
        /// </summary>
        private ReportModel pe_ReportModel = new ReportModel();

        /// <summary>
        /// Constructor de la pagina
        /// </summary>
        /// <param name="owner"></param>
        /// 
        public pnlListadoClientes(Form owner, ReportModel model) : base(owner)
        {
            pe_ReportModel = model;
            vComercialRpts = (frmComercialRpts)owner;
            InitializeComponent();

            #region {Carga de combo box}
                var listadoComboBoxs = new List<ComboBox>
                {
                    mcmbDespliegue,
                    mcmbEstado
                };

                foreach (var combo in listadoComboBoxs)
                {
                    MetroComboBox mcomBox = (MetroComboBox) combo;
                    vMiscelaneosModel.pb_CargaComboBox(ref mcomBox);
                }

            #endregion

        }

        /// <summary>
        /// Instancia el PopUp de clientes y le envia el dato de busqueda como filtro de clientes.
        /// </summary>
        public void pv_BuscarClientes(object sender, EventArgs e)
        {
            try
            {
                var frmPopUpClientes = new frmPopUpClientes(mtxtCliente.Text, this.Name);

                if (frmPopUpClientes.pb_CantidadClientes() > 1)
                {
                    frmPopUpClientes.ShowDialog();
                }

                pe_ClienteModel = frmPopUpClientes.pe_ClienteModel; //Obtiene el modelo cliente devuelvo por el PopUp Cliente

                if (!pe_ClienteModel.cliIntCodigo.Equals("") || !pe_ClienteModel.cliIntCodigo.Equals(0))
                {
                    mtxtCliente.Text = pe_ClienteModel.cliChrNombrePri;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var listadoParametros = new Dictionary<string, object>
                {
                    {"paramEstado", mcmbEstado.SelectedValue.ToString()},
                    {"paramDespliegue", mcmbDespliegue.SelectedValue.ToString()},
                    {"paramModel", pe_ClienteModel},
                };

                foreach (var dato in listadoParametros)
                {
                    if (pe_ReportModel.pe_ListadoParametros.Keys.Contains(dato.Key)){pe_ReportModel.pe_ListadoParametros.Remove(dato.Key);}
                    pe_ReportModel.pe_ListadoParametros.Add(dato.Key,dato.Value);
                }
               
                var vFrmReportView = new frmReportView(pe_ReportModel);
                if (!vFrmReportView.ps_status){ps_msView.pb_MensajeSistema(vComercialRpts, 3, vFrmReportView.ps_mensaje);}
                else{vFrmReportView.Show();}


            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
