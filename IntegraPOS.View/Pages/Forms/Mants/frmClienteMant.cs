using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;
using IntegraPOS.Pages.PopUps;
using IntegraPOS.Clases;
using IntegraPOS.View.Clases;
using System.Globalization;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmClienteMant : IntegraPOS.MasterPage
    {
        #region Variables e instancias

        private TipoCedulaModel pe_TipoCedulaModel = new TipoCedulaModel();
        private List<TipoCedulaModel> ps_TipoCedulaModel; // Lista de tipos de cédula

        private PartidaModel pe_PartidaModel = new PartidaModel();
        private List<PartidaModel> ps_PartidaModel; // Lista de partidas de impuesto

        private VendedorModel pe_VendedorModel = new VendedorModel();
        private List<VendedorModel> ps_VendedorModel; // Lista de vendedores

        private ClienteModel pe_ClienteModel = new ClienteModel();
        private List<ClienteModel> ps_ClienteModel = new List<ClienteModel>(); // Lista de clientes

        private DireccionModelMisc pe_DireccionModelMisc = new DireccionModelMisc();
        private List<DireccionModelMisc> ps_DireccionModelMisc;

        private ConfigEmpresaModelMisc ps_ConfigEmpresaModelMisc = new ConfigEmpresaModelMisc();
        private MiscelaneosModel pe_MiscelaneosModel = new MiscelaneosModel();

        /// <summary>
        /// Instancia de MensajeView para la presentancion de datos.
        /// </summary>
        private MensajeView vMensajeView = new MensajeView();

        /// <summary>
        /// Instancia la clase RegExp para validar los datos ingresados.
        /// </summary>
        private RegExp reg = new RegExp();

        private int vObtenerMascara = 0;

        /// <summary>
        /// Almacena el codigo de cliente enviado desde el View.
        /// </summary>
        private int pe_CodigoCliente = 0;

        /// <summary>
        /// Almacena el código del usuario enviado desde el View.
        /// </summary>
        private int pe_CodigoUsuario = 0;

        private int pe_Accion = 0;

        private string ps_Mensaje = "";

        private bool? ps_Estado = false;

        #endregion

        #region Constructor

        public frmClienteMant()
        {
            InitializeComponent();
        }

        public frmClienteMant(int pe_CodCliente, int pe_CodUsuario, int pe_Accion) : this()
        {
            try
            {
                pe_CodigoCliente = pe_CodCliente;
                pe_CodigoUsuario = pe_CodUsuario;
                this.pe_Accion = pe_Accion;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion

        private void frmClienteMant_Load(object sender, EventArgs e)
        {
            try
            {
                pv_CargarTipoCedula();
                pv_CargarTipoCliente();
                pv_CargarPartidas();
                pv_CargarVendedores();
                pv_CargarCuentaCredito();
                pv_CargarEstados();
                pv_CargarCodigosCliente();

                vObtenerMascara = 1;

                pv_CargarCliente(pe_CodigoCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar el modelo de cliente con sus propiedades
        /// </summary>
        private void pv_CargarCliente(int pe_intCodigoCliente)
        {
            try
            {
                string vCodDireccion = "";
                // Si acción es diferente de 0, es un código de un cliente que existe y se va a modificar
                if (pe_intCodigoCliente != 0)
                {
                    #region Cargar Modelo Cliente

                    // Se carga el modelo cliente
                    pe_ClienteModel.pb_ObtenerCliente(pe_intCodigoCliente.ToString(), ref pe_ClienteModel);

                    #endregion

                    #region Cargar Modelo Tipo de Cédula

                    //if (!pe_ClienteModel.Equals(null))
                    //{
                    //    // Se carga el tipo de cédula del cliente cargado
                    //    pe_TipoCedulaModel.pb_ObtenerTipoCedula(ref ps_TipoCedulaModel, pe_ClienteModel.tceIntCodigo.ToString());

                    //    if (ps_TipoCedulaModel.Count == 1)
                    //    {
                    //        // Se agrega el modelo de tipo de cédula al modelo de cliente cargado
                    //        pe_ClienteModel.tipoCedulaModel = ps_TipoCedulaModel.First();
                    //    }
                    //}

                    #endregion

                    #region Cargar Modelo Partidas de Impuestos

                    //if (!pe_ClienteModel.Equals(null))
                    //{
                    //    // Se carga la partida de impuestos del cliente cargado
                    //    pe_PartidaModel.pb_ObtenerPartidas(ref ps_PartidaModel, pe_ClienteModel.parIntCodigo.ToString());

                    //    if (ps_PartidaModel.Count == 1)
                    //    {
                    //        // Se agrega el modelo de partidas de impuestos al modelo de cliente cargado
                    //        pe_ClienteModel.partidaModel = ps_PartidaModel.First();
                    //    }
                    //}

                    #endregion

                    #region Cargar Modelo Vendedor

                    if (!pe_ClienteModel.Equals(null))
                    {
                        // Se carga el vendedor asociado al cliente cargado
                        pe_VendedorModel.pb_ObtenerVendedores(ref ps_VendedorModel, pe_ClienteModel.venIntCodigo.ToString());

                        if (ps_VendedorModel.Count == 1)
                        {
                            // Se agrega el modelo de vendedor al modelo del cliente cargado
                            pe_ClienteModel.vendedorModel = ps_VendedorModel.First();
                        }
                    }

                    #endregion

                    #region Cargar Modelo Dirección

                    // Se carga la direccion del cliente cargado
                    pe_DireccionModelMisc.pb_ObtenerDirecciones(50, pe_ClienteModel.dirChrCodDireccion, ref ps_DireccionModelMisc);

                    if (ps_DireccionModelMisc.Count == 1)
                    {
                        // Se agrega el modelo de direccion al modelo de cliente cargado
                        pe_ClienteModel.direccionModelMisc = ps_DireccionModelMisc.First();
                    }

                    #endregion

                    vCodDireccion = pe_ClienteModel.direccionModelMisc.dirChrNomDireccion;
                    mtxtCodigoPadre.Enabled = false;
                    mtxtCodigoPadre.BackColor = Color.Gainsboro;
                    mtxtCodigoPadre.ForeColor = Color.Black;
                    mtxtCodigoPadre.UseCustomBackColor = true;
                    mtxtCodigoPadre.UseCustomForeColor = true;
                    mlnkBuscCodigo.Enabled = false;
                    mtxtCodigo.Enabled = false;
                    mtxtCodigo.BackColor = Color.Gainsboro;
                    mtxtCodigo.UseCustomBackColor = true;
                    mlnkConsecutivo.Enabled = false;

                    mcbEstado.Enabled = true;
                    mcbEstado.BackColor = Color.White;
                    mcbEstado.UseCustomBackColor = true;
                }
                else if (pe_intCodigoCliente == 0)
                {
                    mcbEstado.Enabled = false;
                    mcbEstado.BackColor = Color.Gainsboro;
                }

                #region Cargar datos en controles

                mtxtCodigo.Text = pe_ClienteModel.cliChrCodigoPri;
                mcbEstado.SelectedIndex = (pe_ClienteModel.cliChrEstado.Equals("ACT") ? 0 : pe_ClienteModel.cliChrEstado.Equals("INC") ? 1 : 2);
                mcbTipoCedula.SelectedValue = pe_ClienteModel.tceIntCodigo;

                var datoQuery = ps_TipoCedulaModel.Select(s => s).Where(
                     w => w.tceIntCodigo.Equals(pe_ClienteModel.tceIntCodigo)
                    ).FirstOrDefault();

                maskCedula.Mask = string.IsNullOrEmpty(datoQuery.tceChrFormato) ? string.Empty : datoQuery.tceChrFormato;

                maskCedula.Text = pe_ClienteModel.cliChrCedula;
                mcbTipoCliente.SelectedItem = pe_ClienteModel.cliChrFPago;
                mtxtNombre.Text = pe_ClienteModel.cliChrNombrePri;
                mtxtNombreSec.Text = pe_ClienteModel.cliChrNombreSec;
                mtxtTelefono.Text = pe_ClienteModel.cliChrTelefono;
                mtxtPagWeb.Text = pe_ClienteModel.cliChrPaginaWeb;
                mtxtEmail.Text = pe_ClienteModel.cliChrEmail;
                mtxtDireccion.Text = vCodDireccion;
                mtxtCodDireccion.Text = pe_ClienteModel.dirChrCodDireccion;
                mtxtSeniasExactas.Text = pe_ClienteModel.cliChrDireccionDet;
                mtxtAnotaciones.Text = pe_ClienteModel.cliChrAnotaciones;
                mtxtCuentaCredito.Text = (pe_ClienteModel.cliChrCuentaXCobrar.Equals("")) ? ps_ConfigEmpresaModelMisc.CnfCuentaCredito : pe_ClienteModel.cliChrCuentaXCobrar;
                mcbPartidaImpuesto.SelectedValue = pe_ClienteModel.parIntCodigo;
                mcbVendedor.SelectedValue = pe_ClienteModel.venIntCodigo;
                mtxtDiasCredito.Text = pe_ClienteModel.cliIntDiasCredito.ToString();

                string cantDecimales = ps_ConfigEmpresaModelMisc.CnfDecimalesMontos;

                mtxtMontoMinCredito.Text = pe_ClienteModel.cliMonMinimoCredito.ToString("N" + cantDecimales, CultureInfo.InvariantCulture);
                mtxtMontoMaxCredito.Text = pe_ClienteModel.cliMonMaximoCredito.ToString("N" + cantDecimales, CultureInfo.InvariantCulture);

                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Cargas generales

        /// <summary>
        /// Método para cargar el ddl de tipos de cédula
        /// </summary>
        private void pv_CargarTipoCedula()
        {
            try
            {
                pe_TipoCedulaModel.pb_ObtenerTipoCedula(ref ps_TipoCedulaModel, "%");

                mcbTipoCedula.DataSource = ps_TipoCedulaModel;
                mcbTipoCedula.DisplayMember = "tceChrNombre";
                mcbTipoCedula.ValueMember = "tceIntCodigo";

                // cargar el formato de cedula

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar el ddl de tipos de cliente
        /// </summary>
        private void pv_CargarTipoCliente()
        {
            try
            {
                mcbTipoCliente.Items.Insert(0, "Contado");
                mcbTipoCliente.Items.Insert(1, "Crédito");
                mcbTipoCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar el ddl de Partidas de impuesto
        /// </summary>
        private void pv_CargarPartidas()
        {
            try
            {
                pe_PartidaModel.pb_ObtenerPartidas(ref ps_PartidaModel, "%");

                mcbPartidaImpuesto.DataSource = ps_PartidaModel;
                mcbPartidaImpuesto.DisplayMember = "parChrNombre";
                mcbPartidaImpuesto.ValueMember = "parIntCodigo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar el ddl de vendedores
        /// </summary>
        private void pv_CargarVendedores()
        {
            try
            {
                pe_VendedorModel.pb_ObtenerVendedores(ref ps_VendedorModel, "%");

                mcbVendedor.DataSource = ps_VendedorModel;
                mcbVendedor.DisplayMember = "venChrNombre";
                mcbVendedor.ValueMember = "venIntCodigo";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar la cuenta de crédito estándar de clientes
        /// </summary>
        private void pv_CargarCuentaCredito()
        {
            try
            {
                ps_ConfigEmpresaModelMisc.pb_ObtenerConfigEmpresa(ref ps_ConfigEmpresaModelMisc);

                mtxtCuentaCredito.Text = ps_ConfigEmpresaModelMisc.CnfCuentaCredito;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar el combobox de estados
        /// </summary>
        private void pv_CargarEstados()
        {
            try
            {
                mcbEstado.Items.Insert(0, "Activo");
                mcbEstado.Items.Insert(1, "Inactivo");
                mcbEstado.Items.Insert(2, "Bloqueado");
                mcbEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para cargar el combobox de codigos de cliente
        /// </summary>
        private void pv_CargarCodigosCliente()
        {
            try
            {
                pe_ClienteModel.pb_ObtenerClientes("%", 500, "view", ref ps_ClienteModel);
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
        private void frmClienteMant_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:   // Guardar el cliente
                        pv_GuardarCliente();
                        break;

                    case Keys.F2:
                        pv_BuscarDirecciones();
                        break;

                    case Keys.F3:
                        pv_BuscarCodigoPadre();
                        break;

                    case Keys.F5:
                        pv_CargarCliente(pe_CodigoCliente); // Envia el código que obtiene desde el View.
                        break;

                    case Keys.Escape: //Regresa a la pagina Inicial
                        frmClientesView frmClientesView = new frmClientesView();
                        frmClientesView.Show();
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

        #region Busqueda de Direcciones

        /// <summary>
        /// Inicia la busqueda de direcciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBusqDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                pv_BuscarDirecciones();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Hace el llamado al Pop Up y obtiene la dirección seleccionada
        /// </summary>
        private void pv_BuscarDirecciones()
        {
            try
            {
                try
                {
                    frmPopUpDirecciones frmPopUpDirecciones = new frmPopUpDirecciones(mtxtDireccion.Text);

                    if (frmPopUpDirecciones.pb_CantidadDirecciones() > 1)
                    {
                        frmPopUpDirecciones.ShowDialog();
                    }
                    else if (frmPopUpDirecciones.pb_CantidadDirecciones() == 0)
                    {
                        vMensajeView.pb_MensajeSistema(this, 3, "Dato de filtro no concuerda con ningúna dirección.");
                    }

                    pe_DireccionModelMisc = frmPopUpDirecciones.pe_DireccionModelMisc; //Obtiene el modelo dirección devuelvo por el PopUp Dirección

                    if (!pe_ClienteModel.cliIntCodigo.Equals("") || !pe_ClienteModel.cliIntCodigo.Equals(0))
                    {
                        mtxtDireccion.Text = pe_DireccionModelMisc.dirChrNomDireccion;
                        mtxtCodDireccion.Text = pe_DireccionModelMisc.dirChrCodDireccion;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Búsqueda de Código Padre

        /// <summary>
        /// Buscar código padre para cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBuscCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                pv_BuscarCodigoPadre();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_BuscarCodigoPadre()
        {
            try
            {
                frmPopUpClientes vFrmPopUpClientes = new frmPopUpClientes(mtxtCodigoPadre.Text, this.Name);

                if (vFrmPopUpClientes.pb_CantidadClientes() > 1)
                {
                    vFrmPopUpClientes.ShowDialog();
                }
                else if (vFrmPopUpClientes.pb_CantidadClientes() == 0)
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "Dato de filtro no concuerda con ningún cliente.");
                }

                pe_ClienteModel.cliChrCodigoPri = vFrmPopUpClientes.pe_ClienteModel.cliChrCodigoPri; //Obtiene el modelo cliente devuelvo por el PopUp Cliente

                if (!pe_ClienteModel.cliChrCodigoPri.Equals("") || !pe_ClienteModel.cliChrCodigoPri.Equals(0))
                {
                    mtxtCodigoPadre.Text = pe_ClienteModel.cliChrCodigoPri;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos controles

        /// <summary>
        /// Limpia el campo de código de dirección si el campo de dirección cambia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtDireccion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mtxtCodDireccion.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carga el formato de cédula de acuerdo al tipo de cédula seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcbTipoCedula_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string mask = maskCedula.Text;

                if (vObtenerMascara == 1)
                {
                    var tipoCedula = mcbTipoCedula.SelectedValue;

                    foreach (TipoCedulaModel tipoCed in ps_TipoCedulaModel)
                    {
                        if (tipoCed.tceIntCodigo == Convert.ToInt32(tipoCedula))
                        {
                            maskCedula.Mask = tipoCed.tceChrFormato;
                            maskCedula.Text = mask;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deshabilitar controles de cliente de crédito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (mcbTipoCliente.SelectedIndex.Equals(0))
                {
                    mtxtDiasCredito.Enabled = false;
                    mtxtDiasCredito.BackColor = Color.Gainsboro;
                    mtxtDiasCredito.UseCustomBackColor = true;
                    mtxtDiasCredito.Text = "0";

                    mtxtMontoMaxCredito.Enabled = false;
                    mtxtMontoMaxCredito.BackColor = Color.Gainsboro;
                    mtxtMontoMaxCredito.UseCustomBackColor = true;
                    mtxtMontoMaxCredito.Text = "0.00";

                    mtxtMontoMinCredito.Enabled = false;
                    mtxtMontoMinCredito.BackColor = Color.Gainsboro;
                    mtxtMontoMinCredito.UseCustomBackColor = true;
                    mtxtMontoMinCredito.Text = "0.00";
                }
                else
                {
                    mtxtDiasCredito.Enabled = true;
                    mtxtDiasCredito.BackColor = Color.White;
                    mtxtDiasCredito.UseCustomBackColor = false;

                    mtxtMontoMaxCredito.Enabled = true;
                    mtxtMontoMaxCredito.BackColor = Color.White;
                    mtxtMontoMaxCredito.UseCustomBackColor = false;

                    mtxtMontoMinCredito.Enabled = true;
                    mtxtMontoMinCredito.BackColor = Color.White;
                    mtxtMontoMinCredito.UseCustomBackColor = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Solo permite ingresar valores numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Solo permite ingresar valores numéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtDiasCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Solo permite ingresar valores numéricos y puntos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtMontoMaxCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Solo permite ingresar valores numéricos y puntos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtMontoMinCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Guardar cliente si se presiona el botón F1 del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_GuardarCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Buscar direcciones si se presiona el botón F2 del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBuscarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                pv_BuscarDirecciones();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Recargar el formulario si se presiona el botón F5 del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_CargarCliente(pe_CodigoCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Regresar al view de clientes si se presiona el botón ESC del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientesView frmClientesView = new frmClientesView();
                frmClientesView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Le da formato al monto mínimo cuando el control pierde el foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtMontoMinCredito_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantDecimales = ps_ConfigEmpresaModelMisc.CnfDecimalesMontos;

                decimal monto = decimal.Parse(mtxtMontoMinCredito.Text);

                mtxtMontoMinCredito.Text = monto.ToString("N" + cantDecimales, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Le da formato al monto máximo cuando el control pierde el foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtMontoMaxCredito_Leave(object sender, EventArgs e)
        {
            try
            {
                string cantDecimales = ps_ConfigEmpresaModelMisc.CnfDecimalesMontos;

                decimal monto = decimal.Parse(mtxtMontoMaxCredito.Text);

                mtxtMontoMaxCredito.Text = monto.ToString("N" + cantDecimales, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Genera el siguiente consecutivo de acuerdo al código padre seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkConsecutivo_Click(object sender, EventArgs e)
        {
            try
            {
                //var vPadre = mtxtCodigoPadre.Text;
                var vPadre = pe_ClienteModel.cliChrCodigoPri;

                if (!vPadre.Equals(""))
                {
                    var vPadreFormat = vPadre.Replace("-", "");
                    var vlengthPadre = vPadre.Replace("-", "").Length;
                    string vMayor = "";

                    // --------------------------- //
                    var vFormato = ps_ConfigEmpresaModelMisc.CnfNivelesClientes;
                    var vFormatoArreglo = vFormato.Split('-');
                    var vFormatoLength = vFormatoArreglo.Length;
                    var vUltimoNivel = vFormatoArreglo[vFormatoLength - 1];
                    var vConcatenar = "";

                    var vListaHijos = ps_ClienteModel.Where(
                                        w => (w.cliChrCodigoPri.Replace("-", "").Length > vlengthPadre) &&
                                        w.cliChrCodigoPri.Replace("-", "").Substring(0, (vlengthPadre)).Equals(vPadreFormat)
                                    ).ToList();


                    if (vListaHijos.Count != 0)
                    {
                        int myNum = 0;
                        var vHijoArreglo = vListaHijos.Last().cliChrCodigoPri.Split('-');
                        var vLength = vHijoArreglo.Length;
                        var vUltimo = vHijoArreglo[vLength - 1];

                        if (int.TryParse(vUltimo, out myNum))
                        {
                            vMayor = (Convert.ToInt32(vUltimo) + 1).ToString();

                            for (int i = vMayor.Length; i < vUltimoNivel.Length; i++)
                            {
                                vConcatenar += "0";
                            }
                        }
                        else
                        {
                            vMayor = vUltimo;
                        }
                    }
                    else
                    {
                        vMayor = "1";

                        for (int i = vMayor.Length; i < vUltimoNivel.Length; i++)
                        {
                            vConcatenar += "0";
                        }
                    }

                    mtxtCodigo.Text = vConcatenar += vMayor;
                }
                else
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "Debe seleccionar un código padre.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Borrar el código del padre cuando se digita con el teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtCodigoPadre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                pe_ClienteModel.cliChrCodigoPri = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Buscar código padre si se presiona el botón F3 del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBuscarCodPadre_Click(object sender, EventArgs e)
        {
            try
            {
                pv_BuscarCodigoPadre();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Insertar / Actualizar

        private void pv_GuardarCliente()
        {
            try
            {
                ValidarControles validarControles = new ValidarControles();

                if (validarControles.pb_ValidarControles(this))
                {
                    if (pv_ValidarDatos())
                    {
                        int vLenghtNiveles = ps_ConfigEmpresaModelMisc.CnfNivelesClientes.Replace("-", "").Length;
                        int vLenghtCodigo = (pe_Accion.Equals(1)) ? (pe_ClienteModel.cliChrCodigoPri + mtxtCodigo.Text).Replace("-", "").Length : pe_ClienteModel.cliChrCodigoPri.Replace("-", "").Length;

                        if (vLenghtCodigo.Equals(vLenghtNiveles))
                        {
                            pe_ClienteModel.cliIntCodigo = pe_ClienteModel.cliIntCodigo;
                            pe_ClienteModel.cliChrCodigoPri = (pe_Accion.Equals(1)) ? (pe_ClienteModel.cliChrCodigoPri + mtxtCodigo.Text).Replace("-", "") : pe_ClienteModel.cliChrCodigoPri.Replace("-", "");
                            pe_ClienteModel.tceIntCodigo = Convert.ToInt32(mcbTipoCedula.SelectedValue);
                            pe_ClienteModel.cliChrCedula = maskCedula.Text;
                            pe_ClienteModel.cliChrNombrePri = mtxtNombre.Text;
                            pe_ClienteModel.cliChrNombreSec = mtxtNombreSec.Text;
                            pe_ClienteModel.dirChrCodDireccion = mtxtCodDireccion.Text;
                            pe_ClienteModel.cliChrDireccionDet = mtxtSeniasExactas.Text;
                            pe_ClienteModel.cliChrAnotaciones = mtxtAnotaciones.Text;
                            pe_ClienteModel.cliChrTelefono = mtxtTelefono.Text;
                            pe_ClienteModel.cliChrFPago = (mcbTipoCliente.SelectedIndex).ToString();
                            pe_ClienteModel.cliChrPaginaWeb = mtxtPagWeb.Text;
                            pe_ClienteModel.cliChrEmail = mtxtEmail.Text;
                            pe_ClienteModel.venIntCodigo = Convert.ToInt32(mcbVendedor.SelectedValue);
                            pe_ClienteModel.cliChrCuentaXCobrar = mtxtCuentaCredito.Text;
                            pe_ClienteModel.cliIntDiasCredito = Convert.ToInt32(mtxtDiasCredito.Text);
                            pe_ClienteModel.cliMonMinimoCredito = Convert.ToDecimal(mtxtMontoMinCredito.Text);
                            pe_ClienteModel.cliMonMaximoCredito = Convert.ToDecimal(mtxtMontoMaxCredito.Text);
                            pe_ClienteModel.parIntCodigo = Convert.ToInt32(mcbPartidaImpuesto.SelectedValue);
                            pe_ClienteModel.cliChrEstado = (mcbEstado.SelectedItem.ToString().ToLower().Equals("activo")) ? "ACT" :
                                                            (mcbEstado.SelectedItem.ToString().ToLower().Equals("inactivo")) ? "INC" : "BLQ";

                            pe_ClienteModel.pb_GuardarCliente(pe_Accion, pe_ClienteModel, ref ps_Estado, ref ps_Mensaje);

                            if (ps_Estado.Value)
                            {
                                vMensajeView.pb_MensajeSistema(this, 1, "Datos guardados correctamente.");
                                frmClientesView vfrmClientesView = new frmClientesView(pe_CodigoUsuario);
                                vfrmClientesView.Show();
                                Close();
                            }
                            else
                            {
                                vMensajeView.pb_MensajeSistema(this, 3, ps_Mensaje);
                            }
                        }
                        else
                        {
                            vMensajeView.pb_MensajeSistema(this, 3, "El nivel del código de cliente es incorrecto.");
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
                vMensajeView.pb_MensajeSistema(this, 5, ex.Message);
            }
        }

        private bool pv_ValidarDatos()
        {
            try
            {
                if (!reg.pb_ValidarRegExp(mtxtCodigoPadre, "letraNumero") && mtxtCodigoPadre.ForeColor.Name.Equals("Maroon"))
                {
                    ps_Mensaje = "Formato de código padre incorrecto.";
                    return false;
                }
                if (!reg.pb_ValidarRegExp(mtxtCodigo, "letraNumero"))
                {
                    ps_Mensaje = "Formato de código incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtNombre, "nombre"))
                {
                    ps_Mensaje = "Formato de nombre incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtTelefono, "numero"))
                {
                    ps_Mensaje = "Formato de teléfono incorrecto.";
                    return false;
                }
                else if (!mtxtPagWeb.Text.Equals("") && (!reg.pb_ValidarRegExp(mtxtPagWeb, "letras")))
                {
                    ps_Mensaje = "Formato de página web incorrecto.";
                    return false;
                }
                else if (!mtxtEmail.Text.Equals("") && !reg.pb_ValidarRegExp(mtxtEmail, "correo"))
                {
                    ps_Mensaje = "Formato de correo electrónico incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtDireccion, "letras"))
                {
                    ps_Mensaje = "Formato de dirección incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtCodDireccion, "numero"))
                {
                    ps_Mensaje = "Formato de código de dirección incorrecto.";
                    return false;
                }
                else if (!mtxtSeniasExactas.Text.Equals("") && !reg.pb_ValidarRegExp(mtxtSeniasExactas, "letraNumero"))
                {
                    ps_Mensaje = "Formato de señas exactas incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtCuentaCredito, "numero"))
                {
                    ps_Mensaje = "Formato de cuenta de crédito incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtDiasCredito, "numero"))
                {
                    ps_Mensaje = "Formato de días de crédito incorrecto.";
                    return false;
                }
                else if (mcbTipoCliente.SelectedItem.Equals("Crédito"))
                {
                    if (Convert.ToInt32(mtxtDiasCredito.Text) <= 0)
                    {
                        ps_Mensaje = "Días de crédito deben ser mayor a cero.";
                        return false;
                    }
                    else if (Convert.ToDecimal(mtxtMontoMinCredito.Text) <= 0)
                    {
                        ps_Mensaje = "Monto mínimo de crédito deben ser mayor a cero.";
                        return false;
                    }
                    else if (Convert.ToDecimal(mtxtMontoMaxCredito.Text) < Convert.ToDecimal(mtxtMontoMinCredito.Text))
                    {
                        ps_Mensaje = "Monto máximo de crédito deben ser mayor al monto mínimo.";
                        return false;
                    }
                }
                else if (!reg.pb_ValidarRegExp(mtxtMontoMinCredito, "numero"))
                {
                    ps_Mensaje = "Formato de monto mínimo de crédito incorrecto.";
                    return false;
                }
                else if (!reg.pb_ValidarRegExp(mtxtMontoMaxCredito, "numero"))
                {
                    ps_Mensaje = "Formato de monto máximo de crédito incorrecto.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }


        /*private bool pv_ValidarControles()
{
    try
    {
        if (mtxtCodigo.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar un código de cliente.";
            return false;
        }
        else if (maskCedula.Text.Replace("-", "").Equals(""))
        {
            ps_Mensaje = "Debe ingresar el número de cédula del cliente.";
            return false;
        }
        else if (mtxtNombre.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar el nombre del cliente.";
            return false;
        }
        else if (mtxtTelefono.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar un número de teléfono del cliente.";
            return false;
        }
        else if (mtxtCodDireccion.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar la dirección del cliente.";
            return false;
        }
        else if (mtxtCuentaCredito.Text.Equals(""))
        {
            ps_Mensaje = "No se ha configurado una cuenta de crédito para el cliente.";
            return false;
        }
        else if (mtxtDiasCredito.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar la cantidad de días de crédito.";
            return false;
        }
        else if (mtxtMontoMinCredito.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar el monto mínimo de crédito.";
            return false;
        }
        else if (mtxtMontoMaxCredito.Text.Equals(""))
        {
            ps_Mensaje = "Debe ingresar el monto máximo de crédito.";
            return false;
        }
    }
    catch (Exception ex)
    {
        throw ex;
    }

    return true;
}*/

        #endregion
    }
}
