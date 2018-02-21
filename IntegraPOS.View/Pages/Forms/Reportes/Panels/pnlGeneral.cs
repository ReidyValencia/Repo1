using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegraPOS.Clases;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;
using IntegraPOS.Model.Entidades.PopUps;
using IntegraPOS.Model.Entidades.Reportes;
using IntegraPOS.Pages.PopUps;
using MetroFramework.Controls;

namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    public partial class pnlGeneral : pnlDeslizarMenuReportes
    {
        #region{ Variables }
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
        /// 
        /// </summary>
        private BodegaModelMisc _BodegaModelMisc = new BodegaModelMisc();


        /// <summary>
        /// Instancia de PopUpProductoModel para obtener datos de consulta.
        /// </summary>
        private PopUpProductoModel pe_PopUpProductoModel = new PopUpProductoModel();
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor del format general.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="model"></param>
        public pnlGeneral(Form owner, ReportModel model) : base(owner)
        {
            InitializeComponent();
            pe_ReportModel = model;
            vComercialRpts = (frmComercialRpts)owner;

            mlblTituloListadoGeneral.Text = model.pe_rptChrTitulo;

            pv_CargaInicial();
        } 
        #endregion

        #region Load 

        private void pv_CargaInicial()
        {

            #region {Carga de combos generales}
            var listadoComboBoxs = new List<MetroComboBox>{mcboxDespliegue,mcboxEstadoCliente,mcboxTipoInforme,mcboxFormaPago};

            foreach (var combo in listadoComboBoxs)
            {
                var mcbox = combo; vMiscelaneosModel.pb_CargaComboBox(ref mcbox);
            }
            #endregion

            #region {Carga de combo de bodegas}

            var _lisBodegas = new List<BodegaModelMisc>();
            _BodegaModelMisc.pb_ObtenerBodegas(ref _lisBodegas);
            if (_lisBodegas.Count > 0)
            {
                mcboxBodega.DataSource = _lisBodegas;
                mcboxBodega.DisplayMember = "bodChrNombre";
                mcboxBodega.ValueMember = "bodChrCodigo";
            }

            #endregion

            #region {Carga calendarios}

            vMiscelaneosModel.pv_CargaCalendario(ref mdateFechaIni);
            vMiscelaneosModel.pv_CargaCalendario(ref mdateFechaFin);

            #endregion

            #region Cargar los tipos de transacción.

            var tiposTransaccion = new TipoTransaccionModel();
            var _list = new List<TipoTransaccionModel>();
            tiposTransaccion.pb_ObtenerTipoTransaccion("%",ref _list);
            if (_list.Count > 0)
            {
                mcboxTipoTransaccion.DataSource    = _list;
                mcboxTipoTransaccion.ValueMember   = "ttpChrCodigo";
                mcboxTipoTransaccion.DisplayMember = "ttpChrNombre";
            }

            #endregion

            #region Carga los estado transacciones

            vMiscelaneosModel.pb_ListadoEstadosTransacciones("%",ref mcboxEstadoTransac);

            #endregion

            #region Carga de sucursales





            #endregion
        }

        #endregion

        #region Llama reporte
        private void mbtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            var listadoParametros = new Dictionary<string, object>
                {
                    {"paramEstado", mcboxEstadoCliente.SelectedValue.ToString()},
                    {"paramDespliegue", mcboxDespliegue.SelectedValue.ToString()},
                    {"paramModelCli", pe_ClienteModel},
                    {"paramModelInv", pe_PopUpProductoModel}
                };

            foreach (var dato in listadoParametros)
            {
                if (pe_ReportModel.pe_ListadoParametros.Keys.Contains(dato.Key)) { pe_ReportModel.pe_ListadoParametros.Remove(dato.Key); }
                pe_ReportModel.pe_ListadoParametros.Add(dato.Key, dato.Value);
            }

            var vFrmReportView = new frmReportView(pe_ReportModel);
            if (!vFrmReportView.ps_status) { ps_msView.pb_MensajeSistema(vComercialRpts, 3, vFrmReportView.ps_mensaje); }
            else { vFrmReportView.Show(); }


        }
        #endregion

        #region Llamados a popup's


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

        public void pv_BuscarVendedor(object sender, EventArgs e)
        {
            
        }

        public void pv_BuscarProducto(object sender, EventArgs e)
        {
            try
            {
                frmPopUpProductos frmPopUpProductos = new frmPopUpProductos(mcboxBodega.SelectedValue.ToString(), mtxtInventario.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                if (frmPopUpProductos.pb_CantidadProductos() > 1)
                {
                    frmPopUpProductos.ShowDialog();
                }
                else if (frmPopUpProductos.pb_CantidadProductos() == 0)
                {
                    ps_msView.pb_MensajeSistema(vComercialRpts, 3, "Dato de filtro no concuerda con ningún producto.");
                }

                pe_PopUpProductoModel = frmPopUpProductos.pe_PopUpProductoModel; // Obtiene el modelo producto devuelvo por el PopUp Producto.

                if (!pe_PopUpProductoModel.prdIntCodigo.Equals("") && !pe_PopUpProductoModel.prdIntCodigo.Equals(0))
                {
                    mtxtInventario.Text = pe_PopUpProductoModel.prdChrDescripcion;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
