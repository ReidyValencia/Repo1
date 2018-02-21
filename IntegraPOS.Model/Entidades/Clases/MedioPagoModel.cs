using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class MedioPagoModel
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
        /// Descripción del medio de pago.
        /// </summary>
        public string mpgChrDescripcion { get; set; }
        /// <summary>
        /// Código de la moneda del medio de pago.
        /// </summary>
        public int mndIntCodigo { get; set; }
        /// <summary>
        /// Símbolo de la moneda del medio de pago.
        /// </summary>
        public string mndChrSimbolo { get; set; }
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
        /// TTP?
        /// </summary>
        public string ttpChrCodigo { get; set; }
        /// <summary>
        /// Mot int codigo
        /// </summary>
        public int motIntCodigo { get; set; }
        /// <summary>
        /// Número de la transacción asociada al detalle de medio de pago.
        /// </summary>
        public string traChrNumero { get; set; }
        /// <summary>
        /// Posición del medio de pago en el detalle de medio de pago.
        /// </summary>
        public int dmpIntPosicion { get; set; }
        /// <summary>
        /// Documento de referencia del detalle de medio de pago.
        /// </summary>
        public string dmpChrDocumento { get; set; }
        /// <summary>
        /// Banco asociado al detalle de medio de pago.
        /// </summary>
        public string dmpChrBancoEmisor { get; set; }
        /// <summary>
        /// Fecha del documento del detalle de medio de pago.
        /// </summary>
        public string dmpFecFechaDoc { get; set; }
        /// <summary>
        /// Monto del detalle de medio de pago.
        /// </summary>
        public string mpgMonMontoMPago { get; set; }
        /// <summary>
        /// Monto de factor del medio de pago.
        /// </summary>
        public decimal mpgMonMontoFactor { get; set; }
        /// <summary>
        /// Monto del detalle de medio de pago en la moneda de la transacción.
        /// </summary>
        public string mpgMonMontoTransac { get; set; }
        /// <summary>
        /// Código del usuario que realiza los procesos del medio de pago.
        /// </summary>
        public int usuIntCodigo { get; set; }
        /// <summary>
        /// Fecha en que se realizan los procesos del medio de pago.
        /// </summary>
        public DateTime mpgFecFecha { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public MedioPagoModel()
        {
            empIntCodigo = 0;
            mpgChrCodigo = "";
            tpgChrCodigo = "";
            mpgChrNombre = "";
            mpgChrDescripcion = "";
            mndIntCodigo = 0;
            mndChrSimbolo = "";
            mpgBndUtilPINPAD = false;
            tpgBndUtilDoc = false;
            mpgBndUtilDenominacion = false;
            ttpChrCodigo = "";
            motIntCodigo = 0;
            traChrNumero = "";
            dmpIntPosicion = 0;
            dmpChrDocumento = "";
            dmpChrBancoEmisor = "";
            dmpFecFechaDoc = "";
            mpgMonMontoMPago = "";
            mpgMonMontoFactor = 0;
            mpgMonMontoTransac = "";
            usuIntCodigo = 0;
            mpgFecFecha = DateTime.Now;
        }

        ~MedioPagoModel() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerMediosPago(string pe_CodigoCaja, string pe_FechaProceso, int pe_CodigoMoneda, decimal pe_ValorTasa, int pe_FormaPago, ref List<MedioPagoModel> ps_MedioPagoModel)
        {
            try
            {
                pv_ObtenerMediosPago(pe_CodigoCaja, pe_FechaProceso, pe_CodigoMoneda, pe_ValorTasa, pe_FormaPago, ref ps_MedioPagoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerMediosPago(string pe_CodigoCaja, string pe_FechaProceso, int pe_CodigoMoneda, decimal pe_ValorTasa, int pe_FormaPago, ref List<MedioPagoModel> ps_MedioPagoModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerMediosPago(pe_CodigoCaja, pe_FechaProceso, pe_CodigoMoneda, pe_ValorTasa, pe_FormaPago, ref ps_MedioPagoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
