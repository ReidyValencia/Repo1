using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegraPOS.Model.Entidades.Miscelaneos;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class TipoTransaccionModel
    {
        #region Variables e instancias

        #endregion

        #region Propiedades

        /// <summary>
        /// Código de empresa.
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código del tipo de transacción.
        /// </summary>
        public string ttpChrCodigo { get; set; }
        /// <summary>
        /// Nombre del tipo de transacción.
        /// </summary>
        public string ttpChrNombre { get; set; }
        /// <summary>
        /// Código de la clasificación de transacción.
        /// </summary>
        public string tclChrCodigo { get; set; }
        /// <summary>
        /// Atributos del tipo de transacción.
        /// </summary>
        public Dictionary<string, string> AtributosTTransaccion { get; set; }
        /// <summary>
        /// Código de usuario
        /// </summary>
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public TipoTransaccionModel()
        {
            try
            {
                empIntCodigo = 0;
                ttpChrCodigo = "";
                ttpChrNombre = "";
                tclChrCodigo = "";
                usuIntCodigo = 0;
                AtributosTTransaccion = new Dictionary<string, string>(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~TipoTransaccionModel() { }

        #endregion

        #region  Métodos Públicos

        public void pb_ObtenerTipoTransaccion(string pe_datoBusqueda, ref List<TipoTransaccionModel> ps_TipoTransaccionModel)
        {
            try
            {
                pv_ObtenerTipoTransaccion(pe_datoBusqueda, ref ps_TipoTransaccionModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region  Métodos Privados

        private void pv_ObtenerTipoTransaccion(string pe_datoBusqueda, ref List<TipoTransaccionModel> ps_TipoTransaccionModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerTipoTransaccion(pe_datoBusqueda, ref ps_TipoTransaccionModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }

    public class TransaccionEstadoModel
    {
        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        public TransaccionEstadoModel()
        {
            empIntCodigo = 0;
            estChrCodigo = string.Empty;
            estChrNombreAct = string.Empty;
            estChrNombrePrx = string.Empty;
            estChrDescripcionUso = string.Empty;
            estChrTipoEstado = string.Empty;
        }

        public int empIntCodigo { get; set; }
        public string estChrCodigo { get; set; }
        public string estChrNombreAct { get; set; }
        public string estChrNombrePrx { get; set; }
        public string estChrDescripcionUso { get; set; }
        public string estChrTipoEstado { get; set; }


        public List<TransaccionEstadoModel> pb_GetTransaccionEstadoModel(string pe_dato)
        {
            try
            {
                return pv_GetTransaccionEstadoModel(pe_dato);
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        private List<TransaccionEstadoModel> pv_GetTransaccionEstadoModel(string pe_dato)
        {
            try
            {
                return vConnectionModel.pb_ObtenerEstadoTransacciones(pe_dato);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
