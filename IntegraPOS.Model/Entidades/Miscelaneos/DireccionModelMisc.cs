using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Miscelaneos
{
    public class DireccionModelMisc
    {

        #region Propiedades

        /// <summary>
        /// Almacena el código de empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de la dirección
        /// </summary>
        public string dirChrCodDireccion { get; set; }
        /// <summary>
        /// Nombre de la dirección
        /// </summary>
        public string dirChrNomDireccion { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public DireccionModelMisc()
        {
            empIntCodigo = 0;
            dirChrCodDireccion = "";
            dirChrNomDireccion = "";
        }

        ~DireccionModelMisc() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerDirecciones(int pe_intTopBusqueda, string pe_chrDatoBusqueda, ref List<DireccionModelMisc> ps_DireccionModelMisc)
        {
            try
            {
                pv_ObtenerDirecciones(pe_intTopBusqueda, pe_chrDatoBusqueda, ref ps_DireccionModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerDirecciones(int pe_intTopBusqueda, string pe_chrDatoBusqueda, ref List<DireccionModelMisc> ps_DireccionModelMisc)
        {
            try
            {
                vConnectionModel.pb_ObtenerDirecciones(pe_intTopBusqueda, pe_chrDatoBusqueda, ref ps_DireccionModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
