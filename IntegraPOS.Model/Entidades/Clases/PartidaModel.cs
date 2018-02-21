using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class PartidaModel
    {
        #region Propiedades

        /// <summary>
        /// Almacena el código de empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de la partida de impuesto
        /// </summary>
        public int parIntCodigo { get; set; }
        /// <summary>
        /// Nombre de la partida de impuesto
        /// </summary>
        public string parChrNombre { get; set; }
        /// <summary>
        /// Codigo de usuario que realiza los procesos a la partida
        /// </summary>
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public PartidaModel()
        {
            empIntCodigo = 0;
            parIntCodigo = 0;
            parChrNombre = "";
            usuIntCodigo = 0;
        }

        ~PartidaModel() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerPartidas(ref List<PartidaModel> ps_PartidaModel, string pe_chrDatoBusqueda)
        {
            try
            {
                pv_ObtenerPartidas(ref ps_PartidaModel, pe_chrDatoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerPartidas(ref List<PartidaModel> ps_PartidaModel, string pe_chrDatoBusqueda)
        {
            try
            {
                vConnectionModel.pb_ObtenerPartidas(ref ps_PartidaModel, pe_chrDatoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
