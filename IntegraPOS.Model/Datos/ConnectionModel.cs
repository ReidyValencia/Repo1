using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using IntegraPOS.Model.Entidades;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;
using IntegraPOS.Model.Entidades.PopUps;
using IntegraPOS.Model.Entidades.Reportes;

namespace IntegraPOS.Model
{
    public class ConnectionModel
    {
        public IDbConnection Connection;
        public readonly string DBConnection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private ConfigurationModel ps_ConfigurationModel = new ConfigurationModel(); //Instancia con las propiedades de configuración de Punto Venta.
        private List<MiscelaneosModel> ps_MiscelaneosModel;


        #region Constructor / Destructor

        public ConnectionModel() { }

        ~ConnectionModel() { }

        #endregion

        #region Metodos Principales

        #region Validaciones

        /// <summary>
        /// Valida el acceso del usuario antes de ingresar al sistema.
        /// </summary>
        /// <param name="pe_UsuarioModel">Modelo del usuario con los datos para consulta</param>
        /// <param name="ps_UsuarioModel">Modelo del usuario con todos los atributos del usuario</param>
        /// <param name="ps_estadoProceso">estado de la validación del acceso al sistema</param>
        /// <param name="ps_mensaje">mensaje en caso que se presente un problema en la validación de los datos de acceso</param>
        public void pb_ValidarUsuario(UsuarioModel pe_UsuarioModel, ref UsuarioModel ps_UsuarioModel, ref bool? ps_estadoProceso, ref string ps_mensaje)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "ptv.pr_AccValidarLoginUsuario";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@pe_empIntCodigo", empresa, DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_usuChrLogin", pe_UsuarioModel.usuChrLogin, DbType.String, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@pe_usuChrClave", pe_UsuarioModel.usuBinClave, DbType.String, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@ps_usuIntCodigo", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    parameter.Add("@ps_usuChrNombre", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);
                    parameter.Add("@ps_usuChrPregunta", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);
                    parameter.Add("@ps_usuChrRespuesta", dbType: DbType.String, direction: ParameterDirection.Output, size: 250);
                    parameter.Add("@ps_empBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    parameter.Add("@ps_empChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    Connection.Execute(SqlText, parameter, null, null, CommandType.StoredProcedure);

                    ps_UsuarioModel.usuIntCodigo = parameter.Get<int>("@ps_usuIntCodigo");
                    ps_UsuarioModel.usuChrNombre = parameter.Get<string>("@ps_usuChrNombre");
                    ps_UsuarioModel.usuBinPregunta = parameter.Get<string>("@ps_usuChrPregunta");
                    ps_UsuarioModel.usuBinRespuesta = parameter.Get<string>("@ps_usuChrRespuesta");
                    ps_estadoProceso = parameter.Get<bool>("@ps_empBndEstatusProc");
                    ps_mensaje = parameter.Get<string>("@ps_empChrMensajeProc");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #region Select

        #region Clientes

        /// <summary>
        /// Obtiene el clienta para cargarlo
        /// </summary>
        /// <param name="pe_datoBusqueda"></param>
        /// <param name="ps_ClienteModel"></param>
        public void pb_ObtenerCliente(string pe_datoBusqueda, ref ClienteModel ps_ClienteModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCLI_CLIENTE(" + empresa + ",'" + pe_datoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_ClienteModel = Connection.Query<ClienteModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = pe_datoBusqueda }).FirstOrDefault();

                    Connection.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los clientes para cargarlos
        /// </summary>
        /// <param name="pe_datoBusqueda">Dato como filtro de busqueda</param>
        /// <param name="pe_topRegistros">Cantidad de registros a presentar</param>
        /// <param name="ps_ClienteModel">Lista de clientes</param>
        public void pb_ObtenerClientes(string pe_datoBusqueda, int pe_topRegistros, string pe_tipoBusqueda, ref List<ClienteModel> ps_ClienteModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_CLIENTE_MISC(" + empresa + "," + pe_topRegistros + ",'" + pe_datoBusqueda + "','" + pe_tipoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_ClienteModel = Connection.Query<ClienteModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_intTopBusqueda = pe_topRegistros, @pe_chrDatoBusqueda = pe_datoBusqueda }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cajas

        /// <summary>
        /// Obtiene la caja que tiene asignada el usuario
        /// </summary>
        /// <param name="pe_datoBusqueda"></param>
        /// <param name="ps_CajaModel"></param>
        public void pb_ObtenerCajaUsuario(string pe_datoBusqueda, ref CajaModel ps_CajaModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_CAJAUSUARIO(" + empresa + ",'" + pe_datoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_CajaModel = Connection.Query<CajaModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = pe_datoBusqueda }).FirstOrDefault();
                    

                    Connection.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
        public List<CajaModel> pb_getCajas(string pe_cajChrCodigo, string pe_datoBusqueda)
        {
            try
            {
                List<CajaModel> oListCajas = new List<CajaModel>();

                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT *  FROM [ptv].[fn_SelCOM_CAJA](" + empresa + ",'" + pe_cajChrCodigo + "','" + pe_datoBusqueda + "')";                

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();
                    oListCajas = Connection.Query<CajaModel>(SqlText).ToList();
                    Connection.Close();
                }

                return oListCajas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Tipo Transaccion 

        /// <summary>
        /// Obtiene el tipo de transaccion.
        /// </summary>
        /// <param name="pe_datoBusqueda"></param>
        /// <param name="ps_TipoTransaccionModel"></param>
        public void pb_ObtenerTipoTransaccion(string pe_datoBusqueda, ref List<TipoTransaccionModel> ps_TipoTransaccionModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                var SqlText = "SELECT * FROM ptv.fn_SelCOM_TIPOTRANSACCION(" + empresa + ",'" + pe_datoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    var vTipoTransaccionModel = Connection.Query(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = pe_datoBusqueda }).ToList();

                    var vParametros = vTipoTransaccionModel.GroupBy(g => new { g.ttpChrCodigo, g.ttpChrNombre, g.tclChrCodigo });

                    foreach (var tipoTransac in vParametros)
                    {
                        var model = new TipoTransaccionModel
                        {
                            ttpChrCodigo = tipoTransac.Key.ttpChrCodigo,ttpChrNombre = tipoTransac.Key.ttpChrNombre,tclChrCodigo = tipoTransac.Key.tclChrCodigo,
                        };

                        var atributos = vTipoTransaccionModel.GroupBy(g => new { g.atrChrClave, g.axtChrDato });

                        model.AtributosTTransaccion = new Dictionary<string, string>();

                        foreach (var atr in atributos)
                        {
                            model.AtributosTTransaccion.Add(atr.Key.atrChrClave, atr.Key.axtChrDato);
                        }

                        ps_TipoTransaccionModel.Add(model);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Monedas

        /// <summary>
        /// Obtiene las monedad configuradas.
        /// </summary>
        /// <param name="pe_CodMoneda"></param>
        /// <param name="pe_TipoBusqueda"></param>
        /// <param name="ps_MonedaModel"></param>
        public void pb_ObtenerMoneda(string pe_codMoneda, int pe_tipoBusqueda, ref List<MonedaModel> ps_MonedaModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelEMP_MONEDA_MISC(" + empresa + ",'" + pe_codMoneda + "'," + pe_tipoBusqueda + ")";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_MonedaModel = Connection.Query<MonedaModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_mndIntCodigo = pe_codMoneda, @pe_tipoBusqueda = pe_tipoBusqueda }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Transacciones

        public void pb_ObtenerTransacciones(string pe_datoBusqueda, int pe_topRegistros, string pe_tipoTransac, ref List<TransaccionEncabezadoModel> ps_TransaccionEncabezadoModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_TRANSACCION_ENC_MISC(" + empresa + "," + pe_topRegistros + ",'" + pe_tipoTransac + "','" + pe_datoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_TransaccionEncabezadoModel = Connection.Query<TransaccionEncabezadoModel>(SqlText, new
                    {
                        @pe_empIntCodigo = empresa,
                        @pe_intTopBusqueda = pe_topRegistros,
                        @pe_chrTipoTransac = pe_tipoTransac,
                        @pe_chrDatoBusqueda = pe_datoBusqueda
                    }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #endregion

        #region Insert

        public void pb_GuardarCliente(int pe_Accion, ClienteModel pe_ClienteModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                var empresa = Convert.ToInt32(ps_ConfigurationModel.codEmpresa);

                string SqlText = "ptv.pr_InsCLI_CLIENTE";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@pe_empIntCodigo", empresa, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliIntCodigo", pe_ClienteModel.cliIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliIntCodigoSync", pe_ClienteModel.cliIntCodigoSync, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@pe_cliChrCodigoPri", pe_ClienteModel.cliChrCodigoPri, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@pe_tceIntCodigo", pe_ClienteModel.tceIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliChrCedula", pe_ClienteModel.cliChrCedula, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@pe_cliChrNombrePri", pe_ClienteModel.cliChrNombrePri, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    parameter.Add("@pe_cliChrNombreSec", pe_ClienteModel.cliChrNombreSec, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    parameter.Add("@pe_dirChrCodDireccion", pe_ClienteModel.dirChrCodDireccion, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@pe_cliChrDireccionDet", pe_ClienteModel.cliChrDireccionDet, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    parameter.Add("@pe_cliChrTelefono", pe_ClienteModel.cliChrTelefono, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    parameter.Add("@pe_cliChrPaginaWeb", pe_ClienteModel.cliChrPaginaWeb, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    parameter.Add("@pe_cliChrEmail", pe_ClienteModel.cliChrEmail, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    parameter.Add("@pe_cliIntFPago", pe_ClienteModel.cliChrFPago, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliChrCuentaXCobrar", pe_ClienteModel.cliChrCuentaXCobrar, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    parameter.Add("@pe_parIntCodigo", pe_ClienteModel.parIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliIntDiasCredito", pe_ClienteModel.cliIntDiasCredito, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliMonMinimoCredito", pe_ClienteModel.cliMonMinimoCredito, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliMonMaximoCredito", pe_ClienteModel.cliMonMaximoCredito, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    parameter.Add("@pe_venIntCodigo", pe_ClienteModel.venIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);          
                    parameter.Add("@pe_cliChrEstado", pe_ClienteModel.cliChrEstado, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    parameter.Add("@pe_cliChrEstadoSync", pe_ClienteModel.cliChrEstadoSync, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    parameter.Add("@pe_cliChrAnotaciones", pe_ClienteModel.cliChrAnotaciones, dbType: DbType.String, direction: ParameterDirection.Input, size: 500);
                    parameter.Add("@pe_IntAccion", pe_Accion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_usuIntCodigo", pe_ClienteModel.usuIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@ps_cliBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    parameter.Add("@ps_cliChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    Connection.Execute(SqlText, parameter, null, null, CommandType.StoredProcedure);

                    ps_Estado = parameter.Get<bool?>("@ps_cliBndEstatusProc");
                    ps_Mensaje = parameter.Get<string>("@ps_cliChrMensajeProc");

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Metodos de guardados de una Transaccion

        public void pb_InsertarTransaccion(TransaccionEncabezadoModel pe_TransaccionEncabezadoModel, List<MedioPagoModel> pe_MedioPagoModel,
                                            List<DetalleProductoModel> pe_DetalleProductoModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                var empresa = Convert.ToInt32(ps_ConfigurationModel.codEmpresa);

                string SqlEncabezado = "ptv.pr_InsCOM_TRANSACLI_ENC";
                string SqlDetalleMPago = "ptv.pr_InsCOM_TRANSACCION_DETMPG";
                string SqlDetalleProducto = "ptv.pr_InsCOM_TRANSACCION_DETPRD";

                var parametersMPagos = new List<DynamicParameters>();
                var parametersProductos = new List<DynamicParameters>();

                using (Connection = new SqlConnection(DBConnection))
                {
                    try
                    {
                        Connection.Open();

                        using (var Connec = Connection.BeginTransaction())
                        {
                            #region Insertar Encabezado de la transaccion

                            DynamicParameters parameter = new DynamicParameters();

                            parameter.Add("@pe_empIntCodigo", empresa, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traChrNumero", pe_TransaccionEncabezadoModel.traChrNumero, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                            parameter.Add("@pe_ttpChrCodigo", pe_TransaccionEncabezadoModel.ttpChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                            parameter.Add("@pe_sucIntCodigo", pe_TransaccionEncabezadoModel.sucIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_cajChrCodigo", pe_TransaccionEncabezadoModel.cajChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                            parameter.Add("@pe_tdcChrCodigo", pe_TransaccionEncabezadoModel.tdcChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                            parameter.Add("@pe_mndIntCodigo", pe_TransaccionEncabezadoModel.mndIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traMonTasaMon", pe_TransaccionEncabezadoModel.traMonTasaMon, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traChrTasaTipo", pe_TransaccionEncabezadoModel.traChrTasaTipo, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                            parameter.Add("@pe_traFecFechaDoc", pe_TransaccionEncabezadoModel.traFecFechaDoc, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                            parameter.Add("@pe_cliIntDiasCreditoMax", pe_TransaccionEncabezadoModel.cliIntDiasCreditoMax, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traIntDiasValido", pe_TransaccionEncabezadoModel.traIntDiasValido, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_cliIntCodigo", pe_TransaccionEncabezadoModel.cliIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_venIntCodigo", pe_TransaccionEncabezadoModel.venIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_prvIntCodigo", pe_TransaccionEncabezadoModel.prvIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traIntFormaPago", pe_TransaccionEncabezadoModel.traIntFormaPago, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traChrAnotacion", pe_TransaccionEncabezadoModel.traChrAnotacion, dbType: DbType.String, direction: ParameterDirection.Input, size: 500);
                            parameter.Add("@pe_bodChrCodigoOrg", pe_TransaccionEncabezadoModel.bodChrCodigoOrg, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                            parameter.Add("@pe_traMonSubTotalORG", pe_TransaccionEncabezadoModel.traMonSubTotalORG, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traMonSubTotalPRC", pe_TransaccionEncabezadoModel.traMonSubTotalPRC, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traMonTotalDescuento", pe_TransaccionEncabezadoModel.traMonTotalDescuento, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traMonTotalBruto", pe_TransaccionEncabezadoModel.traMonTotalBruto, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traMonTotalImpuesto", pe_TransaccionEncabezadoModel.traMonTotalImpuesto, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traMonTotalNeto", pe_TransaccionEncabezadoModel.traMonTotalNeto, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                            parameter.Add("@pe_traChrEstado", pe_TransaccionEncabezadoModel.traChrEstado, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                            parameter.Add("@pe_traIntAction", pe_TransaccionEncabezadoModel.traIntAction, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@pe_usuIntCodigo", pe_TransaccionEncabezadoModel.usuIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                            parameter.Add("@ps_traChrNumero", dbType: DbType.String, direction: ParameterDirection.Output, size: 25);
                            parameter.Add("@ps_traBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                            parameter.Add("@ps_traChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                            Connection.Execute(SqlEncabezado, parameter, commandType: CommandType.StoredProcedure, transaction: Connec);

                            var ps_traChrNumero = parameter.Get<string>("@ps_traChrNumero");
                            ps_Estado = parameter.Get<bool?>("@ps_traBndEstatusProc");
                            ps_Mensaje = parameter.Get<string>("@ps_traChrMensajeProc");

                            #endregion

                            #region Insertar Detalle Medios de Pago

                            if (ps_Estado.Value)
                            {
                                #region Listado de Detalle Medios de Pago

                                foreach (MedioPagoModel DetMedioPago in pe_MedioPagoModel)
                                {
                                    DynamicParameters parameterMPago = new DynamicParameters();

                                    parameterMPago.Add("@pe_empIntCodigo", empresa, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@pe_traChrNumero", DetMedioPago.traChrNumero, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                                    parameterMPago.Add("@pe_mpgChrCodigo", DetMedioPago.mpgChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                                    parameterMPago.Add("@pe_dmpIntPosicion", DetMedioPago.dmpIntPosicion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@pe_dmpChrDocumento", DetMedioPago.dmpChrDocumento, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                                    parameterMPago.Add("@pe_dmpChrBancoEmisor", DetMedioPago.dmpChrBancoEmisor, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                                    parameterMPago.Add("@pe_dmpFecFechaDoc", DetMedioPago.dmpFecFechaDoc, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@pe_dmpMonMontoMedPago", DetMedioPago.mpgMonMontoMPago, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@pe_dmpMonMontoFactor", DetMedioPago.mpgMonMontoFactor, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@pe_dmpMonMontoTransac", DetMedioPago.mpgMonMontoTransac, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@pe_usuIntCodigo", DetMedioPago.usuIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterMPago.Add("@ps_dmpBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                                    parameterMPago.Add("@ps_dmpChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                                    parametersMPagos.Add(parameterMPago);
                                }

                                #endregion

                                Connection.Execute(SqlDetalleMPago, parametersMPagos, commandType: CommandType.StoredProcedure, transaction: Connec);

                                var vEstado = parametersMPagos.Where(w => w.Get<bool?>("@ps_dmpBndEstatusProc").Equals(false)).Any();

                                if (vEstado)
                                {
                                    ps_Estado = false;
                                    var vMensaje = parametersMPagos.Where(w => w.Get<bool?>("@ps_dmpBndEstatusProc").Equals(false)).Select(
                                                    s => s.Get<string>("@ps_dmpChrMensajeProc")).ToList();
                                }
                                else
                                {
                                    ps_Estado = true;
                                }
                            }

                            #endregion

                            #region Insertar Detalle de Productos

                            if (ps_Estado.Value)
                            {
                                #region Listado de Detalle de Productos

                                foreach (DetalleProductoModel DetProducto in pe_DetalleProductoModel)
                                {
                                    DynamicParameters parameterProducto = new DynamicParameters();

                                    parameterProducto.Add("@pe_empIntCodigo", empresa, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_traChrNumero", DetProducto.traChrNumero, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                                    parameterProducto.Add("@pe_dprdIntConsecutivo", DetProducto.dprdIntConsecutivo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_prdIntCodigo", DetProducto.prdIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdChrNombre", DetProducto.dprdChrNombre, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                                    parameterProducto.Add("@pe_bodChrCodigo", DetProducto.bodChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                                    parameterProducto.Add("@pe_undChrCodigo", DetProducto.undChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                                    parameterProducto.Add("@pe_pxuMonFactor", DetProducto.pxuMonFactor, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdFecFechaGarantia", DetProducto.dprdFecFechaGarantia, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdMonCantIngresada", DetProducto.dprdMonCantIngresada, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdMonPorcDescuento", DetProducto.dprdMonPorcDescuento, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdMonPorcImpuesto", DetProducto.dprdMonPorcImpuesto, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdMonCostUnitario", DetProducto.dprdMonCostUnitario, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdMonPrecUnitario", DetProducto.dprdMonPrecUnitario, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdMonTotalDescuento", DetProducto.dprdMonTotalDescuento, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_dprdChrMotivoDescuento", DetProducto.dprdChrMotivoDescuento, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                                    parameterProducto.Add("@pe_dprdMonTotalNeto", DetProducto.dprdMonTotalNeto, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@pe_usuIntCodigo", DetProducto.usuIntCodigo, dbType: DbType.Int32, direction: ParameterDirection.Input);
                                    parameterProducto.Add("@ps_dprdBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                                    parameterProducto.Add("@ps_dprdChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                                    parametersProductos.Add(parameterProducto);
                                }

                                #endregion

                                Connection.Execute(SqlDetalleProducto, parametersProductos, commandType: CommandType.StoredProcedure, transaction: Connec);

                                var vEstado = parametersProductos.Where(w => w.Get<bool?>("@ps_dprdBndEstatusProc").Equals(false)).Any();

                                if (vEstado)
                                {
                                    ps_Estado = false;

                                    var vMensaje = parametersProductos.Where(w => w.Get<bool?>("@ps_dprdBndEstatusProc").Equals(false)).Select(
                                                    s => s.Get<string>("@ps_dprdChrMensajeProc")).ToList();
                                }
                                else
                                {
                                    ps_Estado = true;
                                }
                            }

                            #endregion

                            #region Ejecutar Rollback o Commit de la transaccion

                            if (!ps_Estado.Value)
                            {
                                Connec.Rollback();
                                ps_Estado = false;
                            }
                            else
                            {
                                Connec.Commit();
                                ps_Estado = true;
                            }

                            #endregion
                        }

                        Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void pb_GuardarDetalleMedioPago()
        //public void pb_GuardarDetalleMedioPago(List<DetalleMedioPagoModel> pe_DetalleMedioPagoModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                var empresa = Convert.ToInt32(ps_ConfigurationModel.codEmpresa);

                string SqlText = "ptv.pr_InsCOM_TRANSACCION_DETMPG";

                var parameters = new List<DynamicParameters>();
                DynamicParameters p = new DynamicParameters();


                for (int i = 0; i < 1; i++)
                //foreach (DetalleMedioPagoModel DetMedioPago in pe_DetalleMedioPagoModel)
                {
                    //DynamicParameters p = new DynamicParameters();

                    //p.Add("@pe_empIntCodigo", empresa, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    //p.Add("@pe_traChrNumero", DetMedioPago.traChrNumero, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                    //p.Add("@pe_mpgChrCodigo", DetMedioPago.mpgChrCodigo, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                    //p.Add("@pe_dmpIntPosicion", DetMedioPago.dmpIntPosicion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    //p.Add("@pe_dmpChrDocumento", DetMedioPago.dmpChrDocumento, dbType: DbType.String, direction: ParameterDirection.Input, size: 25);
                    //p.Add("@pe_dmpChrBancoEmisor", DetMedioPago.dmpChrBancoEmisor, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    //p.Add("@pe_dmpFecFechaDoc", DetMedioPago.dmpFecFechaDoc, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    //p.Add("@pe_dmpMonMontoMedPago", DetMedioPago.dmpMonMontoMedPago, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    //p.Add("@pe_dmpMonMontoFactor", DetMedioPago.dmpMonMontoFactor, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    //p.Add("@pe_dmpMonMontoTransac", DetMedioPago.dmpMonMontoTransac, dbType: DbType.Decimal, direction: ParameterDirection.Input);
                    //p.Add("@pe_usuIntCodigo", DetMedioPago.usuIntCodigoMod, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    //p.Add("@ps_dmpBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    //p.Add("@ps_dmpChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    //parameters.Add(p);


                    #region Prueba

                    p = new DynamicParameters();

                    p.Add("@pe_empIntCodigo", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_traChrNumero", "FAC-00001", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_mpgChrCodigo", "EFEC-001", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpIntPosicion", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpChrDocumento", "DOC-005", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpChrBancoEmisor", "Banco Nacional", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpFecFechaDoc", DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoMedPago", 120000.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoFactor", 1.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoTransac", 120000.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_usuIntCodigo", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@ps_dmpBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    p.Add("@ps_dmpChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    parameters.Add(p);

                    p = new DynamicParameters();

                    p.Add("@pe_empIntCodigo", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_traChrNumero", "", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_mpgChrCodigo", "CHKS-002", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpIntPosicion", 2, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpChrDocumento", "DOC-005", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpChrBancoEmisor", "Banco Nacional", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpFecFechaDoc", DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoMedPago", 120000.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoFactor", 1.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoTransac", 120000.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_usuIntCodigo", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@ps_dmpBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    p.Add("@ps_dmpChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    parameters.Add(p);

                    p = new DynamicParameters();

                    p.Add("@pe_empIntCodigo", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_traChrNumero", "FAC-00001", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_mpgChrCodigo", "EFEC-001", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpIntPosicion", null, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpChrDocumento", "DOC-005", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpChrBancoEmisor", "Banco Nacional", dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpFecFechaDoc", DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoMedPago", 120000.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoFactor", 1.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_dmpMonMontoTransac", 120000.00, dbType: DbType.Decimal, direction: ParameterDirection.Input, size: 10);
                    p.Add("@pe_usuIntCodigo", 1, dbType: DbType.Int32, direction: ParameterDirection.Input, size: 10);
                    p.Add("@ps_dmpBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    p.Add("@ps_dmpChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    parameters.Add(p);

                    #endregion
                }

                #region Prueba 1           

                using (Connection = new SqlConnection(DBConnection))
                {
                    try
                    {
                        Connection.Open();

                        using (var Connec = Connection.BeginTransaction())
                        {
                            try
                            {
                                Connection.Execute(SqlText, parameters, commandType: CommandType.StoredProcedure, transaction: Connec);

                                //var vEstado = parameters.Select(s => s.Get<bool?>("@ps_dmpBndEstatusProc")).Where(
                                //                    w => w.Value.Equals(false)).FirstOrDefault();

                                //var vMensaje = parameters.Select(s => s.Get<string>("@ps_dmpChrMensajeProc")).Where(
                                //                    w => !w.ToString().Equals("")).FirstOrDefault();


                                var vEstado = parameters.Where(w => w.Get<bool?>("@ps_dmpBndEstatusProc").Equals(false)).Any();

                                if (vEstado)
                                {
                                    var vMensaje = parameters.Where(w => w.Get<bool?>("@ps_dmpBndEstatusProc").Equals(false)).Select(s =>
                                                                       s.Get<string>("@ps_dmpChrMensajeProc")).ToList();
                                }

                                //if (!vEstado.Value)
                                //{
                                //    //ps_Mensaje = vMensaje;
                                //    Connec.Rollback();
                                //    //ps_Estado = vEstado;
                                //}
                                //else
                                //{
                                //    Connec.Commit();
                                //    //ps_Estado = vEstado;
                                //}
                            }
                            catch (Exception ex)
                            {
                                Connec.Rollback();
                                //ps_Estado = vEstado;
                                throw ex;
                            }
                        }

                        Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

                #endregion

                #region Prueba 2

                //using (TransactionScope scope = new TransactionScope())
                //using (Connection = new SqlConnection(DBConnection))
                //{
                //    try
                //    {
                //        Connection.Open();

                //        Connection.Execute(SqlText, parameters, null, null, CommandType.StoredProcedure);

                //        var v_Estado = parameters.Select(s => s.Get<bool?>("@ps_dmpBndEstatusProc"));
                //        var v_Mensaje = parameters.Select(s => s.Get<string>("@ps_dmpChrMensajeProc"));

                //        scope.Complete();

                //        Connection.Close();
                //    }
                //    catch (Exception ex)
                //    {
                //        Connection.BeginTransaction().Rollback();
                //        throw ex;
                //    }
                //}

                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #endregion

        #region Delete

        public void pb_InactivarCliente(int pe_CodCliente, int pe_CodUsuario, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                var empresa = Convert.ToInt32(ps_ConfigurationModel.codEmpresa);

                string SqlText = "ptv.pr_DelCLI_CLIENTE";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    DynamicParameters parameter = new DynamicParameters();

                    parameter.Add("@pe_empIntCodigo", empresa, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_cliIntCodigo", pe_CodCliente, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@pe_usuIntCodigo", pe_CodUsuario, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    parameter.Add("@ps_cliBndEstatusProc", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    parameter.Add("@ps_cliChrMensajeProc", dbType: DbType.String, direction: ParameterDirection.Output, size: 150);

                    Connection.Execute(SqlText, parameter, null, null, CommandType.StoredProcedure);

                    ps_Estado = parameter.Get<bool?>("@ps_cliBndEstatusProc");
                    ps_Mensaje = parameter.Get<string>("@ps_cliChrMensajeProc");

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #endregion

        #region Metodos de PopUps

        /// <summary>
        /// Obtiene los productos para cargalos en el PopUp de Productos
        /// </summary>
        /// <param name="pe_codBodega">Codigo de Bodega donde se va a realizar la existencia del producto</param>
        /// <param name="pe_datoBusqueda">Dato como filtro de busqueda</param>
        /// <param name="pe_topRegistros">Cantidad de registros a presentar</param>
        /// <param name="ps_PopUpProductoModel">Lista de productos</param>
        public void pb_ObtenerPopUpProducto(string pe_codBodega, string pe_datoBusqueda, int pe_topRegistros, string pe_FechaHasta, ref List<PopUpProductoModel> ps_PopUpProductoModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;
                var bodega = (pe_codBodega.Equals("")) ? ps_ConfigurationModel.codBodega : pe_codBodega;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_CLIPOPUP_PRODUCTO(" + empresa + ",'" + pe_FechaHasta + "','" + bodega + "'," + pe_topRegistros + ",'" + pe_datoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_PopUpProductoModel = Connection.Query<PopUpProductoModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_traFecFechaHasta = pe_FechaHasta, @pe_bodChrCodigo = bodega, @pe_intTopBusqueda = pe_topRegistros, @pe_chrDatoBusqueda = pe_datoBusqueda }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los medios de pago para cargarlos en el Pop up de Medios de Pago
        /// </summary>
        /// <param name="pe_CodigoCaja"></param>
        /// <param name="pe_TipoMedioPago"></param>
        /// <param name="pe_FechaProceso"></param>
        /// <param name="pe_CodigoMoneda"></param>
        /// <param name="pe_ValorTasa"></param>
        /// <param name="pe_FormaPago"></param>
        public void pb_ObtenerMediosPago(string pe_CodigoCaja, string pe_FechaProceso, int pe_CodigoMoneda, decimal pe_ValorTasa, int pe_FormaPago, ref List<MedioPagoModel> ps_MedioPagoModel)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_CLIPOPUP_MEDIOPAGO(" + empresa + ",'" + pe_CodigoCaja + "','" + pe_FechaProceso
                                                                                   + "'," + pe_CodigoMoneda + "," + pe_ValorTasa + "," + pe_FormaPago + ")";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_MedioPagoModel = Connection.Query<MedioPagoModel>(SqlText, new
                    {
                        @pe_empIntCodigo = empresa,
                        @pe_cajIntCodigo = pe_CodigoCaja,
                        @pe_traFecFecha = pe_FechaProceso,
                        @pe_mndIntCodigo = pe_CodigoMoneda,
                        @pe_traMonTasaMon = pe_ValorTasa,
                        @pe_traIntFormaPago = pe_FormaPago
                    }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos Miscelaneos

        #region Bodegas

        /// <summary>
        /// Obtiene las bodegas para cargarlas en un combobox.
        /// </summary>
        /// <param name="ps_BodegaModelMisc"></param>
        public void pb_ObtenerBodegasMisc(ref List<BodegaModelMisc> ps_BodegaModelMisc)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_BODEGA_MISC(" + empresa + ", '%')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_BodegaModelMisc = Connection.Query<BodegaModelMisc>(SqlText, new { @pe_empIntCodigo = empresa, @pe_bodChrCodigo = "%" }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Configuracion Empresa

        /// <summary>
        /// Obtiene las propiedades de configuración por empresa.
        /// </summary>
        /// <param name="ps_ConfiguracionEmpresaModelMisc"></param>
        public void pb_ObtenerConfigEmpresa(ref ConfigEmpresaModelMisc ps_ConfiguracionEmpresaModelMisc)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelEMP_CONFIGEMPRESA_MISC(" + empresa + ")";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_MiscelaneosModel = Connection.Query<MiscelaneosModel>(SqlText, new { @pe_empIntCodigo = empresa }).ToList();

                    foreach (var propiedad in ps_ConfiguracionEmpresaModelMisc.GetType().GetProperties())
                    {
                        var datoQuery = ps_MiscelaneosModel.Select(s => s).Where(
                            w => w.cnfChrNombre.Split('_')[1].ToLower().Equals(propiedad.Name.ToLower())
                        ).FirstOrDefault();

                        var dato = string.IsNullOrEmpty(datoQuery.cnfChrDato) ? string.Empty : datoQuery.cnfChrDato;
                        propiedad.SetValue(ps_ConfiguracionEmpresaModelMisc, dato, null);
                    }

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Tipo de Cédula

        public void pb_ObtenerTipoCedula(ref List<TipoCedulaModel> ps_TipoCedulaModel, string pe_chrDatoBusqueda)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelEMP_TIPOCEDULA(" + empresa + ",'" + pe_chrDatoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_TipoCedulaModel = Connection.Query<TipoCedulaModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = "%" }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Partidas de Impuesto

        public void pb_ObtenerPartidas(ref List<PartidaModel> ps_PartidaModel, string pe_chrDatoBusqueda)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCOM_PARTIDA_IMPUESTO(" + empresa + ",'" + pe_chrDatoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_PartidaModel = Connection.Query<PartidaModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = "%" }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Vendedores

        public void pb_ObtenerVendedores(ref List<VendedorModel> ps_VendedorModel, string pe_chrDatoBusqueda)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelCLI_VENDEDOR(" + empresa + ",'" + pe_chrDatoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_VendedorModel = Connection.Query<VendedorModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = "%" }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Direcciones

        public void pb_ObtenerDirecciones(int pe_intTopBusqueda, string pe_chrDatoBusqueda, ref List<DireccionModelMisc> ps_DireccionModelMisc)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                string SqlText = "SELECT * FROM ptv.fn_SelEMP_DIRECCION(" + empresa + "," + pe_intTopBusqueda + ",'" + pe_chrDatoBusqueda + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    ps_DireccionModelMisc = Connection.Query<DireccionModelMisc>(SqlText, new { @pe_empIntCodigo = empresa, @pe_intTopBusqueda = pe_intTopBusqueda, @pe_chrDatoBusqueda = pe_chrDatoBusqueda }).ToList();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Formato

        public void pb_AplicarFormato(ref string pe_Cadena, string pe_Formato, char pe_Delimitador)
        {
            try
            {
                string SqlText = "SELECT ptv.fn_UtlCalAplicarFormato('" + pe_Cadena + "','" + pe_Formato + "','" + pe_Delimitador + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    pe_Cadena = Connection.Query<string>(SqlText, new { @entNumeroFor = pe_Cadena, @entCtaFormat = pe_Formato, @entSeparador = pe_Delimitador }).ToList().First<string>().ToString();

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cargar Listado de Reportes

        public List<ReportModel> pb_ListadoReportes(int pe_Acceso, string pe_Modulo, string pe_NombreReporte)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;
                var querySql = "select * from [ptv].[fn_SELEMP_LISTADO_REPORTES]("+empresa+", "+ pe_Acceso + " , '"+ pe_Modulo + "', '"+pe_NombreReporte+"' )";
                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    var listado = Connection.Query<ReportModel>(querySql, new
                    {
                       @entEmpIntCodigo = empresa,
                       @entAccIntCodigo = pe_Acceso,
                       @entRptChrModulo = pe_Modulo,
                       @entRptChrNombre = pe_NombreReporte
                    }).ToList();

                    listado.ForEach(s =>
                    {
                        s.pe_ConfigurationModel = ps_ConfigurationModel;
                    });

                    Connection.Close();
                    return listado;

                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Opciones miscelaneas
        public Dictionary<string, string> pb_PTV_CargasMiscelaneos(string pe_opcion)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                var SqlText = "select * from [ptv].[fn_SelPVT_CargasMiscelaneos](" + empresa + ", '" + pe_opcion + "' )";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    var listado = Connection.Query<OpcionesCargasMiscelaneos>(SqlText,
                        new {@entEMPIntCodigo = empresa, @entTipoCarga = pe_opcion})
                        .ToDictionary(row => row.PVT_Descripcion,
                            row => row.PVT_Valor);

                    Connection.Close();

                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Carga estados de transacciones

        public List<TransaccionEstadoModel> pb_ObtenerEstadoTransacciones(string pdato)
        {
            try
            {
                var empresa = ps_ConfigurationModel.codEmpresa;

                var SqlText = "SELECT * FROM [ptv].[fn_SELCOM_TRANSACCION_ESTADO](" + empresa + ",'"+ pdato + "')";

                using (Connection = new SqlConnection(DBConnection))
                {
                    Connection.Open();

                    var _list = Connection.Query<TransaccionEstadoModel>(SqlText, new { @pe_empIntCodigo = empresa, @pe_chrDatoBusqueda = pdato }).ToList();

                    Connection.Close();

                    return _list.Count > 0 ? _list : null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        #endregion


        #endregion
    }
}
