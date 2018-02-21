using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Miscelaneos
{
    public class BodegaModelMisc
    {
        #region Propiedades

        /// <summary>
        /// Almacena el código de empresa
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de la Bodega 
        /// </summary>
        public string bodChrCodigo { get; set; }
        /// <summary>
        /// Nombre de la Bodega
        /// </summary>
        public string bodChrNombre { get; set; }
        /// <summary>
        /// Código de la sucursal donde se encuentra la bodega
        /// </summary>
        public int sucIntCodigo { get; set; }
        /// <summary>
        /// Tipo de Bodega (FIS = Fisica, RES = Reserva)
        /// </summary>
        public string bodChrTipo { get; set; }
        /// <summary>
        /// Estado de la Bodega
        /// </summary>
        public string bodChrEstado { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public BodegaModelMisc()
        {
            empIntCodigo = 0;
            bodChrCodigo = "";
            bodChrNombre = "";
            sucIntCodigo = 0;
            bodChrTipo = "";
            bodChrEstado = "";
        }

        ~BodegaModelMisc() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerBodegas(ref List<BodegaModelMisc> ps_BodegaModelMisc)
        {
            try
            {
                pv_ObtenerBodegas(ref ps_BodegaModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodos Privados

        private void pv_ObtenerBodegas(ref List<BodegaModelMisc> ps_BodegaModelMisc)
        {
            try
            {
                vConnectionModel.pb_ObtenerBodegasMisc(ref ps_BodegaModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
