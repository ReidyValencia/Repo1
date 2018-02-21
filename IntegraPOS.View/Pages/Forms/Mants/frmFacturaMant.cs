using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Model;
using IntegraPOS.Model.Entidades;
using IntegraPOS.Pages.PopUps;
using MetroFramework;
using System.Globalization;
using System.Linq;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;
using IntegraPOS.Model.Entidades.PopUps;
using IntegraPOS.Clases;
using IntegraPOS.Model.Entidades.Reportes;
using IntegraPOS.View.Clases;
using IntegraPOS.Pages.Forms;
using IntegraPOS.Pages.Forms.Reportes;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS
{
    public partial class frmFacturaMant : IntegraPOS.MasterPage
    {

        #region Variables - Clases

        #region Clases

        /// <summary>
        /// Instancia de RegExp para validar los tipo de valores ingresado en los campos
        /// </summary>
        private RegExp vRegExp = new RegExp();

        /// <summary>
        /// Instancia de ConfigEmpresaModelMisc para obtener los atributos de configuración por empresa.
        /// </summary>
        private ConfigEmpresaModelMisc ps_ConfigEmpresaModelMisc = new ConfigEmpresaModelMisc();

        /// <summary>
        /// Instancia de ConfigurationModel para obtener los parametros con que esta configurado el punto de venta.
        /// </summary>
        private ConfigurationModel ps_ConfiguraciónModel = new ConfigurationModel();

        /// <summary>
        /// Instancia de CajaModel para obtener la caja que tiene asignada el usuario.
        /// </summary>
        private CajaModel ps_CajaModel = new CajaModel();

        /// <summary>
        /// Instancia de TipoTransaccionModel para obtener las propiedades del tipo de transacción.
        /// </summary>
        private TipoTransaccionModel ps_TipoTransaccionModel = new TipoTransaccionModel();

        /// <summary>
        /// Instancia de ClienteModel para obtener datos de consulta.
        /// </summary>
        private ClienteModel pe_ClienteModel = new ClienteModel();

        /// <summary>
        /// Instancia de PopUpProductoModel para obtener datos de consulta.
        /// </summary>
        private PopUpProductoModel pe_PopUpProductoModel = new PopUpProductoModel();

        /// <summary>
        /// Instancia de BodegaModelMisc para obtener las bodegas en estado activas.
        /// </summary>
        private BodegaModelMisc pe_BodegaModelMisc = new BodegaModelMisc();
        /// <summary>
        /// Instancia una lista de Bodegas.
        /// </summary>
        private List<BodegaModelMisc> ps_BodegaModelMisc;

        /// <summary>
        /// Instancia de MonedaModel para obtener las monedas configuradas.
        /// </summary>
        private MonedaModel pe_MonedaModel = new MonedaModel();
        /// <summary>
        /// Instancia de una lista de Monedas.
        /// </summary>
        private List<MonedaModel> ps_MonedaModel;

        /// <summary>
        /// Instancia de TransaccionEncabezadoModel para guardar el encabezado de la transacciòn
        /// </summary>
        private TransaccionEncabezadoModel pe_TransaccionEncabezadoModel = new TransaccionEncabezadoModel();

        /// <summary>
        /// Instancia una lista del modelo DetalleMedioPagoModel para guardar los registros de medio de pago.
        /// </summary>
        private List<MedioPagoModel> pe_DetalleMedioPagoModel;

        /// <summary>
        /// Instancia una lista del modelo para guardar los registros de productos.
        /// </summary>
        private List<DetalleProductoModel> pe_DetalleProductoModel;

        /// <summary>
        /// Instancia de MensajeView para la presentancion de datos.
        /// </summary>
        private MensajeView vMensajeView = new MensajeView();

        #endregion

        #region Variables

        private int vSumarMontos = 0;

        /// <summary>
        /// Lista de códigos productos agregados al mgridProductos
        /// </summary>
        private List<string> listaProductos = new List<string>();

        /// <summary>
        /// Estado del proceso que se esta realizando
        /// </summary>
        private bool? ps_Estado;

        /// <summary>
        /// Mensaje en caso que se presente algún error.
        /// </summary>
        private string ps_Mensaje;

        /// <summary>
        /// Guarda el formulario padre que lo inicializo
        /// </summary>
        private string frmOrigen;

        /// <summary>
        /// Almacena si el usuario tiene una caja asignada.
        /// </summary>
        public bool vAsigancionCaja = true;

        #region Variables defecto

        private int vCodClienteAsoc = 1;
        private int vCodContactoCliente = 1;
        private int vCodVendedor = 1;
        private int vCodVendedorApoyo = 2;
        private int vCodVendedorAsistente = 1;

        private bool vEnviarCobrar = false;
        private bool vPagoAnticipado = false;
        private decimal vMontoSaldoCKPF = 8000000;
        private bool vValidarCKPF = false;
        private decimal vMontoSaldoActual = 12000000;

        #endregion

        #region

        #endregion

        #endregion

        #endregion

        public frmFacturaMant()
        {
            InitializeComponent();
        }

        public frmFacturaMant(string frmOrigen) : this()
        {
            this.frmOrigen = frmOrigen;

            pv_CargarCaja();

            if (ps_CajaModel == null) { vAsigancionCaja = false; }
        }

        private void frmFacturaMant_Load(object sender, EventArgs e)
        {
            try
            {
                pv_CargarComboxBox();
                pv_CargaConfigEmpresa();
                pv_CargarTipoTransaccion();
                pv_CargarControles();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos Controles

        #region Busqueda Cliente

        /// <summary>
        /// Inicia la busqueda del cliente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBusqCliente_Click(object sender, EventArgs e)
        {
            try
            {
                pv_BuscarClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicia la busqueda del cliente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void mtxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch (e.KeyChar)
                {
                    case (char)Keys.Enter:
                        pv_BuscarClientes();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Busqueda Producto

        /// <summary>
        /// Inicia la busqueda del producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBusqProducto_Click(object sender, EventArgs e)
        {
            try
            {
                pv_BuscarProductos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicia la busqueda del producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch (e.KeyChar)
                {
                    case (char)Keys.Enter:
                        pv_BuscarProductos();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void mlnkNuevaFact_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturaMant vFrmFacturaMant = new frmFacturaMant("frmPrincipal");
                vFrmFacturaMant.Show();
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
                if (frmOrigen.Equals("frmPrincipal"))
                {
                    Close();
                }
                else if (frmOrigen.Equals("frmFacturasView"))
                {
                    frmFacturasView vFrmFacturasView = new frmFacturasView();
                    vFrmFacturasView.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (vSumarMontos.Equals(1))
                {
                    pv_ActualizarTotales();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mcbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pv_HabilitarControles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza la actualización de los montos totales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtileTotalFactura_Click(object sender, EventArgs e)
        {
            try
            {
                pv_ActualizarTotales();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_GuardarFactura(sender, e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cargas de ComboBox

        /// <summary>
        /// Carga el ComboBox de formas de pago.
        /// </summary>
        private void pv_CargarComboxBox()
        {
            try
            {
                #region Formas Pago

                mcbFormaPago.Items.Clear();
                mcbFormaPago.Items.Insert(0, "Contado");
                mcbFormaPago.Items.Insert(1, "Crédito");
                mcbFormaPago.SelectedIndex = 0;

                #endregion

                #region Monedas

                pe_MonedaModel.pb_ObtenerMonedas("%", 2, ref ps_MonedaModel);

                if (ps_MonedaModel.Count > 0)
                {
                    mcbMoneda.DataBindings.Clear();
                    mcbMoneda.DataSource = ps_MonedaModel;
                    mcbMoneda.DisplayMember = "mndChrNombre";
                    mcbMoneda.ValueMember = "mndIntCodigo";
                }

                #endregion

                #region Tipos Tasas

                mcbTipoTasa.Items.Clear();
                mcbTipoTasa.Items.Insert(0, "Venta");
                mcbTipoTasa.Items.Insert(1, "Compra");
                mcbTipoTasa.SelectedIndex = 0;

                #endregion

                #region Bodegas

                pe_BodegaModelMisc.pb_ObtenerBodegas(ref ps_BodegaModelMisc);

                if (ps_BodegaModelMisc.Count > 0)
                {
                    mcbBodega.DataBindings.Clear();
                    mcbBodega.DataSource = ps_BodegaModelMisc;
                    mcbBodega.DisplayMember = "bodChrNombre";
                    mcbBodega.ValueMember = "bodChrCodigo";
                }

                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cargas de Modelos

        /// <summary>
        /// Carga los atributos de configuración por empresa.
        /// </summary>
        private void pv_CargaConfigEmpresa()
        {
            try
            {
                ps_ConfigEmpresaModelMisc.pb_ObtenerConfigEmpresa(ref ps_ConfigEmpresaModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene la caja asignada al usuario.
        /// </summary>
        private void pv_CargarCaja()
        {
            try
            {
                ps_CajaModel.pb_ObtenerCajaUsuario(ps_ConfiguraciónModel.codUsuario, ref ps_CajaModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los atributos asignados al tipo de transacción.
        /// </summary>
        private void pv_CargarTipoTransaccion()
        {
            try
            {
                List<TipoTransaccionModel> _tipoTransaccionModels = new List<TipoTransaccionModel>();

                ps_TipoTransaccionModel.pb_ObtenerTipoTransaccion(ps_CajaModel.ttpChrCodigo, ref _tipoTransaccionModels);
                ps_TipoTransaccionModel = _tipoTransaccionModels.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cargar Controles

        private void pv_HabilitarControles()
        {
            try
            {
                if (mcbMoneda.SelectedValue.Equals(1))
                {
                    mcbTipoTasa.Enabled = false;
                    mcbTipoTasa.BackColor = Color.Gainsboro;
                    mcbTipoTasa.UseCustomBackColor = true;
                    mtxtValorTasa.Text = "1";
                    mtxtValorTasa.Enabled = false;
                    mtxtValorTasa.BackColor = Color.Gainsboro;
                    mtxtValorTasa.UseCustomBackColor = true;
                }
                else
                {
                    mcbTipoTasa.Enabled = true;
                    mcbTipoTasa.BackColor = Color.Blue;
                    mcbTipoTasa.UseCustomBackColor = false;
                    mtxtValorTasa.Text = "";
                    mtxtValorTasa.Enabled = true;
                    mtxtValorTasa.BackColor = Color.Blue;
                    mtxtValorTasa.UseCustomBackColor = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_CargarControles()
        {
            try
            {
                mlblTipoTransaccion.Text = ps_TipoTransaccionModel.AtributosTTransaccion["TipDoc"].ToString() + "-";
                string consecutivo = (Convert.ToInt32(ps_TipoTransaccionModel.AtributosTTransaccion["Consec"].ToString()) + 1).ToString();
                mcbTipoTasa.SelectedIndex = (ps_TipoTransaccionModel.AtributosTTransaccion["TipTasa"].Equals("TCV")) ? 0 : 1;

                for (int i = consecutivo.Length; i < 8; i++) { consecutivo = "0" + consecutivo; }

                mlblNumConsecutivo.Text = consecutivo;

                pv_HabilitarControles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Evento de Teclas

        /// <summary>
        /// Inicializa un evento o proceso de acuerdo a la tecla presionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFacturaMant_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        pv_GuardarFactura(sender, e); // Inicia el proceso de guardar la factura.
                        break;

                    case Keys.F2: // Busqueda de clientes.
                        pv_BuscarClientes();
                        mtxtCliente.Focus();
                        break;

                    case Keys.F3: // Busqueda de productos.
                        pv_BuscarProductos();
                        mtxtProducto.Focus();
                        break;

                    case Keys.Escape: // Regresa a la pagina Inicial.
                        Close();
                        break;

                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Busquedas de Clientes, Productos, Medio Pago

        /// <summary>
        /// Instancia el PopUp de clientes y le envia el dato de busqueda como filtro de clientes.
        /// </summary>
        private void pv_BuscarClientes()
        {
            try
            {
                frmPopUpClientes frmPopUpClientes = new frmPopUpClientes(mtxtCliente.Text, this.Name);

                if (frmPopUpClientes.pb_CantidadClientes() > 1)
                {
                    frmPopUpClientes.ShowDialog();
                }

                pe_ClienteModel = frmPopUpClientes.pe_ClienteModel; //Obtiene el modelo cliente devuelvo por el PopUp Cliente

                if (!pe_ClienteModel.cliIntCodigo.Equals("") || !pe_ClienteModel.cliIntCodigo.Equals(0))
                {
                    mtxtCliente.Text = pe_ClienteModel.cliChrNombrePri;
                    mcbFormaPago.SelectedItem = pe_ClienteModel.cliChrFPago;
                    mtxtProducto.Focus();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Instancia el PopUp de productos y le envia el dato de busqueda como filtro  de productos.
        /// </summary>
        private void pv_BuscarProductos()
        {
            try
            {
                frmPopUpProductos frmPopUpProductos = new frmPopUpProductos(mcbBodega.SelectedValue.ToString(), mtxtProducto.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                if (frmPopUpProductos.pb_CantidadProductos() > 1)
                {
                    frmPopUpProductos.ShowDialog();
                }
                else if (frmPopUpProductos.pb_CantidadProductos() == 0)
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "Dato de filtro no concuerda con ningún producto.");
                }

                pe_PopUpProductoModel = frmPopUpProductos.pe_PopUpProductoModel; // Obtiene el modelo producto devuelvo por el PopUp Producto.

                if (!pe_PopUpProductoModel.prdIntCodigo.Equals("") && !pe_PopUpProductoModel.prdIntCodigo.Equals(0))
                {
                    pv_AgregarProducto();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Instancia el PopUp de medios de pago y envia los datos necesarios para realizar calculos
        /// </summary>
        private bool pv_BuscarMediosPago()
        {
            try
            {
                string vNumTransac = mlblTipoTransaccion.Text + "" + mlblNumConsecutivo.Text;
                string vCaja = ps_CajaModel.cajChrCodigo;
                int vFormaPago = Convert.ToInt32(mcbFormaPago.SelectedValue);
                int vMoneda = Convert.ToInt32(mcbMoneda.SelectedValue);
                decimal vMontoValorTasa = Convert.ToDecimal(mtxtValorTasa.Text.Replace(",", ""));
                decimal vTotalPagar = Convert.ToDecimal((mtileTotalFactura.Text.Replace("TOTAL ", "")).Replace(",", ""));


                frmPopUpMedioPago vfrmPopUpMedioPago = new frmPopUpMedioPago(vNumTransac, vCaja, vFormaPago, vMoneda, vMontoValorTasa, vTotalPagar);

                vfrmPopUpMedioPago.ShowDialog();

                pe_DetalleMedioPagoModel = vfrmPopUpMedioPago.ps_MedioPagoModel; // Obtiene el listado de detalles de medio de pago

                return (pe_DetalleMedioPagoModel.Count > 0) ? true : false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodo que agrega productos al GridView

        /// <summary>
        /// Agrega un nuevo Producto al gridView de Productos.
        /// </summary>
        private void pv_AgregarProducto()
        {
            try
            {
                int vNumLinea = mgvProductos.Rows.Count;
                string vCodProducto = Convert.ToString(pe_PopUpProductoModel.prdIntCodigo);

                vSumarMontos = 0;

                //if (!listaProductos.Contains(vCodProducto))
                //{
                mgvProductos.Rows.Add(1);

                // Agrega el nuevo producto al GridView de productos.
                mgvProductos.Rows[vNumLinea].Cells["NumLinea"].Value = (vNumLinea + 1);
                mgvProductos.Rows[vNumLinea].Cells["Bodega"].Value = mcbBodega.Text; // Cambiar por la bodega seleccionada.
                mgvProductos.Rows[vNumLinea].Cells["CodBodega"].Value = mcbBodega.SelectedValue;
                mgvProductos.Rows[vNumLinea].Cells["CodigoProducto"].Value = pe_PopUpProductoModel.prdIntCodigo;
                mgvProductos.Rows[vNumLinea].Cells["CodigoPri"].Value = pe_PopUpProductoModel.prdChrCodigoPri;
                mgvProductos.Rows[vNumLinea].Cells["Descripcion"].Value = pe_PopUpProductoModel.prdChrDescripcion;
                mgvProductos.Rows[vNumLinea].Cells["Unidad"].Value = pe_PopUpProductoModel.undChrCodigo;
                mgvProductos.Rows[vNumLinea].Cells["MonFactor"].Value = pe_PopUpProductoModel.pxuMonFactor;
                mgvProductos.Rows[vNumLinea].Cells["Cantidad"].Value = "1.00";
                mgvProductos.Rows[vNumLinea].Cells["Precio"].Value = pe_PopUpProductoModel.prdMonPrecioBase.ToString();
                mgvProductos.Rows[vNumLinea].Cells["CostoPromedio"].Value = pe_PopUpProductoModel.prdMonPrecioBase.ToString();
                mgvProductos.Rows[vNumLinea].Cells["DiasGarantia"].Value = pe_PopUpProductoModel.prdIntDiasGarantiaV;
                mgvProductos.Rows[vNumLinea].Cells["Descuento"].Value = "0.00";
                mgvProductos.Rows[vNumLinea].Cells["Impuesto"].Value = "0.00";

                //Agrega el código de producto a las lista de productos.
                listaProductos.Add(pe_PopUpProductoModel.prdIntCodigo.ToString());

                //Actualiza el Total general de la transacción.
                pv_ActualizarTotales();
                vSumarMontos = 1;
                //}
                //else
                //{
                //    vMensajeView.pb_MensajeSistema(this, 3, "Producto ya se encuentra agregado.");
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Método que recorre el GridView para actualizar los totales.

        private void pv_ActualizarTotales()
        {
            try
            {
                int decimales = Convert.ToInt32(ps_ConfigEmpresaModelMisc.CnfDecimalesMontos);
                int vNumLineas = mgvProductos.Rows.Count;
                int vCont = 0;
                decimal vPrecio = 0, vCantidad = 0;
                decimal vSubTotalLinea, vSubTotalDescLinea = 0;
                decimal vDescuento = 0, vImpuesto = 0;

                decimal vSubTotalGeneral = 0, vSubTotalDescGeneral = 0;
                decimal vDescuentoGeneral = 0, vImpuestoGeneral = 0;
                decimal vTotalGeneral = 0;

                vSumarMontos = 0;

                for (; vCont < vNumLineas; vCont++)
                {
                    // Obtiene los valos del gridView de productos.
                    mgvProductos.Rows[vCont].Cells["Precio"].Value = Convert.ToDecimal(Convert.ToDecimal(mgvProductos.Rows[vCont].Cells["Precio"].Value).ToString());

                    vPrecio = Convert.ToDecimal(mgvProductos.Rows[vCont].Cells["Precio"].Value.ToString().Replace(",", ""));
                    vCantidad = Convert.ToDecimal(mgvProductos.Rows[vCont].Cells["Cantidad"].Value.ToString().Replace(",", ""));
                    vDescuento = Convert.ToDecimal(mgvProductos.Rows[vCont].Cells["Descuento"].Value.ToString().Replace(",", ""));
                    vImpuesto = Convert.ToDecimal(mgvProductos.Rows[vCont].Cells["Impuesto"].Value.ToString().Replace(",", ""));

                    //Formateo de campos
                    mgvProductos.Rows[vCont].Cells["Precio"].Value = vPrecio.ToString("N" + decimales, CultureInfo.InvariantCulture);
                    mgvProductos.Rows[vCont].Cells["Cantidad"].Value = vCantidad.ToString("N" + decimales, CultureInfo.InvariantCulture);
                    mgvProductos.Rows[vCont].Cells["Descuento"].Value = vDescuento.ToString("N" + decimales, CultureInfo.InvariantCulture);
                    mgvProductos.Rows[vCont].Cells["Impuesto"].Value = vImpuesto.ToString("N" + decimales, CultureInfo.InvariantCulture);

                    // SubTotales
                    vSubTotalLinea = vCantidad * vPrecio;
                    vSubTotalGeneral += Convert.ToDecimal(vSubTotalLinea.ToString());

                    // Descuentos
                    vDescuento = vSubTotalLinea * (vDescuento / 100);
                    vDescuentoGeneral += Convert.ToDecimal(vDescuento.ToString());
                    mgvProductos.Rows[vCont].Cells["MonDescuentoLinea"].Value = vDescuento.ToString("N" + decimales, CultureInfo.InvariantCulture);

                    // SubTotalDescuento
                    vSubTotalDescLinea = vSubTotalLinea - vDescuento;
                    vSubTotalDescGeneral += Convert.ToDecimal(vSubTotalLinea);

                    // Impuesto
                    vImpuesto = vSubTotalDescLinea * (vImpuesto / 100);
                    vImpuestoGeneral += vImpuesto;
                    mgvProductos.Rows[vCont].Cells["MonImpuestoLinea"].Value = vImpuesto.ToString("N" + decimales, CultureInfo.InvariantCulture);

                    // Total de la Linea
                    mgvProductos.Rows[vCont].Cells["TotalLinea"].Value = (vSubTotalDescLinea + vImpuesto).ToString("N" + decimales, CultureInfo.InvariantCulture);

                    vTotalGeneral += (vSubTotalDescLinea + vImpuesto);
                }

                mlblSubTotalGeneral.Text = vSubTotalGeneral.ToString("N" + decimales, CultureInfo.InvariantCulture);
                mlblDescuentoGeneral.Text = vDescuentoGeneral.ToString("N" + decimales, CultureInfo.InvariantCulture);
                mlblSubTotalDescGeneral.Text = vSubTotalGeneral.ToString("N" + decimales, CultureInfo.InvariantCulture);
                mlblImpuestoGeneral.Text = vImpuestoGeneral.ToString("N" + decimales, CultureInfo.InvariantCulture);
                mtileTotalFactura.Text = "TOTAL " + vTotalGeneral.ToString("N" + decimales, CultureInfo.InvariantCulture);

                vSumarMontos = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodos para Guardar la transacción.

        private void pv_GuardarFactura(object sender, EventArgs e)
        {
            try
            {
                ValidarControles validarControles = new ValidarControles();

                if (validarControles.pb_ValidarControles(this))
                {
                    if (pv_ValidarEncabezadoTransac())
                    {
                        // Carga el modelo de encabezado de la transaccion con los datos ingresados.
                        pv_CargarEncabezadoTransac();

                        if (pv_ValidarCliente())
                        {
                            pv_ActualizarTotales();

                            if (pv_ValidarDetalleTransac())
                            {
                                pv_CargarDetalleProductos();

                                if (pv_BuscarMediosPago())
                                {
                                    pe_TransaccionEncabezadoModel.pb_GuardarTransaccion(pe_TransaccionEncabezadoModel, pe_DetalleMedioPagoModel, pe_DetalleProductoModel, ref ps_Estado, ref ps_Mensaje);
                                    if (ps_Estado != null && ps_Estado.Value)
                                    {
                                        var format = new FormatModel(pe_TransaccionEncabezadoModel.empIntCodigo, pe_TransaccionEncabezadoModel.traChrNumero, "CLIVEN", "COM", "001", pe_TransaccionEncabezadoModel.traChrEstado, "");
                                        var frmFormatoView = new frmFormatoView(format);
                                        if (frmFormatoView.ps_status)
                                        {
                                            vMensajeView.pb_MensajeSistema(this, 1, "Transacción almacenada con exito.");
                                            frmFormatoView.Show();
                                            Close();
                                            frmFacturaMant vFrmFacturaMant = new frmFacturaMant(frmOrigen);
                                            vFrmFacturaMant.Show();
                                        }
                                        else
                                        {
                                            vMensajeView.pb_MensajeSistema(this, 3, frmFormatoView.ps_mensaje);
                                        }
                                    }
                                }
                                else
                                {
                                    vMensajeView.pb_MensajeSistema(this, 3, "No se han asigando medios de pago a la factura");
                                }

                            }
                            else
                            {
                                vMensajeView.pb_MensajeSistema(this, 3, ps_Mensaje);
                            }
                        }
                        else
                        {
                            vMensajeView.pb_MensajeSistema(this, 3, ps_Mensaje);
                        }
                    }
                    else
                    {
                        vMensajeView.pb_MensajeSistema(this, 3, ps_Mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Validaciones

        /// <summary>
        /// Valida el formato de los datos ingresados en el encabezado.
        /// </summary>
        private bool pv_ValidarEncabezadoTransac()
        {
            try
            {
                DateTime fechaproceso = DateTime.Now;

                if (!mlblNumConsecutivo.Text.Equals("")) // Valida que el numero de documento no este vacio
                {
                    if (!vRegExp.pb_ValidarRegExp(mtxtCliente, "nombre"))
                    {
                        ps_Mensaje = "Formato incorrecto de nombre de cliente."; return false;
                    }
                    else if (!vRegExp.pb_ValidarRegExp(mtxtValorTasa, "numero"))
                    {
                        ps_Mensaje = "Debe ingresar el valor de la tasa."; return false;
                    }
                    else if (DateTime.Now < Convert.ToDateTime(ps_ConfigEmpresaModelMisc.FecInaPeriodo))
                    {
                        ps_Mensaje = "Fecha de la transacción es menor a la fecha de inactividad."; return false;
                    }
                    else if (DateTime.Now < Convert.ToDateTime(ps_ConfigEmpresaModelMisc.FecIniPeriodo) || fechaproceso > Convert.ToDateTime(ps_ConfigEmpresaModelMisc.FecFinPeriodo))
                    {
                        ps_Mensaje = "Fecha de la transacción esta fuera del periodo contable."; return false;
                    }
                    else if (vCodClienteAsoc.Equals(""))
                    {
                        ps_Mensaje = "Cliente asociado no asignado."; return false;
                    }
                    else if (vCodContactoCliente.Equals(""))
                    {
                        ps_Mensaje = "Cliente de contacto no asignado"; return false;
                    }
                    else if (vCodVendedor.Equals(""))
                    {
                        ps_Mensaje = "Vendedor no asignado"; return false;
                    }
                    else if (vCodVendedorApoyo.Equals(""))
                    {
                        ps_Mensaje = "Vendedor de apoyo"; return false;
                    }
                    else if (vCodVendedor.Equals(vCodVendedorApoyo))
                    {
                        ps_Mensaje = "El vendedor de apoyo debe ser distinto al vendedor."; return false;
                    }
                    else if (vCodVendedorAsistente.Equals(""))
                    {
                        ps_Mensaje = "Vendedor asistente no asignado."; return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    ps_Mensaje = "No se ha ingresado el número de documento.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Valida la información del cliente
        /// </summary>
        /// <returns></returns>
        private bool pv_ValidarCliente()
        {
            try
            {
                decimal vSaldoDisponible = 0, vTotalGeneral = 0, vMontoTasa = 0;

                if (mcbFormaPago.SelectedItem.Equals("Credito"))
                {
                    vTotalGeneral = Convert.ToDecimal((mtileTotalFactura.Text.Replace("TOTAL ", "")).Replace(",", ""));
                    vMontoTasa = Convert.ToDecimal(mtxtValorTasa.Text.Replace(",", ""));

                    if (vEnviarCobrar)
                    {
                        if (Convert.ToDecimal(vMontoSaldoActual) > 0)
                        {
                            ps_Mensaje = "El tipo de cliente es enviar y cobrar e posse saldos pendientes";
                            return false;
                        }
                    }

                    if (vPagoAnticipado)
                    {
                        ps_Mensaje = "El cliente posee caracteristicas de pago anticipado, por lo que la factura debe ser de contado.";
                        return false;
                    }

                    if (vValidarCKPF)
                    {
                        vSaldoDisponible = (Convert.ToDecimal(pe_ClienteModel.cliMonMaximoCredito) - (Convert.ToDecimal(vMontoSaldoActual) + Convert.ToDecimal(vMontoSaldoCKPF)));
                    }
                    else
                    {
                        vSaldoDisponible = (Convert.ToDecimal(pe_ClienteModel.cliMonMaximoCredito) - Convert.ToDecimal(vMontoSaldoActual));
                    }

                    if (!vMontoSaldoActual.Equals("") && !pe_ClienteModel.cliMonMaximoCredito.Equals(""))
                    {
                        if (!vTotalGeneral.Equals("") && !vMontoTasa.Equals(""))
                        {
                            if ((vTotalGeneral * vMontoTasa) > Convert.ToDecimal(vSaldoDisponible))
                            {
                                ps_Mensaje = "El monto de la factura supera el saldo disponible del cliente, saldo actual : " + vSaldoDisponible + " en su moneda local";
                                return false;
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Valida el detalle de registros de productos de la transacción
        /// </summary>
        /// <returns></returns>
        private bool pv_ValidarDetalleTransac()
        {
            try
            {
                int cont = 0, vNumLinea = 0;

                if (mgvProductos.RowCount > 0)
                {
                    while (cont < mgvProductos.RowCount)
                    {
                        vNumLinea++;

                        var cantidad = mgvProductos.Rows[cont].Cells["Cantidad"].Value;
                        var precio = mgvProductos.Rows[cont].Cells["Precio"].Value;
                        var descuento = mgvProductos.Rows[cont].Cells["Descuento"].Value;
                        var impuesto = mgvProductos.Rows[cont].Cells["Impuesto"].Value;
                        var totalLinea = mgvProductos.Rows[cont].Cells["TotalLinea"].Value;

                        if (cantidad.Equals("") || cantidad.Equals(null))
                        {
                            ps_Mensaje = "Debe ingresar la cantidad en la línea " + vNumLinea;
                            return false;
                        }
                        else if (precio.Equals("") || precio.Equals(null))
                        {
                            ps_Mensaje = "Debe ingresar el precio en la línea " + vNumLinea;
                            return false;
                        }
                        else if (descuento.Equals("") || descuento.Equals(null))
                        {
                            ps_Mensaje = "Debe ingresar el porcentaje de descuento en la linea " + vNumLinea;
                            return false;
                        }
                        else if (impuesto.Equals("") || impuesto.Equals(null))
                        {
                            ps_Mensaje = "Debe ingresar el porcentaje de impuesto en la linea " + vNumLinea;
                            return false;
                        }
                        else if (Convert.ToDecimal(totalLinea) < 0)
                        {
                            ps_Mensaje = "El total de la linea " + vNumLinea + " no puede ser menor o igual a 0.00";
                            return false;
                        }

                        cont++;
                    }
                }
                else
                {
                    ps_Mensaje = "Debe ingresar por lo menos un producto.";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cargas de Modelos para mandarlos a guardar

        /// <summary>
        /// Carga el modelo de encabezado de la transaccion para mandarlo a guardar
        /// </summary>
        private void pv_CargarEncabezadoTransac()
        {
            try
            {
                decimal vMontoTasa = Convert.ToDecimal(mtxtValorTasa.Text);

                pe_TransaccionEncabezadoModel.empIntCodigo = Convert.ToInt32(ps_ConfiguraciónModel.codEmpresa);
                pe_TransaccionEncabezadoModel.traChrNumero = mlblTipoTransaccion.Text + "" + mlblNumConsecutivo.Text;
                pe_TransaccionEncabezadoModel.ttpChrCodigo = ps_TipoTransaccionModel.ttpChrCodigo;
                pe_TransaccionEncabezadoModel.sucIntCodigo = ps_CajaModel.sucIntCodigo;
                pe_TransaccionEncabezadoModel.cajChrCodigo = ps_CajaModel.cajChrCodigo;
                pe_TransaccionEncabezadoModel.tdcChrCodigo = ps_TipoTransaccionModel.AtributosTTransaccion["TipDoc"].ToString();
                pe_TransaccionEncabezadoModel.mndIntCodigo = Convert.ToInt32(mcbMoneda.SelectedValue);
                pe_TransaccionEncabezadoModel.traMonTasaMon = mtxtValorTasa.Text;
                pe_TransaccionEncabezadoModel.traChrTasaTipo = (mcbTipoTasa.SelectedIndex.Equals(0)) ? "V" : "C";
                pe_TransaccionEncabezadoModel.traFecFechaDoc = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"), CultureInfo.InvariantCulture);
                pe_TransaccionEncabezadoModel.cliIntDiasCreditoMax = pe_ClienteModel.cliIntDiasCredito;
                pe_TransaccionEncabezadoModel.traIntDiasValido = pe_ClienteModel.cliIntDiasCredito;
                pe_TransaccionEncabezadoModel.cliIntCodigo = pe_ClienteModel.cliIntCodigo;
                pe_TransaccionEncabezadoModel.venIntCodigo = pe_ClienteModel.venIntCodigo;
                pe_TransaccionEncabezadoModel.prvIntCodigo = 1;
                pe_TransaccionEncabezadoModel.traIntFormaPago = Convert.ToInt32(mcbFormaPago.SelectedIndex.ToString());
                pe_TransaccionEncabezadoModel.traChrAnotacion = mtxtAnotacion.Text;
                pe_TransaccionEncabezadoModel.bodChrCodigoOrg = mcbBodega.SelectedValue.ToString();
                pe_TransaccionEncabezadoModel.traMonSubTotalORG = Convert.ToDecimal(mlblSubTotalGeneral.Text) * vMontoTasa;
                pe_TransaccionEncabezadoModel.traMonSubTotalPRC = Convert.ToDecimal(mlblSubTotalGeneral.Text) * vMontoTasa;
                pe_TransaccionEncabezadoModel.traMonTotalDescuento = Convert.ToDecimal(mlblDescuentoGeneral.Text) * vMontoTasa;
                pe_TransaccionEncabezadoModel.traMonTotalBruto = Convert.ToDecimal(mlblSubTotalDescGeneral.Text) * vMontoTasa;
                pe_TransaccionEncabezadoModel.traMonTotalImpuesto = Convert.ToDecimal(mlblImpuestoGeneral.Text) * vMontoTasa;
                pe_TransaccionEncabezadoModel.traMonTotalNeto = (Convert.ToDecimal(mtileTotalFactura.Text.Split(' ')[1]) * vMontoTasa).ToString();
                pe_TransaccionEncabezadoModel.traChrEstado = "700-APL";
                pe_TransaccionEncabezadoModel.traIntAction = 1;
                pe_TransaccionEncabezadoModel.usuIntCodigo = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carga el listado de modelos de detalleProducto.
        /// </summary>
        private void pv_CargarDetalleProductos()
        {
            try
            {
                pe_DetalleProductoModel = new List<DetalleProductoModel>();

                foreach (DataGridViewRow row in mgvProductos.Rows)
                {
                    if (!Convert.ToDecimal(row.Cells["TotalLinea"].Value).Equals(0))
                    {
                        DetalleProductoModel vDetalleProductoModel = new DetalleProductoModel();

                        vDetalleProductoModel.empIntCodigo = Convert.ToInt32(ps_ConfiguraciónModel.codEmpresa.ToString());
                        vDetalleProductoModel.traChrNumero = mlblTipoTransaccion.Text + "" + mlblNumConsecutivo.Text;
                        vDetalleProductoModel.dprdIntConsecutivo = Convert.ToInt32(row.Cells["NumLinea"].Value.ToString());
                        vDetalleProductoModel.prdIntCodigo = Convert.ToInt32(row.Cells["CodigoProducto"].Value.ToString());
                        vDetalleProductoModel.dprdChrNombre = row.Cells["Descripcion"].Value.ToString();
                        vDetalleProductoModel.bodChrCodigo = row.Cells["CodBodega"].Value.ToString();
                        vDetalleProductoModel.undChrCodigo = row.Cells["Unidad"].Value.ToString();
                        vDetalleProductoModel.pxuMonFactor = Convert.ToDecimal(row.Cells["MonFactor"].Value.ToString());
                        vDetalleProductoModel.dprdFecFechaGarantia = Convert.ToDateTime(DateTime.Now.AddDays(Convert.ToInt32(row.Cells["DiasGarantia"].Value)).ToString("yyyy/MM/dd"));
                        vDetalleProductoModel.dprdMonCantIngresada = Convert.ToDecimal(row.Cells["Cantidad"].Value.ToString());
                        vDetalleProductoModel.dprdMonPorcDescuento = Convert.ToDecimal(row.Cells["Descuento"].Value.ToString());
                        vDetalleProductoModel.dprdMonPorcImpuesto = Convert.ToDecimal(row.Cells["Impuesto"].Value.ToString());
                        vDetalleProductoModel.dprdMonCostUnitario = Convert.ToDecimal(row.Cells["CostoPromedio"].Value.ToString());
                        vDetalleProductoModel.dprdMonPrecUnitario = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
                        vDetalleProductoModel.dprdMonTotalDescuento = Convert.ToDecimal(row.Cells["MonDescuentoLinea"].Value.ToString());
                        vDetalleProductoModel.dprdChrMotivoDescuento = "";
                        vDetalleProductoModel.dprdMonTotalNeto = Convert.ToDecimal(row.Cells["TotalLinea"].Value.ToString());
                        vDetalleProductoModel.usuIntCodigo = 1;

                        pe_DetalleProductoModel.Add(vDetalleProductoModel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #endregion

        private void mgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!e.RowIndex.Equals(-1))
                {
                    if (e.ColumnIndex.Equals(mgvProductos.Rows[e.RowIndex].Cells["EliminarRegistro"].ColumnIndex))
                    {
                        mgvProductos.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //try
            //{
            //    if (!e.RowIndex.Equals(-1))
            //    {
            //        if (e.ColumnIndex.Equals(mgvMediosPago.Rows[e.RowIndex].Cells["Totalizar"].ColumnIndex))
            //        {
            //            int decimales = Convert.ToInt32(pe_ConfigEmpresaModelMisc.CnfDecimalesMontos);

            //            foreach (DataGridViewRow row in mgvMediosPago.Rows)
            //            {
            //                row.Cells["MonMedPago"].Value = (0).ToString("N" + decimales, CultureInfo.InvariantCulture);
            //            }

            //            mgvMediosPago.Rows[e.RowIndex].Cells["MonMedPago"].Value = lblTotalPagar.Text;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}
