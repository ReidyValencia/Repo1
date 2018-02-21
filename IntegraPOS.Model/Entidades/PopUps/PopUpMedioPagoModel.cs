using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.PopUps
{
    public class PopUpMedioPagoModel
    {
        #region Propiedades

        /// <summary>
        /// Código de empresa
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de medio de pago.
        /// </summary>
        /// <returns></returns>
        public string mpgChrCodigo { get; set; }
        /// <summary>
        /// Código del Tipo de medio de pago.
        /// </summary>
	    public string tpgChrCodigo { get; set; }
        /// <summary>
        /// Nombre del medio de pago.
        /// </summary>
	    public string mpgChrNombre { get; set; }
        /// <summary>
        /// Banco asociado al medio de pago
        /// </summary>
        public string mpgChrBancoAsociado { get; set; }
        /// <summary>
        /// Simbolo de la moneda.
        /// </summary>
        public string mndChrSimbolo { get; set; }
        /// <summary>
        /// Numero de linea.
        /// </summary>
	    public int mpgIntLinea { get; set; }
        /// <summary>
        /// Establece si el medio de pago utiliza PINPAD.
        /// </summary>
        public bool mpgBndUtilPINPAD { get; set; }
        /// <summary>
        /// Establece si el medio de pago utiliza documentos.
        /// </summary>
        public bool tpgBndUtilDoc { get; set; }
        /// <summary>
        /// Establece si el medio de pago utiliza denominaciones.
        /// </summary>
        public bool mpgBndUtilDenominacion { get; set; }
        /// <summary>
        /// Numero del Documento asignado.
        /// </summary>
        public string mpgChrNumDocumento { get; set; }
        /// <summary>
        /// Monto a pagar con el medio de pago.
        /// </summary>
        public string mpgMonMontoMPago { get; set; }
        /// <summary>
        /// Monto del factor del medio de pago.
        /// </summary>
        public string mpgMonMontoFactor { get; set; }
        /// <summary>
        /// Monto de la Transacción.
        /// </summary>
        public string mpgMonMontoTransac { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destrcutor

        public PopUpMedioPagoModel()
        {
            try
            {
                empIntCodigo = 0;
                mpgChrCodigo = "";
                tpgChrCodigo = "";
                mpgChrNombre = "";
                mndChrSimbolo = "";
                mpgIntLinea = 0;
                mpgBndUtilPINPAD = false;
                tpgBndUtilDoc = false;
                mpgBndUtilDenominacion = false;
                mpgChrNumDocumento = "";
                mpgMonMontoMPago = "";
                mpgMonMontoFactor = "";
                mpgMonMontoTransac = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        ~PopUpMedioPagoModel() { }

        #endregion

        #region Metodos Públicos

        /// <summary>
        /// Obtiene los medios de pago deacuerdo a la caja, tipo de medio de pago y la forma de pago
        /// </summary>
        /// <param name="pe_CodigoCaja">Código de la Caja</param>
        /// <param name="pe_TipoMedioPago">Tipo de medio de pago a consultar</param>
        /// <param name="pe_FechaProceso">Fecha del proceso de la transacción</param>
        /// <param name="pe_CodigoMoneda">Codigo de la moneda</param>
        /// <param name="pe_ValorTasa">Valor de tasa de la transacción </param>
        /// <param name="pe_FormaPago">Forma de Pago en que se va a realizar la transaccion (Contado / Credito)</param>
        public void pb_ObtenerMediosPago(string pe_CodigoCaja, string pe_FechaProceso, int pe_CodigoMoneda, decimal pe_ValorTasa, int pe_FormaPago, ref List<PopUpMedioPagoModel> ps_PopUpMedioPagoModel)
        {
            try
            {
                pv_ObtenerMediosPago(pe_CodigoCaja, pe_FechaProceso, pe_CodigoMoneda, pe_ValorTasa, pe_FormaPago, ref ps_PopUpMedioPagoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodos Privados

        private void pv_ObtenerMediosPago(string pe_CodigoCaja, string pe_FechaProceso, int pe_CodigoMoneda, decimal pe_ValorTasa, int pe_FormaPago, ref List<PopUpMedioPagoModel> ps_PopUpMedioPagoModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerMediosPago(pe_CodigoCaja, pe_FechaProceso, pe_CodigoMoneda, pe_ValorTasa, pe_FormaPago, ref ps_PopUpMedioPagoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
