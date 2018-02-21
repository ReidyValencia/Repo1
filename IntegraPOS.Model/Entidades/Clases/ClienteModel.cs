using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class ClienteModel
    {

        #region Variables e instancias

        private MiscelaneosModel pe_MiscelaneosModel = new MiscelaneosModel();
        private ConfigEmpresaModelMisc pe_ConfigEmpresaModelMisc = new ConfigEmpresaModelMisc();

        #endregion

        #region Propiedades

        /// <summary>
        /// Almacena el código de empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código del Cliente asignado por el sistema.
        /// </summary>
        public int cliIntCodigo { get; set; }
        /// <summary>
        /// Código de sincronización
        /// </summary>
        public int cliIntCodigoSync { get; set; }
        /// <summary>
        /// Código Principal del cliente asignado por el usuario que lo ingreso.
        /// </summary>
        public string cliChrCodigoPri { get; set; }
        /// <summary>
        /// Código del tipo de cédula del cliente
        /// </summary>
        public int tceIntCodigo { get; set; }
        /// <summary>
        /// Modelo Tipo de cedula del cliente
        /// </summary>
        public TipoCedulaModel tipoCedulaModel { get; set; }
        /// <summary>
        /// Cedula del cliente
        /// </summary>
        public string cliChrCedula { get; set; }
        /// <summary>
        /// Nombre principal de cliente
        /// </summary>
        public string cliChrNombrePri { get; set; }
        /// <summary>
        /// Nombre secundario de cliente
        /// </summary>
        public string cliChrNombreSec { get; set; }
        /// <summary>
        /// Código de la dirección del cliente
        /// </summary>
        public string dirChrCodDireccion { get; set; }
        /// <summary>
        /// Modelo Direccion del cliente
        /// </summary>
        public DireccionModelMisc direccionModelMisc { get; set; }
        /// <summary>
        /// Dirección detallada del cliente
        /// </summary>
        public string cliChrDireccionDet { get; set; }
        /// <summary>
        /// Telefono Principal del cliente
        /// </summary>
        public string cliChrTelefono { get; set; }
        /// <summary>
        /// Pagina Web del Cliente
        /// </summary>
        public string cliChrPaginaWeb { get; set; }
        /// <summary>
        /// Correo Electrónico del cliente
        /// </summary>
        public string cliChrEmail { get; set; }
        /// <summary>
        /// Forma de pago del cliente (Contado / Credito)
        /// </summary>
        public string cliChrFPago { get; set; }
        /// <summary>
        /// Cuenta por cobrar estándar para el cliente
        /// </summary>
        public string cliChrCuentaXCobrar { get; set; }
        /// <summary>
        /// Código de la partida de impuestos del cliente
        /// </summary>
        public int parIntCodigo { get; set; }
        /// <summary>
        /// Modelo de la partida de impuestos del cliente
        /// </summary>
        public PartidaModel partidaModel { get; set; }
        /// <summary>
        /// Días de credito que posee el cliente
        /// </summary>
        public int cliIntDiasCredito { get; set; }
        /// <summary>
        /// Monto minimo de credito que tiene el cliente
        /// </summary>
        public decimal cliMonMinimoCredito { get; set; }
        /// <summary>
        /// Monto maximo de credito que tiene el cliente
        /// </summary>
        public decimal cliMonMaximoCredito { get; set; }
        /// <summary>
        /// Código del vendedor asociado al cliente
        /// </summary>
        public int venIntCodigo { get; set; }
        /// <summary>
        /// Modelo del Vendedor asociado al Cliente
        /// </summary>
        public VendedorModel vendedorModel { get; set; }
        /// <summary>
        /// Estado del cliente (Activo / Inactivo)
        /// </summary>
        public string cliChrEstado { get; set; }
        /// <summary>
        /// Estado de sincronización del cliente (NoSync / SyncPOS / SyncERP)
        /// </summary>
        public string cliChrEstadoSync { get; set; }
        /// <summary>
        /// Anotaciones del cliente
        /// </summary>
        public string cliChrAnotaciones { get; set; }
        /// <summary>
        /// Codigo de usuario que realiza los procesos al cliente
        /// </summary>
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public ClienteModel()
        {
            try
            {
                empIntCodigo = 0;
                cliIntCodigo = 0;
                cliIntCodigoSync = 0;
                cliChrCodigoPri = "";
                tceIntCodigo = 1;
                tipoCedulaModel = null;
                cliChrCedula = "";
                cliChrNombrePri = "";
                cliChrNombreSec = "";
                dirChrCodDireccion = "";
                direccionModelMisc = null;
                cliChrDireccionDet = "";
                cliChrTelefono = "";
                cliChrPaginaWeb = "";
                cliChrEmail = "";
                cliChrFPago = "";
                cliChrCuentaXCobrar = "";
                parIntCodigo = 0;
                partidaModel = null;
                cliIntDiasCredito = 0;
                cliMonMinimoCredito = 0;
                cliMonMaximoCredito = 0;
                venIntCodigo = 1;
                vendedorModel = null;
                cliChrEstado = "ACT";
                cliChrEstadoSync = "NoSync";
                cliChrAnotaciones = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~ClienteModel() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerClientes(string pe_datoBusqueda, int pe_topRegistros, string pe_TipoBusqueda, ref List<ClienteModel> ps_ClienteModel)
        {
            try
            {
                pv_ObtenerClientes(pe_datoBusqueda, pe_topRegistros, pe_TipoBusqueda, ref ps_ClienteModel);
                pv_AplicarFormato(ref ps_ClienteModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void pb_ObtenerCliente(string pe_datoBusqueda, ref ClienteModel ps_ClienteModel)
        {
            try
            {
                pv_ObtenerCliente(pe_datoBusqueda, ref ps_ClienteModel);

                List<ClienteModel> ps_Lista = new List<ClienteModel>();
                ps_Lista.Add(ps_ClienteModel);
                pv_AplicarFormato(ref ps_Lista);
                ps_ClienteModel = ps_Lista.First();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void pb_GuardarCliente(int pe_Accion, ClienteModel pe_ClienteModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                pv_GuardarCliente(pe_Accion, pe_ClienteModel, ref ps_Estado, ref ps_Mensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerClientes(string pe_datoBusqueda, int pe_topRegistros, string pe_TipoBusqueda, ref List<ClienteModel> ps_ClienteModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerClientes(pe_datoBusqueda, pe_topRegistros, pe_TipoBusqueda, ref ps_ClienteModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_ObtenerCliente(string pe_datoBusqueda, ref ClienteModel ps_ClienteModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerCliente(pe_datoBusqueda, ref ps_ClienteModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_GuardarCliente(int pe_Accion, ClienteModel pe_ClienteModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                vConnectionModel.pb_GuardarCliente(pe_Accion, pe_ClienteModel, ref ps_Estado, ref ps_Mensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Aplica el formato de niveles configurado para los códigos de clientes
        /// </summary>
        /// <param name="ps_ClienteModel"></param>
        /// <param name="pe_Formato"></param>
        private void pv_AplicarFormato(ref List<ClienteModel> ps_ClienteModel)
        {
            try
            {
                pe_ConfigEmpresaModelMisc.pb_ObtenerConfigEmpresa(ref pe_ConfigEmpresaModelMisc);
                string niveles = pe_ConfigEmpresaModelMisc.CnfNivelesClientes;

                foreach (ClienteModel cli in ps_ClienteModel)
                {
                    string cadena = cli.cliChrCodigoPri;
                    pe_MiscelaneosModel.pb_AplicarFormato(ref cadena, niveles, '-');
                    cli.cliChrCodigoPri = cadena;
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
