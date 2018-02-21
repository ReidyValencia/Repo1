using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class TransaccionEncabezadoModel
    {
        #region Varibles e instancias

        #endregion

        #region Propiedades

        /// <summary>
        /// Codigo de empresa
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Numero de Transaccion
        /// </summary>
        public string traChrNumero { get; set; }
        /// <summary>
        /// Codigo tipo de transaccion
        /// </summary>
        public string ttpChrCodigo { get; set; }
        /// <summary>
        /// Código de la sucursal
        /// </summary>
        public int sucIntCodigo { get; set; }
        /// <summary>
        /// Nombre de la sucursal.
        /// </summary>
        public string sucChrNombre { get; set; }
        /// <summary>
        /// Codigo de caja
        /// </summary>
        public string cajChrCodigo { get; set; }
        /// <summary>
        /// Nombre de la caja.
        /// </summary>
        public string cajChrNombre { get; set; }
        /// <summary>
        /// Tipo de documento
        /// </summary>
        public string tdcChrCodigo { get; set; }
        /// <summary>
        /// Codigo de moneda.
        /// </summary>
        public int mndIntCodigo { get; set; }
        /// <summary>
        /// Símbolo de la moneda.
        /// </summary>
        public string mndChrSimbolo { get; set; }
        /// <summary>
        /// Monto de la tasa de cambio
        /// </summary>
        public string traMonTasaMon { get; set; }
        /// <summary>
        /// Tipo de tasa (C=compra / V=venta)
        /// </summary>
        public string traChrTasaTipo { get; set; }
        /// <summary>
        /// Fecha de documento
        /// </summary>
        public DateTime traFecFechaDoc { get; set; }
        /// <summary>
        /// Fecha de vencimiento.
        /// </summary>
        public DateTime traFecFechaVnc { get; set; }
        /// <summary>
        /// Dias maximo de credito del cliente.
        /// </summary>
        public int cliIntDiasCreditoMax { get; set; }
        /// <summary>
        /// Dias valido del documento
        /// </summary>
        public int traIntDiasValido { get; set; }
        /// <summary>
        /// Codigo del cliente
        /// </summary>
        public int cliIntCodigo { get; set; }
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string cliChrNombrePri { get; set; }
        /// <summary>
        /// Codigo del vendedor
        /// </summary>
        public int venIntCodigo { get; set; }
        /// <summary>
        /// Nombre del vendedor
        /// </summary>
        public string venChrNombre { get; set; }
        /// <summary>
        /// Codigo del proveedor
        /// </summary>
        public int prvIntCodigo { get; set; }
        /// <summary>
        /// Nombre del proveedor
        /// </summary>
        public string prvChrNombrePri { get; set; }
        /// <summary>
        /// Forma de pago (0=contado / 1=credito)
        /// </summary>
        public int traIntFormaPago { get; set; }
        /// <summary>
        /// Anotacion de la transaccion
        /// </summary>
        public string traChrAnotacion { get; set; }
        /// <summary>
        /// Codigo de bodega.
        /// </summary>
        public string bodChrCodigoOrg { get; set; }
        /// <summary>
        /// Nombre de la bodega
        /// </summary>
        public string bodChrNombre { get; set; }
        /// <summary>
        /// Sub Total Original
        /// </summary>
        public decimal traMonSubTotalORG { get; set; }
        /// <summary>
        /// Sub Total Principal
        /// </summary>
        public decimal traMonSubTotalPRC { get; set; }
        /// <summary>
        /// Total descuento
        /// </summary>
        public decimal traMonTotalDescuento { get; set; }
        /// <summary>
        /// Total Bruto
        /// </summary>
        public decimal traMonTotalBruto { get; set; }
        /// <summary>
        /// Total de Impuestos
        /// </summary>
        public decimal traMonTotalImpuesto { get; set; }
        /// <summary>
        /// Total Neto de la transaccion
        /// </summary>
        public string traMonTotalNeto { get; set; }
        /// <summary>
        /// Estado de la transaccion
        /// </summary>
        public string traChrEstado { get; set; }
        /// <summary>
        /// Accion a realizar(1=Insertar / 2=Modificar)
        /// </summary>
        public int traIntAction { get; set; }
        /// <summary>
        /// Codigo de usuario que realiza la  transaccion
        /// </summary>
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public TransaccionEncabezadoModel()
        {
            try
            {
                empIntCodigo = 0;
                traChrNumero = "";
                ttpChrCodigo = "";
                sucIntCodigo = 0;
                sucChrNombre = "";
                cajChrCodigo = "";
                cajChrNombre = "";
                tdcChrCodigo = "";
                mndIntCodigo = 0;
                mndChrSimbolo = "";
                traMonTasaMon = "";
                traChrTasaTipo = "";
                traFecFechaDoc = DateTime.Now;
                traFecFechaVnc = DateTime.Now;
                cliIntDiasCreditoMax = 0;
                traIntDiasValido = 0;
                cliIntCodigo = 0;
                cliChrNombrePri = "";
                venIntCodigo = 0;
                venChrNombre = "";
                prvIntCodigo = 0;
                prvChrNombrePri = "";
                traIntFormaPago = 0;
                traChrAnotacion = "";
                bodChrCodigoOrg = "";
                bodChrNombre = "";
                traMonSubTotalORG = 0;
                traMonSubTotalPRC = 0;
                traMonTotalDescuento = 0;
                traMonTotalBruto = 0;
                traMonTotalImpuesto = 0;
                traMonTotalNeto = "";
                traChrEstado = "";
                traIntAction = 0;
                usuIntCodigo = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~TransaccionEncabezadoModel() { }

        #endregion

        #region  Métodos Públicos

        public void pb_ObtenerTransaccionEncabezado(string pe_datoBusqueda, int pe_topRegistros, string pe_tipoTransac, ref List<TransaccionEncabezadoModel> ps_TransaccionEncabezadoModel)
        {
            try
            {
                pv_ObtenerTransacciones(pe_datoBusqueda, pe_topRegistros, pe_tipoTransac, ref ps_TransaccionEncabezadoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los modelos para mandarlos a guardar
        /// </summary>
        /// <param name="pe_TransaccionEncabezadoModel"></param>
        /// <param name="pe_DetalleMedioPagoModel"></param>
        public void pb_GuardarTransaccion(TransaccionEncabezadoModel pe_TransaccionEncabezadoModel, List<MedioPagoModel> pe_MedioPagoModel,
                                            List<DetalleProductoModel> pe_DetalleProductoModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                pv_GuardarTransaccion(pe_TransaccionEncabezadoModel, pe_MedioPagoModel, pe_DetalleProductoModel, ref ps_Estado, ref ps_Mensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerTransacciones(string pe_datoBusqueda, int pe_topRegistros, string pe_tipoTransac, ref List<TransaccionEncabezadoModel> ps_TransaccionEncabezadoModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerTransacciones(pe_datoBusqueda, pe_topRegistros, pe_tipoTransac, ref ps_TransaccionEncabezadoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los modelos para mandarlos a guardar
        /// </summary>
        /// <param name="pe_TransaccionEncabezadoModel"></param>
        /// <param name="pe_DetalleMedioPagoModel"></param>
        public void pv_GuardarTransaccion(TransaccionEncabezadoModel pe_TransaccionEncabezadoModel, List<MedioPagoModel> pe_MedioPagoModel,
                                            List<DetalleProductoModel> pe_DetalleProductoModel, ref bool? ps_Estado, ref string ps_Mensaje)
        {
            try
            {
                vConnectionModel.pb_InsertarTransaccion(pe_TransaccionEncabezadoModel, pe_MedioPagoModel, pe_DetalleProductoModel,
                                                        ref ps_Estado, ref ps_Mensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
