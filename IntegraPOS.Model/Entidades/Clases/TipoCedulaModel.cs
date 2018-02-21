using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class TipoCedulaModel
    {
        #region Propiedades

        /// <summary>
        /// Almacena el código de empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código del tipo de cédula
        /// </summary>
        public int tceIntCodigo { get; set; }
        /// <summary>
        /// Nombre del tipo de cédula
        /// </summary>
        public string tceChrNombre { get; set; }
        /// <summary>
        /// Formato del tipo de cédula
        /// </summary>
        public string tceChrFormato { get; set; }
        /// <summary>
        /// Codigo de usuario que realiza los procesos al tipo de cédula
        /// </summary>
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public TipoCedulaModel()
        {
            empIntCodigo = 0;
            tceIntCodigo = 0;
            tceChrNombre = "";
            tceChrFormato = "";
            usuIntCodigo = 0;
        }

        ~TipoCedulaModel()
        {

        }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerTipoCedula(ref List<TipoCedulaModel> ps_TipoCedulaModel, string pe_chrDatoBusqueda)
        {
            try
            {
                pv_ObtenerTipoCedula(ref ps_TipoCedulaModel, pe_chrDatoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerTipoCedula(ref List<TipoCedulaModel> ps_TipoCedulaModel, string pe_chrDatoBusqueda)
        {
            try
            {
                vConnectionModel.pb_ObtenerTipoCedula(ref ps_TipoCedulaModel, pe_chrDatoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
