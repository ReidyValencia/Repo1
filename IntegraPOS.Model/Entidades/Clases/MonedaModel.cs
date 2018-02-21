using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class MonedaModel
    {

        #region Propiedades

        /// <summary>
        /// Código de empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de la moneda.
        /// </summary>
        public int mndIntCodigo { get; set; }
        /// <summary>
        /// Nombre de la empresa.
        /// </summary>
        public string mndChrNombre { get; set; }
        /// <summary>
        /// Prioridad de la moneda.
        /// </summary>
        public int mndIntPrioridad { get; set; }
        /// <summary>
        /// Símbolo de la moneda.
        /// </summary>
        public string mndChrSimbolo { get; set; }
        /// <summary>
        /// Código del usuario.
        /// </summary>
        public int usuIntCodigoIng { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public MonedaModel()
        {
            empIntCodigo = 0;
            mndIntCodigo = 0;
            mndChrNombre = "";
            mndIntPrioridad = 0;
            mndChrSimbolo = "";
            usuIntCodigoIng = 0;
        }

        ~MonedaModel() { }

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Obtiene las monedas configuradas o una moneda en espefico
        /// </summary>
        /// <param name="pe_CodMoneda"></param>
        /// <param name="ps_MonedaModel"></param>
        public void pb_ObtenerMonedas(string pe_CodMoneda, int pe_TipoBusqueda, ref List<MonedaModel> ps_MonedaModel)
        {
            try
            {
                pv_ObtenerMonedas(pe_CodMoneda, pe_TipoBusqueda, ref ps_MonedaModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Obtiene las monedas configuradas o una moneda en espefico
        /// </summary>
        /// <param name="pe_CodMoneda"></param>
        /// <param name="ps_MonedaModel"></param>
        public void pv_ObtenerMonedas(string pe_CodMoneda, int pe_TipoBusqueda, ref List<MonedaModel> ps_MonedaModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerMoneda(pe_CodMoneda, pe_TipoBusqueda, ref ps_MonedaModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
