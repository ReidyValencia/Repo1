using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class CajaModel
    {

        #region Variables e instancias

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Propiedades

        /// <summary>
        /// Código de la empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de la caja.
        /// </summary>
        public string cajChrCodigo { get; set; }
        /// <summary>
        /// Nombre de la caja.
        /// </summary>
        public string cajChrNombre { get; set; }
        /// <summary>
        /// Código de la sucursal que se le asigna a la caja.
        /// </summary>
        public int sucIntCodigo { get; set; }
        /// <summary>
        /// Nombre de la sucursal
        /// </summary>
        public string sucChrNombre { get; set; }
        /// <summary>
        /// Código del tipo de transaccion.
        /// </summary>
        public string ttpChrCodigo { get; set; }
        public string tasChrCodigoDif { get; set; }
        public string catChrCodigoDif { get; set; }
        /// <summary>
        /// Establece el estado de la caja activa, inactiva.
        /// </summary>
        public string cajChrEstado { get; set; }
        /// <summary>
        /// Establece si la caja esta cerrada=0, abierta=1 .
        /// </summary>
        public bool cajBndAbierta { get; set; }

        public bool cajBndTransacPostApe { get; set; }
        public bool cajBndActivarMsjDif { get; set; }

        /// <summary>
        /// Código de usuario que tiene abierta la caja.
        /// </summary>
        public int usuIntCodigoCaj { get; set; }

        public int usuIntCodigoIng { get; set; }

        public DateTime usuFecFechaIng { get; set; }

        public int usuIntCodigoMod { get; set; }

        public DateTime usuFecFechaMod { get; set; }


    #endregion

        #region Constructor / Destructor

        public CajaModel()
        {
            try
            {
                empIntCodigo = 0;
                cajChrCodigo = "";
                cajChrNombre = "";
                sucIntCodigo = 0;
                ttpChrCodigo = "";
                cajBndAbierta = Convert.ToBoolean(0);
                cajChrEstado = "INC";
                usuIntCodigoCaj = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~CajaModel() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerCajaUsuario(string pe_datoBusqueda, ref CajaModel ps_CajaModel)
        {
            try
            {
                pv_ObtenerCajaUsuario(pe_datoBusqueda, ref ps_CajaModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CajaModel> pb_getCajas(string pe_cajChrCodigo, string pe_datoBusqueda)
        {
            List<CajaModel> oListCajas = new List<CajaModel>();
            try
            {
                oListCajas = vConnectionModel.pb_getCajas(pe_cajChrCodigo, pe_datoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oListCajas;
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerCajaUsuario(string pe_datoBusqueda, ref CajaModel ps_CajaModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerCajaUsuario(pe_datoBusqueda, ref ps_CajaModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
